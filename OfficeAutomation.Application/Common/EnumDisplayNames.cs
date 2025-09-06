using OfficeAutomation.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeAutomation.Application.Common
{
    public static class EnumDisplayNames
    {
        public static readonly Dictionary<BloodType, string> BloodTypeNames = new Dictionary<BloodType, string>
        {
            { BloodType.OPositive, "O+" },
            { BloodType.ABPositive, "AB+" },
            { BloodType.BPositive, "B+" },
            { BloodType.ONegative, "O-" },
            { BloodType.BNegative, "B-" },
            { BloodType.ANegative, "A-" },
            { BloodType.ABNegative, "AB-" },
            { BloodType.APositive, "A+" }
        };

        public static readonly Dictionary<Sex, string> SexNames = new Dictionary<Sex, string>
        {
            { Sex.Male, "مرد" },
            { Sex.Female, "زن" }
        };

        public static readonly Dictionary<ShirtSize, string> ShirtSizeNames = new Dictionary<ShirtSize, string>
        {
            { ShirtSize.Small, "S" },
            { ShirtSize.Medium, "M" },
            { ShirtSize.Large, "L" },
            { ShirtSize.ExtraLarge, "XL" },
            { ShirtSize.ExtraExtraLarge, "XXL" },
            { ShirtSize.TripleExtraLarge, "XXXL" },
            { ShirtSize.QuadrupleExtraLarge, "XXXXL" }
        };

        public static readonly Dictionary<CitizenShip, string> CitizenShipNames = new Dictionary<CitizenShip, string>
        {
            { CitizenShip.Iranian, "ایران" },
            { CitizenShip.NonIranian, "ندارد" }
        };

        public static readonly Dictionary<Religion, string> ReligionNames = new Dictionary<Religion, string>
        {
            { Religion.None, "ندارد" },
            { Religion.Shia, "شیعه" },
            { Religion.Sunni, "سنی" }
        };

        public static readonly Dictionary<SoldierStatus, string> SoldierStatusNames = new Dictionary<SoldierStatus, string>
        {
            { SoldierStatus.NotServed, "عدم خدمت سربازی" },
            { SoldierStatus.Served, "خدمت سربازی" },
            { SoldierStatus.Exempt, "معافیت" }
        };

        public static readonly Dictionary<TypeHome, string> TypeHomeNames = new Dictionary<TypeHome, string>
        {
            { TypeHome.Owned, "مالکیت" },
            { TypeHome.Rented, "اجاره" },
            { TypeHome.Organizational, "سازمانی" }
        };
    }
}
