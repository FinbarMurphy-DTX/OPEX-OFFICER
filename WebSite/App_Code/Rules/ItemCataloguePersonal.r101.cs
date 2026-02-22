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
	public partial class ItemCatalogueBusinessRules : DatatecnixOfficerII.Rules.SharedBusinessRules
    {
        
        /// <summary>
        /// Rule "AddItemToTrolley" implementation:
        /// This method will execute in any view for an action
        /// with a command name that matches "Custom" and argument that matches "Add".
        /// </summary>
        [Rule("r101")]
        public void r101Implementation(ItemCataloguePersonalModel instance)
        {
            TrolleyLinePersonal line = new TrolleyLinePersonal();
            String size = SelectFieldValue("Parameters_SizeCode").ToString();
            line.ItemCode = instance.ItemCode;
            line.SizeCode = SelectFieldValue("Parameters_SizeCode").ToString();
            line.Qty = Int32.Parse(SelectFieldValue("Parameters_Qty").ToString());
            line.StaffUid = Officer.staffRecord.StaffUid;
            line.CommentCode = SelectFieldValue("Parameters_CommentCode").ToString();
            decimal uc = OPEXCost(instance.ItemCode, size);
            line.ReqItemCost = uc;
            line.LineValue = line.Qty * line.ReqItemCost;

            object us = SelectFieldValue("Parameters_UpdateStaffProfile");  // 1.9.9 #1595
            if (us != null)
                {
                line.UpdateStaffProfile = us.ToString();

            }
            line.Type = "S";
            us = SelectFieldValue("Parameters_Description");  // 1.9.9 #1595
            if (us != null)
            {
                line.AdditionalInformation = us.ToString();

            }


            line.Insert();
            /*
            Result.ExecuteOnClient("$app.alert(\'{0}\', function () {{ window.history.go(-1); }})", Localize("NewPasswordAlert", "A new password has been emailed to the address on file."));
            this.PreventDefault();
            */

             OPEXRefresh("view2");
             OPEXRefresh("view3");
             Result.Continue();
             OpexMessage("SH", "8",line.ItemCode,line.SizeCode);
            // Result.ExecuteOnClient("$app.touch.show({ controller: 'ItemCataloguePersonal', view: 'grid1' });");
        }
    }
}
