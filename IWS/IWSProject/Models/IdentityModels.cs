using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace IWSProject.Models
{
    public enum Gender { Male, Female}
    // You can add User data for the user by adding more properties to your User class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        [Display(Name = "Birth Date")]
        public DateTime? BirthDate { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Company")]
        public string Company { get; set; }
        [Display(Name = "Gender")]
        public Gender Gender { get; set; }
        public ClaimsIdentity GenerateUserIdentity(ApplicationUserManager manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = manager.CreateIdentity(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }

        public Task<ClaimsIdentity> GenerateUserIdentityAsync(ApplicationUserManager manager)
        {
            return Task.FromResult(GenerateUserIdentity(manager));
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("ApplicationServices", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }

    //public class IdentityManager
    //{
    //    public bool RoleExists(string name)
    //    {
    //        var rm = new RoleManager<IdentityRole>(
    //            new RoleStore<IdentityRole>(new ApplicationDbContext()));

    //        return rm.RoleExists(name);
    //    }


    //    public bool CreateRole(string name)
    //    {
    //        var rm = new RoleManager<IdentityRole>(
    //            new RoleStore<IdentityRole>(new ApplicationDbContext()));
    //        var idResult = rm.Create(new IdentityRole(name));
    //        return idResult.Succeeded;
    //    }


    //    public bool CreateUser(ApplicationUser user, string password)
    //    {
    //        var um = new UserManager<ApplicationUser>(
    //            new UserStore<ApplicationUser>(new ApplicationDbContext()));
    //        var idResult = um.Create(user, password);
    //        return idResult.Succeeded;
    //    }


    //    public bool AddUserToRole(string userId, string roleName)
    //    {
    //        var um = new UserManager<ApplicationUser>(
    //            new UserStore<ApplicationUser>(new ApplicationDbContext()));
    //        var idResult = um.AddToRole(userId, roleName);
    //        return idResult.Succeeded;
    //    }


    //    public void ClearUserRoles(string userId)
    //    {
    //        var um = new UserManager<ApplicationUser>(
    //            new UserStore<ApplicationUser>(new ApplicationDbContext()));
    //        var user = um.FindById(userId);
    //        var currentRoles = new List<IdentityUserRole>();
    //        currentRoles.AddRange(user.Roles);
    //        foreach (var role in currentRoles)
    //        {
    //            um.RemoveFromRole(userId, role.RoleId);//.Name);
    //        }
    //    }
    //}
}

#region Helpers
namespace IWSProject
{
    public static class IdentityHelper
    {
        // Used for XSRF when linking external logins
        public const string XsrfKey = "XsrfId";

        public const string ProviderNameKey = "providerName";
        public static string GetProviderNameFromRequest(HttpRequest request)
        {
            return request.QueryString[ProviderNameKey];
        }

        public const string CodeKey = "code";
        public static string GetCodeFromRequest(HttpRequest request)
        {
            return request.QueryString[CodeKey];
        }

        public const string UserIdKey = "userId";
        public static string GetUserIdFromRequest(HttpRequest request)
        {
            return HttpUtility.UrlDecode(request.QueryString[UserIdKey]);
        }

        public static string GetResetPasswordRedirectUrl(string code, HttpRequest request)
        {
            var absoluteUri = "/Account/ResetPassword?" + CodeKey + "=" + HttpUtility.UrlEncode(code);
            return new Uri(request.Url, absoluteUri).AbsoluteUri.ToString();
        }

        public static string GetUserConfirmationRedirectUrl(string code, string userId, HttpRequest request)
        {
            var absoluteUri = "/Account/Confirm?" + CodeKey + "=" + HttpUtility.UrlEncode(code) + "&" + UserIdKey + "=" + HttpUtility.UrlEncode(userId);
            return new Uri(request.Url, absoluteUri).AbsoluteUri.ToString();
        }

        private static bool IsLocalUrl(string url)
        {
            return !string.IsNullOrEmpty(url) && ((url[0] == '/' && (url.Length == 1 || (url[1] != '/' && url[1] != '\\'))) || (url.Length > 1 && url[0] == '~' && url[1] == '/'));
        }

        public static void RedirectToReturnUrl(string returnUrl, HttpResponse response)
        {
            if (!String.IsNullOrEmpty(returnUrl) && IsLocalUrl(returnUrl))
            {
                response.Redirect(returnUrl);
            }
            else
            {
                response.Redirect("~/");
            }
        }
    }
}
#endregion