using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;

namespace IWSProject.Models
{
    public class IndexViewModel
    {
        public bool HasPassword { get; set; }
        public IList<UserLoginInfo> Logins { get; set; }
        public string PhoneNumber { get; set; }
        public bool TwoFactor { get; set; }
        public bool BrowserRemembered { get; set; }
    }

    public class ManageLoginsViewModel
    {
        public IList<UserLoginInfo> CurrentLogins { get; set; }
        public IList<AuthenticationDescription> OtherLogins { get; set; }
    }

    public class FactorViewModel
    {
        public string Purpose { get; set; }
    }

    public class SetPasswordViewModel
    {
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "New password")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm new password")]
        [Compare("NewPassword", ErrorMessage = "The new password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }

    public class AddPhoneNumberViewModel
    {
        [Required]
        [Phone]
        [Display(Name = "Phone")]
        public string PhoneNumber { get; set; }
    }

    public class VerifyPhoneNumberViewModel
    {
        [Required]
        [Display(Name = "Code")]
        public string Code { get; set; }

        [Required]
        [Phone]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
    }

    public class ConfigureTwoFactorViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }
    }

    public class ValidateDocsViewModel
    {
        [Key]
        [Column(Order = 1)]
        public int ItemID { get; set; }
        [Key]
        [Column(Order = 2)]
        public string ItemType { get; set; }
        public DateTime DueDate { get; set; }
        public string Periode { get; set; }
        public string SupplierID { get; set; }
        public string CompanyID { get; set; }
        public string VAT { get; set; }
        public decimal TotalVAT { get; set; }
        public decimal TotalHVAT { get; set; }
        public bool IsValidated { get; set; }
    }
    public class DocumentsViewModel
    {
        [Key]
        [Column(Order = 1)]
        public int ItemID { get; set; }
        [Key]
        [Column(Order = 2)]
        public string ItemType { get; set; }
        public DateTime DueDate { get; set; }
        public string SupplierID { get; set; }
        public string CompanyID { get; set; }
        public decimal TotalVAT { get; set; }
        public decimal TotalHVAT { get; set; }
        public bool IsValidated { get; set; }
    }
    public class ValidateStockViewModel
    {
        [Key]
        [Column(Order =1)]
        public string StoreID { get; set; }
        [Key]
        [Column(Order =2)]
        public string ItemID { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public bool IsService { get; set; }
    }
    public class AccountBalanceViewModel
    {
        [Key]
        public string AccountID { get; set; }
        public string Periode { get; set; }
        public decimal Debit { get; set; }
        public decimal Credit { get; set; }
    }
    public class StockViewModel
    {
        [Key]
        public string ItemName { get; set; }
        public string StoreName { get; set; }
        public int Quantity { get; set; }
        public string ItemUnit { get; set; }
        public decimal AveragePrice { get; set; }
    }
}