using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using DatatecnixOfficerII.Data;
using DatatecnixOfficerII.Models;
using System.Web.Configuration;
using System.Web.Security;
using Newtonsoft.Json;
using SmartFormat;
using System.Web;
// using static DatatecnixOfficerII.Rules.SharedBusinessRules;


// https://github.com/scottrippey/SmartFormat.NET/wiki

namespace DatatecnixOfficerII.Rules
{
    public partial class SharedBusinessRules : DatatecnixOfficerII.Data.BusinessRules
    {



        public String OPEXFormatEmailTemplate(String template, Dictionary<string,string> fred)
        {
            if (OPEX.debugEmailTemplates)
            {
                Smart.Default.Settings.FormatErrorAction = SmartFormat.Core.Settings.ErrorAction.ThrowError;
                Smart.Default.Settings.ParseErrorAction = SmartFormat.Core.Settings.ErrorAction.ThrowError;
            }
            else
            {
                Smart.Default.Settings.FormatErrorAction = SmartFormat.Core.Settings.ErrorAction.Ignore;
                Smart.Default.Settings.ParseErrorAction = SmartFormat.Core.Settings.ErrorAction.Ignore;
            }

            return Smart.Format(template, fred);


        }

        public void OPEXEmailSentConfirm()
        {
            OpexMessage("SH", "9");
            Result.Continue();
        }
           

        public void OPEXHideLocalField(string fieldName)
        {
            FieldValue myFakeField = SelectFieldValueObject(fieldName);
            if (myFakeField != null)
                myFakeField.Modified = false;
        }

        public Boolean OPEXquiteMode = false;

        public void OpexMessage(string moduleId, string msgNo, params string[] msgParameters)
        {

            Messages em = Messages.SelectSingle("msgNo=" + msgNo + " AND module_id=\"" + moduleId + "\"");



            {
                if (em == null)
                {
                    Result.ShowAlert("An unknown error has been detected please report this and quote Error Number " + moduleId + "-" + msgNo);
                }

                else if ((!OPEXquiteMode) || (em.ErrorType == "E"))
                {
                    Result.ShowAlert(em.ErrorMsg, msgParameters);


                }
                else
                {
                    /* TODO maybe we should store the messages that are suppressed in quite mode and display at a later time
                     * */
                }
            }
        }


        public String OPEXOption(string module, string name, Boolean required)


        {
            string add = null;
            Options option = Options.SelectSingle("id = \"" + module + "\" AND option_name = \"" + name + "\" ");
            if (option != null)
            {
                add = option.Value;
            }
            else if (required)
            {
                OpexMessage("AD", "1", name, module);
            }
            return add;
        }

        public String OPEXOptionUC(string module, string name, Boolean required)
        {
            String add = OPEXOption(module, name, required);
            return (add != null) ? add.ToUpper(): null;

        }


        public Boolean OPEXOption(string module, string name)
        {
            string lstring = OPEXOption(module, name, false);
            return  (lstring == null) ? false : (lstring.ToLower() == "true");
        }

        [Serializable()]
        public class OpexConfiguration
        {
            public String authenticationType;
            public String companyId;
            public String pricingModel;
            public String defaultCCOfficer;
            public String defaultCCLocation;
            public Boolean hidePricing;
            public Boolean hideStockLevels;
            public Boolean debugEmailTemplates;

            public String askEmailSubject;
            public String askEmailMessage;
            public String OfficerEmailHeader;
            public String OfficerEmailFooter;

            public UInt32 everyLocationCatalogue;
            public UInt32 everyStaffLocationCatalogue;

            public Boolean restrictStaffCatalogueByRank;
            public Boolean restrictStaffCatalogueByLocation;
        }

 
        public OpexConfiguration OPEX
        {
            get
            {
                string o = (string) Context.Session["OpexConfigurationOfficer"];

                OpexConfiguration fred = new OpexConfiguration();
                if (o == null)
                {

                
                    fred.companyId = OPEXOptionUC("AD", "Company Identifier", true);          
                    fred.authenticationType = OPEXOptionUC("AD", "Authentication", true);
                    fred.pricingModel = OPEXOptionUC("ST", "PricingModel", true);
                    fred.defaultCCOfficer = OPEXOption("SH", "Default Comment Code Officer", false);
                    fred.defaultCCLocation = OPEXOption("SH", "Default Comment Code Location", false);
                    fred.hidePricing = OPEXOption("SH","Hide Pricing");
                    fred.hideStockLevels = OPEXOption("SH", "Hide Stock Levels");
                    fred.debugEmailTemplates = OPEXOption("AD", "Debug Email Templates");

                    fred.askEmailSubject = OPEXOption("SH", "Ask Email Subject", false);
                    fred.askEmailMessage = OPEXOption("SH", "Ask Email Message", false);
                    fred.OfficerEmailHeader = OPEXOption("SH", "Officer Email Header", false);
                    fred.OfficerEmailFooter = OPEXOption("SH", "Officer Email Footer", false);


                    using (SqlText popStocktake = new SqlText("select l.location_catalogue_id from location_catalogue l where l.location_catalogue = @e "))

                    {
                        popStocktake.AddParameter("@e", "Every");
                        Object obj =  popStocktake.ExecuteScalar();
                        if (obj != null)
                        {
                            fred.everyLocationCatalogue = Convert.ToUInt32(obj);

                        }

                    }

                    using (SqlText popStocktake = new SqlText("select l.staff_location_catalogue_id from staff_location_catalogue l where l.staff_location_catalogue = @e "))

                    {
                        popStocktake.AddParameter("@e", "Every");
                        Object obj = popStocktake.ExecuteScalar();
                        if (obj != null)
                        {
                            fred.everyStaffLocationCatalogue = Convert.ToUInt32(obj);

                        }

                    }

                    fred.restrictStaffCatalogueByLocation = OPEXOption("SH", "Restrict Staff Catalogue By Location");
                    fred.restrictStaffCatalogueByRank = OPEXOption("SH", "Restrict Staff Catalogue By Rank");
                    Context.Session.Add("OpexConfigurationOfficer", JsonConvert.SerializeObject(fred));
                    // System.Web.HttpContext.Current.Session["OpexConfiguration"] = fred;
                    return fred;
                }
                else
                {
                    OpexConfiguration oj =  JsonConvert.DeserializeObject<OpexConfiguration>(o);
                    return oj;
                }
            }
        }


        public String OPEXItemFilter
        {
            get
            {
                string f = (string) Context.Session["ItemFilter"];


                if (f == null)
                {
                    f = "Every";
                    TrolleyPersonal tp = TrolleyPersonal.SelectSingle("rq_trolley.staff_uid=@s", new FieldValue("@s", Officer.staffRecord.StaffUid));
                    if (tp != null)
                    {
                        if (tp.LocalRankCode != null)
                        {
                            RqRanks r = RqRanks.SelectSingle("rank_code=@r", new FieldValue("@r", tp.LocalRankCode));
                            if (r != null)
                            {
                                f = r.StaffFilter;
                            }


                        }
                    }
                    Context.Session["ItemFilter"] = f;
                }
  

                return f;
            }
            set
            {
                Context.Session["ItemFilter"] = value;
            }
        }

        public class OpexOfficer
        {
            public string rank;
           // public String itemFilter;
            public StaffAccessControl staffRecord;


        }

        public OpexOfficer Officer

        {


            get
            {

               string o = (string)Context.Session["OPEXOfficerOfficer"];
                // object o = Context.Session["OPEXOfficer"];
                OpexOfficer fred = new OpexOfficer();


               
                if (o == null)
                {

                    // Get the Staff Record we use the clone becuase the staff controller is access control based on the officer staff_uid
                    StaffAccessControl staffRecord = new StaffAccessControl();


                    /* If we are using ASP Authentication then the staff record for the logged on user is  Membership.GetUser().UserName = opex_user_name
                     * If we are using WIN Authentication then the staff record for the logged on user i System.Security.Principal.WindowsIdentity.GetCurrent().Name = userCredentials
                     */



                if (OPEX.authenticationType == "WIN")

                      {
                            staffRecord = StaffAccessControl.SelectSingle("userCredentials = @p",
                                 new FieldValue("@p", System.Security.Principal.WindowsIdentity.GetCurrent().Name.Replace("\\", "")));

                        }
                 else if (OPEX.authenticationType == "MXD")

                    {
                        String oc = Context.Session["OPEXCredentials"].ToString();


         
                           
                            HttpCookie myCookie = new HttpCookie("OPEXCredentials");
                            myCookie["Credentials"] = oc ?? "OC IS NULL";
                            myCookie.Expires = DateTime.Now.AddDays(1d);
                            HttpContext.Current.Response.Cookies.Add(myCookie);


                        staffRecord = StaffAccessControl.SelectSingle("userCredentials = @p",
                             new FieldValue("@p", oc));

                        HttpCookie myCookie1 = new HttpCookie("OPEXStaffRecord");
                        myCookie1["StaffRecord"] = (staffRecord != null) ? staffRecord.StaffCode : "SR IS NULL";
                        myCookie1.Expires = DateTime.Now.AddDays(1d);
                        HttpContext.Current.Response.Cookies.Add(myCookie1);

                    }

                    else if (Membership.GetUser() != null)
                    {
                      
                        staffRecord = StaffAccessControl.SelectSingle("userCredentials = @p",
                            new FieldValue("@p", Membership.GetUser().UserName.Replace("\\", "")));



                    }

        
                    if (staffRecord != null)
                    {
   
                        Context.Session["OfficerEmail"] = staffRecord.Email ?? "info@datatecnix.co.uk";
                        Context.Session["AskEmail"] = OPEXOption("SH", "Question Email", false) ?? "info@datatecnix.co.uk";
                        fred.staffRecord = staffRecord;
                        fred.rank = staffRecord.RankCode;

                    }
                    else 
                    {
                        OpexMessage("SH", "5", Context.User.Identity.Name);
                        Result.Canceled = true;
                    }

                    Context.Session.Add("OPEXOfficerOfficer", JsonConvert.SerializeObject(fred));
                   
                    return fred;
                }
                else
                {
                    return JsonConvert.DeserializeObject<OpexOfficer>(o);
                   // return (OpexOfficer)(o);

                }
            
               
            }
       

        }

        // 1.9.8 #1595

        public class OPEXDefaultSize
        {
            public string defaultSize;
            public Boolean inProfile;

        }
        public OPEXDefaultSize OPEXGetDefaultSize(uint? officerId, string itemId)
        // Returns the default size specified for this item, or the only size 'All' if no default and only one size
        {
            OPEXDefaultSize defSize = new OPEXDefaultSize();
            if ((officerId != 0) || (officerId != null)) // This used to be a null check 22/01/15 FM
            {

                int sizeCount;
                using (SqlText popStocktake = new SqlText("SELECT size_code from rq_stitm st WHERE st.item_code = @item_code AND st.staff_uid = @staff_uid"))
                {
                    popStocktake.AddParameter("@item_code", itemId);
                    popStocktake.AddParameter("@staff_uid", officerId);
                    defSize.defaultSize = Convert.ToString(popStocktake.ExecuteScalar());

                    if (defSize.defaultSize == "")
                    {
                        //If there is no default value, check if there is only one size and use that as the default
                        defSize.inProfile = false;
                        using (SqlText sql2 = new SqlText("SELECT count(*) from  st_itmsz st WHERE st.item_code = @item_code"))
                        {
                            sql2.AddParameter("@item_code", itemId);
                            sizeCount = Convert.ToInt32(sql2.ExecuteScalar());
                        }

                        if (sizeCount == 1)
                        {
                            using (SqlText sql3 = new SqlText("SELECT size_code from  st_itmsz st WHERE st.item_code = @item_code"))
                            {
                                sql3.AddParameter("@item_code", itemId);
                                defSize.defaultSize = Convert.ToString(sql3.ExecuteScalar());
                            }
                        }


                    }
                    else
                    {
                        defSize.inProfile = true;
                    }

                }


            }
            return defSize;
        }



        public decimal OPEXCost(string item_code, string size_code)
        /* Returns the cost of an Item based on the pricing model being used, cost is from the item size record
         */

        {
            decimal itemCost = 0;
            object dbobj;
            using (SqlText popStocktake = new SqlText("select OPEXCost(@i,@s,null)"))
            {
                popStocktake.AddParameter("@i", item_code);
                popStocktake.AddParameter("@s", size_code);
                dbobj = popStocktake.ExecuteScalar();
            }


            itemCost = (dbobj == DBNull.Value) ? 0 : Convert.ToDecimal(dbobj);
         
            
            return itemCost;
        }


        public void OPEXRefresh(string formName)
        {
            
            Result.ExecuteOnClient("debugger; var df = Web.DataView.find('" + formName + "'); if (df) {df.refresh()}");
        }


        public void OPEXSharedBusinessRules()
        {
        }


    }
}
