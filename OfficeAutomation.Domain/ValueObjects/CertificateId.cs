using System;

namespace OfficeAutomation.Domain.ValueObjects
{
    public class CertificateId
    {
        public CertificateId(string value)
        {
            if (value != null && value.Length > 20)
                throw new ArgumentException("CertificateId cannot exceed 20 characters.");

            Value = value;
        }

        public string Value { get; }

        public override bool Equals(object obj)
        {
            if (obj is CertificateId other)
                return Value == other.Value;
            return false;
        }

        public override int GetHashCode() => Value?.GetHashCode() ?? 0;

        public override string ToString() => Value;
    }
}