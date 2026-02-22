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
	public partial class TrolleyPersonalBusinessRules : DatatecnixOfficerII.Rules.SharedBusinessRules
    {
        
        /// <summary>
        /// Rule "SubmitPersonalTrolley" implementation:
        /// This method will execute in any view for an action
        /// with a command name that matches "Custom" and argument that matches "SubmitPersonalTrolley".
        /// </summary>
        [Rule("r100")]
        public void r100Implementation(TrolleyPersonalModel instance)
        {


            Int16 count = 0;

            using (SqlText popStocktake = new SqlText("select count(*) from rq_trolley_item t where t.staff_uid = @l"))
            {
                popStocktake.AddParameter("@l", Officer.staffRecord.StaffUid);
                count = Int16.Parse(popStocktake.ExecuteScalar().ToString());
            }

            if (count != 0)
            {
                Sql("call CreateReqFromTrolley(@StaffUid)");
                OPEXRefresh("view2");  // Trolley Personal
                OPEXRefresh("view3"); //Trolley Line Personal
                // Result.RefreshChildren();
                OpexMessage("SH", "1");
            }
            else
            {
                OpexMessage("SH", "10");
            }
        }


    }
}
