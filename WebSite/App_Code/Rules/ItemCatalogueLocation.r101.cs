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
	public partial class ItemCatalogueLocationBusinessRules : DatatecnixOfficerII.Rules.SharedBusinessRules
    {
        
        /// <summary>
        /// Rule "AddItemToTrolley" implementation:
        /// This method will execute in any view for an action
        /// with a command name that matches "Custom" and argument that matches "Add".
        /// </summary>
        [Rule("r101")]
        public void r101Implementation(ItemCatalogueLocationModel instance)
        {
            TrolleyLineLocation line = new TrolleyLineLocation();
            String size = SelectFieldValue("Parameters_SizeCode").ToString();
            line.ItemCode = instance.ItemCode;
            line.SizeCode = SelectFieldValue("Parameters_SizeCode").ToString();
            line.Qty = Int32.Parse(SelectFieldValue("Parameters_Qty").ToString());
            line.LocationCode = Officer.staffRecord.LocationCode;
            line.CommentCode = SelectFieldValue("Parameters_CommentCode").ToString();
            decimal uc = OPEXCost(instance.ItemCode, size);
            line.ReqItemCost = uc;
            line.LineValue = line.Qty * line.ReqItemCost;
            line.RequestedBy = Officer.staffRecord.StaffUid;
            line.RequestedDate = System.DateTime.Now;
            line.Type = "S";
            object us = SelectFieldValue("Parameters_Description");  // 1.9.9 #1595
            if (us != null)
            {
                line.AdditionalInformation = us.ToString();

            }
            line.Insert();
            OPEXRefresh("view1"); // Location Trolley Header
            OPEXRefresh("view2");// Location Trolley Lines
            Result.Continue();
            OpexMessage("SH", "8",line.ItemCode,line.SizeCode);
        }
    }
}
