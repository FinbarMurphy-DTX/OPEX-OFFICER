using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using DatatecnixOfficerII.Data;

namespace DatatecnixOfficerII.Models
{
    public enum StaffDataField
    {

        StaffUid,

        StaffCode,

        StaffTitle,

        Initials,

        Forname,

        Surname,

        RankCode,

        RankDesc,

        RankStaffFilterstaffFilter,

        EplNumber,

        LocationCode,

        LocationDesc,

        LocationDefaultDeliveryLocationid,

        LocationCatalogueid,

        LocationStaffLocationCatalogueid,

        LocationDivisionDesc,

        LocationDivisionCompanyName,

        LocationCompanyName,

        LocationDefaultDeliveryLocationSlaAcc,

        LocationBudgetIndbudgetDesc,

        JoinDate,

        LeaveDate,

        Comments,

        Email,

        CompanyID,

        CompanyName,

        UserCredentials,

        Telephone,

        Internal,

        OpexUser,

        OpexUserName,

        Gender,

        Active,

        RestrictAccess,

        AccessControlType,

        LocationCatalogueLocationCatalogue,

        LocationCatalogueDescription,
    }

    public partial class StaffModel : BusinessRulesObjectModel
    {

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private uint? _staffUid;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _staffCode;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _staffTitle;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _initials;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _forname;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _surname;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _rankCode;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _rankDesc;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _rankStaffFilterstaffFilter;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _eplNumber;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _locationCode;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _locationDesc;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private uint? _locationDefaultDeliveryLocationid;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private uint? _locationCatalogueid;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private uint? _locationStaffLocationCatalogueid;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _locationDivisionDesc;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _locationDivisionCompanyName;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _locationCompanyName;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _locationDefaultDeliveryLocationSlaAcc;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _locationBudgetIndbudgetDesc;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _joinDate;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _leaveDate;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _comments;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _email;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private uint? _companyID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _companyName;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _userCredentials;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _telephone;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _internal;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _opexUser;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _opexUserName;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _gender;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _active;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _restrictAccess;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _accessControlType;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _locationCatalogueLocationCatalogue;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _locationCatalogueDescription;

        public StaffModel()
        {
        }

        public StaffModel(BusinessRules r) :
                base(r)
        {
        }

        public uint? StaffUid
        {
            get
            {
                return _staffUid;
            }
            set
            {
                _staffUid = value;
                UpdateFieldValue("StaffUid", value);
            }
        }

        public string StaffCode
        {
            get
            {
                return _staffCode;
            }
            set
            {
                _staffCode = value;
                UpdateFieldValue("StaffCode", value);
            }
        }

        public string StaffTitle
        {
            get
            {
                return _staffTitle;
            }
            set
            {
                _staffTitle = value;
                UpdateFieldValue("StaffTitle", value);
            }
        }

        public string Initials
        {
            get
            {
                return _initials;
            }
            set
            {
                _initials = value;
                UpdateFieldValue("Initials", value);
            }
        }

        public string Forname
        {
            get
            {
                return _forname;
            }
            set
            {
                _forname = value;
                UpdateFieldValue("Forname", value);
            }
        }

        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                _surname = value;
                UpdateFieldValue("Surname", value);
            }
        }

        public string RankCode
        {
            get
            {
                return _rankCode;
            }
            set
            {
                _rankCode = value;
                UpdateFieldValue("RankCode", value);
            }
        }

        public string RankDesc
        {
            get
            {
                return _rankDesc;
            }
            set
            {
                _rankDesc = value;
                UpdateFieldValue("RankDesc", value);
            }
        }

        public string RankStaffFilterstaffFilter
        {
            get
            {
                return _rankStaffFilterstaffFilter;
            }
            set
            {
                _rankStaffFilterstaffFilter = value;
                UpdateFieldValue("RankStaffFilterstaffFilter", value);
            }
        }

        public string EplNumber
        {
            get
            {
                return _eplNumber;
            }
            set
            {
                _eplNumber = value;
                UpdateFieldValue("EplNumber", value);
            }
        }

        public string LocationCode
        {
            get
            {
                return _locationCode;
            }
            set
            {
                _locationCode = value;
                UpdateFieldValue("LocationCode", value);
            }
        }

        public string LocationDesc
        {
            get
            {
                return _locationDesc;
            }
            set
            {
                _locationDesc = value;
                UpdateFieldValue("LocationDesc", value);
            }
        }

        public uint? LocationDefaultDeliveryLocationid
        {
            get
            {
                return _locationDefaultDeliveryLocationid;
            }
            set
            {
                _locationDefaultDeliveryLocationid = value;
                UpdateFieldValue("LocationDefaultDeliveryLocationid", value);
            }
        }

        public uint? LocationCatalogueid
        {
            get
            {
                return _locationCatalogueid;
            }
            set
            {
                _locationCatalogueid = value;
                UpdateFieldValue("LocationCatalogueid", value);
            }
        }

        public uint? LocationStaffLocationCatalogueid
        {
            get
            {
                return _locationStaffLocationCatalogueid;
            }
            set
            {
                _locationStaffLocationCatalogueid = value;
                UpdateFieldValue("LocationStaffLocationCatalogueid", value);
            }
        }

        public string LocationDivisionDesc
        {
            get
            {
                return _locationDivisionDesc;
            }
            set
            {
                _locationDivisionDesc = value;
                UpdateFieldValue("LocationDivisionDesc", value);
            }
        }

        public string LocationDivisionCompanyName
        {
            get
            {
                return _locationDivisionCompanyName;
            }
            set
            {
                _locationDivisionCompanyName = value;
                UpdateFieldValue("LocationDivisionCompanyName", value);
            }
        }

        public string LocationCompanyName
        {
            get
            {
                return _locationCompanyName;
            }
            set
            {
                _locationCompanyName = value;
                UpdateFieldValue("LocationCompanyName", value);
            }
        }

        public string LocationDefaultDeliveryLocationSlaAcc
        {
            get
            {
                return _locationDefaultDeliveryLocationSlaAcc;
            }
            set
            {
                _locationDefaultDeliveryLocationSlaAcc = value;
                UpdateFieldValue("LocationDefaultDeliveryLocationSlaAcc", value);
            }
        }

        public string LocationBudgetIndbudgetDesc
        {
            get
            {
                return _locationBudgetIndbudgetDesc;
            }
            set
            {
                _locationBudgetIndbudgetDesc = value;
                UpdateFieldValue("LocationBudgetIndbudgetDesc", value);
            }
        }

        public DateTime? JoinDate
        {
            get
            {
                return _joinDate;
            }
            set
            {
                _joinDate = value;
                UpdateFieldValue("JoinDate", value);
            }
        }

        public DateTime? LeaveDate
        {
            get
            {
                return _leaveDate;
            }
            set
            {
                _leaveDate = value;
                UpdateFieldValue("LeaveDate", value);
            }
        }

        public string Comments
        {
            get
            {
                return _comments;
            }
            set
            {
                _comments = value;
                UpdateFieldValue("Comments", value);
            }
        }

        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
                UpdateFieldValue("Email", value);
            }
        }

        public uint? CompanyID
        {
            get
            {
                return _companyID;
            }
            set
            {
                _companyID = value;
                UpdateFieldValue("CompanyID", value);
            }
        }

        public string CompanyName
        {
            get
            {
                return _companyName;
            }
            set
            {
                _companyName = value;
                UpdateFieldValue("CompanyName", value);
            }
        }

        public string UserCredentials
        {
            get
            {
                return _userCredentials;
            }
            set
            {
                _userCredentials = value;
                UpdateFieldValue("UserCredentials", value);
            }
        }

        public string Telephone
        {
            get
            {
                return _telephone;
            }
            set
            {
                _telephone = value;
                UpdateFieldValue("Telephone", value);
            }
        }

        public string Internal
        {
            get
            {
                return _internal;
            }
            set
            {
                _internal = value;
                UpdateFieldValue("Internal", value);
            }
        }

        public string OpexUser
        {
            get
            {
                return _opexUser;
            }
            set
            {
                _opexUser = value;
                UpdateFieldValue("OpexUser", value);
            }
        }

        public string OpexUserName
        {
            get
            {
                return _opexUserName;
            }
            set
            {
                _opexUserName = value;
                UpdateFieldValue("OpexUserName", value);
            }
        }

        public string Gender
        {
            get
            {
                return _gender;
            }
            set
            {
                _gender = value;
                UpdateFieldValue("Gender", value);
            }
        }

        public string Active
        {
            get
            {
                return _active;
            }
            set
            {
                _active = value;
                UpdateFieldValue("Active", value);
            }
        }

        public string RestrictAccess
        {
            get
            {
                return _restrictAccess;
            }
            set
            {
                _restrictAccess = value;
                UpdateFieldValue("RestrictAccess", value);
            }
        }

        public string AccessControlType
        {
            get
            {
                return _accessControlType;
            }
            set
            {
                _accessControlType = value;
                UpdateFieldValue("AccessControlType", value);
            }
        }

        public string LocationCatalogueLocationCatalogue
        {
            get
            {
                return _locationCatalogueLocationCatalogue;
            }
            set
            {
                _locationCatalogueLocationCatalogue = value;
                UpdateFieldValue("LocationCatalogueLocationCatalogue", value);
            }
        }

        public string LocationCatalogueDescription
        {
            get
            {
                return _locationCatalogueDescription;
            }
            set
            {
                _locationCatalogueDescription = value;
                UpdateFieldValue("LocationCatalogueDescription", value);
            }
        }

        public FieldValue this[StaffDataField field]
        {
            get
            {
                return this[field.ToString()];
            }
        }
    }

    public partial class Staff : StaffModel
    {

        public static List<DatatecnixOfficerII.Models.Staff> Select(string filter, string sort, string dataView, params object[] parameters)
        {
            return new StaffFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }

        public static List<DatatecnixOfficerII.Models.Staff> Select(string filter, string sort, params object[] parameters)
        {
            return new StaffFactory().Select(filter, sort, StaffFactory.SelectView, new BusinessObjectParameters(parameters));
        }

        public static List<DatatecnixOfficerII.Models.Staff> Select(string filter, params object[] parameters)
        {
            return new StaffFactory().Select(filter, null, StaffFactory.SelectView, new BusinessObjectParameters(parameters));
        }

        public static DatatecnixOfficerII.Models.Staff SelectSingle(string filter, params object[] parameters)
        {
            return new StaffFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }

        public static DatatecnixOfficerII.Models.Staff SelectSingle(uint? staffUid)
        {
            return new StaffFactory().SelectSingle(staffUid);
        }

        public int Insert()
        {
            return new StaffFactory().Insert(this);
        }

        public int Update()
        {
            return new StaffFactory().Update(this);
        }

        public int Delete()
        {
            return new StaffFactory().Delete(this);
        }

        public override string ToString()
        {
            return string.Format("StaffUid: {0}", this.StaffUid);
        }

        public static DatatecnixOfficerII.Models.Staff SelectSingle(object filter)
        {
            var paramList = new BusinessObjectParameters(filter);
            return SelectSingle(paramList.ToWhere(), paramList);
        }

        public static List<DatatecnixOfficerII.Models.Staff> Select(object filter, string sort, string view)
        {
            var paramList = new BusinessObjectParameters(filter);
            return Select(paramList.ToWhere(), sort, view, paramList);
        }

        public static List<DatatecnixOfficerII.Models.Staff> Select(object filter, string sort)
        {
            return Select(filter, sort, null);
        }

        public static List<DatatecnixOfficerII.Models.Staff> Select(object filter)
        {
            return Select(filter, null);
        }

        public static DatatecnixOfficerII.Models.Staff Insert(object initializer)
        {
            var instance = CreateInstance<DatatecnixOfficerII.Models.Staff>(initializer);
            if (instance.Insert() == 0)
                return null;
            return instance;
        }

        public static List<DatatecnixOfficerII.Models.Staff> SelectAll()
        {
            return SelectAll(null);
        }

        public static List<DatatecnixOfficerII.Models.Staff> SelectAll(string sort)
        {
            return new DatatecnixOfficerII.Models.StaffFactory().Select(null, sort, DatatecnixOfficerII.Models.StaffFactory.SelectView, new BusinessObjectParameters());
        }
    }

    public partial class StaffFactory
    {

        public StaffFactory()
        {
        }

        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("Staff");
            }
        }

        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("Staff");
            }
        }

        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("Staff");
            }
        }

        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("Staff");
            }
        }

        public static StaffFactory Create()
        {
            return new StaffFactory();
        }

        public List<DatatecnixOfficerII.Models.Staff> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }

        public List<DatatecnixOfficerII.Models.Staff> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }

        public List<DatatecnixOfficerII.Models.Staff> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            var request = new PageRequest(0, Int32.MaxValue, sort, new string[0])
            {
                RequiresMetaData = true,
                MetadataFilter = new string[] {
                    "fields"}
            };
            var c = ControllerFactory.CreateDataController();
            var bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            var page = c.GetPage("Staff", dataView, request);
            return page.ToList<DatatecnixOfficerII.Models.Staff>();
        }

        public DatatecnixOfficerII.Models.Staff SelectSingle(uint? staffUid)
        {
            var parameterMarker = SqlStatement.GetParameterMarker(string.Empty);
            var paramValues = new BusinessObjectParameters();
            paramValues[(parameterMarker + "objpk0")] = staffUid;
            return SelectSingle(string.Format("StaffUid={0}objpk0", parameterMarker), paramValues);
        }

        public DatatecnixOfficerII.Models.Staff SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            var list = Select(filter, parameters);
            if (list.Count > 0)
                return list[0];
            return null;
        }

        protected virtual FieldValue[] CreateFieldValues(DatatecnixOfficerII.Models.Staff theStaff, DatatecnixOfficerII.Models.Staff original_Staff)
        {
            var values = new List<FieldValue>();
            values.Add(new FieldValue("StaffUid", original_Staff.StaffUid, theStaff.StaffUid, true));
            values.Add(new FieldValue("StaffCode", original_Staff.StaffCode, theStaff.StaffCode));
            values.Add(new FieldValue("StaffTitle", original_Staff.StaffTitle, theStaff.StaffTitle));
            values.Add(new FieldValue("Initials", original_Staff.Initials, theStaff.Initials));
            values.Add(new FieldValue("Forname", original_Staff.Forname, theStaff.Forname));
            values.Add(new FieldValue("Surname", original_Staff.Surname, theStaff.Surname));
            values.Add(new FieldValue("RankCode", original_Staff.RankCode, theStaff.RankCode));
            values.Add(new FieldValue("RankDesc", original_Staff.RankDesc, theStaff.RankDesc, true));
            values.Add(new FieldValue("RankStaffFilterstaffFilter", original_Staff.RankStaffFilterstaffFilter, theStaff.RankStaffFilterstaffFilter, true));
            values.Add(new FieldValue("EplNumber", original_Staff.EplNumber, theStaff.EplNumber));
            values.Add(new FieldValue("LocationCode", original_Staff.LocationCode, theStaff.LocationCode));
            values.Add(new FieldValue("LocationDesc", original_Staff.LocationDesc, theStaff.LocationDesc, true));
            values.Add(new FieldValue("LocationDefaultDeliveryLocationid", original_Staff.LocationDefaultDeliveryLocationid, theStaff.LocationDefaultDeliveryLocationid, true));
            values.Add(new FieldValue("LocationCatalogueid", original_Staff.LocationCatalogueid, theStaff.LocationCatalogueid, true));
            values.Add(new FieldValue("LocationStaffLocationCatalogueid", original_Staff.LocationStaffLocationCatalogueid, theStaff.LocationStaffLocationCatalogueid, true));
            values.Add(new FieldValue("LocationDivisionDesc", original_Staff.LocationDivisionDesc, theStaff.LocationDivisionDesc, true));
            values.Add(new FieldValue("LocationDivisionCompanyName", original_Staff.LocationDivisionCompanyName, theStaff.LocationDivisionCompanyName, true));
            values.Add(new FieldValue("LocationCompanyName", original_Staff.LocationCompanyName, theStaff.LocationCompanyName, true));
            values.Add(new FieldValue("LocationDefaultDeliveryLocationSlaAcc", original_Staff.LocationDefaultDeliveryLocationSlaAcc, theStaff.LocationDefaultDeliveryLocationSlaAcc, true));
            values.Add(new FieldValue("LocationBudgetIndbudgetDesc", original_Staff.LocationBudgetIndbudgetDesc, theStaff.LocationBudgetIndbudgetDesc, true));
            values.Add(new FieldValue("JoinDate", original_Staff.JoinDate, theStaff.JoinDate));
            values.Add(new FieldValue("LeaveDate", original_Staff.LeaveDate, theStaff.LeaveDate));
            values.Add(new FieldValue("Comments", original_Staff.Comments, theStaff.Comments));
            values.Add(new FieldValue("Email", original_Staff.Email, theStaff.Email));
            values.Add(new FieldValue("CompanyID", original_Staff.CompanyID, theStaff.CompanyID));
            values.Add(new FieldValue("CompanyName", original_Staff.CompanyName, theStaff.CompanyName, true));
            values.Add(new FieldValue("UserCredentials", original_Staff.UserCredentials, theStaff.UserCredentials));
            values.Add(new FieldValue("Telephone", original_Staff.Telephone, theStaff.Telephone));
            values.Add(new FieldValue("Internal", original_Staff.Internal, theStaff.Internal));
            values.Add(new FieldValue("OpexUser", original_Staff.OpexUser, theStaff.OpexUser));
            values.Add(new FieldValue("OpexUserName", original_Staff.OpexUserName, theStaff.OpexUserName));
            values.Add(new FieldValue("Gender", original_Staff.Gender, theStaff.Gender));
            values.Add(new FieldValue("Active", original_Staff.Active, theStaff.Active));
            values.Add(new FieldValue("RestrictAccess", original_Staff.RestrictAccess, theStaff.RestrictAccess));
            values.Add(new FieldValue("AccessControlType", original_Staff.AccessControlType, theStaff.AccessControlType));
            values.Add(new FieldValue("LocationCatalogueLocationCatalogue", original_Staff.LocationCatalogueLocationCatalogue, theStaff.LocationCatalogueLocationCatalogue, true));
            values.Add(new FieldValue("LocationCatalogueDescription", original_Staff.LocationCatalogueDescription, theStaff.LocationCatalogueDescription, true));
            return values.ToArray();
        }

        protected virtual int ExecuteAction(DatatecnixOfficerII.Models.Staff theStaff, DatatecnixOfficerII.Models.Staff original_Staff, string lastCommandName, string commandName, string dataView)
        {
            var args = new ActionArgs()
            {
                Controller = "Staff",
                View = dataView,
                Values = CreateFieldValues(theStaff, original_Staff),
                LastCommandName = lastCommandName,
                CommandName = commandName
            };
            var result = ControllerFactory.CreateDataController().Execute("Staff", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theStaff);
            return result.RowsAffected;
        }

        public virtual int Update(DatatecnixOfficerII.Models.Staff theStaff, DatatecnixOfficerII.Models.Staff original_Staff)
        {
            return ExecuteAction(theStaff, original_Staff, "Edit", "Update", UpdateView);
        }

        public virtual int Update(DatatecnixOfficerII.Models.Staff theStaff)
        {
            return Update(theStaff, SelectSingle(theStaff.StaffUid));
        }

        public virtual int Insert(DatatecnixOfficerII.Models.Staff theStaff)
        {
            return ExecuteAction(theStaff, new Staff(), "New", "Insert", InsertView);
        }

        public virtual int Delete(DatatecnixOfficerII.Models.Staff theStaff)
        {
            return ExecuteAction(theStaff, theStaff, "Select", "Delete", DeleteView);
        }
    }
}
