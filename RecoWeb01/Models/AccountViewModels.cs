﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RecoWeb01.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "전자 메일")]
        public string Email { get; set; }
    }

    public class ExternalLoginListViewModel
    {
        public string ReturnUrl { get; set; }
    }

    public class SendCodeViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }
        public string ReturnUrl { get; set; }
        public bool RememberMe { get; set; }
    }

    public class VerifyCodeViewModel
    {
        [Required]
        public string Provider { get; set; }

        [Required]
        [Display(Name = "코드")]
        public string Code { get; set; }
        public string ReturnUrl { get; set; }

        [Display(Name = "이 브라우저 기억")]
        public bool RememberBrowser { get; set; }

        public bool RememberMe { get; set; }
    }

    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "전자 메일")]
        public string Email { get; set; }
    }

    public class LoginViewModel_Back
    {
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "사번")]
        public string EmployeeNumber { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "암호")]
        public string Password { get; set; }

        [Display(Name = "Remember me")]
        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel
    {
        [Required]
        [StringLength(100, ErrorMessage = "사번은 {2}자 이상이어야 합니다.", MinimumLength = 6)]
        [DataType(DataType.Text)]
        [Display(Name = "사번")]
        public string EmployeeId { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "{0}은(는) {2}자 이상이어야 합니다.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "암호")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "암호 확인")]
        [Compare("Password", ErrorMessage = "암호와 확인 암호가 일치하지 않습니다.")]
        public string ConfirmPassword { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "성명")]
        public string EmployeeName { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [Required]
        [Phone]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "휴대전화")]
        public string PhoneNumber { get; set; }

    }
    public class FindPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "사번은 {2}자 이상이어야 합니다.", MinimumLength = 6)]
        [DataType(DataType.Text)]
        [Display(Name = "사번")]
        public string EmployeeId { get; set; }

    }

    public class ResetPasswordViewModel
    {
        [Required]
        [StringLength(100, ErrorMessage = "{0}은(는) {2}자 이상이어야 합니다.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "암호")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "암호 확인")]
        [Compare("Password", ErrorMessage = "암호와 확인 암호가 일치하지 않습니다.")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }


    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "전자 메일")]
        public string Email { get; set; }
    }
}
