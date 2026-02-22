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
        /// Rule "UpadateRole" implementation:
        /// This method will execute in any view for an action
        /// with a command name that matches "Update".
        /// </summary>
        [Rule("r102")]
        public void r102Implementation(TrolleyPersonalModel instance)
        {
            if (Officer.staffRecord != null)
            {
                FieldValue role =  SelectFieldValueObject("RoleID");

                if (role.Modified)
                {
                    Sql("call EmptyStaffTrolley(@s)", new ParameterValue("@s", instance.StaffUid));
                    OPEXRefresh("view3");

                    RqRanks r = RqRanks.SelectSingle("rank_code = @r", new FieldValue("@r", instance.LocalRankCode));
                    if (r != null)
                    {
                        if (r.StaffFilter != null)
                        {

                            OPEXItemFilter = r.StaffFilter;
                        }
                            
                    }
                }
                Result.Continue();
            }
            else
            {
                    
               DatatecnixOfficerII.Services.ApplicationServices.Logout();
               
            }
        }
    }
}
