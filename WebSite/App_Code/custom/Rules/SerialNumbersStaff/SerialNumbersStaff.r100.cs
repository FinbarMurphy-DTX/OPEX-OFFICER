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
	public partial class SerialNumbersStaffBusinessRules : DatatecnixOfficerII.Rules.SharedBusinessRules
    {
        
        /// <summary>Rule "ReplaceSerialItem" implementation:
        /// This method will execute in any view for an action
        /// with a command name that matches "Custom" and argument that matches "Replace".
        /// </summary>
        [Rule("r100")]
        public void r100Implementation(SerialNumbersStaffModel instance)
        {
            
            using (SqlText popStocktake = new SqlText("call ReplaceSerialItem(@staffID,@oldSerialId,@newSerialId)"))

            {

                popStocktake.AddParameter("@staffID", instance.StaffUid);

                popStocktake.AddParameter("@oldSerialId", instance.ID);

                popStocktake.AddParameter("@newSerialId", SelectFieldValue("Parameters_NewSerialNumberId").ToString());

                popStocktake.ExecuteNonQuery();

            }
            OpexMessage("SN", "20", instance.SerialNumber.ToString(), SelectFieldValue("Parameters_NewSerialNumber").ToString());
        }
    }
}
