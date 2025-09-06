using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeAutomation.Domain.DomainServices
{
    public class PasswordConfirmationService
    {
        public void ValidatePasswordConfirmation(string password, string confirmPassword)
        {
            if (string.IsNullOrWhiteSpace(confirmPassword))
                throw new ArgumentException("تکرار رمز عبور الزامی است.");
            if (confirmPassword != password)
                throw new ArgumentException("تکرار رمز عبور با رمز عبور مطابقت ندارد.");
        }
    }
}
