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
	public partial class TrolleyLineLocationBusinessRules : DatatecnixOfficerII.Rules.SharedBusinessRules
    {
        
        /// <summary>
        /// Rule "RefreshMaster" implementation:
        /// This method will execute in any view for an action
        /// with a command name that matches "Insert|Update|Delete".
        /// </summary>
        [Rule("r104")]
        public void r104Implementation(TrolleyLineLocationModel instance)
        {
            Sql("Call UpdateTrolleyTotalLocation(@lc)", new ParameterValue("@lc", instance.LocationCode));
            OPEXRefresh("view1");
            Result.Continue();
        }
    }
}
