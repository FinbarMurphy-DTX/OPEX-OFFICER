using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Security;
using DatatecnixOfficerII.Data;

namespace DatatecnixOfficerII.Rules
{
    public partial class SerialNumbersReplacePromptBusinessRules : DatatecnixOfficerII.Rules.SharedBusinessRules
    {

        [RowBuilder("SerialNumbersReplacePrompt", RowKind.New)]
        public void BuildNewSerialNumbersReplacePrompt()
        {
            UpdateFieldValue("SerialNumber", SelectFieldValue("Context_SerialNumber"));
            UpdateFieldValue("ItemCode", SelectFieldValue("Context_ItemCode"));
            UpdateFieldValue("ItemStiDesc", SelectFieldValue("Context_ItemStiDesc"));
        }
    }
}
