using System;
using System.Collections.Generic;
using Domain.Entities;
using OfficeAutomation.Domain.Entities;

namespace OfficeAutomation.Domain.Aggregates
{
    public class PersonalAggregate
    {
        private readonly Personal _personal;

        public PersonalAggregate(Personal personal)
        {
            _personal = personal ?? throw new ArgumentNullException(nameof(personal));
        }

        public int IdPersonal => _personal.IdPersonal;
     

    

       
    }
}