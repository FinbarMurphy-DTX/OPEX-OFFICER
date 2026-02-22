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
    public partial class TrolleyLineLocationBusinessRules : DatatecnixOfficerII.Rules.SharedBusinessRules
    {

        [RowBuilder("TrolleyLineLocation", RowKind.New)]
        public void BuildNewTrolleyLineLocation()
        {
            UpdateFieldValue("Qty", 1);
            UpdateFieldValue("RequestedBy", Officer.staffRecord.StaffUid);
        }
    }
}
