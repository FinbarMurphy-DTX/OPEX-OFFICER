using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using DatatecnixOfficerII.Data;

namespace DatatecnixOfficerII.Models
{
    public enum TrolleyLinePersonalDataField
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

        UpdateStaffProfile,

        StaffUid,

        Type,

        Description,

        AdditionalInformation,

        glCode,

        BudgetCode,

        Supplier,

        Local_StaffProfileSize,

        Local_Description,
    }

    public partial class TrolleyLinePersonalModel : BusinessRulesObjectModel
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
        private string _updateStaffProfile;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private uint? _staffUid;

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
        private string _local_StaffProfileSize;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _local_Description;

        public TrolleyLinePersonalModel()
        {
        }

        public TrolleyLinePersonalModel(BusinessRules r) :
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

        public string UpdateStaffProfile
        {
            get
            {
                return _updateStaffProfile;
            }
            set
            {
                _updateStaffProfile = value;
                UpdateFieldValue("UpdateStaffProfile", value);
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

        public string Local_StaffProfileSize
        {
            get
            {
                return _local_StaffProfileSize;
            }
            set
            {
                _local_StaffProfileSize = value;
                UpdateFieldValue("Local_StaffProfileSize", value);
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

        public FieldValue this[TrolleyLinePersonalDataField field]
        {
            get
            {
                return this[field.ToString()];
            }
        }
    }

    public partial class TrolleyLinePersonal : TrolleyLinePersonalModel
    {

        public static List<DatatecnixOfficerII.Models.TrolleyLinePersonal> Select(string filter, string sort, string dataView, params object[] parameters)
        {
            return new TrolleyLinePersonalFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }

        public static List<DatatecnixOfficerII.Models.TrolleyLinePersonal> Select(string filter, string sort, params object[] parameters)
        {
            return new TrolleyLinePersonalFactory().Select(filter, sort, TrolleyLinePersonalFactory.SelectView, new BusinessObjectParameters(parameters));
        }

        public static List<DatatecnixOfficerII.Models.TrolleyLinePersonal> Select(string filter, params object[] parameters)
        {
            return new TrolleyLinePersonalFactory().Select(filter, null, TrolleyLinePersonalFactory.SelectView, new BusinessObjectParameters(parameters));
        }

        public static DatatecnixOfficerII.Models.TrolleyLinePersonal SelectSingle(string filter, params object[] parameters)
        {
            return new TrolleyLinePersonalFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }

        public static DatatecnixOfficerII.Models.TrolleyLinePersonal SelectSingle(int? rowid)
        {
            return new TrolleyLinePersonalFactory().SelectSingle(rowid);
        }

        public int Insert()
        {
            return new TrolleyLinePersonalFactory().Insert(this);
        }

        public int Update()
        {
            return new TrolleyLinePersonalFactory().Update(this);
        }

        public int Delete()
        {
            return new TrolleyLinePersonalFactory().Delete(this);
        }

        public override string ToString()
        {
            return string.Format("Rowid: {0}", this.Rowid);
        }

        public static DatatecnixOfficerII.Models.TrolleyLinePersonal SelectSingle(object filter)
        {
            var paramList = new BusinessObjectParameters(filter);
            return SelectSingle(paramList.ToWhere(), paramList);
        }

        public static List<DatatecnixOfficerII.Models.TrolleyLinePersonal> Select(object filter, string sort, string view)
        {
            var paramList = new BusinessObjectParameters(filter);
            return Select(paramList.ToWhere(), sort, view, paramList);
        }

        public static List<DatatecnixOfficerII.Models.TrolleyLinePersonal> Select(object filter, string sort)
        {
            return Select(filter, sort, null);
        }

        public static List<DatatecnixOfficerII.Models.TrolleyLinePersonal> Select(object filter)
        {
            return Select(filter, null);
        }

        public static DatatecnixOfficerII.Models.TrolleyLinePersonal Insert(object initializer)
        {
            var instance = CreateInstance<DatatecnixOfficerII.Models.TrolleyLinePersonal>(initializer);
            if (instance.Insert() == 0)
                return null;
            return instance;
        }

        public static List<DatatecnixOfficerII.Models.TrolleyLinePersonal> SelectAll()
        {
            return SelectAll(null);
        }

        public static List<DatatecnixOfficerII.Models.TrolleyLinePersonal> SelectAll(string sort)
        {
            return new DatatecnixOfficerII.Models.TrolleyLinePersonalFactory().Select(null, sort, DatatecnixOfficerII.Models.TrolleyLinePersonalFactory.SelectView, new BusinessObjectParameters());
        }
    }

    public partial class TrolleyLinePersonalFactory
    {

        public TrolleyLinePersonalFactory()
        {
        }

        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("TrolleyLinePersonal");
            }
        }

        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("TrolleyLinePersonal");
            }
        }

        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("TrolleyLinePersonal");
            }
        }

        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("TrolleyLinePersonal");
            }
        }

        public static TrolleyLinePersonalFactory Create()
        {
            return new TrolleyLinePersonalFactory();
        }

        public List<DatatecnixOfficerII.Models.TrolleyLinePersonal> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }

        public List<DatatecnixOfficerII.Models.TrolleyLinePersonal> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }

        public List<DatatecnixOfficerII.Models.TrolleyLinePersonal> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
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
            var page = c.GetPage("TrolleyLinePersonal", dataView, request);
            return page.ToList<DatatecnixOfficerII.Models.TrolleyLinePersonal>();
        }

        public DatatecnixOfficerII.Models.TrolleyLinePersonal SelectSingle(int? rowid)
        {
            var parameterMarker = SqlStatement.GetParameterMarker(string.Empty);
            var paramValues = new BusinessObjectParameters();
            paramValues[(parameterMarker + "objpk0")] = rowid;
            return SelectSingle(string.Format("Rowid={0}objpk0", parameterMarker), paramValues);
        }

        public DatatecnixOfficerII.Models.TrolleyLinePersonal SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            var list = Select(filter, parameters);
            if (list.Count > 0)
                return list[0];
            return null;
        }

        protected virtual FieldValue[] CreateFieldValues(DatatecnixOfficerII.Models.TrolleyLinePersonal theTrolleyLinePersonal, DatatecnixOfficerII.Models.TrolleyLinePersonal original_TrolleyLinePersonal)
        {
            var values = new List<FieldValue>();
            values.Add(new FieldValue("Rowid", original_TrolleyLinePersonal.Rowid, theTrolleyLinePersonal.Rowid, true));
            values.Add(new FieldValue("ItemCode", original_TrolleyLinePersonal.ItemCode, theTrolleyLinePersonal.ItemCode));
            values.Add(new FieldValue("ItemStiDesc", original_TrolleyLinePersonal.ItemStiDesc, theTrolleyLinePersonal.ItemStiDesc, true));
            values.Add(new FieldValue("SizeCode", original_TrolleyLinePersonal.SizeCode, theTrolleyLinePersonal.SizeCode));
            values.Add(new FieldValue("Qty", original_TrolleyLinePersonal.Qty, theTrolleyLinePersonal.Qty));
            values.Add(new FieldValue("CommentCode", original_TrolleyLinePersonal.CommentCode, theTrolleyLinePersonal.CommentCode));
            values.Add(new FieldValue("CommentDesc", original_TrolleyLinePersonal.CommentDesc, theTrolleyLinePersonal.CommentDesc, true));
            values.Add(new FieldValue("LineValue", original_TrolleyLinePersonal.LineValue, theTrolleyLinePersonal.LineValue));
            values.Add(new FieldValue("ReqItemCost", original_TrolleyLinePersonal.ReqItemCost, theTrolleyLinePersonal.ReqItemCost));
            values.Add(new FieldValue("UpdateStaffProfile", original_TrolleyLinePersonal.UpdateStaffProfile, theTrolleyLinePersonal.UpdateStaffProfile));
            values.Add(new FieldValue("StaffUid", original_TrolleyLinePersonal.StaffUid, theTrolleyLinePersonal.StaffUid));
            values.Add(new FieldValue("Type", original_TrolleyLinePersonal.Type, theTrolleyLinePersonal.Type));
            values.Add(new FieldValue("Description", original_TrolleyLinePersonal.Description, theTrolleyLinePersonal.Description));
            values.Add(new FieldValue("AdditionalInformation", original_TrolleyLinePersonal.AdditionalInformation, theTrolleyLinePersonal.AdditionalInformation));
            values.Add(new FieldValue("glCode", original_TrolleyLinePersonal.glCode, theTrolleyLinePersonal.glCode));
            values.Add(new FieldValue("BudgetCode", original_TrolleyLinePersonal.BudgetCode, theTrolleyLinePersonal.BudgetCode));
            values.Add(new FieldValue("Supplier", original_TrolleyLinePersonal.Supplier, theTrolleyLinePersonal.Supplier));
            values.Add(new FieldValue("Local_StaffProfileSize", original_TrolleyLinePersonal.Local_StaffProfileSize, theTrolleyLinePersonal.Local_StaffProfileSize));
            values.Add(new FieldValue("Local_Description", original_TrolleyLinePersonal.Local_Description, theTrolleyLinePersonal.Local_Description));
            return values.ToArray();
        }

        protected virtual int ExecuteAction(DatatecnixOfficerII.Models.TrolleyLinePersonal theTrolleyLinePersonal, DatatecnixOfficerII.Models.TrolleyLinePersonal original_TrolleyLinePersonal, string lastCommandName, string commandName, string dataView)
        {
            var args = new ActionArgs()
            {
                Controller = "TrolleyLinePersonal",
                View = dataView,
                Values = CreateFieldValues(theTrolleyLinePersonal, original_TrolleyLinePersonal),
                LastCommandName = lastCommandName,
                CommandName = commandName
            };
            var result = ControllerFactory.CreateDataController().Execute("TrolleyLinePersonal", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theTrolleyLinePersonal);
            return result.RowsAffected;
        }

        public virtual int Update(DatatecnixOfficerII.Models.TrolleyLinePersonal theTrolleyLinePersonal, DatatecnixOfficerII.Models.TrolleyLinePersonal original_TrolleyLinePersonal)
        {
            return ExecuteAction(theTrolleyLinePersonal, original_TrolleyLinePersonal, "Edit", "Update", UpdateView);
        }

        public virtual int Update(DatatecnixOfficerII.Models.TrolleyLinePersonal theTrolleyLinePersonal)
        {
            return Update(theTrolleyLinePersonal, SelectSingle(theTrolleyLinePersonal.Rowid));
        }

        public virtual int Insert(DatatecnixOfficerII.Models.TrolleyLinePersonal theTrolleyLinePersonal)
        {
            return ExecuteAction(theTrolleyLinePersonal, new TrolleyLinePersonal(), "New", "Insert", InsertView);
        }

        public virtual int Delete(DatatecnixOfficerII.Models.TrolleyLinePersonal theTrolleyLinePersonal)
        {
            return ExecuteAction(theTrolleyLinePersonal, theTrolleyLinePersonal, "Select", "Delete", DeleteView);
        }
    }
}
