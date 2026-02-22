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
	public partial class SerialNumbersLocationBusinessRules : DatatecnixOfficerII.Rules.SharedBusinessRules
    {
        
        /// <summary>Rule "Assign" implementation:
        /// This method will execute in any view for an action
        /// with a command name that matches "Custom" and argument that matches "Asign".
        /// </summary>
        [Rule("r101")]
        public void r101Implementation(SerialNumbersLocationModel instance)
        {

            using (SqlText popStocktake = new SqlText("call AssignSerialItem(@staffID,@serialId)"))

            {

                popStocktake.AddParameter("@staffID", SelectFieldValue("Parameters_StaffId").ToString());

                popStocktake.AddParameter("@serialId", instance.ID);

                popStocktake.ExecuteNonQuery();

            }
            OpexMessage("SN", "21", instance.SerialNumber.ToString(), 
                SelectFieldValue("Parameters_StaffEpl").ToString() + "-" + SelectFieldValue("Parameters_StaffSurname").ToString());

        }
    }
}
