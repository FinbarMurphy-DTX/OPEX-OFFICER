using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using DatatecnixOfficerII.Data;
using System.Reflection;

namespace DatatecnixOfficerII.Rules
{
    public partial class SharedBusinessRules : DatatecnixOfficerII.Data.BusinessRules
    {

 

        public override bool SupportsVirtualization(string controllerName)
        /* Add the tag Virtual to the Page Data View then IsTagged = true
         * 
         */

        {

            MethodInfo mi = this.GetType().GetMethod("customise" + controllerName);
            if (mi != null)
            { 

                return true;
            }
            else
            {
                return false;
            }

            

        }


        protected override void VirtualizeController(string controllerName)
        {
            /* Customise by Controller Name
             * */

            //1.8.3 #1116

            //Get the method information using the method info class, need to b PUBLIC

            MethodInfo mi = this.GetType().GetMethod("customise" + controllerName);
            if (mi != null)
            {
                mi.Invoke(this, null);
            }
        }


        protected void HidePricing()  //TODO
        {

        }

        public void customiseItemAddPrompt()
        
        {
            if (OPEX.hidePricing)
            {
                NodeSet().SelectView("PromptView")
                    .SelectDataField("ReqItemCost").SetHidden(true)
                    .SelectDataField("LineValue").SetHidden(true);
            }

        }

        public void customiseTrolleyLinePersonal()

        {
            if (OPEX.hidePricing)
            {
                NodeSet().Select("//view")
                    .SelectDataFields("ReqItemCost").SetHidden(true)
                    .Select("//view").SelectDataFields("LineValue").SetHidden(true);
            }

            if (OPEX.companyId != "WF")
            {

                NodeSet().SelectField("ItemCode").Select("items").Attr("copy", "ItemStiDesc=StiDesc&#xD;&#xA;");
 
            }


        }

        public void customiseRequisitionLines()

        {
            if (OPEX.hidePricing)
            {
                NodeSet().Select("//view")
                    .SelectDataFields("ReqItemCost").SetHidden(true)
                    .Select("//view").SelectDataFields("LineValue").SetHidden(true);
            }


        }


        public void customiseRequisitionLinesLocations()

        {
            if (OPEX.hidePricing)
            {
                NodeSet().Select("//view")
                    .SelectDataFields("ReqItemCost").SetHidden(true)
                    .Select("//view").SelectDataFields("LineValue").SetHidden(true);
            }


        }

        public void customiseTrolleyPersonal()

        {
            if (OPEX.hidePricing)
            {
                NodeSet().Select("//view")
                    .Select("//view").SelectDataFields("HeaderValue").SetHidden(true);
            }

            if (OPEX.companyId != "WF")
            {

                NodeSet().SelectField("ItemCode").Select("items").Attr("copy", "ItemStiDesc=StiDesc&#xD;&#xA;");
            }
        }

        public void customiseItemCataloguePersonal()

        {
            if (OPEX.hidePricing)
            {
                NodeSet().Select("//view")
                    .SelectDataFields("Local_OPEXCost").SetHidden(true);
                    
            }

            if (OPEX.hideStockLevels)
            {
                NodeSet().Select("//view")
                    .SelectDataFields("StiFreStk").SetHidden(true);

            }

            if (OPEX.companyId == "WF")
            {
                NodeSet().Select("//view")
                      .SelectDataFields("ChargeCode").SetHidden(false)
                      .SelectDataFields("ChargeCodeDescription").SetHidden(false)
       
                     ;

            }
        }

        public void customiseItemCatalogueLocation()

        {
            if (OPEX.hidePricing)
            {
                NodeSet().Select("//view")
                    .SelectDataFields("Local_OPEXCost").SetHidden(true);


            }

            if (OPEX.hideStockLevels)
            {
                NodeSet().Select("//view")
                    .SelectDataFields("StiFreStk").SetHidden(true);

            }

            if (OPEX.companyId == "WF")
            {
                NodeSet().Select("//view")
                      .SelectDataFields("ChargeCode").SetHidden(false)
                      .SelectDataFields("ChargeCodeDescription").SetHidden(false)

                     ;
            }


            }

        public void customiseItem()

        {
            if (OPEX.hidePricing)
            {
                NodeSet().Select("//view")
                    .SelectDataFields("Local_OPEXCost").SetHidden(true);


            }

            if (OPEX.hideStockLevels)
            {
                NodeSet().Select("//view")
                    .SelectDataFields("StiFreStk").SetHidden(true);

            }

        }

        public void customiseItemSize()
        {
            if (OPEX.hidePricing)
            {
                NodeSet().Select("//view")
                    .SelectDataFields("Local_OPEXCost").SetHidden(true);

            }

            if (OPEX.hideStockLevels)
            {
                NodeSet().Select("//view")
                    .SelectDataFields("FreeQty").SetHidden(true);

            }
        }


        public void customiseTrolleyLocation()

        {
            if (OPEX.hidePricing)
            {
                NodeSet().Select("//view")
                    .Select("//view").SelectDataFields("HeaderValue").SetHidden(true);
            }


        }

        public void customiseTrolleyLineLocation()

        {
            if (OPEX.hidePricing)
            {
                NodeSet().Select("//view")
                    .SelectDataFields("ReqItemCost").SetHidden(true)
                    .Select("//view").SelectDataFields("LineValue").SetHidden(true);
            }
            if (OPEX.companyId != "WF")
            {

                NodeSet().SelectField("ItemCode").Select("items").Attr("copy", "ItemStiDesc=StiDesc&#xD;&#xA;");

            }



        }

        public void customiseItemAddPromptLocation()

        {
            if (OPEX.hidePricing)
            {
                NodeSet().SelectView("PromptView")
                    .SelectDataField("ReqItemCost").SetHidden(true)
                    .SelectDataField("LineValue").SetHidden(true);
            }


        }

    }
}
 