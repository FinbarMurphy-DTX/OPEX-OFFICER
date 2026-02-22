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
	public partial class TrolleyLocationBusinessRules : DatatecnixOfficerII.Rules.SharedBusinessRules
    {
        
        /// <summary>
        /// Rule "SubmitPersonalTrolley" implementation:
        /// This method will execute in any view for an action
        /// with a command name that matches "Custom" and argument that matches "SubmitPersonalTrolley".
        /// </summary>
        [Rule("r100")]
        public void r100Implementation(TrolleyLocationModel instance)
        {
            Int16 count = 0;

            using (SqlText popStocktake = new SqlText("select count(*) from rq_trolley_item_location t where t.location_code = @l"))
            { 
                popStocktake.AddParameter("@l", Officer.staffRecord.LocationCode);
                count = Int16.Parse(popStocktake.ExecuteScalar().ToString());
            }

            if (count != 0)
            {
                Sql("call CreateReqFromLocationTrolley(@LocationCode,@sid)", new ParameterValue("@sid", Officer.staffRecord.StaffUid),
                    new ParameterValue("@LocationCode", Officer.staffRecord.LocationCode));
                OPEXRefresh("view2");
                OPEXRefresh("view1");
                OpexMessage("SH", "1");
            }
            else
            {
                OpexMessage("SH", "10");
            }
        }
    }
}
