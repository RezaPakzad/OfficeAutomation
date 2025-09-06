using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeAutomation.Domain.ValueObjects
{
    class Address
    {
        public Address(string value)
        {
            if (value != null && value.Length > 20)
                throw new ArgumentException("CertificateId cannot exceed 20 characters.");

            Value = value;
        }

        public string Value { get; }

        public override bool Equals(object obj)
        {
            if (obj is Address other)
                return Value == other.Value;
            return false;
        }

        public override int GetHashCode() => Value?.GetHashCode() ?? 0;

        public override string ToString() => Value;
    }
}
