using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using DatatecnixOfficerII.Data;

namespace DatatecnixOfficerII.Models
{
    public enum MessagesDataField
    {

        MsgNo,

        ErrorMsg,

        ModuleID,

        ErrorType,

        Rowid,
    }

    public partial class MessagesModel : BusinessRulesObjectModel
    {

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _msgNo;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _errorMsg;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _moduleID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _errorType;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _rowid;

        public MessagesModel()
        {
        }

        public MessagesModel(BusinessRules r) :
                base(r)
        {
        }

        public string MsgNo
        {
            get
            {
                return _msgNo;
            }
            set
            {
                _msgNo = value;
                UpdateFieldValue("MsgNo", value);
            }
        }

        public string ErrorMsg
        {
            get
            {
                return _errorMsg;
            }
            set
            {
                _errorMsg = value;
                UpdateFieldValue("ErrorMsg", value);
            }
        }

        public string ModuleID
        {
            get
            {
                return _moduleID;
            }
            set
            {
                _moduleID = value;
                UpdateFieldValue("ModuleID", value);
            }
        }

        public string ErrorType
        {
            get
            {
                return _errorType;
            }
            set
            {
                _errorType = value;
                UpdateFieldValue("ErrorType", value);
            }
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

        public FieldValue this[MessagesDataField field]
        {
            get
            {
                return this[field.ToString()];
            }
        }
    }

    public partial class Messages : MessagesModel
    {

        public static List<DatatecnixOfficerII.Models.Messages> Select(string filter, string sort, string dataView, params object[] parameters)
        {
            return new MessagesFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }

        public static List<DatatecnixOfficerII.Models.Messages> Select(string filter, string sort, params object[] parameters)
        {
            return new MessagesFactory().Select(filter, sort, MessagesFactory.SelectView, new BusinessObjectParameters(parameters));
        }

        public static List<DatatecnixOfficerII.Models.Messages> Select(string filter, params object[] parameters)
        {
            return new MessagesFactory().Select(filter, null, MessagesFactory.SelectView, new BusinessObjectParameters(parameters));
        }

        public static DatatecnixOfficerII.Models.Messages SelectSingle(string filter, params object[] parameters)
        {
            return new MessagesFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }

        public static DatatecnixOfficerII.Models.Messages SelectSingle(int? rowid)
        {
            return new MessagesFactory().SelectSingle(rowid);
        }

        public int Insert()
        {
            return new MessagesFactory().Insert(this);
        }

        public int Update()
        {
            return new MessagesFactory().Update(this);
        }

        public int Delete()
        {
            return new MessagesFactory().Delete(this);
        }

        public override string ToString()
        {
            return string.Format("Rowid: {0}", this.Rowid);
        }

        public static DatatecnixOfficerII.Models.Messages SelectSingle(object filter)
        {
            var paramList = new BusinessObjectParameters(filter);
            return SelectSingle(paramList.ToWhere(), paramList);
        }

        public static List<DatatecnixOfficerII.Models.Messages> Select(object filter, string sort, string view)
        {
            var paramList = new BusinessObjectParameters(filter);
            return Select(paramList.ToWhere(), sort, view, paramList);
        }

        public static List<DatatecnixOfficerII.Models.Messages> Select(object filter, string sort)
        {
            return Select(filter, sort, null);
        }

        public static List<DatatecnixOfficerII.Models.Messages> Select(object filter)
        {
            return Select(filter, null);
        }

        public static DatatecnixOfficerII.Models.Messages Insert(object initializer)
        {
            var instance = CreateInstance<DatatecnixOfficerII.Models.Messages>(initializer);
            if (instance.Insert() == 0)
                return null;
            return instance;
        }

        public static List<DatatecnixOfficerII.Models.Messages> SelectAll()
        {
            return SelectAll(null);
        }

        public static List<DatatecnixOfficerII.Models.Messages> SelectAll(string sort)
        {
            return new DatatecnixOfficerII.Models.MessagesFactory().Select(null, sort, DatatecnixOfficerII.Models.MessagesFactory.SelectView, new BusinessObjectParameters());
        }
    }

    public partial class MessagesFactory
    {

        public MessagesFactory()
        {
        }

        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("Messages");
            }
        }

        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("Messages");
            }
        }

        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("Messages");
            }
        }

        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("Messages");
            }
        }

        public static MessagesFactory Create()
        {
            return new MessagesFactory();
        }

        public List<DatatecnixOfficerII.Models.Messages> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }

        public List<DatatecnixOfficerII.Models.Messages> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }

        public List<DatatecnixOfficerII.Models.Messages> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
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
            var page = c.GetPage("Messages", dataView, request);
            return page.ToList<DatatecnixOfficerII.Models.Messages>();
        }

        public DatatecnixOfficerII.Models.Messages SelectSingle(int? rowid)
        {
            var parameterMarker = SqlStatement.GetParameterMarker(string.Empty);
            var paramValues = new BusinessObjectParameters();
            paramValues[(parameterMarker + "objpk0")] = rowid;
            return SelectSingle(string.Format("Rowid={0}objpk0", parameterMarker), paramValues);
        }

        public DatatecnixOfficerII.Models.Messages SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            var list = Select(filter, parameters);
            if (list.Count > 0)
                return list[0];
            return null;
        }

        protected virtual FieldValue[] CreateFieldValues(DatatecnixOfficerII.Models.Messages theMessages, DatatecnixOfficerII.Models.Messages original_Messages)
        {
            var values = new List<FieldValue>();
            values.Add(new FieldValue("MsgNo", original_Messages.MsgNo, theMessages.MsgNo));
            values.Add(new FieldValue("ErrorMsg", original_Messages.ErrorMsg, theMessages.ErrorMsg));
            values.Add(new FieldValue("ModuleID", original_Messages.ModuleID, theMessages.ModuleID));
            values.Add(new FieldValue("ErrorType", original_Messages.ErrorType, theMessages.ErrorType));
            values.Add(new FieldValue("Rowid", original_Messages.Rowid, theMessages.Rowid, true));
            return values.ToArray();
        }

        protected virtual int ExecuteAction(DatatecnixOfficerII.Models.Messages theMessages, DatatecnixOfficerII.Models.Messages original_Messages, string lastCommandName, string commandName, string dataView)
        {
            var args = new ActionArgs()
            {
                Controller = "Messages",
                View = dataView,
                Values = CreateFieldValues(theMessages, original_Messages),
                LastCommandName = lastCommandName,
                CommandName = commandName
            };
            var result = ControllerFactory.CreateDataController().Execute("Messages", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theMessages);
            return result.RowsAffected;
        }

        public virtual int Update(DatatecnixOfficerII.Models.Messages theMessages, DatatecnixOfficerII.Models.Messages original_Messages)
        {
            return ExecuteAction(theMessages, original_Messages, "Edit", "Update", UpdateView);
        }

        public virtual int Update(DatatecnixOfficerII.Models.Messages theMessages)
        {
            return Update(theMessages, SelectSingle(theMessages.Rowid));
        }

        public virtual int Insert(DatatecnixOfficerII.Models.Messages theMessages)
        {
            return ExecuteAction(theMessages, new Messages(), "New", "Insert", InsertView);
        }

        public virtual int Delete(DatatecnixOfficerII.Models.Messages theMessages)
        {
            return ExecuteAction(theMessages, theMessages, "Select", "Delete", DeleteView);
        }
    }
}
