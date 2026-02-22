using DatatecnixOfficerII.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace DatatecnixOfficerII.Services
{
    public partial class MSGraphOAuthHandler : MSGraphOAuthHandlerBase
    {
        public override string[] GetDefaultUserRoles(MembershipUser user)
        {
            return new string[] {
                    "Officer","Officer-Detail","Officer-Profile"};
        }
    }

        public partial class GoogleOAuthHandler : GoogleOAuthHandlerBase
    {
        public override string[] GetDefaultUserRoles(MembershipUser user)
        {
            return new string[] {
                    "Officer","Officer-Detail","Officer-Profile"};
        }
        public override MembershipUser SyncUser()
        {
            var username = GetUserName();
            var email = GetUserEmail();
            var user = Membership.GetUser(username);
            if (user == null)
            {
                var userNameOfEmailOwner = Membership.GetUserNameByEmail(username);
                if (!string.IsNullOrEmpty(userNameOfEmailOwner))
                    user = Membership.GetUser(userNameOfEmailOwner);
            }
            if ((user == null) && (Config["Sync User"] == "true"))
            {
                // create user
                var comment = ("Source: " + GetHandlerName());
                MembershipCreateStatus status;
                if (string.IsNullOrEmpty(email))
                    email = username;
                user = Membership.CreateUser(username, Guid.NewGuid().ToString(), email, comment, Guid.NewGuid().ToString(), true, out status);
                if (status != MembershipCreateStatus.Success)
                    throw new Exception(status.ToString());
                user.Comment = comment;
                Membership.UpdateUser(user);
                Roles.AddUserToRoles(user.UserName, GetDefaultUserRoles(user));
            }
            if (user != null)
            {
                if (!string.IsNullOrEmpty(email) && email != user.Email)
                {
                    user.Email = email;
                    Membership.UpdateUser(user);
                }
                SetUserAvatar(user);
                if (Config["Sync Roles"] == "true")
                {
                    // verify roles
                    var roleList = GetUserRoles(user);
                    foreach (var role in roleList)
                        if (!Roles.IsUserInRole(user.UserName, role))
                        {
                            if (!Roles.RoleExists(role))
                                Roles.CreateRole(role);
                            Roles.AddUserToRole(user.UserName, role);
                        }
                    var existingRoles = new List<string>(Roles.GetRolesForUser(user.UserName));
                    foreach (var oldRole in existingRoles)
                        if (!roleList.Contains(oldRole))
                            Roles.RemoveUserFromRole(user.UserName, oldRole);
                }
            }

            if (user == null)
            {
                var opex_user_name = "";
                using (SqlText popStocktake = new SqlText("select s.opex_user_name from rq_staff s where s.email = @email"))
                {
                    popStocktake.AddParameter("@email", username);
                    opex_user_name = (string)popStocktake.ExecuteScalar();
                }

                user = (opex_user_name != null) ? Membership.GetUser(opex_user_name) : null;
            }

            ApplicationServicesBase.Create().OAuthSyncUser(user);
            return user;
        }
    }
}
