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
	public partial class RequisitionLinesLocationsBusinessRules : DatatecnixOfficerII.Rules.SharedBusinessRules
    {
        
        /// <summary>
        /// This method will execute in any view for an action
        /// with a command name that matches "Custom" and argument that matches "Test".
        /// </summary>
        [Rule("r101")]
        public void r101Implementation(RequisitionLinesLocationsModel instance)
        {
            // This is the placeholder for method implementation.
        }
    }
}
