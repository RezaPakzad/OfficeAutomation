using Domain.Entities;
using OfficeAutomation.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeAutomation.Domain.Aggregates
{
    public class LoginAggregate
    {
        private readonly Login _login;

        public LoginAggregate(Login login)
        {
            _login = login ?? throw new ArgumentNullException(nameof(login));
        }

        public int IdLogin => _login.IdLogin;

        public void UpdatePersonal(Personal personal)
        {
            _login.UpdatePersonal(personal);
        }

        // Other methods
    }
}
