using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using DatatecnixOfficerII.Data;

namespace DatatecnixOfficerII.Models
{
    public enum StaffAccessControlDataField
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

    public partial class StaffAccessControlModel : BusinessRulesObjectModel
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

        public StaffAccessControlModel()
        {
        }

        public StaffAccessControlModel(BusinessRules r) :
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

        public FieldValue this[StaffAccessControlDataField field]
        {
            get
            {
                return this[field.ToString()];
            }
        }
    }

    public partial class StaffAccessControl : StaffAccessControlModel
    {

        public static List<DatatecnixOfficerII.Models.StaffAccessControl> Select(string filter, string sort, string dataView, params object[] parameters)
        {
            return new StaffAccessControlFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }

        public static List<DatatecnixOfficerII.Models.StaffAccessControl> Select(string filter, string sort, params object[] parameters)
        {
            return new StaffAccessControlFactory().Select(filter, sort, StaffAccessControlFactory.SelectView, new BusinessObjectParameters(parameters));
        }

        public static List<DatatecnixOfficerII.Models.StaffAccessControl> Select(string filter, params object[] parameters)
        {
            return new StaffAccessControlFactory().Select(filter, null, StaffAccessControlFactory.SelectView, new BusinessObjectParameters(parameters));
        }

        public static DatatecnixOfficerII.Models.StaffAccessControl SelectSingle(string filter, params object[] parameters)
        {
            return new StaffAccessControlFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }

        public static DatatecnixOfficerII.Models.StaffAccessControl SelectSingle(uint? staffUid)
        {
            return new StaffAccessControlFactory().SelectSingle(staffUid);
        }

        public int Insert()
        {
            return new StaffAccessControlFactory().Insert(this);
        }

        public int Update()
        {
            return new StaffAccessControlFactory().Update(this);
        }

        public int Delete()
        {
            return new StaffAccessControlFactory().Delete(this);
        }

        public override string ToString()
        {
            return string.Format("StaffUid: {0}", this.StaffUid);
        }

        public static DatatecnixOfficerII.Models.StaffAccessControl SelectSingle(object filter)
        {
            var paramList = new BusinessObjectParameters(filter);
            return SelectSingle(paramList.ToWhere(), paramList);
        }

        public static List<DatatecnixOfficerII.Models.StaffAccessControl> Select(object filter, string sort, string view)
        {
            var paramList = new BusinessObjectParameters(filter);
            return Select(paramList.ToWhere(), sort, view, paramList);
        }

        public static List<DatatecnixOfficerII.Models.StaffAccessControl> Select(object filter, string sort)
        {
            return Select(filter, sort, null);
        }

        public static List<DatatecnixOfficerII.Models.StaffAccessControl> Select(object filter)
        {
            return Select(filter, null);
        }

        public static DatatecnixOfficerII.Models.StaffAccessControl Insert(object initializer)
        {
            var instance = CreateInstance<DatatecnixOfficerII.Models.StaffAccessControl>(initializer);
            if (instance.Insert() == 0)
                return null;
            return instance;
        }

        public static List<DatatecnixOfficerII.Models.StaffAccessControl> SelectAll()
        {
            return SelectAll(null);
        }

        public static List<DatatecnixOfficerII.Models.StaffAccessControl> SelectAll(string sort)
        {
            return new DatatecnixOfficerII.Models.StaffAccessControlFactory().Select(null, sort, DatatecnixOfficerII.Models.StaffAccessControlFactory.SelectView, new BusinessObjectParameters());
        }
    }

    public partial class StaffAccessControlFactory
    {

        public StaffAccessControlFactory()
        {
        }

        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("StaffAccessControl");
            }
        }

        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("StaffAccessControl");
            }
        }

        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("StaffAccessControl");
            }
        }

        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("StaffAccessControl");
            }
        }

        public static StaffAccessControlFactory Create()
        {
            return new StaffAccessControlFactory();
        }

        public List<DatatecnixOfficerII.Models.StaffAccessControl> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }

        public List<DatatecnixOfficerII.Models.StaffAccessControl> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }

        public List<DatatecnixOfficerII.Models.StaffAccessControl> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
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
            var page = c.GetPage("StaffAccessControl", dataView, request);
            return page.ToList<DatatecnixOfficerII.Models.StaffAccessControl>();
        }

        public DatatecnixOfficerII.Models.StaffAccessControl SelectSingle(uint? staffUid)
        {
            var parameterMarker = SqlStatement.GetParameterMarker(string.Empty);
            var paramValues = new BusinessObjectParameters();
            paramValues[(parameterMarker + "objpk0")] = staffUid;
            return SelectSingle(string.Format("StaffUid={0}objpk0", parameterMarker), paramValues);
        }

        public DatatecnixOfficerII.Models.StaffAccessControl SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            var list = Select(filter, parameters);
            if (list.Count > 0)
                return list[0];
            return null;
        }

        protected virtual FieldValue[] CreateFieldValues(DatatecnixOfficerII.Models.StaffAccessControl theStaffAccessControl, DatatecnixOfficerII.Models.StaffAccessControl original_StaffAccessControl)
        {
            var values = new List<FieldValue>();
            values.Add(new FieldValue("StaffUid", original_StaffAccessControl.StaffUid, theStaffAccessControl.StaffUid, true));
            values.Add(new FieldValue("StaffCode", original_StaffAccessControl.StaffCode, theStaffAccessControl.StaffCode));
            values.Add(new FieldValue("StaffTitle", original_StaffAccessControl.StaffTitle, theStaffAccessControl.StaffTitle));
            values.Add(new FieldValue("Initials", original_StaffAccessControl.Initials, theStaffAccessControl.Initials));
            values.Add(new FieldValue("Forname", original_StaffAccessControl.Forname, theStaffAccessControl.Forname));
            values.Add(new FieldValue("Surname", original_StaffAccessControl.Surname, theStaffAccessControl.Surname));
            values.Add(new FieldValue("RankCode", original_StaffAccessControl.RankCode, theStaffAccessControl.RankCode));
            values.Add(new FieldValue("RankDesc", original_StaffAccessControl.RankDesc, theStaffAccessControl.RankDesc, true));
            values.Add(new FieldValue("RankStaffFilterstaffFilter", original_StaffAccessControl.RankStaffFilterstaffFilter, theStaffAccessControl.RankStaffFilterstaffFilter, true));
            values.Add(new FieldValue("EplNumber", original_StaffAccessControl.EplNumber, theStaffAccessControl.EplNumber));
            values.Add(new FieldValue("LocationCode", original_StaffAccessControl.LocationCode, theStaffAccessControl.LocationCode));
            values.Add(new FieldValue("LocationDesc", original_StaffAccessControl.LocationDesc, theStaffAccessControl.LocationDesc, true));
            values.Add(new FieldValue("LocationDefaultDeliveryLocationid", original_StaffAccessControl.LocationDefaultDeliveryLocationid, theStaffAccessControl.LocationDefaultDeliveryLocationid, true));
            values.Add(new FieldValue("LocationCatalogueid", original_StaffAccessControl.LocationCatalogueid, theStaffAccessControl.LocationCatalogueid, true));
            values.Add(new FieldValue("LocationStaffLocationCatalogueid", original_StaffAccessControl.LocationStaffLocationCatalogueid, theStaffAccessControl.LocationStaffLocationCatalogueid, true));
            values.Add(new FieldValue("LocationDivisionDesc", original_StaffAccessControl.LocationDivisionDesc, theStaffAccessControl.LocationDivisionDesc, true));
            values.Add(new FieldValue("LocationDivisionCompanyName", original_StaffAccessControl.LocationDivisionCompanyName, theStaffAccessControl.LocationDivisionCompanyName, true));
            values.Add(new FieldValue("LocationCompanyName", original_StaffAccessControl.LocationCompanyName, theStaffAccessControl.LocationCompanyName, true));
            values.Add(new FieldValue("LocationDefaultDeliveryLocationSlaAcc", original_StaffAccessControl.LocationDefaultDeliveryLocationSlaAcc, theStaffAccessControl.LocationDefaultDeliveryLocationSlaAcc, true));
            values.Add(new FieldValue("LocationBudgetIndbudgetDesc", original_StaffAccessControl.LocationBudgetIndbudgetDesc, theStaffAccessControl.LocationBudgetIndbudgetDesc, true));
            values.Add(new FieldValue("JoinDate", original_StaffAccessControl.JoinDate, theStaffAccessControl.JoinDate));
            values.Add(new FieldValue("LeaveDate", original_StaffAccessControl.LeaveDate, theStaffAccessControl.LeaveDate));
            values.Add(new FieldValue("Comments", original_StaffAccessControl.Comments, theStaffAccessControl.Comments));
            values.Add(new FieldValue("Email", original_StaffAccessControl.Email, theStaffAccessControl.Email));
            values.Add(new FieldValue("CompanyID", original_StaffAccessControl.CompanyID, theStaffAccessControl.CompanyID));
            values.Add(new FieldValue("CompanyName", original_StaffAccessControl.CompanyName, theStaffAccessControl.CompanyName, true));
            values.Add(new FieldValue("UserCredentials", original_StaffAccessControl.UserCredentials, theStaffAccessControl.UserCredentials));
            values.Add(new FieldValue("Telephone", original_StaffAccessControl.Telephone, theStaffAccessControl.Telephone));
            values.Add(new FieldValue("Internal", original_StaffAccessControl.Internal, theStaffAccessControl.Internal));
            values.Add(new FieldValue("OpexUser", original_StaffAccessControl.OpexUser, theStaffAccessControl.OpexUser));
            values.Add(new FieldValue("OpexUserName", original_StaffAccessControl.OpexUserName, theStaffAccessControl.OpexUserName));
            values.Add(new FieldValue("Gender", original_StaffAccessControl.Gender, theStaffAccessControl.Gender));
            values.Add(new FieldValue("Active", original_StaffAccessControl.Active, theStaffAccessControl.Active));
            values.Add(new FieldValue("RestrictAccess", original_StaffAccessControl.RestrictAccess, theStaffAccessControl.RestrictAccess));
            values.Add(new FieldValue("AccessControlType", original_StaffAccessControl.AccessControlType, theStaffAccessControl.AccessControlType));
            values.Add(new FieldValue("LocationCatalogueLocationCatalogue", original_StaffAccessControl.LocationCatalogueLocationCatalogue, theStaffAccessControl.LocationCatalogueLocationCatalogue, true));
            values.Add(new FieldValue("LocationCatalogueDescription", original_StaffAccessControl.LocationCatalogueDescription, theStaffAccessControl.LocationCatalogueDescription, true));
            return values.ToArray();
        }

        protected virtual int ExecuteAction(DatatecnixOfficerII.Models.StaffAccessControl theStaffAccessControl, DatatecnixOfficerII.Models.StaffAccessControl original_StaffAccessControl, string lastCommandName, string commandName, string dataView)
        {
            var args = new ActionArgs()
            {
                Controller = "StaffAccessControl",
                View = dataView,
                Values = CreateFieldValues(theStaffAccessControl, original_StaffAccessControl),
                LastCommandName = lastCommandName,
                CommandName = commandName
            };
            var result = ControllerFactory.CreateDataController().Execute("StaffAccessControl", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theStaffAccessControl);
            return result.RowsAffected;
        }

        public virtual int Update(DatatecnixOfficerII.Models.StaffAccessControl theStaffAccessControl, DatatecnixOfficerII.Models.StaffAccessControl original_StaffAccessControl)
        {
            return ExecuteAction(theStaffAccessControl, original_StaffAccessControl, "Edit", "Update", UpdateView);
        }

        public virtual int Update(DatatecnixOfficerII.Models.StaffAccessControl theStaffAccessControl)
        {
            return Update(theStaffAccessControl, SelectSingle(theStaffAccessControl.StaffUid));
        }

        public virtual int Insert(DatatecnixOfficerII.Models.StaffAccessControl theStaffAccessControl)
        {
            return ExecuteAction(theStaffAccessControl, new StaffAccessControl(), "New", "Insert", InsertView);
        }

        public virtual int Delete(DatatecnixOfficerII.Models.StaffAccessControl theStaffAccessControl)
        {
            return ExecuteAction(theStaffAccessControl, theStaffAccessControl, "Select", "Delete", DeleteView);
        }
    }
}
