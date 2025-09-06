using System;

namespace OfficeAutomation.Domain.ValueObjects
{
    public class NationalCode
    {
        private readonly string _value;

        public NationalCode(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("National code cannot be empty.");
            if (value.Length > 20)
                throw new ArgumentException("National code cannot exceed 20 characters.");

            // اعتبارسنجی اضافی (مانند فرمت کد ملی)
            _value = value;
        }

        public string Value => _value;

        public override bool Equals(object obj)
        {
            if (obj is NationalCode other)
                return _value == other._value;
            return false;
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => _value;
    }
}