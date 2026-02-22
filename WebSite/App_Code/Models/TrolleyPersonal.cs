using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using DatatecnixOfficerII.Data;

namespace DatatecnixOfficerII.Models
{
    public enum TrolleyPersonalDataField
    {

        Rowid,

        DateRequired,

        StatusCode,

        HeaderValue,

        UrgentReq,

        Customer,

        DelCode,

        FreeText,

        JobNo,

        BudgetInd,

        BudgetIndbudgetDesc,

        DeliveryLocation,

        StaffUlocationCode,

        StaffuForname,

        StaffuSurname,

        StaffuRankCode,

        StaffuEmail,

        StaffuStaffCode,

        StaffUcompanyName,

        StaffUrankRankDesc,

        RoleID,

        RoleCostCentre,

        RoleStaffUlocationCode,

        RoleName,

        RoleLocationDesc,

        DelLocationID,

        DelLocationSlaAcc,

        DelLocationSlaNam,

        StaffUid,

        RoleRankDesc,

        StaffUlocationLocationDesc,

        DefaultCommentCode,

        DefaultCommentCodeCommentDesc,

        Local_TrolleyCount,

        Local_RoleDescription,

        LocalRankCode,

        LocalRankDescription,

        LocalBudgetCode,

        LocalLocation,

        LocalLocationCode,
    }

    public partial class TrolleyPersonalModel : BusinessRulesObjectModel
    {

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _rowid;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _dateRequired;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _statusCode;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _headerValue;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _urgentReq;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _customer;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _delCode;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _freeText;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _jobNo;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _budgetInd;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _budgetIndbudgetDesc;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _deliveryLocation;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _staffUlocationCode;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _staffuForname;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _staffuSurname;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _staffuRankCode;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _staffuEmail;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _staffuStaffCode;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _staffUcompanyName;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _staffUrankRankDesc;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _roleID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _roleCostCentre;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _roleStaffUlocationCode;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _roleName;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _roleLocationDesc;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private uint? _delLocationID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _delLocationSlaAcc;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _delLocationSlaNam;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private uint? _staffUid;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _roleRankDesc;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _staffUlocationLocationDesc;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _defaultCommentCode;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _defaultCommentCodeCommentDesc;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private uint? _local_TrolleyCount;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _local_RoleDescription;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _localRankCode;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _localRankDescription;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _localBudgetCode;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _localLocation;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _localLocationCode;

        public TrolleyPersonalModel()
        {
        }

        public TrolleyPersonalModel(BusinessRules r) :
                base(r)
        {
        }

        public int? Rowid
        {
            get
            {
                return _rowid;
            }
            set
            {
                _rowid = value;
                UpdateFieldValue("Rowid", value);
            }
        }

        public DateTime? DateRequired
        {
            get
            {
                return _dateRequired;
            }
            set
            {
                _dateRequired = value;
                UpdateFieldValue("DateRequired", value);
            }
        }

        public string StatusCode
        {
            get
            {
                return _statusCode;
            }
            set
            {
                _statusCode = value;
                UpdateFieldValue("StatusCode", value);
            }
        }

        public decimal? HeaderValue
        {
            get
            {
                return _headerValue;
            }
            set
            {
                _headerValue = value;
                UpdateFieldValue("HeaderValue", value);
            }
        }

        public string UrgentReq
        {
            get
            {
                return _urgentReq;
            }
            set
            {
                _urgentReq = value;
                UpdateFieldValue("UrgentReq", value);
            }
        }

        public string Customer
        {
            get
            {
                return _customer;
            }
            set
            {
                _customer = value;
                UpdateFieldValue("Customer", value);
            }
        }

        public string DelCode
        {
            get
            {
                return _delCode;
            }
            set
            {
                _delCode = value;
                UpdateFieldValue("DelCode", value);
            }
        }

        public string FreeText
        {
            get
            {
                return _freeText;
            }
            set
            {
                _freeText = value;
                UpdateFieldValue("FreeText", value);
            }
        }

        public string JobNo
        {
            get
            {
                return _jobNo;
            }
            set
            {
                _jobNo = value;
                UpdateFieldValue("JobNo", value);
            }
        }

        public string BudgetInd
        {
            get
            {
                return _budgetInd;
            }
            set
            {
                _budgetInd = value;
                UpdateFieldValue("BudgetInd", value);
            }
        }

        public string BudgetIndbudgetDesc
        {
            get
            {
                return _budgetIndbudgetDesc;
            }
            set
            {
                _budgetIndbudgetDesc = value;
                UpdateFieldValue("BudgetIndbudgetDesc", value);
            }
        }

        public string DeliveryLocation
        {
            get
            {
                return _deliveryLocation;
            }
            set
            {
                _deliveryLocation = value;
                UpdateFieldValue("DeliveryLocation", value);
            }
        }

        public string StaffUlocationCode
        {
            get
            {
                return _staffUlocationCode;
            }
            set
            {
                _staffUlocationCode = value;
                UpdateFieldValue("StaffUlocationCode", value);
            }
        }

        public string StaffuForname
        {
            get
            {
                return _staffuForname;
            }
            set
            {
                _staffuForname = value;
                UpdateFieldValue("StaffuForname", value);
            }
        }

        public string StaffuSurname
        {
            get
            {
                return _staffuSurname;
            }
            set
            {
                _staffuSurname = value;
                UpdateFieldValue("StaffuSurname", value);
            }
        }

        public string StaffuRankCode
        {
            get
            {
                return _staffuRankCode;
            }
            set
            {
                _staffuRankCode = value;
                UpdateFieldValue("StaffuRankCode", value);
            }
        }

        public string StaffuEmail
        {
            get
            {
                return _staffuEmail;
            }
            set
            {
                _staffuEmail = value;
                UpdateFieldValue("StaffuEmail", value);
            }
        }

        public string StaffuStaffCode
        {
            get
            {
                return _staffuStaffCode;
            }
            set
            {
                _staffuStaffCode = value;
                UpdateFieldValue("StaffuStaffCode", value);
            }
        }

        public string StaffUcompanyName
        {
            get
            {
                return _staffUcompanyName;
            }
            set
            {
                _staffUcompanyName = value;
                UpdateFieldValue("StaffUcompanyName", value);
            }
        }

        public string StaffUrankRankDesc
        {
            get
            {
                return _staffUrankRankDesc;
            }
            set
            {
                _staffUrankRankDesc = value;
                UpdateFieldValue("StaffUrankRankDesc", value);
            }
        }

        public int? RoleID
        {
            get
            {
                return _roleID;
            }
            set
            {
                _roleID = value;
                UpdateFieldValue("RoleID", value);
            }
        }

        public string RoleCostCentre
        {
            get
            {
                return _roleCostCentre;
            }
            set
            {
                _roleCostCentre = value;
                UpdateFieldValue("RoleCostCentre", value);
            }
        }

        public string RoleStaffUlocationCode
        {
            get
            {
                return _roleStaffUlocationCode;
            }
            set
            {
                _roleStaffUlocationCode = value;
                UpdateFieldValue("RoleStaffUlocationCode", value);
            }
        }

        public string RoleName
        {
            get
            {
                return _roleName;
            }
            set
            {
                _roleName = value;
                UpdateFieldValue("RoleName", value);
            }
        }

        public string RoleLocationDesc
        {
            get
            {
                return _roleLocationDesc;
            }
            set
            {
                _roleLocationDesc = value;
                UpdateFieldValue("RoleLocationDesc", value);
            }
        }

        public uint? DelLocationID
        {
            get
            {
                return _delLocationID;
            }
            set
            {
                _delLocationID = value;
                UpdateFieldValue("DelLocationID", value);
            }
        }

        public string DelLocationSlaAcc
        {
            get
            {
                return _delLocationSlaAcc;
            }
            set
            {
                _delLocationSlaAcc = value;
                UpdateFieldValue("DelLocationSlaAcc", value);
            }
        }

        public string DelLocationSlaNam
        {
            get
            {
                return _delLocationSlaNam;
            }
            set
            {
                _delLocationSlaNam = value;
                UpdateFieldValue("DelLocationSlaNam", value);
            }
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

        public string RoleRankDesc
        {
            get
            {
                return _roleRankDesc;
            }
            set
            {
                _roleRankDesc = value;
                UpdateFieldValue("RoleRankDesc", value);
            }
        }

        public string StaffUlocationLocationDesc
        {
            get
            {
                return _staffUlocationLocationDesc;
            }
            set
            {
                _staffUlocationLocationDesc = value;
                UpdateFieldValue("StaffUlocationLocationDesc", value);
            }
        }

        public string DefaultCommentCode
        {
            get
            {
                return _defaultCommentCode;
            }
            set
            {
                _defaultCommentCode = value;
                UpdateFieldValue("DefaultCommentCode", value);
            }
        }

        public string DefaultCommentCodeCommentDesc
        {
            get
            {
                return _defaultCommentCodeCommentDesc;
            }
            set
            {
                _defaultCommentCodeCommentDesc = value;
                UpdateFieldValue("DefaultCommentCodeCommentDesc", value);
            }
        }

        public uint? Local_TrolleyCount
        {
            get
            {
                return _local_TrolleyCount;
            }
            set
            {
                _local_TrolleyCount = value;
                UpdateFieldValue("Local_TrolleyCount", value);
            }
        }

        public string Local_RoleDescription
        {
            get
            {
                return _local_RoleDescription;
            }
            set
            {
                _local_RoleDescription = value;
                UpdateFieldValue("Local_RoleDescription", value);
            }
        }

        public string LocalRankCode
        {
            get
            {
                return _localRankCode;
            }
            set
            {
                _localRankCode = value;
                UpdateFieldValue("LocalRankCode", value);
            }
        }

        public string LocalRankDescription
        {
            get
            {
                return _localRankDescription;
            }
            set
            {
                _localRankDescription = value;
                UpdateFieldValue("LocalRankDescription", value);
            }
        }

        public string LocalBudgetCode
        {
            get
            {
                return _localBudgetCode;
            }
            set
            {
                _localBudgetCode = value;
                UpdateFieldValue("LocalBudgetCode", value);
            }
        }

        public string LocalLocation
        {
            get
            {
                return _localLocation;
            }
            set
            {
                _localLocation = value;
                UpdateFieldValue("LocalLocation", value);
            }
        }

        public string LocalLocationCode
        {
            get
            {
                return _localLocationCode;
            }
            set
            {
                _localLocationCode = value;
                UpdateFieldValue("LocalLocationCode", value);
            }
        }

        public FieldValue this[TrolleyPersonalDataField field]
        {
            get
            {
                return this[field.ToString()];
            }
        }
    }

    public partial class TrolleyPersonal : TrolleyPersonalModel
    {

        public static List<DatatecnixOfficerII.Models.TrolleyPersonal> Select(string filter, string sort, string dataView, params object[] parameters)
        {
            return new TrolleyPersonalFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }

        public static List<DatatecnixOfficerII.Models.TrolleyPersonal> Select(string filter, string sort, params object[] parameters)
        {
            return new TrolleyPersonalFactory().Select(filter, sort, TrolleyPersonalFactory.SelectView, new BusinessObjectParameters(parameters));
        }

        public static List<DatatecnixOfficerII.Models.TrolleyPersonal> Select(string filter, params object[] parameters)
        {
            return new TrolleyPersonalFactory().Select(filter, null, TrolleyPersonalFactory.SelectView, new BusinessObjectParameters(parameters));
        }

        public static DatatecnixOfficerII.Models.TrolleyPersonal SelectSingle(string filter, params object[] parameters)
        {
            return new TrolleyPersonalFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }

        public static DatatecnixOfficerII.Models.TrolleyPersonal SelectSingle(int? rowid)
        {
            return new TrolleyPersonalFactory().SelectSingle(rowid);
        }

        public int Insert()
        {
            return new TrolleyPersonalFactory().Insert(this);
        }

        public int Update()
        {
            return new TrolleyPersonalFactory().Update(this);
        }

        public int Delete()
        {
            return new TrolleyPersonalFactory().Delete(this);
        }

        public override string ToString()
        {
            return string.Format("Rowid: {0}", this.Rowid);
        }

        public static DatatecnixOfficerII.Models.TrolleyPersonal SelectSingle(object filter)
        {
            var paramList = new BusinessObjectParameters(filter);
            return SelectSingle(paramList.ToWhere(), paramList);
        }

        public static List<DatatecnixOfficerII.Models.TrolleyPersonal> Select(object filter, string sort, string view)
        {
            var paramList = new BusinessObjectParameters(filter);
            return Select(paramList.ToWhere(), sort, view, paramList);
        }

        public static List<DatatecnixOfficerII.Models.TrolleyPersonal> Select(object filter, string sort)
        {
            return Select(filter, sort, null);
        }

        public static List<DatatecnixOfficerII.Models.TrolleyPersonal> Select(object filter)
        {
            return Select(filter, null);
        }

        public static DatatecnixOfficerII.Models.TrolleyPersonal Insert(object initializer)
        {
            var instance = CreateInstance<DatatecnixOfficerII.Models.TrolleyPersonal>(initializer);
            if (instance.Insert() == 0)
                return null;
            return instance;
        }

        public static List<DatatecnixOfficerII.Models.TrolleyPersonal> SelectAll()
        {
            return SelectAll(null);
        }

        public static List<DatatecnixOfficerII.Models.TrolleyPersonal> SelectAll(string sort)
        {
            return new DatatecnixOfficerII.Models.TrolleyPersonalFactory().Select(null, sort, DatatecnixOfficerII.Models.TrolleyPersonalFactory.SelectView, new BusinessObjectParameters());
        }
    }

    public partial class TrolleyPersonalFactory
    {

        public TrolleyPersonalFactory()
        {
        }

        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("TrolleyPersonal");
            }
        }

        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("TrolleyPersonal");
            }
        }

        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("TrolleyPersonal");
            }
        }

        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("TrolleyPersonal");
            }
        }

        public static TrolleyPersonalFactory Create()
        {
            return new TrolleyPersonalFactory();
        }

        public List<DatatecnixOfficerII.Models.TrolleyPersonal> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }

        public List<DatatecnixOfficerII.Models.TrolleyPersonal> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }

        public List<DatatecnixOfficerII.Models.TrolleyPersonal> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
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
            var page = c.GetPage("TrolleyPersonal", dataView, request);
            return page.ToList<DatatecnixOfficerII.Models.TrolleyPersonal>();
        }

        public DatatecnixOfficerII.Models.TrolleyPersonal SelectSingle(int? rowid)
        {
            var parameterMarker = SqlStatement.GetParameterMarker(string.Empty);
            var paramValues = new BusinessObjectParameters();
            paramValues[(parameterMarker + "objpk0")] = rowid;
            return SelectSingle(string.Format("Rowid={0}objpk0", parameterMarker), paramValues);
        }

        public DatatecnixOfficerII.Models.TrolleyPersonal SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            var list = Select(filter, parameters);
            if (list.Count > 0)
                return list[0];
            return null;
        }

        protected virtual FieldValue[] CreateFieldValues(DatatecnixOfficerII.Models.TrolleyPersonal theTrolleyPersonal, DatatecnixOfficerII.Models.TrolleyPersonal original_TrolleyPersonal)
        {
            var values = new List<FieldValue>();
            values.Add(new FieldValue("Rowid", original_TrolleyPersonal.Rowid, theTrolleyPersonal.Rowid, true));
            values.Add(new FieldValue("DateRequired", original_TrolleyPersonal.DateRequired, theTrolleyPersonal.DateRequired));
            values.Add(new FieldValue("StatusCode", original_TrolleyPersonal.StatusCode, theTrolleyPersonal.StatusCode));
            values.Add(new FieldValue("HeaderValue", original_TrolleyPersonal.HeaderValue, theTrolleyPersonal.HeaderValue));
            values.Add(new FieldValue("UrgentReq", original_TrolleyPersonal.UrgentReq, theTrolleyPersonal.UrgentReq));
            values.Add(new FieldValue("Customer", original_TrolleyPersonal.Customer, theTrolleyPersonal.Customer));
            values.Add(new FieldValue("DelCode", original_TrolleyPersonal.DelCode, theTrolleyPersonal.DelCode));
            values.Add(new FieldValue("FreeText", original_TrolleyPersonal.FreeText, theTrolleyPersonal.FreeText));
            values.Add(new FieldValue("JobNo", original_TrolleyPersonal.JobNo, theTrolleyPersonal.JobNo));
            values.Add(new FieldValue("BudgetInd", original_TrolleyPersonal.BudgetInd, theTrolleyPersonal.BudgetInd));
            values.Add(new FieldValue("BudgetIndbudgetDesc", original_TrolleyPersonal.BudgetIndbudgetDesc, theTrolleyPersonal.BudgetIndbudgetDesc, true));
            values.Add(new FieldValue("DeliveryLocation", original_TrolleyPersonal.DeliveryLocation, theTrolleyPersonal.DeliveryLocation));
            values.Add(new FieldValue("StaffUlocationCode", original_TrolleyPersonal.StaffUlocationCode, theTrolleyPersonal.StaffUlocationCode, true));
            values.Add(new FieldValue("StaffuForname", original_TrolleyPersonal.StaffuForname, theTrolleyPersonal.StaffuForname, true));
            values.Add(new FieldValue("StaffuSurname", original_TrolleyPersonal.StaffuSurname, theTrolleyPersonal.StaffuSurname, true));
            values.Add(new FieldValue("StaffuRankCode", original_TrolleyPersonal.StaffuRankCode, theTrolleyPersonal.StaffuRankCode, true));
            values.Add(new FieldValue("StaffuEmail", original_TrolleyPersonal.StaffuEmail, theTrolleyPersonal.StaffuEmail, true));
            values.Add(new FieldValue("StaffuStaffCode", original_TrolleyPersonal.StaffuStaffCode, theTrolleyPersonal.StaffuStaffCode, true));
            values.Add(new FieldValue("StaffUcompanyName", original_TrolleyPersonal.StaffUcompanyName, theTrolleyPersonal.StaffUcompanyName, true));
            values.Add(new FieldValue("StaffUrankRankDesc", original_TrolleyPersonal.StaffUrankRankDesc, theTrolleyPersonal.StaffUrankRankDesc, true));
            values.Add(new FieldValue("RoleID", original_TrolleyPersonal.RoleID, theTrolleyPersonal.RoleID));
            values.Add(new FieldValue("RoleCostCentre", original_TrolleyPersonal.RoleCostCentre, theTrolleyPersonal.RoleCostCentre, true));
            values.Add(new FieldValue("RoleStaffUlocationCode", original_TrolleyPersonal.RoleStaffUlocationCode, theTrolleyPersonal.RoleStaffUlocationCode, true));
            values.Add(new FieldValue("RoleName", original_TrolleyPersonal.RoleName, theTrolleyPersonal.RoleName, true));
            values.Add(new FieldValue("RoleLocationDesc", original_TrolleyPersonal.RoleLocationDesc, theTrolleyPersonal.RoleLocationDesc, true));
            values.Add(new FieldValue("DelLocationID", original_TrolleyPersonal.DelLocationID, theTrolleyPersonal.DelLocationID));
            values.Add(new FieldValue("DelLocationSlaAcc", original_TrolleyPersonal.DelLocationSlaAcc, theTrolleyPersonal.DelLocationSlaAcc, true));
            values.Add(new FieldValue("DelLocationSlaNam", original_TrolleyPersonal.DelLocationSlaNam, theTrolleyPersonal.DelLocationSlaNam, true));
            values.Add(new FieldValue("StaffUid", original_TrolleyPersonal.StaffUid, theTrolleyPersonal.StaffUid, true));
            values.Add(new FieldValue("RoleRankDesc", original_TrolleyPersonal.RoleRankDesc, theTrolleyPersonal.RoleRankDesc, true));
            values.Add(new FieldValue("StaffUlocationLocationDesc", original_TrolleyPersonal.StaffUlocationLocationDesc, theTrolleyPersonal.StaffUlocationLocationDesc, true));
            values.Add(new FieldValue("DefaultCommentCode", original_TrolleyPersonal.DefaultCommentCode, theTrolleyPersonal.DefaultCommentCode));
            values.Add(new FieldValue("DefaultCommentCodeCommentDesc", original_TrolleyPersonal.DefaultCommentCodeCommentDesc, theTrolleyPersonal.DefaultCommentCodeCommentDesc, true));
            values.Add(new FieldValue("Local_TrolleyCount", original_TrolleyPersonal.Local_TrolleyCount, theTrolleyPersonal.Local_TrolleyCount));
            values.Add(new FieldValue("Local_RoleDescription", original_TrolleyPersonal.Local_RoleDescription, theTrolleyPersonal.Local_RoleDescription));
            values.Add(new FieldValue("LocalRankCode", original_TrolleyPersonal.LocalRankCode, theTrolleyPersonal.LocalRankCode, true));
            values.Add(new FieldValue("LocalRankDescription", original_TrolleyPersonal.LocalRankDescription, theTrolleyPersonal.LocalRankDescription, true));
            values.Add(new FieldValue("LocalBudgetCode", original_TrolleyPersonal.LocalBudgetCode, theTrolleyPersonal.LocalBudgetCode, true));
            values.Add(new FieldValue("LocalLocation", original_TrolleyPersonal.LocalLocation, theTrolleyPersonal.LocalLocation));
            values.Add(new FieldValue("LocalLocationCode", original_TrolleyPersonal.LocalLocationCode, theTrolleyPersonal.LocalLocationCode));
            return values.ToArray();
        }

        protected virtual int ExecuteAction(DatatecnixOfficerII.Models.TrolleyPersonal theTrolleyPersonal, DatatecnixOfficerII.Models.TrolleyPersonal original_TrolleyPersonal, string lastCommandName, string commandName, string dataView)
        {
            var args = new ActionArgs()
            {
                Controller = "TrolleyPersonal",
                View = dataView,
                Values = CreateFieldValues(theTrolleyPersonal, original_TrolleyPersonal),
                LastCommandName = lastCommandName,
                CommandName = commandName
            };
            var result = ControllerFactory.CreateDataController().Execute("TrolleyPersonal", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theTrolleyPersonal);
            return result.RowsAffected;
        }

        public virtual int Update(DatatecnixOfficerII.Models.TrolleyPersonal theTrolleyPersonal, DatatecnixOfficerII.Models.TrolleyPersonal original_TrolleyPersonal)
        {
            return ExecuteAction(theTrolleyPersonal, original_TrolleyPersonal, "Edit", "Update", UpdateView);
        }

        public virtual int Update(DatatecnixOfficerII.Models.TrolleyPersonal theTrolleyPersonal)
        {
            return Update(theTrolleyPersonal, SelectSingle(theTrolleyPersonal.Rowid));
        }

        public virtual int Insert(DatatecnixOfficerII.Models.TrolleyPersonal theTrolleyPersonal)
        {
            return ExecuteAction(theTrolleyPersonal, new TrolleyPersonal(), "New", "Insert", InsertView);
        }

        public virtual int Delete(DatatecnixOfficerII.Models.TrolleyPersonal theTrolleyPersonal)
        {
            return ExecuteAction(theTrolleyPersonal, theTrolleyPersonal, "Select", "Delete", DeleteView);
        }
    }
}
