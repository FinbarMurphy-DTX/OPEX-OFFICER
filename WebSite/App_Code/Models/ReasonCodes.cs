using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using DatatecnixOfficerII.Data;

namespace DatatecnixOfficerII.Models
{
    public enum ReasonCodesDataField
    {

        CommentCode,

        CommentDesc,

        StoresOnly,

        ReqOnly,

        ColOnly,

        Disabled,
    }

    public partial class ReasonCodesModel : BusinessRulesObjectModel
    {

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _commentCode;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _commentDesc;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _storesOnly;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _reqOnly;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _colOnly;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _disabled;

        public ReasonCodesModel()
        {
        }

        public ReasonCodesModel(BusinessRules r) :
                base(r)
        {
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

        public string StoresOnly
        {
            get
            {
                return _storesOnly;
            }
            set
            {
                _storesOnly = value;
                UpdateFieldValue("StoresOnly", value);
            }
        }

        public string ReqOnly
        {
            get
            {
                return _reqOnly;
            }
            set
            {
                _reqOnly = value;
                UpdateFieldValue("ReqOnly", value);
            }
        }

        public string ColOnly
        {
            get
            {
                return _colOnly;
            }
            set
            {
                _colOnly = value;
                UpdateFieldValue("ColOnly", value);
            }
        }

        public string Disabled
        {
            get
            {
                return _disabled;
            }
            set
            {
                _disabled = value;
                UpdateFieldValue("Disabled", value);
            }
        }

        public FieldValue this[ReasonCodesDataField field]
        {
            get
            {
                return this[field.ToString()];
            }
        }
    }

    public partial class ReasonCodes : ReasonCodesModel
    {

        public static List<DatatecnixOfficerII.Models.ReasonCodes> Select(string filter, string sort, string dataView, params object[] parameters)
        {
            return new ReasonCodesFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }

        public static List<DatatecnixOfficerII.Models.ReasonCodes> Select(string filter, string sort, params object[] parameters)
        {
            return new ReasonCodesFactory().Select(filter, sort, ReasonCodesFactory.SelectView, new BusinessObjectParameters(parameters));
        }

        public static List<DatatecnixOfficerII.Models.ReasonCodes> Select(string filter, params object[] parameters)
        {
            return new ReasonCodesFactory().Select(filter, null, ReasonCodesFactory.SelectView, new BusinessObjectParameters(parameters));
        }

        public static DatatecnixOfficerII.Models.ReasonCodes SelectSingle(string filter, params object[] parameters)
        {
            return new ReasonCodesFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }

        public static DatatecnixOfficerII.Models.ReasonCodes SelectSingle(string commentCode)
        {
            return new ReasonCodesFactory().SelectSingle(commentCode);
        }

        public int Insert()
        {
            return new ReasonCodesFactory().Insert(this);
        }

        public int Update()
        {
            return new ReasonCodesFactory().Update(this);
        }

        public int Delete()
        {
            return new ReasonCodesFactory().Delete(this);
        }

        public override string ToString()
        {
            return string.Format("CommentCode: {0}", this.CommentCode);
        }

        public static DatatecnixOfficerII.Models.ReasonCodes SelectSingle(object filter)
        {
            var paramList = new BusinessObjectParameters(filter);
            return SelectSingle(paramList.ToWhere(), paramList);
        }

        public static List<DatatecnixOfficerII.Models.ReasonCodes> Select(object filter, string sort, string view)
        {
            var paramList = new BusinessObjectParameters(filter);
            return Select(paramList.ToWhere(), sort, view, paramList);
        }

        public static List<DatatecnixOfficerII.Models.ReasonCodes> Select(object filter, string sort)
        {
            return Select(filter, sort, null);
        }

        public static List<DatatecnixOfficerII.Models.ReasonCodes> Select(object filter)
        {
            return Select(filter, null);
        }

        public static DatatecnixOfficerII.Models.ReasonCodes Insert(object initializer)
        {
            var instance = CreateInstance<DatatecnixOfficerII.Models.ReasonCodes>(initializer);
            if (instance.Insert() == 0)
                return null;
            return instance;
        }

        public static List<DatatecnixOfficerII.Models.ReasonCodes> SelectAll()
        {
            return SelectAll(null);
        }

        public static List<DatatecnixOfficerII.Models.ReasonCodes> SelectAll(string sort)
        {
            return new DatatecnixOfficerII.Models.ReasonCodesFactory().Select(null, sort, DatatecnixOfficerII.Models.ReasonCodesFactory.SelectView, new BusinessObjectParameters());
        }
    }

    public partial class ReasonCodesFactory
    {

        public ReasonCodesFactory()
        {
        }

        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("ReasonCodes");
            }
        }

        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("ReasonCodes");
            }
        }

        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("ReasonCodes");
            }
        }

        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("ReasonCodes");
            }
        }

        public static ReasonCodesFactory Create()
        {
            return new ReasonCodesFactory();
        }

        public List<DatatecnixOfficerII.Models.ReasonCodes> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }

        public List<DatatecnixOfficerII.Models.ReasonCodes> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }

        public List<DatatecnixOfficerII.Models.ReasonCodes> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
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
            var page = c.GetPage("ReasonCodes", dataView, request);
            return page.ToList<DatatecnixOfficerII.Models.ReasonCodes>();
        }

        public DatatecnixOfficerII.Models.ReasonCodes SelectSingle(string commentCode)
        {
            var parameterMarker = SqlStatement.GetParameterMarker(string.Empty);
            var paramValues = new BusinessObjectParameters();
            paramValues[(parameterMarker + "objpk0")] = commentCode;
            return SelectSingle(string.Format("CommentCode={0}objpk0", parameterMarker), paramValues);
        }

        public DatatecnixOfficerII.Models.ReasonCodes SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            var list = Select(filter, parameters);
            if (list.Count > 0)
                return list[0];
            return null;
        }

        protected virtual FieldValue[] CreateFieldValues(DatatecnixOfficerII.Models.ReasonCodes theReasonCodes, DatatecnixOfficerII.Models.ReasonCodes original_ReasonCodes)
        {
            var values = new List<FieldValue>();
            values.Add(new FieldValue("CommentCode", original_ReasonCodes.CommentCode, theReasonCodes.CommentCode));
            values.Add(new FieldValue("CommentDesc", original_ReasonCodes.CommentDesc, theReasonCodes.CommentDesc));
            values.Add(new FieldValue("StoresOnly", original_ReasonCodes.StoresOnly, theReasonCodes.StoresOnly));
            values.Add(new FieldValue("ReqOnly", original_ReasonCodes.ReqOnly, theReasonCodes.ReqOnly));
            values.Add(new FieldValue("ColOnly", original_ReasonCodes.ColOnly, theReasonCodes.ColOnly));
            values.Add(new FieldValue("Disabled", original_ReasonCodes.Disabled, theReasonCodes.Disabled));
            return values.ToArray();
        }

        protected virtual int ExecuteAction(DatatecnixOfficerII.Models.ReasonCodes theReasonCodes, DatatecnixOfficerII.Models.ReasonCodes original_ReasonCodes, string lastCommandName, string commandName, string dataView)
        {
            var args = new ActionArgs()
            {
                Controller = "ReasonCodes",
                View = dataView,
                Values = CreateFieldValues(theReasonCodes, original_ReasonCodes),
                LastCommandName = lastCommandName,
                CommandName = commandName
            };
            var result = ControllerFactory.CreateDataController().Execute("ReasonCodes", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theReasonCodes);
            return result.RowsAffected;
        }

        public virtual int Update(DatatecnixOfficerII.Models.ReasonCodes theReasonCodes, DatatecnixOfficerII.Models.ReasonCodes original_ReasonCodes)
        {
            return ExecuteAction(theReasonCodes, original_ReasonCodes, "Edit", "Update", UpdateView);
        }

        public virtual int Update(DatatecnixOfficerII.Models.ReasonCodes theReasonCodes)
        {
            return Update(theReasonCodes, SelectSingle(theReasonCodes.CommentCode));
        }

        public virtual int Insert(DatatecnixOfficerII.Models.ReasonCodes theReasonCodes)
        {
            return ExecuteAction(theReasonCodes, new ReasonCodes(), "New", "Insert", InsertView);
        }

        public virtual int Delete(DatatecnixOfficerII.Models.ReasonCodes theReasonCodes)
        {
            return ExecuteAction(theReasonCodes, theReasonCodes, "Select", "Delete", DeleteView);
        }
    }
}
