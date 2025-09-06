using System.Threading.Tasks;


namespace OfficeAutomation.Domain.DomainServices
{
    public class PersonalService
    {
        public async Task<bool> IsPersonalCodeUniqueAsync(int personalCode)
        {
            // منطق بررسی یکتایی کد پرسنلی
            // مثلاً: فراخوانی از repository یا دیتابیس
            return await Task.FromResult(true); // نمونه ساده
        }
    }
}