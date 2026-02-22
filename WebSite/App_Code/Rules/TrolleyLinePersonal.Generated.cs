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
    public partial class TrolleyLinePersonalBusinessRules : DatatecnixOfficerII.Rules.SharedBusinessRules
    {

        [RowBuilder("TrolleyLinePersonal", RowKind.New)]
        public void BuildNewTrolleyLinePersonal()
        {
            UpdateFieldValue("Qty", 1);
            UpdateFieldValue("UpdateStaffProfile", "N");
            UpdateFieldValue("StaffUid", Officer.staffRecord.StaffUid);
        }
    }
}
