using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using DatatecnixOfficerII.Data;

namespace DatatecnixOfficerII.Models
{
    public enum TrolleyLineLocationDataField
    {

        Rowid,

        ItemCode,

        ItemStiDesc,

        SizeCode,

        Qty,

        CommentCode,

        CommentDesc,

        LineValue,

        ReqItemCost,

        RequestedBy,

        RequestedbyStaffCode,

        RequestedbySurname,

        RequestedDate,

        LocationCode,

        Type,

        Description,

        AdditionalInformation,

        glCode,

        BudgetCode,

        Supplier,

        Local_Description,
    }

    public partial class TrolleyLineLocationModel : BusinessRulesObjectModel
    {

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _rowid;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _itemCode;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _itemStiDesc;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sizeCode;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _qty;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _commentCode;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _commentDesc;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _lineValue;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _reqItemCost;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private uint? _requestedBy;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _requestedbyStaffCode;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _requestedbySurname;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _requestedDate;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _locationCode;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _type;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _description;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _additionalInformation;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _glCode;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _budgetCode;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _supplier;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _local_Description;

        public TrolleyLineLocationModel()
        {
        }

        public TrolleyLineLocationModel(BusinessRules r) :
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

        public string ItemCode
        {
            get
            {
                return _itemCode;
            }
            set
            {
                _itemCode = value;
                UpdateFieldValue("ItemCode", value);
            }
        }

        public string ItemStiDesc
        {
            get
            {
                return _itemStiDesc;
            }
            set
            {
                _itemStiDesc = value;
                UpdateFieldValue("ItemStiDesc", value);
            }
        }

        public string SizeCode
        {
            get
            {
                return _sizeCode;
            }
            set
            {
                _sizeCode = value;
                UpdateFieldValue("SizeCode", value);
            }
        }

        public decimal? Qty
        {
            get
            {
                return _qty;
            }
            set
            {
                _qty = value;
                UpdateFieldValue("Qty", value);
            }
        }

        public string CommentCode
        {
            get
            {
                return _commentCode;
            }
            set
            {
                _commentCode = value;
                UpdateFieldValue("CommentCode", value);
            }
        }

        public string CommentDesc
        {
            get
            {
                return _commentDesc;
            }
            set
            {
                _commentDesc = value;
                UpdateFieldValue("CommentDesc", value);
            }
        }

        public decimal? LineValue
        {
            get
            {
                return _lineValue;
            }
            set
            {
                _lineValue = value;
                UpdateFieldValue("LineValue", value);
            }
        }

        public decimal? ReqItemCost
        {
            get
            {
                return _reqItemCost;
            }
            set
            {
                _reqItemCost = value;
                UpdateFieldValue("ReqItemCost", value);
            }
        }

        public uint? RequestedBy
        {
            get
            {
                return _requestedBy;
            }
            set
            {
                _requestedBy = value;
                UpdateFieldValue("RequestedBy", value);
            }
        }

        public string RequestedbyStaffCode
        {
            get
            {
                return _requestedbyStaffCode;
            }
            set
            {
                _requestedbyStaffCode = value;
                UpdateFieldValue("RequestedbyStaffCode", value);
            }
        }

        public string RequestedbySurname
        {
            get
            {
                return _requestedbySurname;
            }
            set
            {
                _requestedbySurname = value;
                UpdateFieldValue("RequestedbySurname", value);
            }
        }

        public DateTime? RequestedDate
        {
            get
            {
                return _requestedDate;
            }
            set
            {
                _requestedDate = value;
                UpdateFieldValue("RequestedDate", value);
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

        public string Type
        {
            get
            {
                return _type;
            }
            set
            {
                _type = value;
                UpdateFieldValue("Type", value);
            }
        }

        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
                UpdateFieldValue("Description", value);
            }
        }

        public string AdditionalInformation
        {
            get
            {
                return _additionalInformation;
            }
            set
            {
                _additionalInformation = value;
                UpdateFieldValue("AdditionalInformation", value);
            }
        }

        public string glCode
        {
            get
            {
                return _glCode;
            }
            set
            {
                _glCode = value;
                UpdateFieldValue("glCode", value);
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

        public string Supplier
        {
            get
            {
                return _supplier;
            }
            set
            {
                _supplier = value;
                UpdateFieldValue("Supplier", value);
            }
        }

        public string Local_Description
        {
            get
            {
                return _local_Description;
            }
            set
            {
                _local_Description = value;
                UpdateFieldValue("Local_Description", value);
            }
        }

        public FieldValue this[TrolleyLineLocationDataField field]
        {
            get
            {
                return this[field.ToString()];
            }
        }
    }

    public partial class TrolleyLineLocation : TrolleyLineLocationModel
    {

        public static List<DatatecnixOfficerII.Models.TrolleyLineLocation> Select(string filter, string sort, string dataView, params object[] parameters)
        {
            return new TrolleyLineLocationFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }

        public static List<DatatecnixOfficerII.Models.TrolleyLineLocation> Select(string filter, string sort, params object[] parameters)
        {
            return new TrolleyLineLocationFactory().Select(filter, sort, TrolleyLineLocationFactory.SelectView, new BusinessObjectParameters(parameters));
        }

        public static List<DatatecnixOfficerII.Models.TrolleyLineLocation> Select(string filter, params object[] parameters)
        {
            return new TrolleyLineLocationFactory().Select(filter, null, TrolleyLineLocationFactory.SelectView, new BusinessObjectParameters(parameters));
        }

        public static DatatecnixOfficerII.Models.TrolleyLineLocation SelectSingle(string filter, params object[] parameters)
        {
            return new TrolleyLineLocationFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }

        public static DatatecnixOfficerII.Models.TrolleyLineLocation SelectSingle(int? rowid)
        {
            return new TrolleyLineLocationFactory().SelectSingle(rowid);
        }

        public int Insert()
        {
            return new TrolleyLineLocationFactory().Insert(this);
        }

        public int Update()
        {
            return new TrolleyLineLocationFactory().Update(this);
        }

        public int Delete()
        {
            return new TrolleyLineLocationFactory().Delete(this);
        }

        public override string ToString()
        {
            return string.Format("Rowid: {0}", this.Rowid);
        }

        public static DatatecnixOfficerII.Models.TrolleyLineLocation SelectSingle(object filter)
        {
            var paramList = new BusinessObjectParameters(filter);
            return SelectSingle(paramList.ToWhere(), paramList);
        }

        public static List<DatatecnixOfficerII.Models.TrolleyLineLocation> Select(object filter, string sort, string view)
        {
            var paramList = new BusinessObjectParameters(filter);
            return Select(paramList.ToWhere(), sort, view, paramList);
        }

        public static List<DatatecnixOfficerII.Models.TrolleyLineLocation> Select(object filter, string sort)
        {
            return Select(filter, sort, null);
        }

        public static List<DatatecnixOfficerII.Models.TrolleyLineLocation> Select(object filter)
        {
            return Select(filter, null);
        }

        public static DatatecnixOfficerII.Models.TrolleyLineLocation Insert(object initializer)
        {
            var instance = CreateInstance<DatatecnixOfficerII.Models.TrolleyLineLocation>(initializer);
            if (instance.Insert() == 0)
                return null;
            return instance;
        }

        public static List<DatatecnixOfficerII.Models.TrolleyLineLocation> SelectAll()
        {
            return SelectAll(null);
        }

        public static List<DatatecnixOfficerII.Models.TrolleyLineLocation> SelectAll(string sort)
        {
            return new DatatecnixOfficerII.Models.TrolleyLineLocationFactory().Select(null, sort, DatatecnixOfficerII.Models.TrolleyLineLocationFactory.SelectView, new BusinessObjectParameters());
        }
    }

    public partial class TrolleyLineLocationFactory
    {

        public TrolleyLineLocationFactory()
        {
        }

        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("TrolleyLineLocation");
            }
        }

        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("TrolleyLineLocation");
            }
        }

        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("TrolleyLineLocation");
            }
        }

        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("TrolleyLineLocation");
            }
        }

        public static TrolleyLineLocationFactory Create()
        {
            return new TrolleyLineLocationFactory();
        }

        public List<DatatecnixOfficerII.Models.TrolleyLineLocation> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }

        public List<DatatecnixOfficerII.Models.TrolleyLineLocation> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }

        public List<DatatecnixOfficerII.Models.TrolleyLineLocation> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
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
            var page = c.GetPage("TrolleyLineLocation", dataView, request);
            return page.ToList<DatatecnixOfficerII.Models.TrolleyLineLocation>();
        }

        public DatatecnixOfficerII.Models.TrolleyLineLocation SelectSingle(int? rowid)
        {
            var parameterMarker = SqlStatement.GetParameterMarker(string.Empty);
            var paramValues = new BusinessObjectParameters();
            paramValues[(parameterMarker + "objpk0")] = rowid;
            return SelectSingle(string.Format("Rowid={0}objpk0", parameterMarker), paramValues);
        }

        public DatatecnixOfficerII.Models.TrolleyLineLocation SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            var list = Select(filter, parameters);
            if (list.Count > 0)
                return list[0];
            return null;
        }

        protected virtual FieldValue[] CreateFieldValues(DatatecnixOfficerII.Models.TrolleyLineLocation theTrolleyLineLocation, DatatecnixOfficerII.Models.TrolleyLineLocation original_TrolleyLineLocation)
        {
            var values = new List<FieldValue>();
            values.Add(new FieldValue("Rowid", original_TrolleyLineLocation.Rowid, theTrolleyLineLocation.Rowid, true));
            values.Add(new FieldValue("ItemCode", original_TrolleyLineLocation.ItemCode, theTrolleyLineLocation.ItemCode));
            values.Add(new FieldValue("ItemStiDesc", original_TrolleyLineLocation.ItemStiDesc, theTrolleyLineLocation.ItemStiDesc, true));
            values.Add(new FieldValue("SizeCode", original_TrolleyLineLocation.SizeCode, theTrolleyLineLocation.SizeCode));
            values.Add(new FieldValue("Qty", original_TrolleyLineLocation.Qty, theTrolleyLineLocation.Qty));
            values.Add(new FieldValue("CommentCode", original_TrolleyLineLocation.CommentCode, theTrolleyLineLocation.CommentCode));
            values.Add(new FieldValue("CommentDesc", original_TrolleyLineLocation.CommentDesc, theTrolleyLineLocation.CommentDesc, true));
            values.Add(new FieldValue("LineValue", original_TrolleyLineLocation.LineValue, theTrolleyLineLocation.LineValue));
            values.Add(new FieldValue("ReqItemCost", original_TrolleyLineLocation.ReqItemCost, theTrolleyLineLocation.ReqItemCost));
            values.Add(new FieldValue("RequestedBy", original_TrolleyLineLocation.RequestedBy, theTrolleyLineLocation.RequestedBy));
            values.Add(new FieldValue("RequestedbyStaffCode", original_TrolleyLineLocation.RequestedbyStaffCode, theTrolleyLineLocation.RequestedbyStaffCode, true));
            values.Add(new FieldValue("RequestedbySurname", original_TrolleyLineLocation.RequestedbySurname, theTrolleyLineLocation.RequestedbySurname, true));
            values.Add(new FieldValue("RequestedDate", original_TrolleyLineLocation.RequestedDate, theTrolleyLineLocation.RequestedDate));
            values.Add(new FieldValue("LocationCode", original_TrolleyLineLocation.LocationCode, theTrolleyLineLocation.LocationCode));
            values.Add(new FieldValue("Type", original_TrolleyLineLocation.Type, theTrolleyLineLocation.Type));
            values.Add(new FieldValue("Description", original_TrolleyLineLocation.Description, theTrolleyLineLocation.Description));
            values.Add(new FieldValue("AdditionalInformation", original_TrolleyLineLocation.AdditionalInformation, theTrolleyLineLocation.AdditionalInformation));
            values.Add(new FieldValue("glCode", original_TrolleyLineLocation.glCode, theTrolleyLineLocation.glCode));
            values.Add(new FieldValue("BudgetCode", original_TrolleyLineLocation.BudgetCode, theTrolleyLineLocation.BudgetCode));
            values.Add(new FieldValue("Supplier", original_TrolleyLineLocation.Supplier, theTrolleyLineLocation.Supplier));
            values.Add(new FieldValue("Local_Description", original_TrolleyLineLocation.Local_Description, theTrolleyLineLocation.Local_Description));
            return values.ToArray();
        }

        protected virtual int ExecuteAction(DatatecnixOfficerII.Models.TrolleyLineLocation theTrolleyLineLocation, DatatecnixOfficerII.Models.TrolleyLineLocation original_TrolleyLineLocation, string lastCommandName, string commandName, string dataView)
        {
            var args = new ActionArgs()
            {
                Controller = "TrolleyLineLocation",
                View = dataView,
                Values = CreateFieldValues(theTrolleyLineLocation, original_TrolleyLineLocation),
                LastCommandName = lastCommandName,
                CommandName = commandName
            };
            var result = ControllerFactory.CreateDataController().Execute("TrolleyLineLocation", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theTrolleyLineLocation);
            return result.RowsAffected;
        }

        public virtual int Update(DatatecnixOfficerII.Models.TrolleyLineLocation theTrolleyLineLocation, DatatecnixOfficerII.Models.TrolleyLineLocation original_TrolleyLineLocation)
        {
            return ExecuteAction(theTrolleyLineLocation, original_TrolleyLineLocation, "Edit", "Update", UpdateView);
        }

        public virtual int Update(DatatecnixOfficerII.Models.TrolleyLineLocation theTrolleyLineLocation)
        {
            return Update(theTrolleyLineLocation, SelectSingle(theTrolleyLineLocation.Rowid));
        }

        public virtual int Insert(DatatecnixOfficerII.Models.TrolleyLineLocation theTrolleyLineLocation)
        {
            return ExecuteAction(theTrolleyLineLocation, new TrolleyLineLocation(), "New", "Insert", InsertView);
        }

        public virtual int Delete(DatatecnixOfficerII.Models.TrolleyLineLocation theTrolleyLineLocation)
        {
            return ExecuteAction(theTrolleyLineLocation, theTrolleyLineLocation, "Select", "Delete", DeleteView);
        }
    }
}
