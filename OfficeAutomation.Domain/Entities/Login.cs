using System;
using Domain.Entities;
using OfficeAutomation.Domain.DomainServices;
using OfficeAutomation.Domain.ValueObjects;


namespace OfficeAutomation.Domain.Entities
{
    public class Login:BaseEntity
    {
        private string _userName;
        private string _password;
        private string _password2;
        private string _confirmPassword;

        public Login(int idPersonal, string userName, string password, string confirmPassword, bool isActive, PasswordConfirmationService passwordConfirmationService)
        {
            if (idPersonal <= 0)
                throw new ArgumentException("IdPersonal must be positive.");
            if (passwordConfirmationService == null)
                throw new ArgumentNullException(nameof(passwordConfirmationService));

            IdPersonal = idPersonal;
            SetUserName(userName);
            SetPassword(password);
            passwordConfirmationService.ValidatePasswordConfirmation(password, confirmPassword); // استفاده از سرویس
            SetConfirmPassword(confirmPassword);
            IsActive = isActive;
        }

        public int IdLogin { get; private set; }
        public int IdPersonal { get; private set; }

        public virtual Personal Personal { get; private set; }
        public string OldPassword { get; set; }
        public string UserName => _userName;
        public string Password => _password;
        public string Password2 => _password2;
        public string ConfirmPassword => _confirmPassword;
        public bool IsActive { get; private set; }

     

        public void SetUserName(string userName)
        {
            if (string.IsNullOrWhiteSpace(userName))
                throw new ArgumentException("نام کاربری الزامی است.");
            if (userName.Length > 20)
                throw new ArgumentException("نام کاربری نمی‌تواند بیش از 20 کاراکتر باشد.");

            _userName = userName;
        }

        public void SetPassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
                throw new ArgumentException("رمز عبور الزامی است.");
            if (password.Length > 50)
                throw new ArgumentException("رمز عبور نمی‌تواند بیش از 50 کاراکتر باشد.");

            _password = password;
        }

        public void SetPassword2(string password2)
        {
            if (password2 != null && password2.Length > 50)
                throw new ArgumentException("رمز عبور دوم نمی‌تواند بیش از 50 کاراکتر باشد.");

            _password2 = password2;
        }

        public void SetConfirmPassword(string confirmPassword)
        {
            if (confirmPassword.Length > 50)
                throw new ArgumentException("تکرار رمز عبور نمی‌تواند بیش از 50 کاراکتر باشد.");

            _confirmPassword = confirmPassword;
        }

        public void UpdatePersonal(Personal personal)
        {
            if (personal == null)
                throw new ArgumentNullException(nameof(personal));
            Personal = personal;
        }
    }
}