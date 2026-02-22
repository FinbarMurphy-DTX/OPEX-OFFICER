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
	public partial class ItemAddPromptBusinessRules : DatatecnixOfficerII.Rules.SharedBusinessRules
    {
        
        /// <summary>
        /// Rule "GetDefaultSize" implementation:
        /// This method will execute in any view for an action
        /// with a command name that matches "New".
        /// </summary>
        [Rule("r100")]
        public void r100Implementation(ItemAddPromptModel instance)
        {

        
            string ic = SelectFieldValue("Context_ItemCode").ToString();
            OPEXDefaultSize sc = OPEXGetDefaultSize(Officer.staffRecord.StaffUid, ic);
            

            if (String.IsNullOrEmpty(sc.defaultSize))
            {
               //Result.Focus("SizeCode");
            }
            else
            {

                instance.SizeCode = sc.defaultSize;
                         
                   decimal uc = OPEXCost(ic, sc.defaultSize);
                    instance.ReqItemCost = uc;
                    instance.LineValue = instance.Qty * instance.ReqItemCost;
                if (sc.inProfile)
                {
                    instance.Local_StaffProfileSize = sc.defaultSize;
                }

              //Result.Focus("Qty");
            }

            TrolleyPersonal t = TrolleyPersonal.SelectSingle("rq_trolley.staff_uid = @s", new FieldValue("@s", Officer.staffRecord.StaffUid));
            if (t != null)
            {

                instance.CommentCode = t.DefaultCommentCode;
                instance.CommentDesc = t.DefaultCommentCodeCommentDesc;
            }

            
            Result.Continue();
        }
    }
}
