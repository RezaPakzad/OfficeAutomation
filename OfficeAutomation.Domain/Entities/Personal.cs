using System;
using System.Collections.Generic;

using OfficeAutomation.Domain.Entities;
using OfficeAutomation.Domain.Enums;
using OfficeAutomation.Domain.ValueObjects;

namespace Domain.Entities
{
    public class Personal : BaseEntity
    {
        private string _fname;
        private string _lname;
        private string _parentName;
        private string _birthDate;
        private string _adressOfResidence;
        private string _postCode;
        private string _mobileNumber;
        private string _phoneEmergency;
        private string _phoneInternal;
        private string _phoneNumber;
        private string _insuranceNumber;
        private string _accountNumber;
        private string _soldierStatusReason;
        private string _startDateWork;
        private string _breechesSize;
        private string _shoeSize;
        private string _fileName;
        private string _fileName1;
        private string _signatureFile;
        private string _relatedSkills;
        private string _relatedNotSkills;
        private string _referenceFullName1;
        private string _referenceAdress1;
        private string _referenceMobile1;
        private string _referenceRelative1;
        private string _referenceFullName2;
        private string _referenceAdress2;
        private string _referenceMobile2;
        private string _referenceRelative2;
        private string _certificateId1;
        private string _certificateDate;

        public Personal(int? personalCode, int? rajaPersonalCode, int? contractorPersonalCode, string fname, string lname, string parentName,
                        NationalCode nationalCode, CertificateId certificateId, string birthDate, int? idCity, int? idCityOfResidence,
                        string adressOfResidence, string postCode, string mobileNumber, string phoneEmergency, string phoneInternal,
                        string phoneNumber, string insuranceNumber, string accountNumber, SoldierStatus? idSoldierStatus, string soldierStatusReason,
                        string startDateWork, ShirtSize? idSizeType, string breechesSize, string shoeSize, BloodType? idBloodType, TypeHome? idTypeHome,
                        Sex? idSex, bool isRetired, string fileName, string fileName1, Religion? idReligion, CitizenShip? idCitizenShip, string signatureFile,
                        string relatedSkills, string relatedNotSkills, string referenceFullName1, string referenceAdress1,
                        string referenceMobile1, string referenceRelative1, string referenceFullName2, string referenceAdress2,
                        string referenceMobile2, string referenceRelative2, int workExperience, int workExperience1, int workExperience2,
                        int workExperience3, long netPayment, bool noAddiction, bool sueHistory, bool occupationalMedicine,
                        string certificateId1, string certificateDate, int? idCityOfCertification, bool isOkFinal, bool isAdmin,
                        string clientIp)
            : base()
        {
            SetPersonalCode(personalCode);
            RajaPersonalCode = rajaPersonalCode;
            ContractorPersonalCode = contractorPersonalCode;
            SetFname(fname);
            SetLname(lname);
            SetParentName(parentName);
            NationalCode = nationalCode ?? throw new ArgumentNullException(nameof(nationalCode));
            CertificateId = certificateId ?? throw new ArgumentNullException(nameof(certificateId));
            SetBirthDate(birthDate);
            IdCity = idCity ?? 0;
            IdCityOfResidence = idCityOfResidence ?? 0;
            SetAdressOfResidence(adressOfResidence);
            SetPostCode(postCode);
            SetMobileNumber(mobileNumber);
            SetPhoneEmergency(phoneEmergency);
            SetPhoneInternal(phoneInternal);
            SetPhoneNumber(phoneNumber);
            SetInsuranceNumber(insuranceNumber);
            SetAccountNumber(accountNumber);
            IdSoldierStatus = idSoldierStatus;
            SetSoldierStatusReason(soldierStatusReason);
            SetStartDateWork(startDateWork);
            IdSizeType = idSizeType;
            SetBreechesSize(breechesSize);
            SetShoeSize(shoeSize);
            IdBloodType = idBloodType;
            IdTypeHome = idTypeHome;
            IdSex = idSex;
            IsRetired = isRetired;
            SetFileName(fileName);
            SetFileName1(fileName1);
            IdReligion = idReligion;
            IdCitizenShip = idCitizenShip;
            SetSignatureFile(signatureFile);
            SetRelatedSkills(relatedSkills);
            SetRelatedNotSkills(relatedNotSkills);
            SetReferenceFullName1(referenceFullName1);
            SetReferenceAdress1(referenceAdress1);
            SetReferenceMobile1(referenceMobile1);
            SetReferenceRelative1(referenceRelative1);
            SetReferenceFullName2(referenceFullName2);
            SetReferenceAdress2(referenceAdress2);
            SetReferenceMobile2(referenceMobile2);
            SetReferenceRelative2(referenceRelative2);
            WorkEexperience = workExperience;
            WorkEexperience1 = workExperience1;
            WorkEexperience2 = workExperience2;
            WorkEexperience3 = workExperience3;
            NetPayment = netPayment;
            NoAddiction = noAddiction;
            SueHistory = sueHistory;
            OccupationalMedicine = occupationalMedicine;
            SetCertificateId1(certificateId1);
            SetCertificateDate(certificateDate);
            IdCityOfCertification = idCityOfCertification ?? 0;
            IsOkFinal = isOkFinal;
            IsAdmin = isAdmin;
            SetClientIp(clientIp);
        }

        public int IdPersonal { get; private set; }
        public int? PersonalCode { get; private set; }
        public int? RajaPersonalCode { get; private set; }
        public int? ContractorPersonalCode { get; private set; }
        public string Fname => _fname;
        public string Lname => _lname;
        public string ParentName => _parentName;
        public NationalCode NationalCode { get; private set; }
        public CertificateId CertificateId { get; private set; }
        public string BirthDate => _birthDate;
        public int? IdCity { get; private set; }
        public City City { get; private set; }
        public int? IdCityOfResidence { get; private set; }
        public string AdressOfResidence => _adressOfResidence;
        public string PostCode => _postCode;
        public string MobileNumber => _mobileNumber;
        public string PhoneEmergency => _phoneEmergency;
        public string PhoneInternal => _phoneInternal;
        public string PhoneNumber => _phoneNumber;
        public string InsuranceNumber => _insuranceNumber;
        public string AccountNumber => _accountNumber;
        public SoldierStatus? IdSoldierStatus { get; private set; }
        public string SoldierStatusReason => _soldierStatusReason;
        public string StartDateWork => _startDateWork;
        public ShirtSize? IdSizeType { get; private set; }
        public string BreechesSize => _breechesSize;
        public string ShoeSize => _shoeSize;
        public BloodType? IdBloodType { get; private set; }
        public TypeHome? IdTypeHome { get; private set; }
        public Sex? IdSex { get; private set; }
        public bool IsRetired { get; private set; }
        public string FileName => _fileName;
        public string FileName1 => _fileName1;
        public Religion? IdReligion { get; private set; }
        public CitizenShip? IdCitizenShip { get; private set; }
        public string SignatureFile => _signatureFile;
        public string RelatedSkills => _relatedSkills;
        public string RelatedNotSkills => _relatedNotSkills;
        public string ReferenceFullName1 => _referenceFullName1;
        public string ReferenceAdress1 => _referenceAdress1;
        public string ReferenceMobile1 => _referenceMobile1;
        public string ReferenceRelative1 => _referenceRelative1;
        public string ReferenceFullName2 => _referenceFullName2;
        public string ReferenceAdress2 => _referenceAdress2;
        public string ReferenceMobile2 => _referenceMobile2;
        public string ReferenceRelative2 => _referenceRelative2;
        public int WorkEexperience { get; private set; }
        public int WorkEexperience1 { get; private set; }
        public int WorkEexperience2 { get; private set; }
        public int WorkEexperience3 { get; private set; }
        public long NetPayment { get; private set; }
        public bool NoAddiction { get; private set; }
        public bool SueHistory { get; private set; }
        public bool OccupationalMedicine { get; private set; }
        public string CertificateId1 => _certificateId1;
        public string CertificateDate => _certificateDate;
        public int? IdCityOfCertification { get; private set; }
        //public List<PersonalContract> PersonalContracts { get; private set; } = new List<PersonalContract>();
        public bool IsOkFinal { get; private set; }
        public bool IsAdmin { get; private set; }

        public string FullName() => $"{_fname} {_lname}";

        public string ComboFull => $"{PersonalCode} {_fname} {_lname}";

        public void SetPersonalCode(int? personalCode)
        {
            if (personalCode <= 0)
                throw new ArgumentException("PersonalCode must be positive if provided.");

            PersonalCode = personalCode;
        }

        public void SetFname(string fname)
        {
            if (string.IsNullOrWhiteSpace(fname))
                throw new ArgumentException("Fname is required.");
            if (fname.Length > 100)
                throw new ArgumentException("Fname cannot exceed 100 characters.");

            _fname = fname;
        }

        public void SetLname(string lname)
        {
            if (string.IsNullOrWhiteSpace(lname))
                throw new ArgumentException("Lname is required.");
            if (lname.Length > 50)
                throw new ArgumentException("Lname cannot exceed 50 characters.");

            _lname = lname;
        }

        public void SetParentName(string parentName)
        {
            if (string.IsNullOrWhiteSpace(parentName))
                throw new ArgumentException("ParentName is required.");
            if (parentName.Length > 50)
                throw new ArgumentException("ParentName cannot exceed 50 characters.");

            _parentName = parentName;
        }

        public void SetBirthDate(string birthDate)
        {
            if (birthDate != null && birthDate.Length > 10)
                throw new ArgumentException("BirthDate cannot exceed 10 characters.");

            _birthDate = birthDate;
        }

        public void UpdateCity(City city)
        {
            if (city == null)
                throw new ArgumentNullException(nameof(city));

            IdCity = city.IdCity;
            City = city;
        }

        public void SetAdressOfResidence(string adressOfResidence)
        {
            if (adressOfResidence != null && adressOfResidence.Length > 150)
                throw new ArgumentException("AdressOfResidence cannot exceed 150 characters.");

            _adressOfResidence = adressOfResidence;
        }

        public void SetPostCode(string postCode)
        {
            if (postCode != null && postCode.Length > 20)
                throw new ArgumentException("PostCode cannot exceed 20 characters.");

            _postCode = postCode;
        }

        public void SetMobileNumber(string mobileNumber)
        {
            if (string.IsNullOrWhiteSpace(mobileNumber))
                throw new ArgumentException("MobileNumber is required.");
            if (mobileNumber.Length > 20)
                throw new ArgumentException("MobileNumber cannot exceed 20 characters.");

            _mobileNumber = mobileNumber;
        }

        public void SetPhoneEmergency(string phoneEmergency)
        {
            if (phoneEmergency != null && phoneEmergency.Length > 20)
                throw new ArgumentException("PhoneEmergency cannot exceed 20 characters.");

            _phoneEmergency = phoneEmergency;
        }

        public void SetPhoneInternal(string phoneInternal)
        {
            if (phoneInternal != null && phoneInternal.Length > 20)
                throw new ArgumentException("PhoneInternal cannot exceed 20 characters.");

            _phoneInternal = phoneInternal;
        }

        public void SetPhoneNumber(string phoneNumber)
        {
            if (phoneNumber != null && phoneNumber.Length > 20)
                throw new ArgumentException("PhoneNumber cannot exceed 20 characters.");

            _phoneNumber = phoneNumber;
        }

        public void SetInsuranceNumber(string insuranceNumber)
        {
            if (insuranceNumber != null && insuranceNumber.Length > 20)
                throw new ArgumentException("InsuranceNumber cannot exceed 20 characters.");

            _insuranceNumber = insuranceNumber;
        }

        public void SetAccountNumber(string accountNumber)
        {
            if (accountNumber != null && accountNumber.Length > 20)
                throw new ArgumentException("AccountNumber cannot exceed 20 characters.");

            _accountNumber = accountNumber;
        }

        public void SetSoldierStatusReason(string soldierStatusReason)
        {
            if (soldierStatusReason != null && soldierStatusReason.Length > 100)
                throw new ArgumentException("SoldierStatusReason cannot exceed 100 characters.");

            _soldierStatusReason = soldierStatusReason;
        }

        public void SetStartDateWork(string startDateWork)
        {
            if (startDateWork != null && startDateWork.Length > 20)
                throw new ArgumentException("StartDateWork cannot exceed 20 characters.");

            _startDateWork = startDateWork;
        }

        public void SetBreechesSize(string breechesSize)
        {
            if (breechesSize == null)
                breechesSize = "0";
            if (breechesSize.Length > 10)
                throw new ArgumentException("BreechesSize cannot exceed 10 characters.");

            _breechesSize = breechesSize;
        }

        public void SetShoeSize(string shoeSize)
        {
            if (shoeSize == null)
                shoeSize = "0";
            if (shoeSize.Length > 10)
                throw new ArgumentException("ShoeSize cannot exceed 10 characters.");

            _shoeSize = shoeSize;
        }

        public void SetFileName(string fileName)
        {
            if (fileName != null && fileName.Length > 20)
                throw new ArgumentException("FileName cannot exceed 20 characters.");

            _fileName = fileName;
        }

        public void SetFileName1(string fileName1)
        {
            if (fileName1 != null && fileName1.Length > 20)
                throw new ArgumentException("FileName1 cannot exceed 20 characters.");

            _fileName1 = fileName1;
        }

        public void SetSignatureFile(string signatureFile)
        {
            if (signatureFile != null && signatureFile.Length > 50)
                throw new ArgumentException("SignatureFile cannot exceed 50 characters.");

            _signatureFile = signatureFile;
        }

        public void SetRelatedSkills(string relatedSkills)
        {
            if (relatedSkills != null && relatedSkills.Length > 500)
                throw new ArgumentException("RelatedSkills cannot exceed 500 characters.");

            _relatedSkills = relatedSkills;
        }

        public void SetRelatedNotSkills(string relatedNotSkills)
        {
            if (relatedNotSkills != null && relatedNotSkills.Length > 500)
                throw new ArgumentException("RelatedNotSkills cannot exceed 500 characters.");

            _relatedNotSkills = relatedNotSkills;
        }

        public void SetReferenceFullName1(string referenceFullName1)
        {
            if (referenceFullName1 != null && referenceFullName1.Length > 50)
                throw new ArgumentException("ReferenceFullName1 cannot exceed 50 characters.");

            _referenceFullName1 = referenceFullName1;
        }

        public void SetReferenceAdress1(string referenceAdress1)
        {
            if (referenceAdress1 != null && referenceAdress1.Length > 150)
                throw new ArgumentException("ReferenceAdress1 cannot exceed 150 characters.");

            _referenceAdress1 = referenceAdress1;
        }

        public void SetReferenceMobile1(string referenceMobile1)
        {
            if (referenceMobile1 != null && referenceMobile1.Length > 15)
                throw new ArgumentException("ReferenceMobile1 cannot exceed 15 characters.");

            _referenceMobile1 = referenceMobile1;
        }

        public void SetReferenceRelative1(string referenceRelative1)
        {
            if (referenceRelative1 != null && referenceRelative1.Length > 50)
                throw new ArgumentException("ReferenceRelative1 cannot exceed 50 characters.");

            _referenceRelative1 = referenceRelative1;
        }

        public void SetReferenceFullName2(string referenceFullName2)
        {
            if (referenceFullName2 != null && referenceFullName2.Length > 50)
                throw new ArgumentException("ReferenceFullName2 cannot exceed 50 characters.");

            _referenceFullName2 = referenceFullName2;
        }

        public void SetReferenceAdress2(string referenceAdress2)
        {
            if (referenceAdress2 != null && referenceAdress2.Length > 150)
                throw new ArgumentException("ReferenceAdress2 cannot exceed 150 characters.");

            _referenceAdress2 = referenceAdress2;
        }

        public void SetReferenceMobile2(string referenceMobile2)
        {
            if (referenceMobile2 != null && referenceMobile2.Length > 15)
                throw new ArgumentException("ReferenceMobile2 cannot exceed 15 characters.");

            _referenceMobile2 = referenceMobile2;
        }

        public void SetReferenceRelative2(string referenceRelative2)
        {
            if (referenceRelative2 != null && referenceRelative2.Length > 50)
                throw new ArgumentException("ReferenceRelative2 cannot exceed 50 characters.");

            _referenceRelative2 = referenceRelative2;
        }

        public void SetCertificateId1(string certificateId1)
        {
            if (certificateId1 != null && certificateId1.Length > 20)
                throw new ArgumentException("CertificateId1 cannot exceed 20 characters.");

            _certificateId1 = certificateId1;
        }

        public void SetCertificateDate(string certificateDate)
        {
            if (certificateDate != null && certificateDate.Length > 10)
                throw new ArgumentException("CertificateDate cannot exceed 10 characters.");

            _certificateDate = certificateDate;
        }
    }
}