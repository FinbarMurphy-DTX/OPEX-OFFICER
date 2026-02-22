using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using DatatecnixOfficerII.Data;

namespace DatatecnixOfficerII.Models
{
    public enum SerialNumbersLocationDataField
    {

        ID,

        ItemCode,

        ItemStiDesc,

        SerialNumber,

        BatchReference,

        BatchReferenceSerialNumber,

        BatchReferenceSupplierCode,

        LastReview,

        ExpiryDate,

        LastTransaction,

        FirstIssue,

        Notes,

        PlaAcc,

        Status,

        snStatus,

        StaffCode,

        LocationCode,

        LocationDesc,

        Registered,

        RqNumber,

        ItemConditionCode,

        ItemConditionDescription,

        SizeCode,

        WhseCode,

        WhseCode1,

        WhseStwhDesc,

        DoNotIssue,

        ReqPrefix,

        StaffUid,

        StaffUlocationCode,

        StaffuStaffCode,

        StaffuEplNumber,

        StaffuSurname,

        HasActualValue,

        ActualValue,

        DisposalDetailID,
    }

    public partial class SerialNumbersLocationModel : BusinessRulesObjectModel
    {

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _iD;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _itemCode;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _itemStiDesc;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _serialNumber;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _batchReference;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _batchReferenceSerialNumber;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _batchReferenceSupplierCode;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _lastReview;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _expiryDate;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _lastTransaction;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _firstIssue;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _notes;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _plaAcc;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _status;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _snStatus;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _staffCode;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _locationCode;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _locationDesc;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _registered;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _rqNumber;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _itemConditionCode;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _itemConditionDescription;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sizeCode;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _whseCode;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _whseCode1;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _whseStwhDesc;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _doNotIssue;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _reqPrefix;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private uint? _staffUid;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _staffUlocationCode;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _staffuStaffCode;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _staffuEplNumber;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _staffuSurname;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _hasActualValue;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _actualValue;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private uint? _disposalDetailID;

        public SerialNumbersLocationModel()
        {
        }

        public SerialNumbersLocationModel(BusinessRules r) :
                base(r)
        {
        }

        public int? ID
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

        public string SerialNumber
        {
            get
            {
                return _serialNumber;
            }
            set
            {
                _serialNumber = value;
                UpdateFieldValue("SerialNumber", value);
            }
        }

        public int? BatchReference
        {
            get
            {
                return _batchReference;
            }
            set
            {
                _batchReference = value;
                UpdateFieldValue("BatchReference", value);
            }
        }

        public string BatchReferenceSerialNumber
        {
            get
            {
                return _batchReferenceSerialNumber;
            }
            set
            {
                _batchReferenceSerialNumber = value;
                UpdateFieldValue("BatchReferenceSerialNumber", value);
            }
        }

        public string BatchReferenceSupplierCode
        {
            get
            {
                return _batchReferenceSupplierCode;
            }
            set
            {
                _batchReferenceSupplierCode = value;
                UpdateFieldValue("BatchReferenceSupplierCode", value);
            }
        }

        public DateTime? LastReview
        {
            get
            {
                return _lastReview;
            }
            set
            {
                _lastReview = value;
                UpdateFieldValue("LastReview", value);
            }
        }

        public DateTime? ExpiryDate
        {
            get
            {
                return _expiryDate;
            }
            set
            {
                _expiryDate = value;
                UpdateFieldValue("ExpiryDate", value);
            }
        }

        public DateTime? LastTransaction
        {
            get
            {
                return _lastTransaction;
            }
            set
            {
                _lastTransaction = value;
                UpdateFieldValue("LastTransaction", value);
            }
        }

        public DateTime? FirstIssue
        {
            get
            {
                return _firstIssue;
            }
            set
            {
                _firstIssue = value;
                UpdateFieldValue("FirstIssue", value);
            }
        }

        public string Notes
        {
            get
            {
                return _notes;
            }
            set
            {
                _notes = value;
                UpdateFieldValue("Notes", value);
            }
        }

        public string PlaAcc
        {
            get
            {
                return _plaAcc;
            }
            set
            {
                _plaAcc = value;
                UpdateFieldValue("PlaAcc", value);
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

        public string snStatus
        {
            get
            {
                return _snStatus;
            }
            set
            {
                _snStatus = value;
                UpdateFieldValue("snStatus", value);
            }
        }

        public string StaffCode
        {
            get
            {
                return _staffCode;
            }
            set
            {
                _staffCode = value;
                UpdateFieldValue("StaffCode", value);
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

        public string LocationDesc
        {
            get
            {
                return _locationDesc;
            }
            set
            {
                _locationDesc = value;
                UpdateFieldValue("LocationDesc", value);
            }
        }

        public DateTime? Registered
        {
            get
            {
                return _registered;
            }
            set
            {
                _registered = value;
                UpdateFieldValue("Registered", value);
            }
        }

        public int? RqNumber
        {
            get
            {
                return _rqNumber;
            }
            set
            {
                _rqNumber = value;
                UpdateFieldValue("RqNumber", value);
            }
        }

        public string ItemConditionCode
        {
            get
            {
                return _itemConditionCode;
            }
            set
            {
                _itemConditionCode = value;
                UpdateFieldValue("ItemConditionCode", value);
            }
        }

        public string ItemConditionDescription
        {
            get
            {
                return _itemConditionDescription;
            }
            set
            {
                _itemConditionDescription = value;
                UpdateFieldValue("ItemConditionDescription", value);
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

        public string WhseCode1
        {
            get
            {
                return _whseCode1;
            }
            set
            {
                _whseCode1 = value;
                UpdateFieldValue("WhseCode1", value);
            }
        }

        public string WhseStwhDesc
        {
            get
            {
                return _whseStwhDesc;
            }
            set
            {
                _whseStwhDesc = value;
                UpdateFieldValue("WhseStwhDesc", value);
            }
        }

        public string DoNotIssue
        {
            get
            {
                return _doNotIssue;
            }
            set
            {
                _doNotIssue = value;
                UpdateFieldValue("DoNotIssue", value);
            }
        }

        public string ReqPrefix
        {
            get
            {
                return _reqPrefix;
            }
            set
            {
                _reqPrefix = value;
                UpdateFieldValue("ReqPrefix", value);
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

        public string StaffuEplNumber
        {
            get
            {
                return _staffuEplNumber;
            }
            set
            {
                _staffuEplNumber = value;
                UpdateFieldValue("StaffuEplNumber", value);
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

        public string HasActualValue
        {
            get
            {
                return _hasActualValue;
            }
            set
            {
                _hasActualValue = value;
                UpdateFieldValue("HasActualValue", value);
            }
        }

        public decimal? ActualValue
        {
            get
            {
                return _actualValue;
            }
            set
            {
                _actualValue = value;
                UpdateFieldValue("ActualValue", value);
            }
        }

        public uint? DisposalDetailID
        {
            get
            {
                return _disposalDetailID;
            }
            set
            {
                _disposalDetailID = value;
                UpdateFieldValue("DisposalDetailID", value);
            }
        }

        public FieldValue this[SerialNumbersLocationDataField field]
        {
            get
            {
                return this[field.ToString()];
            }
        }
    }
}
