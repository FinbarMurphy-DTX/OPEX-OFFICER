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
	public partial class OfficerEmailPromptBusinessRules : DatatecnixOfficerII.Rules.SharedBusinessRules
    {
        
        /// <summary>
        /// Rule "SetFirstField" implementation:
        /// This method will execute in any view for an action
        /// with a command name that matches "New".
        /// </summary>
        [Rule("r100")]


        public void r100Implementation(OfficerEmailPromptModel instance)
        {
            if (Officer.staffRecord != null)
            {
                if ((OPEX.askEmailSubject != null) || (OPEX.askEmailMessage != null))
                     {

                        Object o = Request.ExternalFilter;

                        Dictionary<string, string> kv = new Dictionary<string, string>();
                        foreach (var field in Request.ExternalFilter)
                        {
                            kv.Add(field.Name, field.Value != null ? field.Value.ToString() : null);
                        }

                        kv.Add("Surname", Officer.staffRecord.Surname);
                        kv.Add("Description", SelectFieldValue("Context_StiDesc") != null ? SelectFieldValue("Context_StiDesc").ToString()
                            : SelectFieldValue("Context_ItemStiDesc") != null ? SelectFieldValue("Context_ItemStiDesc").ToString()
                            : SelectFieldValue("Context_ItemCodeStiDesc") != null ? SelectFieldValue("Context_ItemCodeStiDesc").ToString()
                            : null);
                        kv.Add("OfficerEmail", Context.Session["OfficerEmail"].ToString());
                        kv.Add("Forname", Officer.staffRecord.Forname);

                        if (OPEX.askEmailSubject != null)
                        {
                            instance.Subject = OPEXFormatEmailTemplate(OPEX.askEmailSubject, kv);
                        }
                        if (OPEX.askEmailMessage != null)
                        {
                            instance.Message = OPEXFormatEmailTemplate(OPEX.askEmailMessage, kv);
                         }
                }
                Result.Focus("Message");
            }
            else
            {
                DatatecnixOfficerII.Services.ApplicationServices.Logout();
            }
        }
    }
}
