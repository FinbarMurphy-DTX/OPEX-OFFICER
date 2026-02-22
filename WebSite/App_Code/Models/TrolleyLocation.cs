using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using DatatecnixOfficerII.Data;

namespace DatatecnixOfficerII.Models
{
    public enum TrolleyLocationDataField
    {

        DateRequired,

        StatusCode,

        HeaderValue,

        UrgentReq,

        FreeText,

        BudgetCode,

        BudgetDesc,

        DelLocationID,

        DelLocationSlaAcc,

        DelLocationSlaNam,

        DefaultCommentCode,

        DefaultCommentDesc,

        LocationCode,

        LocationCode1,

        Email,

        Rowid,

        Local_TrolleyCount,
    }

    public partial class TrolleyLocationModel : BusinessRulesObjectModel
    {

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _dateRequired;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _statusCode;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _headerValue;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _urgentReq;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _freeText;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _budgetCode;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _budgetDesc;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private uint? _delLocationID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _delLocationSlaAcc;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _delLocationSlaNam;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _defaultCommentCode;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _defaultCommentDesc;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _locationCode;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _locationCode1;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _email;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private uint? _rowid;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private uint? _local_TrolleyCount;

        public TrolleyLocationModel()
        {
        }

        public TrolleyLocationModel(BusinessRules r) :
                base(r)
        {
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

        public string BudgetCode
        {
            get
            {
                return _budgetCode;
            }
            set
            {
                _budgetCode = value;
                UpdateFieldValue("BudgetCode", value);
            }
        }

        public string BudgetDesc
        {
            get
            {
                return _budgetDesc;
            }
            set
            {
                _budgetDesc = value;
                UpdateFieldValue("BudgetDesc", value);
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

        public string DefaultCommentDesc
        {
            get
            {
                return _defaultCommentDesc;
            }
            set
            {
                _defaultCommentDesc = value;
                UpdateFieldValue("DefaultCommentDesc", value);
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

        public string LocationCode1
        {
            get
            {
                return _locationCode1;
            }
            set
            {
                _locationCode1 = value;
                UpdateFieldValue("LocationCode1", value);
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

        public uint? Rowid
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

        public FieldValue this[TrolleyLocationDataField field]
        {
            get
            {
                return this[field.ToString()];
            }
        }
    }

    public partial class TrolleyLocation : TrolleyLocationModel
    {

        public static List<DatatecnixOfficerII.Models.TrolleyLocation> Select(string filter, string sort, string dataView, params object[] parameters)
        {
            return new TrolleyLocationFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }

        public static List<DatatecnixOfficerII.Models.TrolleyLocation> Select(string filter, string sort, params object[] parameters)
        {
            return new TrolleyLocationFactory().Select(filter, sort, TrolleyLocationFactory.SelectView, new BusinessObjectParameters(parameters));
        }

        public static List<DatatecnixOfficerII.Models.TrolleyLocation> Select(string filter, params object[] parameters)
        {
            return new TrolleyLocationFactory().Select(filter, null, TrolleyLocationFactory.SelectView, new BusinessObjectParameters(parameters));
        }

        public static DatatecnixOfficerII.Models.TrolleyLocation SelectSingle(string filter, params object[] parameters)
        {
            return new TrolleyLocationFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }

        public static DatatecnixOfficerII.Models.TrolleyLocation SelectSingle(uint? rowid)
        {
            return new TrolleyLocationFactory().SelectSingle(rowid);
        }

        public int Insert()
        {
            return new TrolleyLocationFactory().Insert(this);
        }

        public int Update()
        {
            return new TrolleyLocationFactory().Update(this);
        }

        public int Delete()
        {
            return new TrolleyLocationFactory().Delete(this);
        }

        public override string ToString()
        {
            return string.Format("Rowid: {0}", this.Rowid);
        }

        public static DatatecnixOfficerII.Models.TrolleyLocation SelectSingle(object filter)
        {
            var paramList = new BusinessObjectParameters(filter);
            return SelectSingle(paramList.ToWhere(), paramList);
        }

        public static List<DatatecnixOfficerII.Models.TrolleyLocation> Select(object filter, string sort, string view)
        {
            var paramList = new BusinessObjectParameters(filter);
            return Select(paramList.ToWhere(), sort, view, paramList);
        }

        public static List<DatatecnixOfficerII.Models.TrolleyLocation> Select(object filter, string sort)
        {
            return Select(filter, sort, null);
        }

        public static List<DatatecnixOfficerII.Models.TrolleyLocation> Select(object filter)
        {
            return Select(filter, null);
        }

        public static DatatecnixOfficerII.Models.TrolleyLocation Insert(object initializer)
        {
            var instance = CreateInstance<DatatecnixOfficerII.Models.TrolleyLocation>(initializer);
            if (instance.Insert() == 0)
                return null;
            return instance;
        }

        public static List<DatatecnixOfficerII.Models.TrolleyLocation> SelectAll()
        {
            return SelectAll(null);
        }

        public static List<DatatecnixOfficerII.Models.TrolleyLocation> SelectAll(string sort)
        {
            return new DatatecnixOfficerII.Models.TrolleyLocationFactory().Select(null, sort, DatatecnixOfficerII.Models.TrolleyLocationFactory.SelectView, new BusinessObjectParameters());
        }
    }

    public partial class TrolleyLocationFactory
    {

        public TrolleyLocationFactory()
        {
        }

        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("TrolleyLocation");
            }
        }

        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("TrolleyLocation");
            }
        }

        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("TrolleyLocation");
            }
        }

        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("TrolleyLocation");
            }
        }

        public static TrolleyLocationFactory Create()
        {
            return new TrolleyLocationFactory();
        }

        public List<DatatecnixOfficerII.Models.TrolleyLocation> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }

        public List<DatatecnixOfficerII.Models.TrolleyLocation> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }

        public List<DatatecnixOfficerII.Models.TrolleyLocation> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
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
            var page = c.GetPage("TrolleyLocation", dataView, request);
            return page.ToList<DatatecnixOfficerII.Models.TrolleyLocation>();
        }

        public DatatecnixOfficerII.Models.TrolleyLocation SelectSingle(uint? rowid)
        {
            var parameterMarker = SqlStatement.GetParameterMarker(string.Empty);
            var paramValues = new BusinessObjectParameters();
            paramValues[(parameterMarker + "objpk0")] = rowid;
            return SelectSingle(string.Format("Rowid={0}objpk0", parameterMarker), paramValues);
        }

        public DatatecnixOfficerII.Models.TrolleyLocation SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            var list = Select(filter, parameters);
            if (list.Count > 0)
                return list[0];
            return null;
        }

        protected virtual FieldValue[] CreateFieldValues(DatatecnixOfficerII.Models.TrolleyLocation theTrolleyLocation, DatatecnixOfficerII.Models.TrolleyLocation original_TrolleyLocation)
        {
            var values = new List<FieldValue>();
            values.Add(new FieldValue("DateRequired", original_TrolleyLocation.DateRequired, theTrolleyLocation.DateRequired));
            values.Add(new FieldValue("StatusCode", original_TrolleyLocation.StatusCode, theTrolleyLocation.StatusCode));
            values.Add(new FieldValue("HeaderValue", original_TrolleyLocation.HeaderValue, theTrolleyLocation.HeaderValue, true));
            values.Add(new FieldValue("UrgentReq", original_TrolleyLocation.UrgentReq, theTrolleyLocation.UrgentReq));
            values.Add(new FieldValue("FreeText", original_TrolleyLocation.FreeText, theTrolleyLocation.FreeText));
            values.Add(new FieldValue("BudgetCode", original_TrolleyLocation.BudgetCode, theTrolleyLocation.BudgetCode));
            values.Add(new FieldValue("BudgetDesc", original_TrolleyLocation.BudgetDesc, theTrolleyLocation.BudgetDesc, true));
            values.Add(new FieldValue("DelLocationID", original_TrolleyLocation.DelLocationID, theTrolleyLocation.DelLocationID));
            values.Add(new FieldValue("DelLocationSlaAcc", original_TrolleyLocation.DelLocationSlaAcc, theTrolleyLocation.DelLocationSlaAcc, true));
            values.Add(new FieldValue("DelLocationSlaNam", original_TrolleyLocation.DelLocationSlaNam, theTrolleyLocation.DelLocationSlaNam, true));
            values.Add(new FieldValue("DefaultCommentCode", original_TrolleyLocation.DefaultCommentCode, theTrolleyLocation.DefaultCommentCode));
            values.Add(new FieldValue("DefaultCommentDesc", original_TrolleyLocation.DefaultCommentDesc, theTrolleyLocation.DefaultCommentDesc, true));
            values.Add(new FieldValue("LocationCode", original_TrolleyLocation.LocationCode, theTrolleyLocation.LocationCode, true));
            values.Add(new FieldValue("LocationCode1", original_TrolleyLocation.LocationCode1, theTrolleyLocation.LocationCode1, true));
            values.Add(new FieldValue("Email", original_TrolleyLocation.Email, theTrolleyLocation.Email));
            values.Add(new FieldValue("Rowid", original_TrolleyLocation.Rowid, theTrolleyLocation.Rowid, true));
            values.Add(new FieldValue("Local_TrolleyCount", original_TrolleyLocation.Local_TrolleyCount, theTrolleyLocation.Local_TrolleyCount));
            return values.ToArray();
        }

        protected virtual int ExecuteAction(DatatecnixOfficerII.Models.TrolleyLocation theTrolleyLocation, DatatecnixOfficerII.Models.TrolleyLocation original_TrolleyLocation, string lastCommandName, string commandName, string dataView)
        {
            var args = new ActionArgs()
            {
                Controller = "TrolleyLocation",
                View = dataView,
                Values = CreateFieldValues(theTrolleyLocation, original_TrolleyLocation),
                LastCommandName = lastCommandName,
                CommandName = commandName
            };
            var result = ControllerFactory.CreateDataController().Execute("TrolleyLocation", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theTrolleyLocation);
            return result.RowsAffected;
        }

        public virtual int Update(DatatecnixOfficerII.Models.TrolleyLocation theTrolleyLocation, DatatecnixOfficerII.Models.TrolleyLocation original_TrolleyLocation)
        {
            return ExecuteAction(theTrolleyLocation, original_TrolleyLocation, "Edit", "Update", UpdateView);
        }

        public virtual int Update(DatatecnixOfficerII.Models.TrolleyLocation theTrolleyLocation)
        {
            return Update(theTrolleyLocation, SelectSingle(theTrolleyLocation.Rowid));
        }

        public virtual int Insert(DatatecnixOfficerII.Models.TrolleyLocation theTrolleyLocation)
        {
            return ExecuteAction(theTrolleyLocation, new TrolleyLocation(), "New", "Insert", InsertView);
        }

        public virtual int Delete(DatatecnixOfficerII.Models.TrolleyLocation theTrolleyLocation)
        {
            return ExecuteAction(theTrolleyLocation, theTrolleyLocation, "Select", "Delete", DeleteView);
        }
    }
}
