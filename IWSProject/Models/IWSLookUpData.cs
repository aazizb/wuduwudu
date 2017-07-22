namespace IWSProject.Models
{
    using DevExpress.Web;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Web;
    public static class IWSLookUp
    {

        const string IWSDataContext = "IWSDataContext";
        public static IWSDataContext IWSEntities
        {
            get
            {
                if (HttpContext.Current.Items[IWSDataContext] == null)
                    HttpContext.Current.Items[IWSDataContext] = new IWSDataContext();

                return (IWSDataContext)HttpContext.Current.Items[IWSDataContext];
            }
        }
        public static IEnumerable GetIBAN()
        {
            var account = IWSEntities.BankAccounts.AsEnumerable().Select(i => new
            {
                Id = i.IBAN,
                Name = i.Owner,
                CompanyID = i.CompanyID,
            })
            .Where(c => c.CompanyID == (string)HttpContext.Current.Session["CompanyID"])
            .OrderBy(o => o.Id);
            return account;
        }

        public static IEnumerable GetBIC()
        {
            var account = IWSEntities.Banks.AsEnumerable().Select(i => new
            {
                Id = i.id,
                Name = i.name,
                CompanyID = i.CompanyID,
            })
            .Where(c => c.CompanyID == (string)HttpContext.Current.Session["CompanyID"])
            .OrderBy(o => o.Id);
            return account;
        }

        public static IEnumerable GetAccounts()
        {
            var account = IWSEntities.Accounts.AsEnumerable().Select(i => new
            {
                Id = i.id,
                Name = i.name,
                CompanyID=i.CompanyID,
                IsUsed=i.IsUsed
            })
            .Where(c => c.CompanyID == (string)HttpContext.Current.Session["CompanyID"] 
                            && c.IsUsed.Equals(true))
            .OrderBy(o => o.Id);
            return account;
        }
        public static IEnumerable GetPackUnits()
        {
            var account = IWSEntities.QuantityUnits.AsEnumerable().Select(i => new
            {
                Id = i.id,
                Name = i.name,
                CompanyID = i.CompanyID
            })
            .Where(c => c.CompanyID == (string)HttpContext.Current.Session["CompanyID"])
            .OrderBy(o => o.Id);
            return account;
        }
        public static IEnumerable GetArticle()
        {
            var article = IWSEntities.Articles.AsEnumerable().Select(item => new
            {
                Id = item.id,
                Name = item.name,
                Price = item.price,
                Unit = item.qttyunit,
                Pack = item.packunit,
                Vat = item.VatCode,
                CompanyID = item.CompanyID
            }).
            Where(c=>c.CompanyID == (string)HttpContext.Current.Session["CompanyID"]).
            OrderBy(o => o.Name);
            return article;
        }
        public static IEnumerable GetBillOfDelivery()
        {
            var b = from o in IWSEntities.BillOfDeliveries
                                 where o.CompanyId == (string)HttpContext.Current.Session["CompanyID"]
                                 select o;
            return b;
        }
        public static IEnumerable GetCustomerInvoice()
        {
            var b = from o in IWSEntities.CustomerInvoices
                    where o.CompanyId == (string)HttpContext.Current.Session["CompanyID"]
                    select o;
            return b;
        }
        public static IEnumerable GetGeneralLedger(string area)
        {
            var b = from o in IWSEntities.GeneralLedgers
                    where o.CompanyId == (string)HttpContext.Current.Session["CompanyID"] && o.Area == area
                    select o;
            return b;
        }
        public static IEnumerable GetGoodReceiving()
        {
            var b = from o in IWSEntities.GoodReceivings
                    where o.CompanyId == (string)HttpContext.Current.Session["CompanyID"]
                    select o;
            return b;
        }
        public static IEnumerable GetInventoryInvoice()
        {
            var b = from o in IWSEntities.InventoryInvoices
                    where o.CompanyId == (string)HttpContext.Current.Session["CompanyID"]
                    select o;
            return b;
        }
        public static IEnumerable GetPayment()
        {
            var b = from o in IWSEntities.Payments
                    where o.CompanyId == (string)HttpContext.Current.Session["CompanyID"]
                    select o;
            return b;
        }
        public static IEnumerable GetPurchaseOrder()
        {
            var b = from o in IWSEntities.PurchaseOrders
                    where o.CompanyId == (string)HttpContext.Current.Session["CompanyID"]
                    select o;
            return b;
        }
        public static IEnumerable GetSalesInvoice()
        {
            var b = from o in IWSEntities.SalesInvoices
                    where o.CompanyId == (string)HttpContext.Current.Session["CompanyID"]
                    select o;
            return b;
        }
        public static IEnumerable GetSalesOrder()
        {
            var b = from o in IWSEntities.SalesOrders
                    where o.CompanyId == (string)HttpContext.Current.Session["CompanyID"]
                    select o;
            return b;
        }
        public static IEnumerable GetSettlement()
        {
            var b = from o in IWSEntities.Settlements
                    where o.CompanyId == (string)HttpContext.Current.Session["CompanyID"]
                    select o;
            return b;
        }
        public static IEnumerable GetVendorInvoice()
        {
            var b = from o in IWSEntities.VendorInvoices
                    where o.CompanyId == (string)HttpContext.Current.Session["CompanyID"]
                    select o;
            return b;
        }
        public static IEnumerable GetCustSuppliers()
        {
            var CustSupplier = IWSEntities.Suppliers.AsEnumerable().
                        Select(item => new
                        {
                            Id = item.id,
                            Name = item.name,
                            CompanyID=item.CompanyID
                        }).
                        Union(IWSEntities.Customers.AsEnumerable().
                        Select(item =>new
                        {
                            Id = item.id,
                            Name = item.name,
                            CompanyID=item.CompanyID
                        }))
                        .Where(c => c.CompanyID == (string)HttpContext.Current.Session["CompanyID"])
                        .OrderBy(o => o.Id);
            return CustSupplier;
        }
        public static IEnumerable GetCustomers()
        {
            var customer = IWSEntities.Customers.AsEnumerable().Select(item => new
            {
                Id = item.id,
                Name = item.name,
                CompanyID=item.CompanyID
            })
            .Where(c => c.CompanyID == (string)HttpContext.Current.Session["CompanyID"])
            .OrderBy(o => o.Id);
            return customer;
        }
        public static IEnumerable GetCustomer()
        {
            var b = from o in IWSEntities.Customers
                    where o.CompanyID == (string)HttpContext.Current.Session["CompanyID"]
                    select o;
            return b;
        }
        public static IEnumerable GetSupplier()
        {
            var b = from o in IWSEntities.Suppliers
                    where o.CompanyID == (string)HttpContext.Current.Session["CompanyID"]
                    select o;
            return b;
        }
        public static IEnumerable GetCompany()
        {
            var b = from o in IWSEntities.Companies
                    where o.id == (string)HttpContext.Current.Session["CompanyID"]
                    select o;
            return b;
        }
        public static IEnumerable GetBankAccount(string Owner)
        {
            var b = from o in IWSEntities.BankAccounts
                    where o.Owner == Owner
                    select o;
            return b;
        }
        public static IEnumerable GetCompanies()
        {
            var company = IWSEntities.Companies.AsEnumerable().Select(item => new
            {
                Id=item.id,
                Name = item.name
            })
            .OrderBy(o => o.Name)
            .ToList();
            return company;
        }
        //public static IEnumerable GetCompany()
        //{
        //    var company = IWSEntities.Companies.AsEnumerable().Select(item => new
        //    {
        //        Id = item.id,
        //        Name = item.name,
        //        CompanyID = item.id
        //    })
        //    .Where(c => c.CompanyID == (string)HttpContext.Current.Session["CompanyID"])
        //    .OrderBy(o => o.Name)
        //    .ToList();
        //    return company;
        //}
        public static IEnumerable GetCostCenters()
        {
            var account = IWSEntities.CostCenters.AsEnumerable().Select(item => new
            {
                Id = item.id,
                Name = item.name,
                CompanyID=item.CompanyID
            })
            .Where(c => c.CompanyID == (string)HttpContext.Current.Session["CompanyID"])
            .OrderBy(o => o.Name);
            return account;
        }
        public static IEnumerable GetMenuId()
        {
            var account = IWSEntities.Menus.AsEnumerable().Select(item => new
            {
                Id = item.ID,
                Name = item.Name,
                CompanyID = item.CompanyID
            })
            .Where(c => c.CompanyID == (string)HttpContext.Current.Session["CompanyID"])
            .OrderBy(o => o.Name);
            return account;
        }
        public static IEnumerable GetRoles()
        {
            var roleManager = new RoleManager<IdentityRole>(
                                    new RoleStore<IdentityRole>(new ApplicationDbContext()));

            List<IWSRoles> Role = (from role in roleManager.Roles
                                   select new IWSRoles
                                   {
                                       Id = role.Id,
                                       RoleName = role.Name
                                   }).ToList();
            return Role;
        }
        public static IEnumerable GetUsers()
        {
            var userManager = new UserManager<IdentityUser>(
                                    new UserStore<IdentityUser>(new ApplicationDbContext()));
            
            List<IWSUserModel> User = (from user in userManager.Users
                                       select new IWSUserModel
                                       {
                                            Id = user.Id,
                                            UserName = user.UserName,
                                       }).ToList();
            return User;
        }
        public static IEnumerable GetUserRoles(string userId)
        {
            var UserRoles = IWSEntities.AspNetUserRoles.Where(item => 
                                item.UserId == userId).Select(item => new
                                {
                                    UserId = item.UserId, 
                                    RoleId = item.RoleId
                                    }).ToList();
            return UserRoles;
        }
        public static IEnumerable GetUserRolesModel(string userId)
        {
            List<IWSUseRolesModel> userRoles = IWSEntities.AspNetUserRoles.
                                            Where(u => u.UserId == userId).
                                            Select(x => new IWSUseRolesModel()
                                            {
                                                UserId = x.UserId,
                                                RoleId = x.RoleId
                                            }).ToList();
            return userRoles;
        }
        public static IEnumerable GetStore()
        {
            var store = IWSEntities.Stores.AsEnumerable().Select(item => new
            {
                Id = item.id,
                Name = item.name,
                CompanyID=item.CompanyID
            }).
            Where(c => c.CompanyID == (string)HttpContext.Current.Session["CompanyID"]).
            OrderBy(o => o.Name);
            return store;
        }
        public static List<Menu> GetMenu(string CompanyID)
        {
            if (HttpContext.Current.Session["Menus"] == null)
            {
                List<Menu> menus = new List<Menu>();
                menus = IWSEntities.Menus
                        .Where(c=>c.CompanyID == CompanyID && c.Disable==false)
                        .ToList();
                HttpContext.Current.Session["Menus"] = menus;
            }
            return (List<Menu>)HttpContext.Current.Session["Menus"];
        }
        public static IEnumerable GetSuppliers()
        {
            var supplier = IWSEntities.Suppliers.AsEnumerable().Select(item => new
            {
                Id = item.id,
                Name = item.name,
                CompanyID =item.CompanyID
            })
            .Where(c => c.CompanyID == (string)HttpContext.Current.Session["CompanyID"])
            .OrderBy(o => o.Id);
            return supplier;
        }
        public static IEnumerable GetVAT()
        {
            var vat = IWSEntities.Vats.AsEnumerable().Select(item => new
            {
                Id = item.id,
                Name = item.PVat,
                CompanyID=item.CompanyID
            })
            .Where(c => c.CompanyID == (string)HttpContext.Current.Session["CompanyID"])
            .OrderBy(o => o.Name);
            return vat;
        }
        public static IEnumerable GetCurrency()
        {
            var currency = IWSEntities.Currencies.AsEnumerable().Select(item => new
            {
                Id = item.Id,
                Name = item.Name,
                CompanyID = item.CompanyID
            })
            .Where(c => c.CompanyID == (string)HttpContext.Current.Session["CompanyID"])
            .OrderBy(o => o.Name);
            return currency;
        }
        public static StatementDetailViewModel GetStatementDetail(int bankStatementID, string itemType)
        {
            try
            {
                if (itemType.Equals(IWSLookUp.DocsType.Settlement.ToString()))
                {
                    StatementDetailViewModel BS =
                (from b in IWSEntities.BankStatements
                 join s in IWSEntities.Customers on new { Kontonummer = b.Kontonummer } equals new { Kontonummer = s.IBAN }
                 join c in IWSEntities.BankAccounts on new { CompanyIBAN = b.CompanyIBAN } equals new { CompanyIBAN = c.IBAN }
                 where
                   b.id == bankStatementID && b.IsValidated==false
                 select new StatementDetailViewModel()
                 {
                    Id = s.id,
                    AccountID = s.accountid,
                    BankAccountID = c.Account,
                    Info = b.Info,
                    Waehrung = b.Waehrung,
                    Betrag = Math.Abs((decimal)b.Betrag),
                     Buchungstag = (DateTime)b.Buchungstag,
                    Valutadatum = (DateTime)b.Valutadatum,
                     Periode = Convert.ToString((int?)b.Buchungstag.Value.Year) +
                                Convert.ToString((int?)b.Buchungstag.Value.Month),
                    Buchungstext = b.Buchungstext,
                    Verwendungszweck = b.Verwendungszweck,
                    BeguenstigterZahlungspflichtiger = b.BeguenstigterZahlungspflichtiger,
                    IBAN = s.IBAN
                 }
                ).Single();
                    return BS;
                }

                if (itemType.Equals(IWSLookUp.DocsType.CustomerInvoice.ToString()))
                {
                    StatementDetailViewModel BS =
                        (from c in IWSEntities.Companies
                         join b in IWSEntities.BankStatements on new { id = c.id } equals new { id = b.CompanyID }
                         join s in IWSEntities.Customers
                             on new { c.id, b.Kontonummer }
                         equals new { id = s.CompanyID, Kontonummer = s.IBAN }
                         where
                         b.IsValidated.Equals(false) &&
                         b.id.Equals(bankStatementID)
                         select new StatementDetailViewModel()
                         {
                             Id = s.id,
                             AccountID = s.accountid,
                             BankAccountID = c.settlementclearingaccountid,
                             Info = b.Info,
                             Waehrung = b.Waehrung,
                             Betrag = (decimal)b.Betrag,
                             Buchungstag = (DateTime)b.Buchungstag,
                             Valutadatum = (DateTime)b.Valutadatum,
                             Periode = Convert.ToString((int?)b.Buchungstag.Value.Year) +
                                         Convert.ToString((int?)b.Buchungstag.Value.Month),
                             Buchungstext = b.Buchungstext,
                             Verwendungszweck = b.Verwendungszweck,
                             BeguenstigterZahlungspflichtiger = b.BeguenstigterZahlungspflichtiger,
                             IBAN = s.IBAN
                         }).Single();
                    return BS;
                }

                if (itemType.Equals(IWSLookUp.DocsType.Payment.ToString()))
                {
                    StatementDetailViewModel BS =
                        (from s in IWSEntities.Suppliers
                         join b in IWSEntities.BankStatements on new { IBAN = s.IBAN } equals new { IBAN = b.Kontonummer }
                         join c in IWSEntities.BankAccounts on new { CompanyIBAN = b.CompanyIBAN } equals new { CompanyIBAN = c.IBAN }
                         where
                           b.id == bankStatementID &&
                           b.IsValidated == false
                         select new StatementDetailViewModel()
                         {
                             Id=s.id,
                             AccountID= s.accountid,
                             BankAccountID= c.Account,
                             Info= b.Info,
                             Waehrung= b.Waehrung,
                             Betrag= Math.Abs((decimal)b.Betrag),
                             Buchungstag= (DateTime)b.Buchungstag,
                             Valutadatum= (DateTime)b.Valutadatum,
                             Periode = Convert.ToString((int?)b.Buchungstag.Value.Year) +
                                Convert.ToString((int?)b.Buchungstag.Value.Month),
                             Buchungstext= b.Buchungstext,
                             Verwendungszweck= b.Verwendungszweck,
                             BeguenstigterZahlungspflichtiger= b.BeguenstigterZahlungspflichtiger,
                             IBAN= s.IBAN
                         }).Single();
                    return BS;
                }

                if (itemType.Equals(IWSLookUp.DocsType.VendorInvoice.ToString()))
                {
                    StatementDetailViewModel BS =
                    (from c in IWSEntities.Companies
                     join b in IWSEntities.BankStatements on new { id = c.id } equals new { id = b.CompanyID }
                     join s in IWSEntities.Suppliers
                     on new { c.id, b.Kontonummer }
                 equals new { id = s.CompanyID, Kontonummer = s.IBAN }
                     where
                 b.IsValidated.Equals(false) &&
                 b.id.Equals(bankStatementID)
                     select new StatementDetailViewModel()
                     {
                         Id = s.id,
                         AccountID = c.purchasingclearingaccountid,
                         BankAccountID = s.accountid,
                         Info = b.Info,
                         Waehrung = b.Waehrung,
                         Betrag = Math.Abs((decimal)b.Betrag),
                         Buchungstag = (DateTime)b.Buchungstag,
                         Valutadatum = (DateTime)b.Valutadatum,
                         Periode = Convert.ToString((int?)b.Buchungstag.Value.Year) +
                                     Convert.ToString((int?)b.Buchungstag.Value.Month),
                         Buchungstext = b.Buchungstext,
                         Verwendungszweck = b.Verwendungszweck,
                         BeguenstigterZahlungspflichtiger = b.BeguenstigterZahlungspflichtiger,
                         IBAN = s.IBAN
                     }).Single();
                    return BS;
                }
            }
            catch (Exception)
            {
                return null;
            }
            return null;
        }
        public static List<BankStatementViewModel> GetBankStatements(string companyID,bool isValidated)
        {
            List<BankStatementViewModel> doc = 
                (from b in IWSEntities.BankStatements
                where
                    b.IsValidated.Equals(isValidated) && b.CompanyID.Equals(companyID)
                orderby
                    b.id
                select new BankStatementViewModel()
                {
                    id = b.id, Auftragskonto = b.Auftragskonto,
                    Buchungstag = b.Buchungstag, Valutadatum = b.Valutadatum,
                    Buchungstext = b.Buchungstext, Verwendungszweck = b.Verwendungszweck,
                    BeguenstigterZahlungspflichtiger = b.BeguenstigterZahlungspflichtiger,
                    Kontonummer = b.Kontonummer, BLZ = b.BLZ, Betrag = b.Betrag,
                    Waehrung = b.Waehrung, Info = b.Info, CompanyID = b.CompanyID,
                    IsValidated = b.IsValidated

                }).ToList();
            return doc;
        }
        public static List<ValidateDocsViewModel> GetBillOfDelivery(string uiCulture, bool IsValidated)
        {
            List<ValidateDocsViewModel> BL = Queryable.OrderBy(
            (from line in IWSEntities.LineBillOfDeliveries
             where line.BillOfDelivery.IsValidated == IsValidated
             from Item in IWSEntities.Localizations
             where Item.ItemName == DocsType.BillOfDelivery.ToString() && Item.UICulture == uiCulture
             group new
             {
                 line.BillOfDelivery,
                 line,
                 line.Article.Vat
             } by new
             {
                 line.BillOfDelivery.id,
                 ItemType = Item.LocalName,
                 ItemDate = (DateTime?)line.BillOfDelivery.ItemDate,
                 Periode = line.BillOfDelivery.oPeriode,
                 line.BillOfDelivery.account,
                 line.BillOfDelivery.CompanyId,
                 line.Vat,
                 line.Currency
             } into g
             orderby
                g.Key.id
             select new ValidateDocsViewModel()
             {
                 ItemID = g.Key.id,
                 ItemType = g.Key.ItemType,
                 DueDate = Convert.ToDateTime(g.Key.ItemDate),
                 Periode = g.Key.Periode,// g.Key.xYear + g.Key.xMonth,
                 Area = false,
                 SupplierID = g.Key.account,
                 CompanyID = g.Key.CompanyId,
                 VAT = g.Key.Vat,
                 Currency = g.Key.Currency,
                 TotalVAT = Convert.ToDecimal(Enumerable.Sum(g, p => p.line.price * p.line.quantity * p.line.Article.Vat.PVat)),
                 TotalHVAT = Convert.ToDecimal(Enumerable.Sum(g, p => p.line.price * p.line.quantity))
             }), o => o.ItemID).ToList();
            return BL;
        }
        public static List<ValidateDocsViewModel> GetVendorInvoice(string uiCulture, bool IsValidated)
        {
            List<ValidateDocsViewModel> BL = Queryable.OrderBy(
            (from line in IWSEntities.LineVendorInvoices
                where line.VendorInvoice.IsValidated == IsValidated
                from Item in IWSEntities.Localizations
                where Item.ItemName == DocsType.VendorInvoice.ToString()  && Item.UICulture == uiCulture
                group new
                {
                    line.VendorInvoice,
                    line
                } by new
                {
                    line.VendorInvoice.id,
                    ItemType = Item.LocalName,
                    ItemDate = (DateTime?)line.VendorInvoice.ItemDate,
                    Periode = line.VendorInvoice.oPeriode,
                    //xMonth = (Convert.ToString((int?)line.VendorInvoice.ItemDate.Month)).Length == 1 ?
                    //                                 '0' + Convert.ToString((int?)line.VendorInvoice.ItemDate.Month) :
                    //                                 Convert.ToString((int?)line.VendorInvoice.ItemDate.Month),
                    //xYear = Convert.ToString((int?)line.VendorInvoice.ItemDate.Year),
                    line.VendorInvoice.account,
                    line.Currency,
                    line.VendorInvoice.CompanyId
                } into g
                orderby
                        g.Key.id
                select new ValidateDocsViewModel()
                {
                    ItemID = g.Key.id,
                    ItemType = g.Key.ItemType,
                    DueDate = Convert.ToDateTime(g.Key.ItemDate),
                    Periode = g.Key.Periode,// g.Key.xYear + g.Key.xMonth,
                    Area = true,
                    SupplierID = g.Key.account,
                    CompanyID = g.Key.CompanyId,
                    VAT = 0,
                    TotalVAT = 0,
                    TotalHVAT = Convert.ToDecimal(Enumerable.Sum(g, p => (double)p.line.amount)),
                    Currency=g.Key.Currency
                }), o => o.ItemID).ToList();
            return BL;
        }
        public static List<ValidateDocsViewModel> GetPurchaseOrder(string uiCulture, bool IsValidated)
        {
            List<ValidateDocsViewModel> BL = Queryable.OrderBy(
            (from line in IWSEntities.LinePurchaseOrders
             where line.PurchaseOrder.IsValidated == IsValidated
             from Item in IWSEntities.Localizations
             where Item.ItemName == DocsType.PurchaseOrder.ToString() && Item.UICulture == uiCulture
             group new
             {
                 line.PurchaseOrder,
                 line,
                 line.Article.Vat
             } by new
             {
                 line.PurchaseOrder.id,
                 ItemType = Item.LocalName,
                 ItemDate = (DateTime?)line.PurchaseOrder.ItemDate,
                 Periode=line.PurchaseOrder.oPeriode,
                 //xMonth = (Convert.ToString((int?)line.PurchaseOrder.ItemDate.Month)).Length == 1 ?
                 //                                    '0' + Convert.ToString((int?)line.PurchaseOrder.ItemDate.Month) :
                 //                                    Convert.ToString((int?)line.PurchaseOrder.ItemDate.Month),
                 //xYear = Convert.ToString((int?)line.PurchaseOrder.ItemDate.Year),
                 line.PurchaseOrder.account,
                 line.PurchaseOrder.CompanyId,
                 line.Vat,
                 line.Currency
             } into g
             orderby
                 g.Key.id
             select new ValidateDocsViewModel()
             {
                 ItemID = g.Key.id,
                 ItemType = g.Key.ItemType,
                 DueDate = Convert.ToDateTime(g.Key.ItemDate),
                 Periode = g.Key.Periode,// g.Key.xYear + g.Key.xMonth,
                 Area = false,
                 SupplierID = g.Key.account,
                 CompanyID = g.Key.CompanyId,
                 VAT=g.Key.Vat,
                 Currency=g.Key.Currency,
                 TotalVAT = Convert.ToDecimal(Enumerable.Sum(g, p => p.line.price * p.line.quantity * p.line.Article.Vat.PVat)),
                 TotalHVAT = Convert.ToDecimal(Enumerable.Sum(g, p => p.line.price * p.line.quantity))
             }), o => o.ItemID).ToList();
            return BL;

        }
        public static List<ValidateDocsViewModel> GetPayment(string uiCulture, bool IsValidated)
        {
             List<ValidateDocsViewModel> BL = Queryable.OrderBy(
             (from line in IWSEntities.LinePayments
             where line.Payment.IsValidated == IsValidated
             from Item in IWSEntities.Localizations
             where Item.ItemName == DocsType.Payment.ToString() && Item.UICulture == uiCulture
             group new
             {
                 line.Payment,
                 line
             } by new
             {
                 line.Payment.id,
                 ItemType = Item.LocalName,
                 ItemDate = (DateTime?)line.Payment.ItemDate,
                 Periode = line.Payment.oPeriode,
                 //xMonth = (Convert.ToString((int?)line.Payment.ItemDate.Month)).Length == 1 ?
                 //                                    '0' + Convert.ToString((int?)line.Payment.ItemDate.Month) :
                 //                                    Convert.ToString((int?)line.Payment.ItemDate.Month),
                 //xYear = Convert.ToString((int?)line.Payment.ItemDate.Year),
                 line.Payment.account,
                 line.Payment.CompanyId,
                 line.Currency
             } into g
             orderby
                 g.Key.id
             select new ValidateDocsViewModel()
             {
                 ItemID = g.Key.id,
                 ItemType = g.Key.ItemType,
                 DueDate = Convert.ToDateTime(g.Key.ItemDate),
                 Periode = g.Key.Periode,// g.Key.xYear + g.Key.xMonth,
                 Area = false,
                 SupplierID = g.Key.account,
                 CompanyID = g.Key.CompanyId,
                 VAT=0,
                 TotalVAT = 0,
                 TotalHVAT = Convert.ToDecimal(Enumerable.Sum(g, p => (double)p.line.amount)),
                 Currency=g.Key.Currency
             }), o => o.ItemID).ToList();
            return BL;
        }
        public static List<ValidateDocsViewModel> GetInventoryInvoice(string uiCulture, bool IsValidated)
        {
            List<ValidateDocsViewModel> BL = Queryable.OrderBy(
                (from line in IWSEntities.LineInventoryInvoices
                 where line.InventoryInvoice.IsValidated == IsValidated
                 from Item in IWSEntities.Localizations
                 where Item.ItemName == DocsType.InventoryInvoice.ToString() && Item.UICulture == uiCulture
                 group new
                 {
                     line.InventoryInvoice,
                     line,
                     line.Article.Vat
                 } by new
                 {
                     line.InventoryInvoice.id,
                     ItemType = Item.LocalName,
                     ItemDate = (DateTime?)line.InventoryInvoice.ItemDate,
                     Periode = line.InventoryInvoice.oPeriode,
                     //xMonth = (Convert.ToString((int?)line.InventoryInvoice.ItemDate.Month)).Length == 1 ?
                     //                                    '0' + Convert.ToString((int?)line.InventoryInvoice.ItemDate.Month) :
                     //                                    Convert.ToString((int?)line.InventoryInvoice.ItemDate.Month),
                     //xYear = Convert.ToString((int?)line.InventoryInvoice.ItemDate.Year),
                     line.InventoryInvoice.account,
                     line.InventoryInvoice.CompanyId,
                     line.Vat,
                     line.Currency
                 } into g
                 orderby
                    g.Key.id
                 select new ValidateDocsViewModel()
                 {
                     ItemID = g.Key.id,
                     ItemType = g.Key.ItemType,
                     DueDate = Convert.ToDateTime(g.Key.ItemDate),
                     Periode = g.Key.Periode,// g.Key.xYear + g.Key.xMonth,
                     Area = true,
                     SupplierID = g.Key.account,
                     CompanyID = g.Key.CompanyId,
                     VAT = g.Key.Vat,
                     Currency=g.Key.Currency,
                     TotalVAT = Convert.ToDecimal(Enumerable.Sum(g, p => p.line.price * p.line.quantity * p.line.Article.Vat.PVat)),
                     TotalHVAT = Convert.ToDecimal(Enumerable.Sum(g, p => p.line.price * p.line.quantity))
                 }), o => o.ItemID).ToList();
            return BL;
        }
        public static List<ValidateDocsViewModel> GetGoodReceiving(string uiCulture, bool IsValidated)
        {
            List<ValidateDocsViewModel> BL = Queryable.OrderBy(
            (from line in IWSEntities.LineGoodReceivings
             where line.GoodReceiving.IsValidated == IsValidated
             from Item in IWSEntities.Localizations
             where Item.ItemName == DocsType.GoodReceiving.ToString() && Item.UICulture == uiCulture
             group new
             {
                 line.GoodReceiving,
                 line,
                 line.Article.Vat
             } by new
             {
                 line.GoodReceiving.id,
                 ItemType = Item.LocalName,
                 ItemDate = (DateTime?)line.GoodReceiving.ItemDate,
                 Periode=line.GoodReceiving.oPeriode,
                 //xMonth = (Convert.ToString((int?)line.GoodReceiving.ItemDate.Month)).Length == 1 ?
                 //                                    '0' + Convert.ToString((int?)line.GoodReceiving.ItemDate.Month) :
                 //                                    Convert.ToString((int?)line.GoodReceiving.ItemDate.Month),
                 //xYear = Convert.ToString((int?)line.GoodReceiving.ItemDate.Year),
                 line.GoodReceiving.account,
                 line.GoodReceiving.CompanyId,
                 line.Vat,
                 line.Currency
             } into g
             orderby
                g.Key.id
             select new ValidateDocsViewModel()
             {
                 ItemID = g.Key.id,
                 ItemType = g.Key.ItemType,
                 DueDate = Convert.ToDateTime(g.Key.ItemDate),
                 Periode= g.Key.Periode,// g.Key.xYear + g.Key.xMonth,
                 Area = true,
                 SupplierID = g.Key.account,
                 CompanyID = g.Key.CompanyId,
                 VAT=g.Key.Vat,
                 Currency=g.Key.Currency,
                 TotalVAT = Convert.ToDecimal(Enumerable.Sum(g, p => p.line.price * p.line.quantity * p.line.Article.Vat.PVat)),
                 TotalHVAT = Convert.ToDecimal(Enumerable.Sum(g, p => p.line.price * p.line.quantity))
             }), o => o.ItemID).ToList();
            return BL;
        }
        public static List<ValidateDocsViewModel> GetSalesOrder(string uiCulture, bool IsValidated)
        {
            List<ValidateDocsViewModel> BL = Queryable.OrderBy(
            (from line in IWSEntities.LineSalesOrders
             where line.SalesOrder.IsValidated == IsValidated
             from Item in IWSEntities.Localizations
             where Item.ItemName == DocsType.SalesOrder.ToString() && Item.UICulture == uiCulture
             group new
             {
                 line.SalesOrder,
                 line,
                 line.Article.Vat
             } by new
             {
                 line.SalesOrder.id,
                 ItemType = Item.LocalName,
                 ItemDate = (DateTime?)line.SalesOrder.ItemDate,
                 Periode=line.SalesOrder.oPeriode,
                 //xMonth = (Convert.ToString((int?)line.SalesOrder.ItemDate.Month)).Length == 1 ?
                 //                                    '0' + Convert.ToString((int?)line.SalesOrder.ItemDate.Month) :
                 //                                    Convert.ToString((int?)line.SalesOrder.ItemDate.Month),
                 //xYear = Convert.ToString((int?)line.SalesOrder.ItemDate.Year),
                 line.SalesOrder.account,
                 line.SalesOrder.CompanyId,
                 line.Vat,
                 line.Currency
             } into g
             orderby
                 g.Key.id
             select new ValidateDocsViewModel()
             {
                 ItemID = g.Key.id,
                 ItemType = g.Key.ItemType,
                 DueDate = Convert.ToDateTime(g.Key.ItemDate),
                 Periode = g.Key.Periode,// g.Key.xYear + g.Key.xMonth,
                 Area = false,
                 SupplierID = g.Key.account,
                 CompanyID = g.Key.CompanyId,
                 VAT = g.Key.Vat,
                 Currency=g.Key.Currency,
                 TotalVAT = Convert.ToDecimal(Enumerable.Sum(g, p => p.line.price * p.line.quantity * p.line.Article.Vat.PVat)),
                 TotalHVAT = Convert.ToDecimal(Enumerable.Sum(g, p => p.line.price * p.line.quantity))
             }), o => o.ItemID).ToList();
            return BL;
        }
        public static List<ValidateDocsViewModel> GetSalesInvoice(string uiCulture, bool IsValidated)
        {
            List<ValidateDocsViewModel> BL = Queryable.OrderBy(
                (from line in IWSEntities.LineSalesInvoices
                 where line.SalesInvoice.IsValidated == IsValidated
                 from Item in IWSEntities.Localizations
                 where Item.ItemName == DocsType.SalesInvoice.ToString() && Item.UICulture == uiCulture
                 group new
                 {
                     line.SalesInvoice,
                     line,
                     line.Article.Vat
                 } by new
                 {
                     line.SalesInvoice.id,
                     ItemType = Item.LocalName,
                     ItemDate = (DateTime?)line.SalesInvoice.ItemDate,
                     Periode=line.SalesInvoice.oPeriode,
                     //xMonth = (Convert.ToString((int?)line.SalesInvoice.ItemDate.Month)).Length == 1 ?
                     //                                    '0' + Convert.ToString((int?)line.SalesInvoice.ItemDate.Month) :
                     //                                    Convert.ToString((int?)line.SalesInvoice.ItemDate.Month),
                     //xYear = Convert.ToString((int?)line.SalesInvoice.ItemDate.Year),
                     line.SalesInvoice.account,
                     line.SalesInvoice.CompanyId,
                     line.Vat,
                     line.Currency
                 } into g
                 orderby
                    g.Key.id
                 select new ValidateDocsViewModel()
                 {
                     ItemID = g.Key.id,
                     ItemType = g.Key.ItemType,
                     DueDate = Convert.ToDateTime(g.Key.ItemDate),
                     Periode = g.Key.Periode,// g.Key.xYear + g.Key.xMonth,
                     Area = false,
                     SupplierID = g.Key.account,
                     CompanyID = g.Key.CompanyId,
                     VAT = g.Key.Vat,
                     Currency=g.Key.Currency,
                     TotalVAT = Convert.ToDecimal(Enumerable.Sum(g, p => p.line.price * p.line.quantity * p.line.Article.Vat.PVat)),
                     TotalHVAT = Convert.ToDecimal(Enumerable.Sum(g, p => p.line.price * p.line.quantity))
                 }), o => o.ItemID).ToList();
            return BL;
        }
        public static List<ValidateDocsViewModel> GetCustomerInvoice(string uiCulture, bool IsValidated)
        {
            List<ValidateDocsViewModel> BL = Queryable.OrderBy(
            (from line in IWSEntities.LineCustomerInvoices
             where line.CustomerInvoice.IsValidated == IsValidated
             from Item in IWSEntities.Localizations
             where Item.ItemName == DocsType.CustomerInvoice.ToString() && Item.UICulture == uiCulture
             group new
             {
                 line.CustomerInvoice,
                 line
             } by new
             {
                 line.CustomerInvoice.id,
                 ItemType = Item.LocalName,
                 ItemDate = (DateTime?)line.CustomerInvoice.ItemDate,
                 Periode=line.CustomerInvoice.oPeriode,
                 //xMonth = (Convert.ToString((int?)line.CustomerInvoice.ItemDate.Month)).Length == 1 ?
                 //                                 '0' + Convert.ToString((int?)line.CustomerInvoice.ItemDate.Month) :
                 //                                 Convert.ToString((int?)line.CustomerInvoice.ItemDate.Month),
                 //xYear = Convert.ToString((int?)line.CustomerInvoice.ItemDate.Year),
                 line.CustomerInvoice.account,
                 line.Currency,
                 line.CustomerInvoice.CompanyId
             } into g
             orderby
                     g.Key.id
             select new ValidateDocsViewModel()
             {
                 ItemID = g.Key.id,
                 ItemType = g.Key.ItemType,
                 DueDate = Convert.ToDateTime(g.Key.ItemDate),
                 Periode = g.Key.Periode,// g.Key.xYear + g.Key.xMonth,
                 Area = false,
                 SupplierID = g.Key.account,
                 CompanyID = g.Key.CompanyId,
                 VAT = 0,
                 TotalVAT = 0,
                 Currency=g.Key.Currency,
                 TotalHVAT = Convert.ToDecimal(Enumerable.Sum(g, p => (double)p.line.amount))
             }), o => o.ItemID).ToList();
            return BL;
        }
        public static List<ValidateDocsViewModel> GetSettlement(string uiCulture, bool IsValidated)
        {
            List<ValidateDocsViewModel> BL = Queryable.OrderBy(
            (from line in IWSEntities.LineSettlements
             where line.Settlement.IsValidated == IsValidated
             from Item in IWSEntities.Localizations
             where Item.ItemName == DocsType.Settlement.ToString() && Item.UICulture == uiCulture
             group new
             {
                 line.Settlement,
                 line
             } by new
             {
                 line.Settlement.id,
                 ItemType = Item.LocalName,
                 ItemDate = (DateTime?)line.Settlement.ItemDate,
                 Periode=line.Settlement.oPeriode,
                 //xMonth = (Convert.ToString((int?)line.Settlement.ItemDate.Month)).Length == 1 ?
                 //                                     '0' + Convert.ToString((int?)line.Settlement.ItemDate.Month) :
                 //                                     Convert.ToString((int?)line.Settlement.ItemDate.Month),
                 //xYear = Convert.ToString((int?)line.Settlement.ItemDate.Year),
                 line.Settlement.account,
                 line.Settlement.CompanyId,
                 line.Currency
             } into g
             orderby
                  g.Key.id
             select new ValidateDocsViewModel()
             {
                 ItemID = g.Key.id,
                 ItemType = g.Key.ItemType,
                 DueDate = Convert.ToDateTime(g.Key.ItemDate),
                 Periode = g.Key.Periode,// g.Key.xYear + g.Key.xMonth,
                 Area = false,
                 SupplierID = g.Key.account,
                 CompanyID = g.Key.CompanyId,
                 VAT = 0,
                 TotalVAT = 0,
                 Currency=g.Key.Currency,
                 TotalHVAT = Convert.ToDecimal(Enumerable.Sum(g, p => (double)p.line.amount))
             }), o => o.ItemID).ToList();
            return BL;
        }
        public static List<ValidateDocsViewModel> GetGeneralLedgerIn(string uiCulture, bool IsValidated)
        {
            List<ValidateDocsViewModel> BL = Queryable.OrderBy(
            (from line in IWSEntities.LineGeneralLedgers
             where line.GeneralLedger.IsValidated == IsValidated && line.GeneralLedger.Area == Area.Sales.ToString()
             from Item in IWSEntities.Localizations
             where Item.ItemName == DocsType.GeneralLedger.ToString() && Item.UICulture == uiCulture
             group new
             {
                 line.GeneralLedger,
                 line
             } by new
             {
                 line.GeneralLedger.id,
                 ItemType = Item.LocalName,
                 ItemDate = (DateTime?)line.GeneralLedger.ItemDate,
                 Periode = line.GeneralLedger.oPeriode,
                 //xMonth = (Convert.ToString((int?)line.GeneralLedger.ItemDate.Month)).Length == 1 ?
                 //                                     '0' + Convert.ToString((int?)line.GeneralLedger.ItemDate.Month) :
                 //                                     Convert.ToString((int?)line.GeneralLedger.ItemDate.Month),
                 //xYear = Convert.ToString((int?)line.GeneralLedger.ItemDate.Year),
                 line.GeneralLedger.CompanyId,
                 line.Currency
             } into g
             orderby
                  g.Key.id
             select new ValidateDocsViewModel()
             {
                 ItemID = g.Key.id,
                 ItemType = g.Key.ItemType,
                 DueDate = Convert.ToDateTime(g.Key.ItemDate),
                 Periode = g.Key.Periode,// g.Key.xYear + g.Key.xMonth,
                 Area = false,
                 SupplierID = Area.Sales.ToString(),
                 CompanyID = g.Key.CompanyId,
                 VAT = 0,
                 TotalVAT = 0,
                 Currency=g.Key.Currency,
                 TotalHVAT = Convert.ToDecimal(Enumerable.Sum(g, p => (double)p.line.amount))
             }), o => o.ItemID).ToList();
            return BL;
        }
        public static List<ValidateDocsViewModel> GetGeneralLedgerOut(string uiCulture, bool IsValidated)
        {
            List<ValidateDocsViewModel> BL = Queryable.OrderBy(
            (from line in IWSEntities.LineGeneralLedgers
             where line.GeneralLedger.IsValidated == IsValidated && line.GeneralLedger.Area == Area.Purchasing.ToString()
             from Item in IWSEntities.Localizations
             where Item.ItemName == DocsType.GeneralLedger.ToString() && Item.UICulture == uiCulture
             group new
             {
                 line.GeneralLedger,
                 line
             } by new
             {
                 line.GeneralLedger.id,
                 ItemType = Item.LocalName,
                 ItemDate = (DateTime?)line.GeneralLedger.ItemDate,
                 Periode=line.GeneralLedger.oPeriode,
                 //xMonth = (Convert.ToString((int?)line.GeneralLedger.ItemDate.Month)).Length == 1 ?
                 //                                     '0' + Convert.ToString((int?)line.GeneralLedger.ItemDate.Month) :
                 //                                     Convert.ToString((int?)line.GeneralLedger.ItemDate.Month),
                 //xYear = Convert.ToString((int?)line.GeneralLedger.ItemDate.Year),
                 line.GeneralLedger.CompanyId,
                 line.Currency
             } into g
             orderby
                  g.Key.id
             select new ValidateDocsViewModel()
             {
                 ItemID = g.Key.id,
                 ItemType = g.Key.ItemType,
                 DueDate = Convert.ToDateTime(g.Key.ItemDate),
                 Periode = g.Key.Periode,// g.Key.xYear + g.Key.xMonth,
                 Area = false,
                 SupplierID = Area.Purchasing.ToString(),
                 CompanyID = g.Key.CompanyId,
                 VAT = 0,
                 TotalVAT = 0,
                 Currency=g.Key.Currency,
                 TotalHVAT = Convert.ToDecimal(Enumerable.Sum(g, p => (double)p.line.amount))
             }), o => o.ItemID).ToList();
            return BL;
        }
        public static List<DocumentsViewModel> GetAccountingDocument(bool IsValidated) 
        {
            // get current thread UICulture
            string uiCulture = Thread.CurrentThread.CurrentUICulture.Name;

            List<ValidateDocsViewModel> document = 
                                            GetPurchaseOrder(uiCulture, IsValidated).
                                            Union(GetGoodReceiving(uiCulture, IsValidated)).
                                            Union(GetInventoryInvoice(uiCulture, IsValidated)).
                                            Union(GetVendorInvoice(uiCulture, IsValidated)).
                                            Union(GetPayment(uiCulture, IsValidated)).
                                            Union(GetSalesOrder(uiCulture, IsValidated)).
                                            Union(GetBillOfDelivery(uiCulture, IsValidated)).
                                            Union(GetSalesInvoice(uiCulture, IsValidated)).
                                            Union(GetCustomerInvoice(uiCulture, IsValidated)).
                                            Union(GetSettlement(uiCulture, IsValidated)).
                                            Union(GetGeneralLedgerIn(uiCulture, IsValidated)).
                                            Union(GetGeneralLedgerOut(uiCulture, IsValidated)).
                                            Where(c=>c.CompanyID==(string)HttpContext.Current.Session["CompanyID"]).
                                            ToList();
            List<DocumentsViewModel> documents = (
                                            from doc in document
                                            group doc by new
                                            {
                                                doc.ItemID, doc.ItemType, doc.DueDate,
                                                doc.SupplierID, doc.CompanyID, doc.Currency
                                            } into g
                                            orderby
                                            g.Key.ItemType, g.Key.ItemID
                                            select new DocumentsViewModel()
                                            {
                                                ItemID=g.Key.ItemID, ItemType=g.Key.ItemType, DueDate=g.Key.DueDate,
                                                SupplierID =g.Key.SupplierID, CompanyID=g.Key.CompanyID,
                                                TotalVAT =g.Sum(s=>s.TotalVAT), TotalHVAT=g.Sum(s=>s.TotalHVAT),
                                                Currency=g.Key.Currency
                                            }).ToList();
            return documents;
        }

        public static List<OwnerViewModel> GetOwner()
        {
            string uiCulture = Thread.CurrentThread.CurrentUICulture.Name;

            List<OwnerViewModel> companies = Queryable.OrderBy(
            (from line in IWSEntities.Companies
             where line.id== (string)HttpContext.Current.Session["CompanyID"]
             from Item in IWSEntities.Localizations
             where Item.ItemName == Owner.Company.ToString() && Item.UICulture == uiCulture
             select new OwnerViewModel()
             {
                 ID = line.id,
                 Name = line.name,
                 OwnerType = Item.LocalName
             }), o => o.OwnerType).ToList();

            List<OwnerViewModel> customers = Queryable.OrderBy(
            (from line in IWSEntities.Customers
             where line.id == (string)HttpContext.Current.Session["CompanyID"]
             from Item in IWSEntities.Localizations
             where Item.ItemName == Owner.Company.ToString() && Item.UICulture == uiCulture
             select new OwnerViewModel()
             {
                 ID = line.id,
                 Name = line.name,
                 OwnerType = Item.LocalName
             }), o => o.OwnerType).ToList();

            List<OwnerViewModel> suppliers = Queryable.OrderBy(
            (from line in IWSEntities.Suppliers
             where line.id == (string)HttpContext.Current.Session["CompanyID"]
             from Item in IWSEntities.Localizations
             where Item.ItemName == Owner.Company.ToString() && Item.UICulture == uiCulture
             select new OwnerViewModel()
             {
                 ID = line.id,
                 Name = line.name,
                 OwnerType = Item.LocalName
             }), o => o.OwnerType).ToList();
            return companies.Union(customers).Union(suppliers).ToList();

        }


        public static IEnumerable GetNewLineGoodReceiving(int  itemID, int oid)
        {
            List<LinePurchaseOrder> items = new List<LinePurchaseOrder>();
            items = IWSEntities.LinePurchaseOrders
                    .Where(c => c.transid == oid)
                    .ToList();
            List<LineGoodReceiving> docs = 
                (from item in items
                select new LineGoodReceiving()
                {
                    transid = itemID, 
                    item=item.item, unit=item.unit,
                    price=item.price, quantity=item.quantity,
                    Vat=item.Vat, duedate=item.duedate,
                    text=item.text, Currency=item.Currency
                }
                ).ToList();
            return docs;
        }
        public static IEnumerable GetNewLineBillOfDelivery(int itemID, int oid)
        {
            List<LineSalesOrder> items = new List<LineSalesOrder>();
            items = IWSEntities.LineSalesOrders
                    .Where(c => c.transid == oid)
                    .ToList();
            List<LineBillOfDelivery> docs =
                (from item in items
                 select new LineBillOfDelivery()
                 {
                     transid = itemID, 
                     item = item.item, unit = item.unit,
                     price = item.price, quantity = item.quantity,
                     Vat = item.Vat, duedate = item.duedate,
                     text = item.text, Currency = item.Currency
                 }
                ).ToList();
            return docs;
        }
        public static IEnumerable GetNewLineSalesInvoice(int itemID, int oid)
        {
            List<LineBillOfDelivery> items = new List<LineBillOfDelivery>();
            items = IWSEntities.LineBillOfDeliveries
                    .Where(c => c.transid == oid)
                    .ToList();
            List<LineSalesInvoice> docs =
                (from item in items
                 select new LineSalesInvoice()
                 {
                     transid = itemID,
                     item = item.item,
                     unit = item.unit,
                     price = item.price,
                     quantity = item.quantity,
                     Vat = item.Vat,
                     duedate = item.duedate,
                     text = item.text,
                     Currency = item.Currency
                 }
                ).ToList();
            return docs;
        }
        public static IEnumerable GetNewLineCustomerInvoice(int itemID, int oid)
        {

            List<CreditViewModel> c = new List<CreditViewModel>
                ((from l in IWSEntities.LineSalesInvoices
                    where 
                    l.transid == oid &&
                    l.Article.CompanyID == (string)HttpContext.Current.Session["CompanyID"] &&
                    l.Article.Vat.CompanyID == (string)HttpContext.Current.Session["CompanyID"]
                    select new CreditViewModel()
                    {
                        OCreditVAT = l.Article.Vat.outputvataccountid,
                        OCreditTotal = l.Article.Vat.revenueaccountid
                    }).Distinct());

            List<DebitViewModel> d = new List<DebitViewModel>
                (from l in IWSEntities.SalesInvoices
                   where
                     l.CompanyId == (string)HttpContext.Current.Session["CompanyID"] &&
                     l.id == oid
                   select new DebitViewModel()
                   {
                       TransID = itemID,
                       ODebit = l.Customer.accountid,
                       OCredit= l.Company.salesclearingaccountid,
                       Side = false,
                       HeaderText = l.HeaderText,
                       ItemDate= l.ItemDate,
                       OVat = l.oVat,
                       OTotal = l.oTotal,
                       Currency = l.oCurrency
                   });
            IList<LineCustomerInvoice> lines = new List<LineCustomerInvoice>() {
                        new LineCustomerInvoice(){
                            transid =itemID, account=d.Single().ODebit, side=d.Single().Side, oaccount=c.Single().OCreditVAT,
                            amount=(decimal)d.Single().OVat, duedate=d.Single().ItemDate, text=d.Single().HeaderText,
                            Currency=d.Single().Currency},
                        new LineCustomerInvoice(){
                            transid =itemID, account=d.Single().ODebit, side=d.Single().Side, oaccount=d.Single().OCredit,
                            amount=(decimal)d.Single().OTotal, duedate=d.Single().ItemDate, text=d.Single().HeaderText,
                            Currency=d.Single().Currency}
                    };
            return lines;
        }
        public static IEnumerable GetNewLineSettlement(int itemID, int oid)
        {
            List<CreditViewModel> c = new List<CreditViewModel>
                ((from l in IWSEntities.CustomerInvoices
                  where
                    l.id == oid
                  select new CreditViewModel()
                  {
                      OCreditTotal= l.Company.bankaccountid
                  }).Distinct());

            List<DebitViewModel> d = new List<DebitViewModel>
                (from l in IWSEntities.LineCustomerInvoices
                 group l by new
                 {
                     l.transid, l.account, l.side, l.duedate, l.Currency, l.text
                 } into g
                 where g.Key.transid == oid
                 select new DebitViewModel()
                 {
                     TransID= g.Key.transid, ODebit= g.Key.account, Side= !g.Key.side,
                     OVat = (decimal?)g.Sum(p => p.amount), ItemDate= g.Key.duedate,
                     Currency= g.Key.Currency, HeaderText= g.Key.text
                 });
            IList<LineSettlement> lines = new List<LineSettlement>() {
                        new LineSettlement(){
                            transid =itemID, account=c.Single().OCreditTotal, side=d.Single().Side, oaccount=d.Single().ODebit,
                            amount=(decimal)d.Single().OVat, duedate=d.Single().ItemDate, text=d.Single().HeaderText,
                            Currency=d.Single().Currency}
                     };
            return lines;            
        }
        public static IEnumerable GetNewLinePayment(int itemID, int oid)
        {
            List<CreditViewModel> c = new List<CreditViewModel>
                ((from l in IWSEntities.VendorInvoices
                  where
                    l.id == oid
                  select new CreditViewModel()
                  {
                      OCreditTotal = l.Company.bankaccountid
                  }).Distinct());

            List<DebitViewModel> d = new List<DebitViewModel>
                (from l in IWSEntities.VendorInvoices
                 where
                   l.id == oid
                 select new DebitViewModel()
                 {
                     TransID = itemID,
                     ODebit = l.Supplier.accountid,
                     Side = true,
                     OTotal= l.oTotal,
                     ItemDate=l.ItemDate,
                     HeaderText=l.HeaderText,
                     Currency=l.oCurrency,
                 });
                 
            IList<LinePayment> lines = new List<LinePayment>() {
                        new LinePayment(){
                            transid =itemID, account=d.Single().ODebit, side=d.Single().Side, oaccount=c.Single().OCreditTotal,
                            amount=(decimal)d.Single().OTotal, duedate=d.Single().ItemDate, text=d.Single().HeaderText,
                            Currency=d.Single().Currency}
                     };
            return lines;
        }
        public static IEnumerable GetNewGeneralLedgerIn(int itemID, int oid)
        {
            List<LineSettlement> items = new List<LineSettlement>();
            items = IWSEntities.LineSettlements
                    .Where(c => c.transid == oid)
                    .ToList();
            List<LineGeneralLedger> docs =
                (from item in items
                 select new LineGeneralLedger()
                 {
                     transid = itemID, account = item.oaccount, side = !item.side,
                     oaccount = item.account, amount = item.amount,
                     duedate = item.duedate, text = item.text,
                     Currency = item.Currency
                 }
                ).ToList();
            return docs;
        }
        public static IEnumerable GetNewGeneralLedgerOut(int itemID, int oid)
        {
            List<LinePayment> items = new List<LinePayment>();
            items = IWSEntities.LinePayments
                    .Where(c => c.transid == oid)
                    .ToList();
            List<LineGeneralLedger> docs =
                (from item in items
                 select new LineGeneralLedger()
                 {
                     transid = itemID, account = item.oaccount, side = !item.side,
                     oaccount = item.account, amount = item.amount,
                     duedate = item.duedate, text = item.text,
                     Currency = item.Currency
                 }
                ).ToList();
            return docs;
        }
        public static IEnumerable GetNewLineInventoryInvoice(int itemID, int oid)
        {
            List<LineGoodReceiving> items = new List<LineGoodReceiving>();
            items = IWSEntities.LineGoodReceivings
                    .Where(c => c.transid == oid)
                    .ToList();
            List<LineInventoryInvoice> docs =
                (from item in items
                 select new LineInventoryInvoice()
                 {
                     transid = itemID, item = item.item, unit = item.unit, price = item.price,
                     quantity = item.quantity, Vat = item.Vat, duedate = item.duedate,
                     text = item.text, Currency = item.Currency
                 }
                ).ToList();
            return docs;
        }
        public static IEnumerable GetNewLineVendorInvoice(int itemID, int oid)
        {
            var lines=
            (
                from LineInventoryInvoices in IWSEntities.LineInventoryInvoices
                where
                  LineInventoryInvoices.transid == oid
                group new { LineInventoryInvoices.Article, LineInventoryInvoices } by new
                {
                    //LineInventoryInvoices.Article.ExpenseAccount
                    LineInventoryInvoices.InventoryInvoice.Company.purchasingclearingaccountid
                } into g
                select new
                {
                    account = g.Key.purchasingclearingaccountid,// g.Key.ExpenseAccount,
                    amount = (decimal?)g.Sum(p => p.LineInventoryInvoices.lineNet)
                }
            ).Union
            (
                from LineInventoryInvoices in IWSEntities.LineInventoryInvoices
                where
                  LineInventoryInvoices.transid == oid
                group new { LineInventoryInvoices.Article.Vat, LineInventoryInvoices } by new
                {
                    LineInventoryInvoices.Article.Vat.inputvataccountid
                } into g
                select new
                {
                    account = g.Key.inputvataccountid,
                    amount = (decimal?)g.Sum(p => p.LineInventoryInvoices.lineVAT)
                }
            );

            var header = from h in IWSEntities.InventoryInvoices
                         where
                           h.id == oid
                         select new
                         {
                             h.HeaderText,
                             h.TransDate,
                             h.oTotal,
                             h.oCurrency,
                             h.Supplier.accountid
                         };

            List<LineInvoiceViewModel> newLine = (from o in lines
                                               select new LineInvoiceViewModel()
                                                {
                                                    TransID=itemID,
                                                    Account=o.account,
                                                    Side = true,
                                                    OAccount =header.Single().accountid,
                                                    Amount= (decimal)o.amount,
                                                    DueDate=header.Single().TransDate,
                                                    Text=header.Single().HeaderText,
                                                    Currency=header.Single().oCurrency
                                                }).ToList();
            List<LineVendorInvoice> docs =
             (from item in newLine
              select new LineVendorInvoice()
              {
                  transid = itemID,
                  account=item.Account,
                  side=item.Side,
                  oaccount=item.OAccount,
                  amount=item.Amount,
                  duedate = item.DueDate,
                  text = item.Text,
                  Currency = item.Currency
              }
             ).ToList();
            return docs;
        }

        public static IEnumerable GetAccountBalance(string CompanyID)
        {
            List<AccountBalanceViewModel> items = (from p in IWSEntities.PeriodicAccountBalances
                                                select new AccountBalanceViewModel()
                                                {
                                                    pk=p.Id,
                                                    AccountID = p.AccountId + "-" +
                                                                p.Name,
                                                    Periode = p.Periode,
                                                    Debit = p.Debit,
                                                    Credit = p.Credit,
                                                    Currency = p.Currency,
                                                    CompanyID = p.CompanyID
                                                })
                                                .Where(c=>c.CompanyID== CompanyID)
                                                .ToList();
            return items;
        }
        public static IEnumerable GetJournal(string CompanyID)
        {
            // get current thread UICulture
            string uiCulture = Thread.CurrentThread.CurrentUICulture.Name;

            List<JournalViewModel> journals = 
                (from j in IWSEntities.Journals
                from item in IWSEntities.Localizations
                where item.ItemName == j.ItemType && item.UICulture == uiCulture
                select new JournalViewModel()
                {
                ItemID = j.ItemID,
                OID = j.OID,
                ItemType = item.LocalName,
                CustSupplierID = j.CustSupplierID,
                TransDate = j.TransDate,
                Periode = j.Periode,
                Account = j.Account,
                OAccount = j.OAccount,
                Amount = j.Amount,
                Side = j.Side,
                Currency=j.Currency,
                CompanyID=j.CompanyID
            })
            .Where(c=>c.CompanyID==CompanyID)
            .ToList();
            return journals;
        }
        public static IEnumerable GetResultat(string classId, string start, string end, string company)
        {
            List<ResultsViewModel> r = (from s in IWSEntities.AccountBalance(classId, start, end, company)
                                        where s.SDebit != s.SCredit
                                        select new ResultsViewModel()
                                        {
                                            ClassId =s.ClassId,
                                            ClassName =s.ClassName,
                                            SubClassId =s.SubClassId,
                                            SubClassName =s.SubClassName,
                                            AccountId = s.AccountId,
                                            AccountName = s.AccountName,
                                            TDebit = (Decimal)s.TDebit,
                                            TCredit = (Decimal)s.TCredit,
                                            SDebit = (Decimal)s.SDebit,
                                            SCredit = (Decimal)s.SCredit,
                                            Currency=s.Currency,
                                            Balance=(decimal)s.Balance
                                        }).ToList();
            return r;
        }
        public static IEnumerable GetClass()
        {

            List<ChildViewModel> r = (from a in IWSEntities.Accounts
                                      where
                                        a.ParentId == null &&
                                        a.CompanyID == (string)HttpContext.Current.Session["CompanyID"]
                                      select new ChildViewModel()
                                      {
                                          ParentId = a.id,
                                          ParentName = a.name
                                      }).ToList();
            return r;
        }
        public static IEnumerable GetStock(string CompanyID)
        {
            List<StockViewModel> SV = (from s in IWSEntities.Stocks
                                       select new StockViewModel()
                                       {
                                           ItemName = (s.Article.id + "-" + s.Article.name),
                                           StoreName = (s.Store.id + "-" + s.Store.name),
                                           Quantity = Convert.ToInt32(s.quantity),
                                           ItemUnit = s.Article.packunit,
                                           AveragePrice = Convert.ToDecimal(s.Article.avgprice),
                                           Currency=s.Currency,
                                           CompanyID =s.CompanyID
                                       })
                                       .Where(c=>c.CompanyID==CompanyID)
                                       .ToList();
            return SV;
        }
        public static string GetPackUnit(string id)
        {
            return IWSEntities.Articles.FirstOrDefault(c => 
                c.id == id && c.CompanyID == (string)HttpContext.Current.Session["CompanyID"]).packunit;
        }
        public static string GetCompany(string UserName)
        {
            return IWSEntities.AspNetUsers.FirstOrDefault(c => 
                                c.UserName == UserName).Company;
        }
        public static string GetQttyUnit(string id)
        {
            return IWSEntities.Articles.FirstOrDefault(c => 
                c.id == id && c.CompanyID == (string)HttpContext.Current.Session["CompanyID"]).qttyunit;
        }
        public static decimal GetVatCode(string id)
        {
            return IWSEntities.Articles.FirstOrDefault(c =>
                   c.id == id && c.CompanyID == (string)HttpContext.Current.Session["CompanyID"]).Vat.PVat;
        }
        public static string GetCurrency(string id)
        {
            return IWSEntities.Articles.FirstOrDefault(c =>
                   c.id == id && c.CompanyID == (string)HttpContext.Current.Session["CompanyID"]).Currency;
        }
        public static decimal GetPrice(string id)
        {
            return IWSEntities.Articles.FirstOrDefault(c => 
                c.id == id && c.CompanyID == (string)HttpContext.Current.Session["CompanyID"]).price;
        }
        public static decimal GetSalesPrice(string id)
        {
            return IWSEntities.Articles.FirstOrDefault(c => 
                c.id == id && c.CompanyID == (string)HttpContext.Current.Session["CompanyID"]).salesprice;
        }
        public static string GetLineText(string id)
        {
            return IWSEntities.Articles.FirstOrDefault(c => 
                c.id == id && c.CompanyID == (string)HttpContext.Current.Session["CompanyID"]).description ?? "N/A";
        }
        public static string GetHeaderText(int id, string ItemType)
        {
            if (ItemType.Equals(DocsType.GoodReceiving.ToString()))
            {
                return IWSEntities.PurchaseOrders.FirstOrDefault(c =>
                c.id == id && c.CompanyId == (string)HttpContext.Current.Session["CompanyID"]).HeaderText ?? "N/A";
            }
            if (ItemType.Equals(DocsType.BillOfDelivery.ToString()))
            {
                return IWSEntities.SalesOrders.FirstOrDefault(c =>
                c.id == id && c.CompanyId == (string)HttpContext.Current.Session["CompanyID"]).HeaderText ?? "N/A";
            }
            if (ItemType.Equals(DocsType.InventoryInvoice.ToString()))
            {
                return IWSEntities.GoodReceivings.FirstOrDefault(c =>
                c.id == id && c.CompanyId == (string)HttpContext.Current.Session["CompanyID"]).HeaderText ?? "N/A";
            }
            if (ItemType.Equals(DocsType.SalesInvoice.ToString()))
            {
                return IWSEntities.BillOfDeliveries.FirstOrDefault(c =>
                c.id == id && c.CompanyId == (string)HttpContext.Current.Session["CompanyID"]).HeaderText ?? "N/A";
            }
            if (ItemType.Equals(DocsType.VendorInvoice.ToString()))
            {
                return IWSEntities.InventoryInvoices.FirstOrDefault(c =>
                c.id == id && c.CompanyId == (string)HttpContext.Current.Session["CompanyID"]).HeaderText ?? "N/A";
            }
            if (ItemType.Equals(DocsType.CustomerInvoice.ToString()))
            {
                return IWSEntities.SalesInvoices.FirstOrDefault(c =>
                c.id == id && c.CompanyId == (string)HttpContext.Current.Session["CompanyID"]).HeaderText ?? "N/A";
            }
            if (ItemType.Equals(DocsType.Settlement.ToString()))
            {
                return IWSEntities.CustomerInvoices.FirstOrDefault(c =>
                c.id == id && c.CompanyId == (string)HttpContext.Current.Session["CompanyID"]).HeaderText ?? "N/A";
            }
            if (ItemType.Equals(DocsType.Payment.ToString()))
            {
                return IWSEntities.VendorInvoices.FirstOrDefault(c =>
                c.id == id && c.CompanyId == (string)HttpContext.Current.Session["CompanyID"]).HeaderText ?? "N/A";
            }
            if (ItemType.Equals(DocsType.GeneralLedgerIn.ToString()))
            {
                return IWSEntities.Settlements.FirstOrDefault(c =>
                c.id == id && c.CompanyId == (string)HttpContext.Current.Session["CompanyID"]).HeaderText ?? "N/A";
            }
            if (ItemType.Equals(DocsType.GeneralLedgerOut.ToString()))
            {
                return IWSEntities.Payments.FirstOrDefault(c =>
                c.id == id && c.CompanyId == (string)HttpContext.Current.Session["CompanyID"]).HeaderText ?? "N/A";
            }
            return null;
        }
        public static string GetStore(int id, string ItemType)
        {
            if (ItemType.Equals(DocsType.GoodReceiving.ToString()))
            {
                return IWSEntities.PurchaseOrders.FirstOrDefault(c =>
                c.id == id && c.CompanyId == (string)HttpContext.Current.Session["CompanyID"]).store;
            }
            if (ItemType.Equals(DocsType.BillOfDelivery.ToString()))
            {
                return IWSEntities.SalesOrders.FirstOrDefault(c =>
                c.id == id && c.CompanyId == (string)HttpContext.Current.Session["CompanyID"]).store;
            }
            if (ItemType.Equals(DocsType.InventoryInvoice.ToString()))
            {
                return IWSEntities.GoodReceivings.FirstOrDefault(c =>
                c.id == id && c.CompanyId == (string)HttpContext.Current.Session["CompanyID"]).store;
            }
            if (ItemType.Equals(DocsType.SalesInvoice.ToString()))
            {
                return IWSEntities.BillOfDeliveries.FirstOrDefault(c =>
                c.id == id && c.CompanyId == (string)HttpContext.Current.Session["CompanyID"]).store;
            }
            if (ItemType.Equals(DocsType.VendorInvoice.ToString()))
            {
                return IWSEntities.InventoryInvoices.FirstOrDefault(c =>
                c.id == id && c.CompanyId == (string)HttpContext.Current.Session["CompanyID"]).store;
            }
            if (ItemType.Equals(DocsType.CustomerInvoice.ToString()))
            {
                return IWSEntities.SalesInvoices.FirstOrDefault(c =>
                c.id == id && c.CompanyId == (string)HttpContext.Current.Session["CompanyID"]).store;
            }
            return null;
           
        }
        public static string GetSupplier(int id, string ItemType)
        {
            if (ItemType.Equals(IWSLookUp.DocsType.GoodReceiving.ToString()))
            {
                return IWSEntities.PurchaseOrders.FirstOrDefault(c =>
                c.id == id && c.CompanyId == (string)HttpContext.Current.Session["CompanyID"]).account;
            }
            if (ItemType.Equals(IWSLookUp.DocsType.BillOfDelivery.ToString()))
            {
                return IWSEntities.SalesOrders.FirstOrDefault(c =>
                c.id == id && c.CompanyId == (string)HttpContext.Current.Session["CompanyID"]).account;
            }
            if (ItemType.Equals(IWSLookUp.DocsType.InventoryInvoice.ToString()))
            {
                return IWSEntities.GoodReceivings.FirstOrDefault(c =>
                c.id == id && c.CompanyId == (string)HttpContext.Current.Session["CompanyID"]).account;
            }
            if (ItemType.Equals(IWSLookUp.DocsType.SalesInvoice.ToString()))
            {
                return IWSEntities.BillOfDeliveries.FirstOrDefault(c =>
                c.id == id && c.CompanyId == (string)HttpContext.Current.Session["CompanyID"]).account;
            }
            if (ItemType.Equals(IWSLookUp.DocsType.VendorInvoice.ToString()))
            {
                return IWSEntities.InventoryInvoices.FirstOrDefault(c =>
                c.id == id && c.CompanyId == (string)HttpContext.Current.Session["CompanyID"]).account;
            }
            if (ItemType.Equals(IWSLookUp.DocsType.CustomerInvoice.ToString()))
            {
                return IWSEntities.SalesInvoices.FirstOrDefault(c =>
                c.id == id && c.CompanyId == (string)HttpContext.Current.Session["CompanyID"]).account;
            }
            if (ItemType.Equals(IWSLookUp.DocsType.Settlement.ToString()))
            {
                return IWSEntities.CustomerInvoices.FirstOrDefault(c =>
                c.id == id && c.CompanyId == (string)HttpContext.Current.Session["CompanyID"]).account;
            }
            if (ItemType.Equals(IWSLookUp.DocsType.Payment.ToString()))
            {
                return IWSEntities.VendorInvoices.FirstOrDefault(c =>
                c.id == id && c.CompanyId == (string)HttpContext.Current.Session["CompanyID"]).account;
            }
            if (ItemType.Equals(IWSLookUp.DocsType.GeneralLedgerIn.ToString()))
            {
                return IWSEntities.Settlements.FirstOrDefault(c =>
                c.id == id && c.CompanyId == (string)HttpContext.Current.Session["CompanyID"]).account;
            }
            return null;
        }
        public static string GetCostCenter(int id, string ItemType)
        {
            
            if (ItemType.Equals(IWSLookUp.DocsType.Settlement.ToString()))
            {
                return IWSEntities.CustomerInvoices.FirstOrDefault(c =>
                c.id == id && c.CompanyId == (string)HttpContext.Current.Session["CompanyID"]).CostCenter;
            }
            if (ItemType.Equals(IWSLookUp.DocsType.Payment.ToString()))
            {
                return IWSEntities.VendorInvoices.FirstOrDefault(c =>
                c.id == id && c.CompanyId == (string)HttpContext.Current.Session["CompanyID"]).CostCenter;
            }
            if (ItemType.Equals(IWSLookUp.DocsType.GeneralLedgerIn.ToString()))
            {
                return IWSEntities.Settlements.FirstOrDefault(c =>
                c.id == id && c.CompanyId == (string)HttpContext.Current.Session["CompanyID"]).CostCenter;
            }
            if (ItemType.Equals(IWSLookUp.DocsType.GeneralLedgerOut.ToString()))
            {
                return IWSEntities.Payments.FirstOrDefault(c =>
                c.id == id && c.CompanyId == (string)HttpContext.Current.Session["CompanyID"]).CostCenter;
            }
            return null;
        }
        public static IEnumerable GetGoodReceivingOID()
        {
            var query =
            from s in IWSEntities.Stores
            join p in IWSEntities.PurchaseOrders on new { id = s.id } equals new { id = p.store }
            join r in IWSEntities.Suppliers on new { account = p.account } equals new { account = r.id }
            where
              p.CompanyId == (string)HttpContext.Current.Session["CompanyID"]
            orderby
              p.id
            select new
            {
                ID = p.id,
                Supplier = r.name,
                Store = s.name,
                DueDate = p.ItemDate.ToShortDateString()
            };
            return query;
        }
        public static IEnumerable GetInventoryInvoiceOID()
        {
            var query =
            from s in IWSEntities.Stores
            join g in IWSEntities.GoodReceivings on new { id = s.id } equals new { id = g.store }
            join r in IWSEntities.Suppliers on new { account = g.account } equals new { account = r.id }
            where
              g.CompanyId == (string)HttpContext.Current.Session["CompanyID"]
            orderby
              g.id
            select new
            {
                ID = g.id,
                Supplier = r.name,
                Store = s.name,
                DueDate = g.ItemDate.ToShortDateString()
            };
            return query;
        }
        public static IEnumerable GetVendorInvoiceOID()
        {
            var query =
            from s in IWSEntities.Stores
            join p in IWSEntities.InventoryInvoices on new { id = s.id } equals new { id = p.store }
            join r in IWSEntities.Suppliers on new { account = p.account } equals new { account = r.id }
            where
              p.CompanyId == (string)HttpContext.Current.Session["CompanyID"]
            orderby
              p.id
            select new
            {
                ID = p.id,
                Supplier = r.name,
                Store = s.name,
                DueDate = p.ItemDate.ToShortDateString()
            };
            return query;
        }
        public static IEnumerable GetPaymentOID()
        {
            var query =
            from s in IWSEntities.CostCenters
            join p in IWSEntities.VendorInvoices on new { id = s.id } equals new { id = p.CostCenter }
            join r in IWSEntities.Suppliers on new { account = p.account } equals new { account = r.id }
            where
              p.CompanyId == (string)HttpContext.Current.Session["CompanyID"]
            orderby
              p.id
            select new
            {
                ID = p.id,
                Supplier = r.name,
                Store = s.name,
                DueDate = p.ItemDate.ToShortDateString()
            };
            return query;
        }
        public static IEnumerable GetBillOfDeliveryOID()
        {
            var query =
            from s in IWSEntities.Stores
            join p in IWSEntities.SalesOrders on new { id = s.id } equals new { id = p.store }
            join r in IWSEntities.Customers on new { account = p.account } equals new { account = r.id }
            where
              p.CompanyId == (string)HttpContext.Current.Session["CompanyID"]
            orderby
              p.id
            select new
            {
                ID = p.id,
                Customer = r.name,
                Store = s.name,
                DueDate = p.ItemDate.ToShortDateString()
            };
            return query;
        }
        public static IEnumerable GetSalesInvoiceOID()
        {
            var query =
            from s in IWSEntities.Stores
            join p in IWSEntities.BillOfDeliveries on new { id = s.id } equals new { id = p.store }
            join r in IWSEntities.Customers on new { account = p.account } equals new { account = r.id }
            where
              p.CompanyId == (string)HttpContext.Current.Session["CompanyID"]
            orderby
              p.id
            select new
            {
                ID = p.id,
                Customer = r.name,
                Store = s.name,
                DueDate = p.ItemDate.ToShortDateString()
            };
            return query;
        }
        public static IEnumerable GetCustomerInvoiceOID()
        {
            var query =
            from s in IWSEntities.Stores
            join p in IWSEntities.SalesInvoices on new { id = s.id } equals new { id = p.store }
            join r in IWSEntities.Customers on new { account = p.account } equals new { account = r.id }
            where
              p.CompanyId == (string)HttpContext.Current.Session["CompanyID"]
            orderby
              p.id
            select new
            {
                ID = p.id,
                Customer = r.name,
                Store = s.name,
                DueDate = p.ItemDate.ToShortDateString()
            };
            return query;
        }
        public static IEnumerable GetSettlementOID()
        {
            var query =
            from s in IWSEntities.CostCenters
            join p in IWSEntities.CustomerInvoices on new { id = s.id } equals new { id = p.CostCenter }
            join r in IWSEntities.Customers on new { account = p.account } equals new { account = r.id }
            where
              p.CompanyId == (string)HttpContext.Current.Session["CompanyID"]
            orderby
              p.id
            select new
            {
                ID = p.id,
                Customer = r.name,
                CostCenter = s.name,
                DueDate = p.ItemDate.ToShortDateString()
            };
            return query;
        }
        public static IEnumerable GetGeneralLedgerInOID()
        {
            var query =
            from s in IWSEntities.CostCenters
            join p in IWSEntities.Settlements on new { id = s.id } equals new { id = p.CostCenter }
            join r in IWSEntities.Customers on new { account = p.account } equals new { account = r.id }
            where
              p.CompanyId == (string)HttpContext.Current.Session["CompanyID"]
            orderby
              p.id
            select new
            {
                ID = p.id,
                Customer = r.name,
                CostCenter = s.name,
                DueDate = p.ItemDate.ToShortDateString()
            };
            return query;
        }
        public static IEnumerable GetGeneralLedgerOutOID()
        {
            var query =
            from s in IWSEntities.CostCenters
            join p in IWSEntities.Payments on new { id = s.id } equals new { id = p.CostCenter }
            join r in IWSEntities.Suppliers on new { account = p.account } equals new { account = r.id }
            where
              p.CompanyId == (string)HttpContext.Current.Session["CompanyID"]
            orderby
              p.id
            select new
            {
                ID = p.id,
                Customer = r.name,
                CostCenter = s.name,
                DueDate = p.ItemDate.ToShortDateString()
            };
            return query;
        }

        public enum DocsType
        {
            SalesInvoice,
            SalesOrder,
            BillOfDelivery,
            GoodReceiving,
            InventoryInvoice,
            Payment,
            PurchaseOrder,
            CustomerInvoice,
            Settlement,
            VendorInvoice,
            GeneralLedger,
            GeneralLedgerIn,
            GeneralLedgerOut,
            BankStatement
        }
        public enum Side
        {
            Credit,
            Debit
        }
        public enum Area
        {
            Purchasing,
            Sales
        }
        public enum Owner
        {
            Company,
            Customer,
            Supplier
        }
    }
}