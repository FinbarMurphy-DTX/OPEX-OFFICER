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
        /// Rule "GetDefaults" implementation:
        /// This method will execute in any view for an action
        /// with a command name that matches "New".
        /// </summary>
        [Rule("r107")]
        public void r107Implementation(TrolleyLineLocationModel instance)
        {
            if (View == "nonStockForm")
            {
                instance.LineValue = 0;
                instance.ReqItemCost = 0;
                instance.Type = "N";
            }
            instance.LocationCode = Officer.staffRecord.LocationCode;
            instance.RequestedDate = System.DateTime.Now;
            TrolleyLocation t = TrolleyLocation.SelectSingle("rq_trolley_location.location_code = @s", new FieldValue("@s", Officer.staffRecord.LocationCode));
            if (t != null)
            {

                instance.CommentCode = t.DefaultCommentCode;
                instance.CommentDesc = t.DefaultCommentDesc;
            }
        }
    }
}
