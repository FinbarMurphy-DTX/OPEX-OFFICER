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
        /// Rule "GetSizeCost" implementation:
        /// This method will execute in any view for an action
        /// with a command name that matches "Calculate".
        /// </summary>
        [Rule("r101")]
        public void r101Implementation(TrolleyLinePersonalModel instance)
        {

            if (Arguments.Trigger == "ItemCode")
            {


                OPEXDefaultSize sc = OPEXGetDefaultSize(Officer.staffRecord.StaffUid, instance.ItemCode);

               
                if  (String.IsNullOrEmpty(sc.defaultSize))
                {
                    Result.Focus("SizeCode");
                }
                else
                {
                    decimal uc = OPEXCost(instance.ItemCode, sc.defaultSize);
                    instance.SizeCode = sc.defaultSize;
                    instance.ReqItemCost = uc;
                    instance.LineValue = instance.Qty * instance.ReqItemCost;

                    if (sc.inProfile)
                    {
                        instance.Local_StaffProfileSize = sc.defaultSize;
                    }
                    Result.Focus("Qty");
                }
               

                Result.Continue();
            }
        }
    }
}
