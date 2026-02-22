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
        /// Rule "GetDefaults" implementation:
        /// This method will execute in any view for an action
        /// with a command name that matches "New".
        /// </summary>
        [Rule("r107")]
        public void r107Implementation(TrolleyLinePersonalModel instance)
        {
            TrolleyPersonal t = TrolleyPersonal.SelectSingle("rq_trolley.staff_uid = @s", new FieldValue("@s",Officer.staffRecord.StaffUid));
            if (t != null)
            {

                instance.CommentCode = t.DefaultCommentCode;
                instance.CommentDesc = t.DefaultCommentCodeCommentDesc;
                instance.ReqItemCost = 0;
                instance.LineValue = 0;
                instance.Type = (View == "nonStockForm") ? instance.Type = "N" : instance.Type = "S";
            }
        }
    }
}
