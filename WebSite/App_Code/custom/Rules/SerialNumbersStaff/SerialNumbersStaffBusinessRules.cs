using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using DatatecnixOfficerII.Data;

namespace DatatecnixOfficerII.Rules
{
	public partial class SerialNumbersStaffBusinessRules : DatatecnixOfficerII.Rules.SharedBusinessRules
    {

        public string OfficerUID
        {
            get
            {
                return Officer.staffRecord.StaffUid.ToString();
            }
        }
    }
}
