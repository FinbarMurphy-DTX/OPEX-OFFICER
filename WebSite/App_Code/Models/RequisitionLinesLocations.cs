using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using DatatecnixOfficerII.Data;

namespace DatatecnixOfficerII.Models
{
    public enum RequisitionLinesLocationsDataField
    {

        Rowid,

        ItemCode,

        StiDesc,

        SizeCode,

        OutsQty,

        CommentCode,

        CommentDesc,

        WhseCode,

        Warehouse,

        StatusCode,

        StatusDescription,

        LineValue,

        AllocQty,

        OrigQty,

        ReqItemCost,

        BudgetInd,

        ReturnDt,

        RqHeader,

        RqHeaderstaffCode,

        rqHeaderStaffUid,

        rqHeaderLocationCode,

        rqHeaderRqnPrefix,

        DateTimePlaced,

        DateTimeRcvd,

        ReturnQtyTotal,

        SerialNumberID,

        SerialNumberSerialNumber,

        ConditionCode,

        GlCode,

        glDescription,

        DispatchID,

        DispatchStatusCode,

        AdditionalText,

        ItemConditionCodeDescription,

        LocationCodeLocationDesc,
    }

    public partial class RequisitionLinesLocationsModel : BusinessRulesObjectModel
    {

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _rowid;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _itemCode;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _stiDesc;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sizeCode;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _outsQty;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _commentCode;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _commentDesc;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _whseCode;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _warehouse;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _statusCode;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _statusDescription;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _lineValue;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _allocQty;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _origQty;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _reqItemCost;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _budgetInd;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _returnDt;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _rqHeader;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _rqHeaderstaffCode;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private uint? _rqHeaderStaffUid;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _rqHeaderLocationCode;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _rqHeaderRqnPrefix;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _dateTimePlaced;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _dateTimeRcvd;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _returnQtyTotal;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _serialNumberID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _serialNumberSerialNumber;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _conditionCode;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _glCode;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _glDescription;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private uint? _dispatchID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _dispatchStatusCode;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _additionalText;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _itemConditionCodeDescription;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _locationCodeLocationDesc;

        public RequisitionLinesLocationsModel()
        {
        }

        public RequisitionLinesLocationsModel(BusinessRules r) :
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

        public string StiDesc
        {
            get
            {
                return _stiDesc;
            }
            set
            {
                _stiDesc = value;
                UpdateFieldValue("StiDesc", value);
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

        public decimal? OutsQty
        {
            get
            {
                return _outsQty;
            }
            set
            {
                _outsQty = value;
                UpdateFieldValue("OutsQty", value);
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

        public string WhseCode
        {
            get
            {
                return _whseCode;
            }
            set
            {
                _whseCode = value;
                UpdateFieldValue("WhseCode", value);
            }
        }

        public string Warehouse
        {
            get
            {
                return _warehouse;
            }
            set
            {
                _warehouse = value;
                UpdateFieldValue("Warehouse", value);
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

        public string StatusDescription
        {
            get
            {
                return _statusDescription;
            }
            set
            {
                _statusDescription = value;
                UpdateFieldValue("StatusDescription", value);
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

        public decimal? AllocQty
        {
            get
            {
                return _allocQty;
            }
            set
            {
                _allocQty = value;
                UpdateFieldValue("AllocQty", value);
            }
        }

        public decimal? OrigQty
        {
            get
            {
                return _origQty;
            }
            set
            {
                _origQty = value;
                UpdateFieldValue("OrigQty", value);
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

        public DateTime? ReturnDt
        {
            get
            {
                return _returnDt;
            }
            set
            {
                _returnDt = value;
                UpdateFieldValue("ReturnDt", value);
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

        public DateTime? DateTimePlaced
        {
            get
            {
                return _dateTimePlaced;
            }
            set
            {
                _dateTimePlaced = value;
                UpdateFieldValue("DateTimePlaced", value);
            }
        }

        public DateTime? DateTimeRcvd
        {
            get
            {
                return _dateTimeRcvd;
            }
            set
            {
                _dateTimeRcvd = value;
                UpdateFieldValue("DateTimeRcvd", value);
            }
        }

        public int? ReturnQtyTotal
        {
            get
            {
                return _returnQtyTotal;
            }
            set
            {
                _returnQtyTotal = value;
                UpdateFieldValue("ReturnQtyTotal", value);
            }
        }

        public int? SerialNumberID
        {
            get
            {
                return _serialNumberID;
            }
            set
            {
                _serialNumberID = value;
                UpdateFieldValue("SerialNumberID", value);
            }
        }

        public string SerialNumberSerialNumber
        {
            get
            {
                return _serialNumberSerialNumber;
            }
            set
            {
                _serialNumberSerialNumber = value;
                UpdateFieldValue("SerialNumberSerialNumber", value);
            }
        }

        public string ConditionCode
        {
            get
            {
                return _conditionCode;
            }
            set
            {
                _conditionCode = value;
                UpdateFieldValue("ConditionCode", value);
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

        public string glDescription
        {
            get
            {
                return _glDescription;
            }
            set
            {
                _glDescription = value;
                UpdateFieldValue("glDescription", value);
            }
        }

        public uint? DispatchID
        {
            get
            {
                return _dispatchID;
            }
            set
            {
                _dispatchID = value;
                UpdateFieldValue("DispatchID", value);
            }
        }

        public string DispatchStatusCode
        {
            get
            {
                return _dispatchStatusCode;
            }
            set
            {
                _dispatchStatusCode = value;
                UpdateFieldValue("DispatchStatusCode", value);
            }
        }

        public string AdditionalText
        {
            get
            {
                return _additionalText;
            }
            set
            {
                _additionalText = value;
                UpdateFieldValue("AdditionalText", value);
            }
        }

        public string ItemConditionCodeDescription
        {
            get
            {
                return _itemConditionCodeDescription;
            }
            set
            {
                _itemConditionCodeDescription = value;
                UpdateFieldValue("ItemConditionCodeDescription", value);
            }
        }

        public string LocationCodeLocationDesc
        {
            get
            {
                return _locationCodeLocationDesc;
            }
            set
            {
                _locationCodeLocationDesc = value;
                UpdateFieldValue("LocationCodeLocationDesc", value);
            }
        }

        public FieldValue this[RequisitionLinesLocationsDataField field]
        {
            get
            {
                return this[field.ToString()];
            }
        }
    }
}
