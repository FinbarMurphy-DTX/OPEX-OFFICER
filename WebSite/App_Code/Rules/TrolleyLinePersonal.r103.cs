using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Security;
using DatatecnixOfficerII.Data;
using DatatecnixOfficerII.Models;

namespace DatatecnixOfficerII.Rules
{
	public partial class TrolleyLinePersonalBusinessRules : DatatecnixOfficerII.Rules.SharedBusinessRules
    {
        
        /// <summary>
        /// Rule "HideLocalFields" implementation:
        /// This method will execute in any view for an action
        /// with a command name that matches "Insert|Update".
        /// </summary>
        [Rule("r103")]
        public void r103Implementation(TrolleyLinePersonalModel instance)
        {
            OPEXHideLocalField("Local_StaffProfileSize");

            instance.LineValue = instance.Qty * instance.ReqItemCost;
        }
    }
}
