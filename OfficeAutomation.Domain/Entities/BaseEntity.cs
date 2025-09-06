using System;

namespace Domain.Entities
{
    public abstract class BaseEntity
    {
        protected BaseEntity()
        {
            RegisterTime = DateTime.Now.ToString("HH:mm");
            RegisterDateM = DateTime.Now;
            RegisterDate ="";
            ClientIp = string.Empty;
        }

        public DateTime? RegisterDateM { get; protected set; }
        public string RegisterDate { get; protected set; }
        public string RegisterTime { get; protected set; }
        public string ClientIp { get; protected set; }

        public void SetClientIp(string clientIp)
        {
            if (clientIp != null && clientIp.Length > 20)
                throw new ArgumentException("ClientIp cannot exceed 20 characters.");

            ClientIp = clientIp ?? string.Empty;
        }

        public void SetRegisterDateM(DateTime? registerDateM)
        {
            RegisterDateM = registerDateM;
        }

        public void SetRegisterDate(string registerDate)
        {
            if (registerDate != null && registerDate.Length > 20)
                throw new ArgumentException("RegisterDate cannot exceed 20 characters.");

            RegisterDate = registerDate;
        }

        public void SetRegisterTime(string registerTime)
        {
            if (registerTime != null && registerTime.Length > 10)
                throw new ArgumentException("RegisterTime cannot exceed 10 characters.");

            RegisterTime = registerTime;
        }
    }
}