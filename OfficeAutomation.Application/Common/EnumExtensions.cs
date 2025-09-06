using System;
using System.Collections.Generic;
using System.Linq;

using OfficeAutomation.Application.Common;
using OfficeAutomation.Application.DTOs;
using OfficeAutomation.Domain.Enums;


namespace Application.Common
{
    public static class EnumExtensions
    {
        public static IEnumerable<DropdownItemDto> ToDropdownList<TEnum>() where TEnum : Enum
        {
            var enumType = typeof(TEnum);
            if (enumType == typeof(BloodType))
                return Enum.GetValues(typeof(BloodType))
                    .Cast<BloodType>()
                    .Select(e => new DropdownItemDto
                    {
                        Value = e.ToString(),
                        Text = EnumDisplayNames.BloodTypeNames[e]
                    });
            if (enumType == typeof(Sex))
                return Enum.GetValues(typeof(Sex))
                    .Cast<Sex>()
                    .Select(e => new DropdownItemDto
                    {
                        Value = e.ToString(),
                        Text = EnumDisplayNames.SexNames[e]
                    });
            if (enumType == typeof(ShirtSize))
                return Enum.GetValues(typeof(ShirtSize))
                    .Cast<ShirtSize>()
                    .Select(e => new DropdownItemDto
                    {
                        Value = e.ToString(),
                        Text = EnumDisplayNames.ShirtSizeNames[e]
                    });
            if (enumType == typeof(CitizenShip))
                return Enum.GetValues(typeof(CitizenShip))
                    .Cast<CitizenShip>()
                    .Select(e => new DropdownItemDto
                    {
                        Value = e.ToString(),
                        Text = EnumDisplayNames.CitizenShipNames[e]
                    });
            if (enumType == typeof(Religion))
                return Enum.GetValues(typeof(Religion))
                    .Cast<Religion>()
                    .Select(e => new DropdownItemDto
                    {
                        Value = e.ToString(),
                        Text = EnumDisplayNames.ReligionNames[e]
                    });
            if (enumType == typeof(SoldierStatus))
                return Enum.GetValues(typeof(SoldierStatus))
                    .Cast<SoldierStatus>()
                    .Select(e => new DropdownItemDto
                    {
                        Value = e.ToString(),
                        Text = EnumDisplayNames.SoldierStatusNames[e]
                    });
            if (enumType == typeof(TypeHome))
                return Enum.GetValues(typeof(TypeHome))
                    .Cast<TypeHome>()
                    .Select(e => new DropdownItemDto
                    {
                        Value = e.ToString(),
                        Text = EnumDisplayNames.TypeHomeNames[e]
                    });

            return Enumerable.Empty<DropdownItemDto>();
        }
    }
}