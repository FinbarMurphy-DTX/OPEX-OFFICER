using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using DatatecnixOfficerII.Data;

namespace DatatecnixOfficerII.Models
{
    public enum RequisitionTextDataField
    {

        Rowid,

        RqHeader,

        RqHeaderstaffCode,

        rqHeaderLocationCode,

        rqHeaderRqnPrefix,

        rqHeaderStaffUid,

        RqtDesc,

        RqtNotes,

        RqtQty,

        RqtValue,

        RqtActVal,

        CommentCode,

        CommentDesc,

        Status,

        rqStatusDescription,

        DateEntered,

        DateApproved,

        DateCompleted,

        GlCode,

        LineValue,

        ActualLineValue,

        BudgetInd,

        BudgetIndbudgetDesc,

        PoHeaderID,

        RequestedbySurname,

        RequestedbyStaffCode,
    }

    public partial class RequisitionTextModel : BusinessRulesObjectModel
    {

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _rowid;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _rqHeader;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _rqHeaderstaffCode;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _rqHeaderLocationCode;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _rqHeaderRqnPrefix;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private uint? _rqHeaderStaffUid;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _rqtDesc;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _rqtNotes;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _rqtQty;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _rqtValue;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _rqtActVal;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _commentCode;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _commentDesc;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _status;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _rqStatusDescription;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _dateEntered;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _dateApproved;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _dateCompleted;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _glCode;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _lineValue;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _actualLineValue;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _budgetInd;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _budgetIndbudgetDesc;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _poHeaderID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _requestedbySurname;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _requestedbyStaffCode;

        public RequisitionTextModel()
        {
        }

        public RequisitionTextModel(BusinessRules r) :
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

        public int? RqHeader
        {
            get
            {
                return _rqHeader;
            }
            set
            {
                _rqHeader = value;
                UpdateFieldValue("RqHeader", value);
            }
        }

        public string RqHeaderstaffCode
        {
            get
            {
                return _rqHeaderstaffCode;
            }
            set
            {
                _rqHeaderstaffCode = value;
                UpdateFieldValue("RqHeaderstaffCode", value);
            }
        }

        public string rqHeaderLocationCode
        {
            get
            {
                return _rqHeaderLocationCode;
            }
            set
            {
                _rqHeaderLocationCode = value;
                UpdateFieldValue("rqHeaderLocationCode", value);
            }
        }

        public string rqHeaderRqnPrefix
        {
            get
            {
                return _rqHeaderRqnPrefix;
            }
            set
            {
                _rqHeaderRqnPrefix = value;
                UpdateFieldValue("rqHeaderRqnPrefix", value);
            }
        }

        public uint? rqHeaderStaffUid
        {
            get
            {
                return _rqHeaderStaffUid;
            }
            set
            {
                _rqHeaderStaffUid = value;
                UpdateFieldValue("rqHeaderStaffUid", value);
            }
        }

        public string RqtDesc
        {
            get
            {
                return _rqtDesc;
            }
            set
            {
                _rqtDesc = value;
                UpdateFieldValue("RqtDesc", value);
            }
        }

        public string RqtNotes
        {
            get
            {
                return _rqtNotes;
            }
            set
            {
                _rqtNotes = value;
                UpdateFieldValue("RqtNotes", value);
            }
        }

        public int? RqtQty
        {
            get
            {
                return _rqtQty;
            }
            set
            {
                _rqtQty = value;
                UpdateFieldValue("RqtQty", value);
            }
        }

        public decimal? RqtValue
        {
            get
            {
                return _rqtValue;
            }
            set
            {
                _rqtValue = value;
                UpdateFieldValue("RqtValue", value);
            }
        }

        public decimal? RqtActVal
        {
            get
            {
                return _rqtActVal;
            }
            set
            {
                _rqtActVal = value;
                UpdateFieldValue("RqtActVal", value);
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

        public string Status
        {
            get
            {
                return _status;
            }
            set
            {
                _status = value;
                UpdateFieldValue("Status", value);
            }
        }

        public string rqStatusDescription
        {
            get
            {
                return _rqStatusDescription;
            }
            set
            {
                _rqStatusDescription = value;
                UpdateFieldValue("rqStatusDescription", value);
            }
        }

        public DateTime? DateEntered
        {
            get
            {
                return _dateEntered;
            }
            set
            {
                _dateEntered = value;
                UpdateFieldValue("DateEntered", value);
            }
        }

        public DateTime? DateApproved
        {
            get
            {
                return _dateApproved;
            }
            set
            {
                _dateApproved = value;
                UpdateFieldValue("DateApproved", value);
            }
        }

        public DateTime? DateCompleted
        {
            get
            {
                return _dateCompleted;
            }
            set
            {
                _dateCompleted = value;
                UpdateFieldValue("DateCompleted", value);
            }
        }

        public string GlCode
        {
            get
            {
                return _glCode;
            }
            set
            {
                _glCode = value;
                UpdateFieldValue("GlCode", value);
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

        public decimal? ActualLineValue
        {
            get
            {
                return _actualLineValue;
            }
            set
            {
                _actualLineValue = value;
                UpdateFieldValue("ActualLineValue", value);
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

        public int? PoHeaderID
        {
            get
            {
                return _poHeaderID;
            }
            set
            {
                _poHeaderID = value;
                UpdateFieldValue("PoHeaderID", value);
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

        public FieldValue this[RequisitionTextDataField field]
        {
            get
            {
                return this[field.ToString()];
            }
        }
    }
}
