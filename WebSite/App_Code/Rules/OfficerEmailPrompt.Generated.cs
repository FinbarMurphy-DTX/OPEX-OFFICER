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
    public partial class OfficerEmailPromptBusinessRules : DatatecnixOfficerII.Rules.SharedBusinessRules
    {

        [RowBuilder("OfficerEmailPrompt", RowKind.New)]
        public void BuildNewOfficerEmailPrompt()
        {
            UpdateFieldValue("ItemCode", SelectFieldValue("Context_ItemCode"));
            UpdateFieldValue("StiDesc", SelectFieldValue("Context_StiDesc") ?? (SelectFieldValue("Context_ItemStiDesc") ?? (SelectFieldValue("Context_ItemCodeStiDesc"))));
            UpdateFieldValue("SizeCode", SelectFieldValue("Context_SizeCode"));
            UpdateFieldValue("Forname", Officer.staffRecord.Forname);
            UpdateFieldValue("Surname", Officer.staffRecord.Surname);
            UpdateFieldValue("AskEmail", Context.Session["AskEmail"]);
            UpdateFieldValue("OfficerEmail", Context.Session["OfficerEmail"]);
            UpdateFieldValue("RqHeader", SelectFieldValue("Context_RqHeader"));
            UpdateFieldValue("OfficerEmailHeader", OPEX.OfficerEmailHeader);
            UpdateFieldValue("OfficerEmailFooter", OPEX.OfficerEmailFooter);
        }
    }
}
