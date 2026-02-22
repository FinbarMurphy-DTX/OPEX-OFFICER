using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using DatatecnixOfficerII.Data;

namespace DatatecnixOfficerII.Models
{
    public enum ItemAddPromptDataField
    {

        ItemCode,

        ItemStiDesc,

        SizeCode,

        Qty,

        CommentCode,

        UpdateStaffProfile,

        CommentDesc,

        LineValue,

        ReqItemCost,

        StaffUid,

        Local_StaffProfileSize,

        Description,
    }

    public partial class ItemAddPromptModel : BusinessRulesObjectModel
    {

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
        private string _updateStaffProfile;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _commentDesc;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _lineValue;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _reqItemCost;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private uint? _staffUid;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _local_StaffProfileSize;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _description;

        public ItemAddPromptModel()
        {
        }

        public ItemAddPromptModel(BusinessRules r) :
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

        public FieldValue this[ItemAddPromptDataField field]
        {
            get
            {
                return this[field.ToString()];
            }
        }
    }
}
