namespace IWSProject.Models
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
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
        public static IEnumerable GetArticle()
        {
            var article = IWSEntities.Articles.AsEnumerable().Select(item => new
            {
                Id = item.id,
                Name = item.name,
                Price = item.price,
                Unit = item.qttyunit,
                Pack = item.packunit,
                Vat = item.VatCode
            }).OrderBy(o => o.Name);
            return article;
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
                                            UserName = user.UserName
                                       }).ToList();
            return User;
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
        public static Article GetArticle(string id)
        {
            var article = IWSEntities.Articles.AsEnumerable<Article>().Select(item => new
            {
                Id = item.id,
                Name = item.name,
                Price = item.price,
                Unit = item.qttyunit,
                Pack = item.packunit,
                Vat = item.VatCode
            }).Where(o => o.Id == id);
            return (Article)article;
        }
        public static IEnumerable GetStore()
        {
            var store = IWSEntities.Stores.AsEnumerable().Select(item => new
            {
                Id = item.id,
                Name = item.name
            }).OrderBy(o => o.Name);
            return store;
        }
        public static List<Menu> GetMenu()
        {
            var menu = IWSEntities.Menus.ToList();
            return menu;
        }
        public static IEnumerable GetSuppliers()
        {
            var supplier = IWSEntities.Suppliers.AsEnumerable().Select(item => new
            {
                Id = item.id,
                Name = item.name
            }).OrderBy(o => o.Id);
            return supplier;
        }
        public static IEnumerable GetCompanies()///IWSEntities.Companies.Select(c => c.name).Distinct().ToList();
        {
            var company = IWSEntities.Companies.AsEnumerable().Select(item => new
            {
                Name = item.name
            }).OrderBy(o => o.Name).ToList();
            return company;
        }
        public static IEnumerable GetAccounts()
        {
            var account = IWSEntities.Accounts.AsEnumerable().Select(item => new
            {
                Id = item.id,
                Name = item.name
            }).OrderBy(o => o.Id);
            return account;
        }
        public static IEnumerable GetBL(bool IsValidated) 
        {
            List<ValidateBLViewModel> BL = (from LineGoodReceiving in IWSEntities.LineGoodReceivings
                                           where
                                             LineGoodReceiving.GoodReceiving.IsValidated == false
                                           group new { LineGoodReceiving.GoodReceiving, LineGoodReceiving, LineGoodReceiving.Article.Vat } by new
                                           {
                                               LineGoodReceiving.GoodReceiving.id,
                                               ItemDate = (DateTime?)LineGoodReceiving.GoodReceiving.ItemDate,
                                               LineGoodReceiving.GoodReceiving.account
                                           } into g
                                           orderby
                                             g.Key.id
                                           select new ValidateBLViewModel()
                                           {
                                               ItemID = g.Key.id,
                                               DueDate = Convert.ToDateTime(g.Key.ItemDate),
                                               CompanyID = "1000",
                                               SupplierID = g.Key.account,
                                               TotalItem = Convert.ToDecimal(g.Sum(p => (double)p.LineGoodReceiving.price * (double)p.LineGoodReceiving.quantity * (1 + p.LineGoodReceiving.Article.Vat.PVat)))
                                           }).OrderBy(o => o.ItemID).ToList(); 

            return BL;
        }
        public static IEnumerable GetAccountBalance()
        {
            List<AccountBalanceViewModel> AB = (from PeriodicAccountBalance in IWSEntities.PeriodicAccountBalances
                                                select new AccountBalanceViewModel()
                                                {
                                                    AccountID = (PeriodicAccountBalance.Account.id + "-" + 
                                                                        PeriodicAccountBalance.Account.name),
                                                    Periode = PeriodicAccountBalance.Periode,
                                                    Debit = PeriodicAccountBalance.Debit,
                                                    Credit = PeriodicAccountBalance.Credit
                                                }).ToList();
            return AB;
        }
        public static IEnumerable GetStock()
        {
            List<StockViewModel> SV = (from Stock in IWSEntities.Stocks
                                       select new StockViewModel()
                                       {
                                           ItemName = (Stock.Article.id + "-" + Stock.Article.name),
                                           StoreName = (Stock.Store.id + "-" + Stock.Store.name),
                                           Quantity = Convert.ToInt32(Stock.quantity),
                                           ItemUnit = Stock.Article.packunit,
                                           AveragePrice = Convert.ToDecimal(Stock.Article.avgprice)
                                       }).ToList();
            return SV;
        }
        public static string GetPackUnit(string id)
        {
            return IWSEntities.Articles.FirstOrDefault(c => c.id == id).packunit;
        }
        public static string GetQttyUnit(string id)
        {
            return IWSEntities.Articles.FirstOrDefault(c => c.id == id).qttyunit;
        }
        public static string GetVatCode(string id)
        {
            return IWSEntities.Articles.FirstOrDefault(c => c.id == id).VatCode;
        }
        public static decimal GetPrice(string id)
        {
            return IWSEntities.Articles.FirstOrDefault(c => c.id == id).price ?? 0;
        }
        public static string GetText(string id)
        {
            return IWSEntities.Articles.FirstOrDefault(c => c.id == id).description;
        }
        public static IEnumerable GetVAT()
        {
            var vat = IWSEntities.Vats.AsEnumerable().Select(item => new
            {
                Id = item.id,
                Name = item.PVat
            }).OrderBy(o => o.Name);
            return vat;
        }
    }
}

