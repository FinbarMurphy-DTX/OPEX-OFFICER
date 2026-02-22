using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using DatatecnixOfficerII.Data;

namespace DatatecnixOfficerII.Models
{
    public enum OptionsDataField
    {

        Rowid,

        ID,

        Description,

        Value,

        OptionName,

        Required,
    }

    public partial class OptionsModel : BusinessRulesObjectModel
    {

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _rowid;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _iD;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _description;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _value;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _optionName;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _required;

        public OptionsModel()
        {
        }

        public OptionsModel(BusinessRules r) :
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

        public string ID
        {
            get
            {
                return _iD;
            }
            set
            {
                _iD = value;
                UpdateFieldValue("ID", value);
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

        public string Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
                UpdateFieldValue("Value", value);
            }
        }

        public string OptionName
        {
            get
            {
                return _optionName;
            }
            set
            {
                _optionName = value;
                UpdateFieldValue("OptionName", value);
            }
        }

        public string Required
        {
            get
            {
                return _required;
            }
            set
            {
                _required = value;
                UpdateFieldValue("Required", value);
            }
        }

        public FieldValue this[OptionsDataField field]
        {
            get
            {
                return this[field.ToString()];
            }
        }
    }

    public partial class Options : OptionsModel
    {

        public static List<DatatecnixOfficerII.Models.Options> Select(string filter, string sort, string dataView, params object[] parameters)
        {
            return new OptionsFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }

        public static List<DatatecnixOfficerII.Models.Options> Select(string filter, string sort, params object[] parameters)
        {
            return new OptionsFactory().Select(filter, sort, OptionsFactory.SelectView, new BusinessObjectParameters(parameters));
        }

        public static List<DatatecnixOfficerII.Models.Options> Select(string filter, params object[] parameters)
        {
            return new OptionsFactory().Select(filter, null, OptionsFactory.SelectView, new BusinessObjectParameters(parameters));
        }

        public static DatatecnixOfficerII.Models.Options SelectSingle(string filter, params object[] parameters)
        {
            return new OptionsFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }

        public static DatatecnixOfficerII.Models.Options SelectSingle(int? rowid)
        {
            return new OptionsFactory().SelectSingle(rowid);
        }

        public int Insert()
        {
            return new OptionsFactory().Insert(this);
        }

        public int Update()
        {
            return new OptionsFactory().Update(this);
        }

        public int Delete()
        {
            return new OptionsFactory().Delete(this);
        }

        public override string ToString()
        {
            return string.Format("Rowid: {0}", this.Rowid);
        }

        public static DatatecnixOfficerII.Models.Options SelectSingle(object filter)
        {
            var paramList = new BusinessObjectParameters(filter);
            return SelectSingle(paramList.ToWhere(), paramList);
        }

        public static List<DatatecnixOfficerII.Models.Options> Select(object filter, string sort, string view)
        {
            var paramList = new BusinessObjectParameters(filter);
            return Select(paramList.ToWhere(), sort, view, paramList);
        }

        public static List<DatatecnixOfficerII.Models.Options> Select(object filter, string sort)
        {
            return Select(filter, sort, null);
        }

        public static List<DatatecnixOfficerII.Models.Options> Select(object filter)
        {
            return Select(filter, null);
        }

        public static DatatecnixOfficerII.Models.Options Insert(object initializer)
        {
            var instance = CreateInstance<DatatecnixOfficerII.Models.Options>(initializer);
            if (instance.Insert() == 0)
                return null;
            return instance;
        }

        public static List<DatatecnixOfficerII.Models.Options> SelectAll()
        {
            return SelectAll(null);
        }

        public static List<DatatecnixOfficerII.Models.Options> SelectAll(string sort)
        {
            return new DatatecnixOfficerII.Models.OptionsFactory().Select(null, sort, DatatecnixOfficerII.Models.OptionsFactory.SelectView, new BusinessObjectParameters());
        }
    }

    public partial class OptionsFactory
    {

        public OptionsFactory()
        {
        }

        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("Options");
            }
        }

        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("Options");
            }
        }

        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("Options");
            }
        }

        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("Options");
            }
        }

        public static OptionsFactory Create()
        {
            return new OptionsFactory();
        }

        public List<DatatecnixOfficerII.Models.Options> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }

        public List<DatatecnixOfficerII.Models.Options> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }

        public List<DatatecnixOfficerII.Models.Options> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
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
            var page = c.GetPage("Options", dataView, request);
            return page.ToList<DatatecnixOfficerII.Models.Options>();
        }

        public DatatecnixOfficerII.Models.Options SelectSingle(int? rowid)
        {
            var parameterMarker = SqlStatement.GetParameterMarker(string.Empty);
            var paramValues = new BusinessObjectParameters();
            paramValues[(parameterMarker + "objpk0")] = rowid;
            return SelectSingle(string.Format("Rowid={0}objpk0", parameterMarker), paramValues);
        }

        public DatatecnixOfficerII.Models.Options SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            var list = Select(filter, parameters);
            if (list.Count > 0)
                return list[0];
            return null;
        }

        protected virtual FieldValue[] CreateFieldValues(DatatecnixOfficerII.Models.Options theOptions, DatatecnixOfficerII.Models.Options original_Options)
        {
            var values = new List<FieldValue>();
            values.Add(new FieldValue("Rowid", original_Options.Rowid, theOptions.Rowid, true));
            values.Add(new FieldValue("ID", original_Options.ID, theOptions.ID));
            values.Add(new FieldValue("Description", original_Options.Description, theOptions.Description));
            values.Add(new FieldValue("Value", original_Options.Value, theOptions.Value));
            values.Add(new FieldValue("OptionName", original_Options.OptionName, theOptions.OptionName));
            values.Add(new FieldValue("Required", original_Options.Required, theOptions.Required));
            return values.ToArray();
        }

        protected virtual int ExecuteAction(DatatecnixOfficerII.Models.Options theOptions, DatatecnixOfficerII.Models.Options original_Options, string lastCommandName, string commandName, string dataView)
        {
            var args = new ActionArgs()
            {
                Controller = "Options",
                View = dataView,
                Values = CreateFieldValues(theOptions, original_Options),
                LastCommandName = lastCommandName,
                CommandName = commandName
            };
            var result = ControllerFactory.CreateDataController().Execute("Options", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theOptions);
            return result.RowsAffected;
        }

        public virtual int Update(DatatecnixOfficerII.Models.Options theOptions, DatatecnixOfficerII.Models.Options original_Options)
        {
            return ExecuteAction(theOptions, original_Options, "Edit", "Update", UpdateView);
        }

        public virtual int Update(DatatecnixOfficerII.Models.Options theOptions)
        {
            return Update(theOptions, SelectSingle(theOptions.Rowid));
        }

        public virtual int Insert(DatatecnixOfficerII.Models.Options theOptions)
        {
            return ExecuteAction(theOptions, new Options(), "New", "Insert", InsertView);
        }

        public virtual int Delete(DatatecnixOfficerII.Models.Options theOptions)
        {
            return ExecuteAction(theOptions, theOptions, "Select", "Delete", DeleteView);
        }
    }
}
