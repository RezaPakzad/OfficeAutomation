using System;
using System.ComponentModel.DataAnnotations;

using OfficeAutomation.Domain.Enums;

namespace Application.DTOs
{
    public class PersonalDto
    {
        public int IdPersonal { get; set; }
        [Display(Name = "کد پرسنلی")]
        public int? PersonalCode { get; set; }
        [Display(Name = "کد پرسنلی رجا")]
        public int? RajaPersonalCode { get; set; }
        [Display(Name = "کد پرسنلی پیمانکار")]
        public int? ContractorPersonalCode { get; set; }
        [Display(Name = "نام")]
        public string Fname { get; set; }
        [Display(Name = "نام خانوادگی")]
        public string Lname { get; set; }
        [Display(Name = "نام پدر")]
        public string ParentName { get; set; }
        [Display(Name = "کد ملی")]
        public string NationalCode { get; set; }
        [Display(Name = "شماره شناسنامه")]
        public string CertificateId { get; set; }
        [Display(Name = "تاریخ تولد")]
        public string BirthDate { get; set; }
        [Display(Name = "محل تولد")]
        public int? IdCity { get; set; }
        [Display(Name = "محل تولد")]
        public string City { get; set; }
        [Display(Name = "نام شهر")]
        public int? IdCityOfResidence { get; set; }
        [Display(Name = "آدرس محل سکونت")]
        public string AdressOfResidence { get; set; }
        [Display(Name = "کد پستی")]
        public string PostCode { get; set; }
        [Display(Name = "شماره تلفن همراه")]
        public string MobileNumber { get; set; }
        [Display(Name = "شماره تلفن ضروری")]
        public string PhoneEmergency { get; set; }
        [Display(Name = "شماره داخلی")]
        public string PhoneInternal { get; set; }
        [Display(Name = "تلفن ثابت")]
        public string PhoneNumber { get; set; }
        [Display(Name = "کد بیمه")]
        public string InsuranceNumber { get; set; }
        [Display(Name = "شماره حساب")]
        public string AccountNumber { get; set; }
        [Display(Name = "وضعیت خدمت")]
        public SoldierStatus? IdSoldierStatus { get; set; }
        [Display(Name = "علت معافیت")]
        public string SoldierStatusReason { get; set; }
        [Display(Name = "تاریخ شروع به کار")]
        public string StartDateWork { get; set; }
        [Display(Name = "سایز پیراهن")]
        public ShirtSize? IdSizeType { get; set; }
        [Display(Name = "سایز شلوار")]
        public string BreechesSize { get; set; }
        [Display(Name = "سایز کفش")]
        public string ShoeSize { get; set; }
        [Display(Name = "گروه خونی")]
        public BloodType? IdBloodType { get; set; }
        [Display(Name = "نوع مسکن")]
        public TypeHome? IdTypeHome { get; set; }
        [Display(Name = "جنسیت")]
        public Sex? IdSex { get; set; }
        [Display(Name = "بازنشسته")]
        public bool IsRetired { get; set; }
        public string FileName { get; set; }
        public string FileName1 { get; set; }
        [Display(Name = "مذهب")]
        public Religion? IdReligion { get; set; }
        [Display(Name = "تابعیت")]
        public CitizenShip? IdCitizenShip { get; set; }
        [Display(Name = "عکس امضا")]
        public string SignatureFile { get; set; }
        [Display(Name = "مهارت مرتبط")]
        public string RelatedSkills { get; set; }
        [Display(Name = "مهارت غیر مرتبط")]
        public string RelatedNotSkills { get; set; }
        [Display(Name = "نام و نام خانوادگی معرف 1")]
        public string ReferenceFullName1 { get; set; }
        [Display(Name = "آدرس معرف 1")]
        public string ReferenceAdress1 { get; set; }
        [Display(Name = "شماره تماس معرف 1")]
        public string ReferenceMobile1 { get; set; }
        [Display(Name = "نسبت معرف 1")]
        public string ReferenceRelative1 { get; set; }
        [Display(Name = "نام و نام خانوادگی معرف 2")]
        public string ReferenceFullName2 { get; set; }
        [Display(Name = "آدرس معرف 2")]
        public string ReferenceAdress2 { get; set; }
        [Display(Name = "شماره تماس معرف 2")]
        public string ReferenceMobile2 { get; set; }
        [Display(Name = "نسبت معرف 2")]
        public string ReferenceRelative2 { get; set; }
        [Display(Name = "سابقه کار با بیمه")]
        public int WorkEexperience { get; set; }
        [Display(Name = "سابقه کار بدون بیمه")]
        public int WorkEexperience1 { get; set; }
        [Display(Name = "سابقه مرتبط با شغل فعلی")]
        public int WorkEexperience2 { get; set; }
        [Display(Name = "سابقه کار غیر مرتبط")]
        public int WorkEexperience3 { get; set; }
        [Display(Name = "آخرین حقوق دریافتی")]
        public long NetPayment { get; set; }
        [Display(Name = "عدم اعتیاد")]
        public bool NoAddiction { get; set; }
        [Display(Name = "سوء پیشینه")]
        public bool SueHistory { get; set; }
        [Display(Name = "طب کار")]
        public bool OccupationalMedicine { get; set; }
        [Display(Name = "شماره سلسله شناسنامه")]
        public string CertificateId1 { get; set; }
        [Display(Name = "تاریخ صدور شناسنامه")]
        public string CertificateDate { get; set; }
        [Display(Name = "محل صدور شناسنامه")]
        public int? IdCityOfCertification { get; set; }
        [Display(Name = "تاریخ ثبت رکورد به صورت میلادی")]
        public DateTime? RegisterDateM { get; set; }
        [Display(Name = "تاریخ ثبت رکورد به صورت شمسی")]
        public string RegisterDate { get; set; }
        [Display(Name = "زمان ثبت رکورد")]
        public string RegisterTime { get; set; }
        [Display(Name = "آدرس IP ثبت کننده")]
        public string ClientIp { get; set; }
        public bool IsOkFinal { get; set; }
        public bool IsAdmin { get; set; }
    }
}