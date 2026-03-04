using DatatecnixOfficerII.Data;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

/* Overides for OAUth 2 Classes
 * 
 * Use a default set of roles for users 
 * 
 * Check the RQStaff table based on the user credentails matching the email address of the user
 * If their is a match then check the opex_user_name to see if there are any roles assigned to that user and assign those roles to the user
 * 
 * If there is no matching staff record the system will throw an message when the Office object is loaded
 * 
 * In the config set Sync Roles: true  these will force the roles to be compared and update 
 * against the roles set for the opex_user_name specified in the rq_staff record
 * 
 * 
 * */

namespace DatatecnixOfficerII.Services
{
    // Microsoft 
    public partial class MSGraphOAuthHandler : MSGraphOAuthHandlerBase
    {
        public override string[] GetDefaultUserRoles(MembershipUser user)

        {
            return new OPEXOAuthHandler().GetDefaultUserRoles(user);

        }

        public override List<string> GetUserRoles(MembershipUser user)
        {
            return new OPEXOAuthHandler().GetUserRoles(user);

        }
    }


    // Google
    public partial class GoogleOAuthHandler : GoogleOAuthHandlerBase
    {

        public override string[] GetDefaultUserRoles(MembershipUser user)

        {
            return new OPEXOAuthHandler().GetDefaultUserRoles(user);

        }

        public override List<string> GetUserRoles(MembershipUser user)
        {
            return new OPEXOAuthHandler().GetUserRoles(user);

        }

    }

    public class OPEXOAuthHandler
    {
        static string[] defaultRoles = {
                    "Officer","Officer-Detail","Officer-Profile"};
        public List<string> GetUserRoles(MembershipUser user)
        {

            using (SqlText popStocktake = new SqlText("select s.opex_user_name from rq_staff s where s.userCredentials = @email"))
            {
                popStocktake.AddParameter("@email", user.Email);
                var rslt = popStocktake.ExecuteScalar();
                if (rslt != DBNull.Value)
                {
                    var r = Roles.GetRolesForUser(rslt.ToString());
                    return r.ToList();
                }
            }

            return defaultRoles.ToList();
        }

        public string[] GetDefaultUserRoles(MembershipUser user)

        {

            if (user != null)
            {

                using (SqlText popStocktake = new SqlText("select s.opex_user_name from rq_staff s where s.userCredentials = @email"))
                {
                    popStocktake.AddParameter("@email", user.Email);
                    var rslt = popStocktake.ExecuteScalar();
                    if (rslt != DBNull.Value)
                    {
                        var r = Roles.GetRolesForUser(rslt.ToString());
                        var existingRoles = Roles.GetRolesForUser(user.UserName);
                        Roles.RemoveUserFromRoles(user.UserName, existingRoles);
                        return r;
                    }

                }
            }

            return defaultRoles;
        }
    }
}
