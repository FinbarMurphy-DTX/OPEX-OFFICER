using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using DatatecnixOfficerII.Data;

namespace DatatecnixOfficerII.Models
{
    public enum ProfileDataField
    {

        ItemCode,

        ItemCodeStiDesc,

        KitCode,

        Allowance,

        Remarks,

        SizeCode,

        Rowid,

        StaffUid,
    }

    public partial class ProfileModel : BusinessRulesObjectModel
    {

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _itemCode;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _itemCodeStiDesc;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _kitCode;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private short? _allowance;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _remarks;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sizeCode;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _rowid;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private uint? _staffUid;

        public ProfileModel()
        {
        }

        public ProfileModel(BusinessRules r) :
                base(r)
        {
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

        public string ItemCodeStiDesc
        {
            get
            {
                return _itemCodeStiDesc;
            }
            set
            {
                _itemCodeStiDesc = value;
                UpdateFieldValue("ItemCodeStiDesc", value);
            }
        }

        public string KitCode
        {
            get
            {
                return _kitCode;
            }
            set
            {
                _kitCode = value;
                UpdateFieldValue("KitCode", value);
            }
        }

        public short? Allowance
        {
            get
            {
                return _allowance;
            }
            set
            {
                _allowance = value;
                UpdateFieldValue("Allowance", value);
            }
        }

        public string Remarks
        {
            get
            {
                return _remarks;
            }
            set
            {
                _remarks = value;
                UpdateFieldValue("Remarks", value);
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

        public FieldValue this[ProfileDataField field]
        {
            get
            {
                return this[field.ToString()];
            }
        }
    }
}
