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
	public partial class RequisitionTextBusinessRules : DatatecnixOfficerII.Rules.SharedBusinessRules
    {
        
        /// <summary>Rule "ConfirmEmail" implementation:
        /// This method will execute in any view after an action
        /// with a command name that matches "Email".
        /// </summary>
        [Rule("r102")]
        public void r102Implementation(RequisitionTextModel instance)
        {
            OPEXEmailSentConfirm();
        }
    }
}
