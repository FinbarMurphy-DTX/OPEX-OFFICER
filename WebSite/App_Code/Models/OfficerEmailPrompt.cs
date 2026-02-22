using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using DatatecnixOfficerII.Data;

namespace DatatecnixOfficerII.Models
{
    public enum OfficerEmailPromptDataField
    {

        ItemCode,

        StiDesc,

        SizeCode,

        Message,

        Forname,

        Surname,

        AskEmail,

        OfficerEmail,

        RqHeader,

        Subject,

        OfficerEmailHeader,

        OfficerEmailFooter,
    }

    public partial class OfficerEmailPromptModel : BusinessRulesObjectModel
    {

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _itemCode;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _stiDesc;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sizeCode;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _message;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _forname;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _surname;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _askEmail;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _officerEmail;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _rqHeader;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _subject;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _officerEmailHeader;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _officerEmailFooter;

        public OfficerEmailPromptModel()
        {
        }

        public OfficerEmailPromptModel(BusinessRules r) :
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

        public string Message
        {
            get
            {
                return _message;
            }
            set
            {
                _message = value;
                UpdateFieldValue("Message", value);
            }
        }

        public string Forname
        {
            get
            {
                return _forname;
            }
            set
            {
                _forname = value;
                UpdateFieldValue("Forname", value);
            }
        }

        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                _surname = value;
                UpdateFieldValue("Surname", value);
            }
        }

        public string AskEmail
        {
            get
            {
                return _askEmail;
            }
            set
            {
                _askEmail = value;
                UpdateFieldValue("AskEmail", value);
            }
        }

        public string OfficerEmail
        {
            get
            {
                return _officerEmail;
            }
            set
            {
                _officerEmail = value;
                UpdateFieldValue("OfficerEmail", value);
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

        public string Subject
        {
            get
            {
                return _subject;
            }
            set
            {
                _subject = value;
                UpdateFieldValue("Subject", value);
            }
        }

        public string OfficerEmailHeader
        {
            get
            {
                return _officerEmailHeader;
            }
            set
            {
                _officerEmailHeader = value;
                UpdateFieldValue("OfficerEmailHeader", value);
            }
        }

        public string OfficerEmailFooter
        {
            get
            {
                return _officerEmailFooter;
            }
            set
            {
                _officerEmailFooter = value;
                UpdateFieldValue("OfficerEmailFooter", value);
            }
        }

        public FieldValue this[OfficerEmailPromptDataField field]
        {
            get
            {
                return this[field.ToString()];
            }
        }
    }
}
