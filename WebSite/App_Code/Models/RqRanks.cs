using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using DatatecnixOfficerII.Data;

namespace DatatecnixOfficerII.Models
{
    public enum RqRanksDataField
    {

        Rowid,

        RankCode,

        RankDesc,

        StaffFilter,

        StaffFilterStaffFilterDescription,
    }

    public partial class RqRanksModel : BusinessRulesObjectModel
    {

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _rowid;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _rankCode;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _rankDesc;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _staffFilter;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _staffFilterStaffFilterDescription;

        public RqRanksModel()
        {
        }

        public RqRanksModel(BusinessRules r) :
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

        public string StaffFilter
        {
            get
            {
                return _staffFilter;
            }
            set
            {
                _staffFilter = value;
                UpdateFieldValue("StaffFilter", value);
            }
        }

        public string StaffFilterStaffFilterDescription
        {
            get
            {
                return _staffFilterStaffFilterDescription;
            }
            set
            {
                _staffFilterStaffFilterDescription = value;
                UpdateFieldValue("StaffFilterStaffFilterDescription", value);
            }
        }

        public FieldValue this[RqRanksDataField field]
        {
            get
            {
                return this[field.ToString()];
            }
        }
    }

    public partial class RqRanks : RqRanksModel
    {

        public static List<DatatecnixOfficerII.Models.RqRanks> Select(string filter, string sort, string dataView, params object[] parameters)
        {
            return new RqRanksFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }

        public static List<DatatecnixOfficerII.Models.RqRanks> Select(string filter, string sort, params object[] parameters)
        {
            return new RqRanksFactory().Select(filter, sort, RqRanksFactory.SelectView, new BusinessObjectParameters(parameters));
        }

        public static List<DatatecnixOfficerII.Models.RqRanks> Select(string filter, params object[] parameters)
        {
            return new RqRanksFactory().Select(filter, null, RqRanksFactory.SelectView, new BusinessObjectParameters(parameters));
        }

        public static DatatecnixOfficerII.Models.RqRanks SelectSingle(string filter, params object[] parameters)
        {
            return new RqRanksFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }

        public static DatatecnixOfficerII.Models.RqRanks SelectSingle(int? rowid)
        {
            return new RqRanksFactory().SelectSingle(rowid);
        }

        public int Insert()
        {
            return new RqRanksFactory().Insert(this);
        }

        public int Update()
        {
            return new RqRanksFactory().Update(this);
        }

        public int Delete()
        {
            return new RqRanksFactory().Delete(this);
        }

        public override string ToString()
        {
            return string.Format("Rowid: {0}", this.Rowid);
        }

        public static DatatecnixOfficerII.Models.RqRanks SelectSingle(object filter)
        {
            var paramList = new BusinessObjectParameters(filter);
            return SelectSingle(paramList.ToWhere(), paramList);
        }

        public static List<DatatecnixOfficerII.Models.RqRanks> Select(object filter, string sort, string view)
        {
            var paramList = new BusinessObjectParameters(filter);
            return Select(paramList.ToWhere(), sort, view, paramList);
        }

        public static List<DatatecnixOfficerII.Models.RqRanks> Select(object filter, string sort)
        {
            return Select(filter, sort, null);
        }

        public static List<DatatecnixOfficerII.Models.RqRanks> Select(object filter)
        {
            return Select(filter, null);
        }

        public static DatatecnixOfficerII.Models.RqRanks Insert(object initializer)
        {
            var instance = CreateInstance<DatatecnixOfficerII.Models.RqRanks>(initializer);
            if (instance.Insert() == 0)
                return null;
            return instance;
        }

        public static List<DatatecnixOfficerII.Models.RqRanks> SelectAll()
        {
            return SelectAll(null);
        }

        public static List<DatatecnixOfficerII.Models.RqRanks> SelectAll(string sort)
        {
            return new DatatecnixOfficerII.Models.RqRanksFactory().Select(null, sort, DatatecnixOfficerII.Models.RqRanksFactory.SelectView, new BusinessObjectParameters());
        }
    }

    public partial class RqRanksFactory
    {

        public RqRanksFactory()
        {
        }

        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("RqRanks");
            }
        }

        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("RqRanks");
            }
        }

        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("RqRanks");
            }
        }

        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("RqRanks");
            }
        }

        public static RqRanksFactory Create()
        {
            return new RqRanksFactory();
        }

        public List<DatatecnixOfficerII.Models.RqRanks> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }

        public List<DatatecnixOfficerII.Models.RqRanks> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }

        public List<DatatecnixOfficerII.Models.RqRanks> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
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
            var page = c.GetPage("RqRanks", dataView, request);
            return page.ToList<DatatecnixOfficerII.Models.RqRanks>();
        }

        public DatatecnixOfficerII.Models.RqRanks SelectSingle(int? rowid)
        {
            var parameterMarker = SqlStatement.GetParameterMarker(string.Empty);
            var paramValues = new BusinessObjectParameters();
            paramValues[(parameterMarker + "objpk0")] = rowid;
            return SelectSingle(string.Format("Rowid={0}objpk0", parameterMarker), paramValues);
        }

        public DatatecnixOfficerII.Models.RqRanks SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            var list = Select(filter, parameters);
            if (list.Count > 0)
                return list[0];
            return null;
        }

        protected virtual FieldValue[] CreateFieldValues(DatatecnixOfficerII.Models.RqRanks theRqRanks, DatatecnixOfficerII.Models.RqRanks original_RqRanks)
        {
            var values = new List<FieldValue>();
            values.Add(new FieldValue("Rowid", original_RqRanks.Rowid, theRqRanks.Rowid, true));
            values.Add(new FieldValue("RankCode", original_RqRanks.RankCode, theRqRanks.RankCode));
            values.Add(new FieldValue("RankDesc", original_RqRanks.RankDesc, theRqRanks.RankDesc));
            values.Add(new FieldValue("StaffFilter", original_RqRanks.StaffFilter, theRqRanks.StaffFilter));
            values.Add(new FieldValue("StaffFilterStaffFilterDescription", original_RqRanks.StaffFilterStaffFilterDescription, theRqRanks.StaffFilterStaffFilterDescription, true));
            return values.ToArray();
        }

        protected virtual int ExecuteAction(DatatecnixOfficerII.Models.RqRanks theRqRanks, DatatecnixOfficerII.Models.RqRanks original_RqRanks, string lastCommandName, string commandName, string dataView)
        {
            var args = new ActionArgs()
            {
                Controller = "RqRanks",
                View = dataView,
                Values = CreateFieldValues(theRqRanks, original_RqRanks),
                LastCommandName = lastCommandName,
                CommandName = commandName
            };
            var result = ControllerFactory.CreateDataController().Execute("RqRanks", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theRqRanks);
            return result.RowsAffected;
        }

        public virtual int Update(DatatecnixOfficerII.Models.RqRanks theRqRanks, DatatecnixOfficerII.Models.RqRanks original_RqRanks)
        {
            return ExecuteAction(theRqRanks, original_RqRanks, "Edit", "Update", UpdateView);
        }

        public virtual int Update(DatatecnixOfficerII.Models.RqRanks theRqRanks)
        {
            return Update(theRqRanks, SelectSingle(theRqRanks.Rowid));
        }

        public virtual int Insert(DatatecnixOfficerII.Models.RqRanks theRqRanks)
        {
            return ExecuteAction(theRqRanks, new RqRanks(), "New", "Insert", InsertView);
        }

        public virtual int Delete(DatatecnixOfficerII.Models.RqRanks theRqRanks)
        {
            return ExecuteAction(theRqRanks, theRqRanks, "Select", "Delete", DeleteView);
        }
    }
}
