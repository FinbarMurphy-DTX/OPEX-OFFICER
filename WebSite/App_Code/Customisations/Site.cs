using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Caching;
using System.Web.Configuration;
using System.Web.Hosting;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using DatatecnixOfficerII.Data;
using DatatecnixOfficerII.Models;


namespace DatatecnixOfficerII.Services
{
  

    public partial class ApplicationServices : EnterpriseApplicationServices
    {
    

        /*
                public override string UserHomePageUrl()
                {
                    if (IsSiteContentEnabled)
                    {
                        SiteContentFile index = ReadSiteContent("index");
                        if (index != null)
                            return HttpContext.Current.Request.ApplicationPath;
                    }
                    if (HttpContext.Current.User.Identity.IsAuthenticated)
                    {
                        return "~/pages/MyCatalogue";
                    }
                    return "~/pages/home";
                }

          */

        public override void UserLogout()
        {

            System.Web.HttpContext.Current.Session["OpexConfiguration"] = null;
            System.Web.HttpContext.Current.Session["OPEXOfficer"] = null;
            System.Web.HttpContext.Current.Session["OPEXOCredentials"] = null;
            System.Web.HttpContext.Current.Session["OfficerEmail"] = null;
            System.Web.HttpContext.Current.Session["AskEmail"] = null;
            System.Web.HttpContext.Current.Session["ItemFilter"] = null;

            base.UserLogout();
        }

    }

}

namespace DatatecnixOfficerII.Handlers
{




    public partial class Site : SiteBase
    {
        public String OPEXOption(string module, string name)
        {
            string add = null;
            Options option = new Options();
            option = Options.SelectSingle("id = \"" + module + "\" AND option_name = \"" + name + "\" ");
            if (option != null)
            {
                add = option.Value;
            }

            return add;
        }

        protected override void OnInit(System.EventArgs e)
        {
            String authMethod = OPEXOption("AD","Authentication");
            MembershipUser user = null;

            Boolean fDebug = false;

            /*

            Options option = new Options();
            option = Options.SelectSingle("id = \"AD\" AND option_name = \"Authentication\" ");        
            if (option != null)
            {
                authMethod = option.Value;
            }
            */



            if (!Page.User.Identity.IsAuthenticated)
            // TODO  This shoud probably be a straight SQL query as we are not logged in to OPEX III so the controllers are all Public
            {
                if (authMethod == "WIN")
                {
                    string opex_user_name;
                    //               string opex_credentials = System.Security.Principal.WindowsIdentity.GetCurrent().Name.Replace("\\", "");

                    string opex_credentials = Request.LogonUserIdentity.Name.Replace("\\", "");

                    using (SqlText popStocktake = new SqlText("select s.opex_user_name from rq_staff s where s.userCredentials = @uc"))
                    {
                        popStocktake.AddParameter("@uc", opex_credentials);
                        opex_user_name = (string)popStocktake.ExecuteScalar();
                    }

                    user = (opex_user_name != null) ? Membership.GetUser(opex_user_name) : null;


                    if (user == null)
                    {


                        user = Membership.GetUser("guest");
                        if (user != null)
                        {
                            FormsAuthentication.RedirectFromLoginPage(user.UserName, false);
                        }

                    }
                    else
                    {
                        string welcome;
                        using (SqlText popStocktake = new SqlText("select concat(s.forname,\" \",s.surname) from rq_staff s where s.userCredentials = @uc"))
                        {
                            popStocktake.AddParameter("@uc", opex_credentials);
                            welcome = (string)popStocktake.ExecuteScalar();
                        }

                        //            ID4.Text = "Welcome String is:" + welcome;

                        Context.Session["OPEXWelcome"] = (fDebug ? "1 " : "") + welcome;
                        Context.Session["OPEXCredentials"] = opex_credentials;
                        FormsAuthentication.RedirectFromLoginPage(user.UserName, false);
                        //        FormsAuthentication.RedirectFromLoginPage("system", false);
                    }
                }
                else if (authMethod == "MXD")
                {
                    string opex_user_name;
                    string encrypted = Request.QueryString["username"];
                    // string opex_credentials = encrypted != null ? StringCipher.Decrypt(encrypted, "FRED") : null;
                    string opex_credentials = encrypted;

                    string OPEXredirectURL = Request.QueryString["OPEXredirectURL"];

                    if (OPEXredirectURL != null)
                    {
                        Context.Session["OPEXredirectURL"] = OPEXredirectURL;
                        HttpCookie myCookie = new HttpCookie("OPEXredirectURL");
                        myCookie["URL"] = OPEXredirectURL;
                        myCookie.Expires = DateTime.Now.AddDays(1d);
                        Response.Cookies.Add(myCookie);
                        
                        
                    }


                    using (SqlText popStocktake = new SqlText("select s.opex_user_name from rq_staff s where s.userCredentials = @uc"))
                    {
                        popStocktake.AddParameter("@uc", opex_credentials);
                        opex_user_name = (string)popStocktake.ExecuteScalar();
                    }
                    user = (opex_user_name != null) ? Membership.GetUser(opex_user_name) : null;

                    /*          This way is nicer but you get caught calling it when not logged in
                     *
                                    Staff_Clone_AccessControl sr = Staff_Clone_AccessControl.SelectSingle(String.Format("select s.opex_user_name from rq_staff s where s.userCredentials = {0}", opex_credentials));
                                    user = (sr != null) ? Membership.GetUser(sr.opex_user) : null;
     
                    */

                    if (user == null)
                    {


                        object redirect = HttpContext.Current.Session["OPEXredirectURL"];
                        string rd = (String)redirect;
                        if (rd != null)
                        {
                            HttpContext.Current.Session["OPEXredirectURL"] = null;
                            if (Context.Session["OPEXCredentials"] == null)  // User Credentials not found
                            {
                                HttpContext.Current.Response.Redirect(rd + "?invalid=true", true);
                            }
                            else // Valid User who has logged out 
                            {
                                HttpContext.Current.Session["OPEXCredentials"] = null;
                                HttpContext.Current.Session["OPEXOfficer"] = null;
                                HttpContext.Current.Response.Redirect(rd, true);
                            }
                        }
                        else // THe user sessin has timed out or they are not coming from another domanin
                        {

                            if (Request.QueryString["_remote"] == "true")
                            {

                            }
                            else // The IIS session has finished so check forthe return url in a cookie
                            {


                                HttpContext.Current.Session["OPEXCredentials"] = null;
                                HttpContext.Current.Session["OPEXOfficer"] = null;
                                HttpCookie myCookie1 = Request.Cookies["OPEXredirectURL"];
                                if (myCookie1 != null)
                                {
                                    string url = myCookie1["URL"];
                                    if (url != null)
                                    {
                                        HttpContext.Current.Response.Redirect(url, false);
                                    }
                                }
                                else
                                {
                                    string lastURL = OPEXOption("AD", "URL Redirect Officer");
                                    if (lastURL != null)
                                    {
                                        HttpContext.Current.Response.Redirect(lastURL + "?Message=NoCookie", false);
                                    }
                                }

                            }
                        }


                    }
                    else
                    {
                        string welcome;
                        using (SqlText popStocktake = new SqlText("select concat(IFNULL(s.forname,\" \"),\" \",IFNULL(s.surname,\" \")) from rq_staff s where s.userCredentials = @uc"))
                        {
                            popStocktake.AddParameter("@uc", opex_credentials);
                            welcome = (string)popStocktake.ExecuteScalar();
                        }
                        Context.Session["OPEXWelcome"] = (fDebug ? "2 " : "") + welcome;
                        Context.Session["OPEXCredentials"] = opex_credentials;
                        FormsAuthentication.RedirectFromLoginPage(user.UserName, false);


                    }
                }
            }
            else if ((authMethod == "MXD") || (authMethod == "ASP")) // This is the case for mixed mode when you signon with local OPEX Credentials
            {

                // The first case is when you have a local domain user sometimes they are autenticated first time through so we never catch the credentials and or the session is reset I don't know how that can happen so this is a guess !
                if (fDebug)
                {
                    //               ID12.Text = "Request URL Query " + Request.Url.Query;
                    //              ID13.Text = "Request Raw URL " + Request.RawUrl.ToString();
                }

                if ((Context.Session["OPEXCredentials"] == null) && (Request.QueryString["username"] != null))
                {
                    Context.Session["OPEXCredentials"] = Request.QueryString["username"];
                }
                else if ((Context.Session["OPEXCredentials"] == null) && (authMethod == "MXD") && (OPEXOption("AD", "Load Balancer") == "Yes"))

                // Special Case to catch the laod balancer changing between the refresh ( I think)
                {
                    HttpCookie myCookie1 = Request.Cookies["OPEXredirectURL"];
                    if (myCookie1 != null)
                    {
                        string url = myCookie1["URL"];
                        if (url != null)
                        {
                            HttpContext.Current.Response.Redirect(url + "?Message=LBP", true);
                        }
                    }
                    else
                    {
                        string lastURL = OPEXOption("AD", "URL Redirect Officer");
                        if (lastURL != null)
                        {
                            HttpContext.Current.Response.Redirect(lastURL + "?Message=LBP", true);
                        }
                    }
                }
                else if ((Context.Session["OPEXCredentials"] == null) && (System.Web.Security.Membership.GetUser() != null))
                {
                    Context.Session["OPEXCredentials"] = System.Web.Security.Membership.GetUser().UserName;
                }
            }
            else if ((authMethod == "WIN") && (System.Web.Security.Membership.GetUser() == null) && (Context.Session["OPEXCredentials"] == null))

            // This is the case for WIndows modes when you have a valid session in another browser window ( I Think)
            // If you have IIS setup for Windows Authentication it will always come here so duplicate the process above, set the COTS user/role
            {

                string opex_user_name;
                string opex_credentials = Request.LogonUserIdentity.Name.Replace("\\", "");

                using (SqlText popStocktake = new SqlText("select s.opex_user_name from rq_staff s where s.userCredentials = @uc"))
                {
                    popStocktake.AddParameter("@uc", opex_credentials);
                    opex_user_name = (string)popStocktake.ExecuteScalar();
                }

                user = (opex_user_name != null) ? Membership.GetUser(opex_user_name) : null;


                if (user == null)
                {


                    user = Membership.GetUser("guest");
                    if (user != null)
                    {
                        FormsAuthentication.RedirectFromLoginPage(user.UserName, false);
                    }

                }
                else
                {
                    string welcome;
                    using (SqlText popStocktake = new SqlText("select concat(s.forname,\" \",s.surname) from rq_staff s where s.userCredentials = @uc"))
                    {
                        popStocktake.AddParameter("@uc", opex_credentials);
                        welcome = (string)popStocktake.ExecuteScalar();
                    }

                    Context.Session["OPEXWelcome"] = (fDebug ? "3 " : "") + welcome;
                    Context.Session["OPEXCredentials"] = opex_credentials;
                    FormsAuthentication.RedirectFromLoginPage(user.UserName, false);

                }
            }
            else if (authMethod == "3RP")
            {

            }

            base.OnInit(e);


        }


    }
}