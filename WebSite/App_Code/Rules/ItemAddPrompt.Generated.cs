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
    public partial class ItemAddPromptBusinessRules : DatatecnixOfficerII.Rules.SharedBusinessRules
    {

        [RowBuilder("ItemAddPrompt", RowKind.New)]
        public void BuildNewItemAddPrompt()
        {
            UpdateFieldValue("ItemCode", SelectFieldValue("Context_ItemCode"));
            UpdateFieldValue("ItemStiDesc", SelectFieldValue("Context_StiDesc"));
            UpdateFieldValue("Qty", 1);
            UpdateFieldValue("CommentCode", (OPEX.companyId == "WF") ? SelectFieldValue("Context_ChargeCode") : SelectFieldValue("CommentCode"));
            UpdateFieldValue("UpdateStaffProfile", "N");
            UpdateFieldValue("CommentDesc", (OPEX.companyId == "WF") ? SelectFieldValue("Context_ChargeCodeDescription") : SelectFieldValue("CommentDesc"));
            UpdateFieldValue("StaffUid", Officer.staffRecord.StaffUid);
        }
    }
}
