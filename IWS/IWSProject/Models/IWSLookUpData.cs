namespace IWSProject.Models
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Threading;
    using System.Web;
    using DevExpress.Web;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
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
        public static IEnumerable GetAccounts()
        {
            var account = IWSEntities.Accounts.AsEnumerable().Select(item => new
            {
                Id = item.id,
                Name = item.name,
                CompanyID=item.CompanyID
            })
            .Where(c => c.CompanyID == (string)HttpContext.Current.Session["CompanyID"])
            .OrderBy(o => o.Id);

 //           Where(c => c.CompanyID == (string)HttpContext.Current.Session["CompanyID"]).
 //           OrderBy(o => o.Name);
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
        public static Article GetArticle(string id)
        {
            var article = IWSEntities.Articles.AsEnumerable<Article>().Select(item => new
            {
                Id = item.id,
                Name = item.name,
                Price = item.price,
                Unit = item.qttyunit,
                Pack = item.packunit,
                Vat = item.VatCode,
                CompanyID=item.CompanyID
            }).
            Where(o => o.Id == id && o.CompanyID==(string)HttpContext.Current.Session["CompanyID"]);
            return (Article)article;
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
                 xMonth = (Convert.ToString((int?)line.BillOfDelivery.ItemDate.Month)).Length == 1 ?
                                                     '0' + Convert.ToString((int?)line.BillOfDelivery.ItemDate.Month) :
                                                     Convert.ToString((int?)line.BillOfDelivery.ItemDate.Month),
                 xYear = Convert.ToString((int?)line.BillOfDelivery.ItemDate.Year),
                 line.BillOfDelivery.account,
                 line.BillOfDelivery.CompanyId,
                 line.VatCode
             } into g
             orderby
                g.Key.id
             select new ValidateDocsViewModel()
             {
                 ItemID = g.Key.id,
                 ItemType = g.Key.ItemType,
                 DueDate = Convert.ToDateTime(g.Key.ItemDate),
                 Periode = g.Key.xYear + g.Key.xMonth,
                 Area = false,
                 SupplierID = g.Key.account,
                 CompanyID = g.Key.CompanyId,
                 VAT = g.Key.VatCode,
                 TotalVAT = Convert.ToDecimal(Enumerable.Sum(g, p => p.line.price * p.line.quantity * p.line.Article.Vat.PVat)),
                 TotalHVAT = Convert.ToDecimal(Enumerable.Sum(g, p => p.line.price * p.line.quantity))
             }), o => o.ItemID).ToList();
            return BL;
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
                    xMonth = (Convert.ToString((int?)line.VendorInvoice.ItemDate.Month)).Length == 1 ?
                                                     '0' + Convert.ToString((int?)line.VendorInvoice.ItemDate.Month) :
                                                     Convert.ToString((int?)line.VendorInvoice.ItemDate.Month),
                    xYear = Convert.ToString((int?)line.VendorInvoice.ItemDate.Year),
                    line.VendorInvoice.account,
                    line.VendorInvoice.CompanyId
                } into g
                orderby
                        g.Key.id
                select new ValidateDocsViewModel()
                {
                    ItemID = g.Key.id,
                    ItemType = g.Key.ItemType,
                    DueDate = Convert.ToDateTime(g.Key.ItemDate),
                    Periode = g.Key.xYear + g.Key.xMonth,
                    Area = true,
                    SupplierID = g.Key.account,
                    CompanyID = g.Key.CompanyId,
                    VAT="0",
                    TotalVAT = 0,
                    TotalHVAT = Convert.ToDecimal(Enumerable.Sum(g, p => (double)p.line.amount))
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
                 xMonth = (Convert.ToString((int?)line.PurchaseOrder.ItemDate.Month)).Length == 1 ?
                                                     '0' + Convert.ToString((int?)line.PurchaseOrder.ItemDate.Month) :
                                                     Convert.ToString((int?)line.PurchaseOrder.ItemDate.Month),
                 xYear = Convert.ToString((int?)line.PurchaseOrder.ItemDate.Year),
                 line.PurchaseOrder.account,
                 line.PurchaseOrder.CompanyId,
                 line.VatCode
             } into g
             orderby
                 g.Key.id
             select new ValidateDocsViewModel()
             {
                 ItemID = g.Key.id,
                 ItemType = g.Key.ItemType,
                 DueDate = Convert.ToDateTime(g.Key.ItemDate),
                 Periode = g.Key.xYear + g.Key.xMonth,
                 Area = false,
                 SupplierID = g.Key.account,
                 CompanyID = g.Key.CompanyId,
                 VAT=g.Key.VatCode,
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
                 xMonth = (Convert.ToString((int?)line.Payment.ItemDate.Month)).Length == 1 ?
                                                     '0' + Convert.ToString((int?)line.Payment.ItemDate.Month) :
                                                     Convert.ToString((int?)line.Payment.ItemDate.Month),
                 xYear = Convert.ToString((int?)line.Payment.ItemDate.Year),
                 line.Payment.account,
                 line.Payment.CompanyId,
             } into g
             orderby
                 g.Key.id
             select new ValidateDocsViewModel()
             {
                 ItemID = g.Key.id,
                 ItemType = g.Key.ItemType,
                 DueDate = Convert.ToDateTime(g.Key.ItemDate),
                 Periode = g.Key.xYear + g.Key.xMonth,
                 Area = false,
                 SupplierID = g.Key.account,
                 CompanyID = g.Key.CompanyId,
                 VAT="0",
                 TotalVAT = 0,
                 TotalHVAT = Convert.ToDecimal(Enumerable.Sum(g, p => (double)p.line.amount))
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
                     xMonth = (Convert.ToString((int?)line.InventoryInvoice.ItemDate.Month)).Length == 1 ?
                                                         '0' + Convert.ToString((int?)line.InventoryInvoice.ItemDate.Month) :
                                                         Convert.ToString((int?)line.InventoryInvoice.ItemDate.Month),
                     xYear = Convert.ToString((int?)line.InventoryInvoice.ItemDate.Year),
                     line.InventoryInvoice.account,
                     line.InventoryInvoice.CompanyId,
                     line.VATCode
                 } into g
                 orderby
                    g.Key.id
                 select new ValidateDocsViewModel()
                 {
                     ItemID = g.Key.id,
                     ItemType = g.Key.ItemType,
                     DueDate = Convert.ToDateTime(g.Key.ItemDate),
                     Periode = g.Key.xYear + g.Key.xMonth,
                     Area = true,
                     SupplierID = g.Key.account,
                     CompanyID = g.Key.CompanyId,
                     VAT = g.Key.VATCode,
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
                 xMonth = (Convert.ToString((int?)line.GoodReceiving.ItemDate.Month)).Length == 1 ?
                                                     '0' + Convert.ToString((int?)line.GoodReceiving.ItemDate.Month) :
                                                     Convert.ToString((int?)line.GoodReceiving.ItemDate.Month),
                 xYear = Convert.ToString((int?)line.GoodReceiving.ItemDate.Year),
                 line.GoodReceiving.account,
                 line.GoodReceiving.CompanyId,
                 line.VatCode
             } into g
             orderby
                g.Key.id
             select new ValidateDocsViewModel()
             {
                 ItemID = g.Key.id,
                 ItemType = g.Key.ItemType,
                 DueDate = Convert.ToDateTime(g.Key.ItemDate),
                 Periode= g.Key.xYear + g.Key.xMonth,
                 Area = true,
                 SupplierID = g.Key.account,
                 CompanyID = g.Key.CompanyId,
                 VAT=g.Key.VatCode,
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
                 xMonth = (Convert.ToString((int?)line.SalesOrder.ItemDate.Month)).Length == 1 ?
                                                     '0' + Convert.ToString((int?)line.SalesOrder.ItemDate.Month) :
                                                     Convert.ToString((int?)line.SalesOrder.ItemDate.Month),
                 xYear = Convert.ToString((int?)line.SalesOrder.ItemDate.Year),
                 line.SalesOrder.account,
                 line.SalesOrder.CompanyId,
                 line.VatCode
             } into g
             orderby
                 g.Key.id
             select new ValidateDocsViewModel()
             {
                 ItemID = g.Key.id,
                 ItemType = g.Key.ItemType,
                 DueDate = Convert.ToDateTime(g.Key.ItemDate),
                 Periode = g.Key.xYear + g.Key.xMonth,
                 Area = false,
                 SupplierID = g.Key.account,
                 CompanyID = g.Key.CompanyId,
                 VAT = g.Key.VatCode,
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
                     xMonth = (Convert.ToString((int?)line.SalesInvoice.ItemDate.Month)).Length == 1 ?
                                                         '0' + Convert.ToString((int?)line.SalesInvoice.ItemDate.Month) :
                                                         Convert.ToString((int?)line.SalesInvoice.ItemDate.Month),
                     xYear = Convert.ToString((int?)line.SalesInvoice.ItemDate.Year),
                     line.SalesInvoice.account,
                     line.SalesInvoice.CompanyId,
                     line.VATCode
                 } into g
                 orderby
                    g.Key.id
                 select new ValidateDocsViewModel()
                 {
                     ItemID = g.Key.id,
                     ItemType = g.Key.ItemType,
                     DueDate = Convert.ToDateTime(g.Key.ItemDate),
                     Periode = g.Key.xYear + g.Key.xMonth,
                     Area = false,
                     SupplierID = g.Key.account,
                     CompanyID = g.Key.CompanyId,
                     VAT = g.Key.VATCode,
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
                 xMonth = (Convert.ToString((int?)line.CustomerInvoice.ItemDate.Month)).Length == 1 ?
                                                  '0' + Convert.ToString((int?)line.CustomerInvoice.ItemDate.Month) :
                                                  Convert.ToString((int?)line.CustomerInvoice.ItemDate.Month),
                 xYear = Convert.ToString((int?)line.CustomerInvoice.ItemDate.Year),
                 line.CustomerInvoice.account,
                 line.CustomerInvoice.CompanyId
             } into g
             orderby
                     g.Key.id
             select new ValidateDocsViewModel()
             {
                 ItemID = g.Key.id,
                 ItemType = g.Key.ItemType,
                 DueDate = Convert.ToDateTime(g.Key.ItemDate),
                 Periode = g.Key.xYear + g.Key.xMonth,
                 Area = false,
                 SupplierID = g.Key.account,
                 CompanyID = g.Key.CompanyId,
                 VAT = "0",
                 TotalVAT = 0,
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
                 xMonth = (Convert.ToString((int?)line.Settlement.ItemDate.Month)).Length == 1 ?
                                                      '0' + Convert.ToString((int?)line.Settlement.ItemDate.Month) :
                                                      Convert.ToString((int?)line.Settlement.ItemDate.Month),
                 xYear = Convert.ToString((int?)line.Settlement.ItemDate.Year),
                 line.Settlement.account,
                 line.Settlement.CompanyId,
             } into g
             orderby
                  g.Key.id
             select new ValidateDocsViewModel()
             {
                 ItemID = g.Key.id,
                 ItemType = g.Key.ItemType,
                 DueDate = Convert.ToDateTime(g.Key.ItemDate),
                 Periode = g.Key.xYear + g.Key.xMonth,
                 Area = false,
                 SupplierID = g.Key.account,
                 CompanyID = g.Key.CompanyId,
                 VAT = "0",
                 TotalVAT = 0,
                 TotalHVAT = Convert.ToDecimal(Enumerable.Sum(g, p => (double)p.line.amount))
             }), o => o.ItemID).ToList();
            return BL;
        }
        public static List<ValidateDocsViewModel> GetGeneralLedgerIn(string uiCulture, bool IsValidated)
        {
            List<ValidateDocsViewModel> BL = Queryable.OrderBy(
            (from line in IWSEntities.LineGeneralLedgers
             where line.GeneralLedger.IsValidated == IsValidated && line.GeneralLedger.Area == Area.Selling.ToString()
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
                 xMonth = (Convert.ToString((int?)line.GeneralLedger.ItemDate.Month)).Length == 1 ?
                                                      '0' + Convert.ToString((int?)line.GeneralLedger.ItemDate.Month) :
                                                      Convert.ToString((int?)line.GeneralLedger.ItemDate.Month),
                 xYear = Convert.ToString((int?)line.GeneralLedger.ItemDate.Year),
                 line.GeneralLedger.CompanyId,
             } into g
             orderby
                  g.Key.id
             select new ValidateDocsViewModel()
             {
                 ItemID = g.Key.id,
                 ItemType = g.Key.ItemType,
                 DueDate = Convert.ToDateTime(g.Key.ItemDate),
                 Periode = g.Key.xYear + g.Key.xMonth,
                 Area = false,
                 SupplierID = Area.Selling.ToString(),
                 CompanyID = g.Key.CompanyId,
                 VAT = "0",
                 TotalVAT = 0,
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
                 xMonth = (Convert.ToString((int?)line.GeneralLedger.ItemDate.Month)).Length == 1 ?
                                                      '0' + Convert.ToString((int?)line.GeneralLedger.ItemDate.Month) :
                                                      Convert.ToString((int?)line.GeneralLedger.ItemDate.Month),
                 xYear = Convert.ToString((int?)line.GeneralLedger.ItemDate.Year),
                 line.GeneralLedger.CompanyId,
             } into g
             orderby
                  g.Key.id
             select new ValidateDocsViewModel()
             {
                 ItemID = g.Key.id,
                 ItemType = g.Key.ItemType,
                 DueDate = Convert.ToDateTime(g.Key.ItemDate),
                 Periode = g.Key.xYear + g.Key.xMonth,
                 Area = false,
                 SupplierID = Area.Purchasing.ToString(),
                 CompanyID = g.Key.CompanyId,
                 VAT = "0",
                 TotalVAT = 0,
                 TotalHVAT = Convert.ToDecimal(Enumerable.Sum(g, p => (double)p.line.amount))
             }), o => o.ItemID).ToList();
            return BL;
        }
        public static List<DocumentsViewModel> GetAccountingDocument(bool IsValidated) 
        {
            // get current thread UICulture
            string uiCulture = Thread.CurrentThread.CurrentUICulture.Name;

            List<ValidateDocsViewModel> document = GetVendorInvoice(uiCulture, IsValidated).
                                            Union(GetPurchaseOrder(uiCulture, IsValidated)).
                                            Union(GetPayment(uiCulture, IsValidated)).
                                            Union(GetInventoryInvoice(uiCulture, IsValidated)).
                                            Union(GetGoodReceiving(uiCulture, IsValidated)).
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
                                                doc.SupplierID, doc.CompanyID
                                            } into g
                                            orderby
                                            g.Key.ItemType, g.Key.ItemID
                                            select new DocumentsViewModel()
                                            {
                                                ItemID=g.Key.ItemID, ItemType=g.Key.ItemType, DueDate=g.Key.DueDate,
                                                SupplierID =g.Key.SupplierID, CompanyID=g.Key.CompanyID,
                                                TotalVAT =g.Sum(s=>s.TotalVAT),
                                                TotalHVAT=g.Sum(s=>s.TotalHVAT)
                                            }).ToList();
            return documents;
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
                                                    CompanyID=p.CompanyID
                                                })
                                                .Where(c=>c.CompanyID== CompanyID)
                                                .OrderBy(o=>o.pk).ToList();
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
                CompanyID=j.CompanyID
            })
            .Where(c=>c.CompanyID==CompanyID)
            .ToList();
            return journals;
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
                                           CompanyID=s.CompanyID
                                       })
                                       .Where(c=>c.CompanyID==CompanyID)
                                       .ToList();
            return SV;
        }
        public static string GetPackUnit(string id)
        {
            return IWSEntities.Articles.FirstOrDefault(c => c.id == id && c.CompanyID == (string)HttpContext.Current.Session["CompanyID"]).packunit;
        }
        public static string GetCompany(string UserName)
        {
            return IWSEntities.AspNetUsers.FirstOrDefault(c => c.UserName == UserName).Company;
        }
        public static string GetQttyUnit(string id)
        {
            return IWSEntities.Articles.FirstOrDefault(c => c.id == id && c.CompanyID == (string)HttpContext.Current.Session["CompanyID"]).qttyunit;
        }
        public static string GetVatCode(string id)
        {
            return IWSEntities.Articles.FirstOrDefault(c => c.id == id && c.CompanyID == (string)HttpContext.Current.Session["CompanyID"]).VatCode;
        }
        public static decimal GetPrice(string id)
        {
            return IWSEntities.Articles.FirstOrDefault(c => c.id == id && c.CompanyID == (string)HttpContext.Current.Session["CompanyID"]).price;
        }
        public static decimal GetSalesPrice(string id)
        {
            return IWSEntities.Articles.FirstOrDefault(c => c.id == id && c.CompanyID == (string)HttpContext.Current.Session["CompanyID"]).salesprice;
        }
        public static string GetText(string id)
        {
            return IWSEntities.Articles.FirstOrDefault(c => c.id == id && c.CompanyID == (string)HttpContext.Current.Session["CompanyID"]).description;
        }
        public static string GetPeriodMax()
        {
            var periode = IWSEntities.PeriodicAccountBalances
                .Where(c => c.CompanyID == (string)HttpContext.Current.Session["CompanyID"])
                .FirstOrDefault();
            if (periode == null)
                return "N/A";
            return IWSEntities.PeriodicAccountBalances
                .Where(c => c.CompanyID == (string)HttpContext.Current.Session["CompanyID"])
                .Max(p => p.Periode)
                .ToString();
        }
        public static string GetPeriodMin()
        {
            var periode = IWSEntities.PeriodicAccountBalances
                .Where(c => c.CompanyID == (string)HttpContext.Current.Session["CompanyID"])
                .FirstOrDefault();
            if (periode == null)
                return "N/A";
            return IWSEntities.PeriodicAccountBalances
                .Where(c => c.CompanyID == (string)HttpContext.Current.Session["CompanyID"])
                .Min(p => p.Periode)
                .ToString();
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
            GeneralLedger
        }
        public enum Side
        {
            Credit,
            Debit
        }
        public enum Area
        {
            Purchasing,
            Selling
        }

        public static UploadControlValidationSettings Settings = new UploadControlValidationSettings()
        {
            AllowedFileExtensions = new string[] { ".jpg", ".jpeg", ".png", ".bmp", ".tiff", ".eps", ".ps" },
            MaxFileSize = 4194304
        };
    }
}