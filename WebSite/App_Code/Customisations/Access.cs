using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using DatatecnixOfficerII.Data;

namespace DatatecnixOfficerII.Rules
{

    public partial class RequisitionTextBusinessRules : DatatecnixOfficerII.Rules.SharedBusinessRules
    {

        [AccessControl("RequisitionText", "rqHeaderStaffUid")]
        public void restrictByStaffCode()
        {

            if (UserIsInRole("Officer"))
                RestrictAccess(Officer.staffRecord.StaffUid);
            else
                UnrestrictedAccess();

        }
    }

    public partial class RequisitionTextLocationBusinessRules : DatatecnixOfficerII.Rules.SharedBusinessRules
    {

        [AccessControl("RequisitionTextLocation", "rqHeaderLocationCode")]
        public void restrictByStaffCode()
        {

            if (UserIsInRole("Officer"))
                RestrictAccess(Officer.staffRecord.LocationCode);
            else
                UnrestrictedAccess();

        }
    }

    public partial class RequisitionLinesBusinessRules : DatatecnixOfficerII.Rules.SharedBusinessRules
    {

        [AccessControl("RequisitionLines", "rqHeaderStaffUid")]
        public void restrictByStaffCode()
        {

            if (UserIsInRole("Officer"))
                RestrictAccess(Officer.staffRecord.StaffUid);
            else
                UnrestrictedAccess();

        }
    }

    public partial class RequisitionLinesLocationsBusinessRules : DatatecnixOfficerII.Rules.SharedBusinessRules
    {

        [AccessControl("RequisitionLinesLocations", "rqHeaderLocationCode")]
        public void restrictByStaffCode()
        {

            if (UserIsInRole("Location"))
                RestrictAccess(Officer.staffRecord.LocationCode);
            else
                UnrestrictedAccess();

        }
    }

    public partial class ItemCatalogueBusinessRules : DatatecnixOfficerII.Rules.SharedBusinessRules
    {


        [AccessControl("ItemCatalogue", "staffFilter")]
        public void restrictByRankCodeItemCatalogue()
        {
           // if (Officer.staffRecord != null)
          

                if (UserIsInRole("Officer"))
                {
                if (OPEX.restrictStaffCatalogueByRank)
                {
                    RestrictAccess("Every");
                    RestrictAccess(OPEXItemFilter);
                }
                else
                {
                    RestrictAccess();
                }
            }
                else
                    UnrestrictedAccess();
            



        }


        [AccessControl("ItemCatalogue", "StaffLocationCatalogueid")]
        public void restrictByLocationCodeItemCatalogue()
        {
            // if (Officer.staffRecord != null)


            if (UserIsInRole("Officer"))
            {

                if (OPEX.restrictStaffCatalogueByLocation)
                {
                    RestrictAccess(OPEX.everyStaffLocationCatalogue); ;
                    RestrictAccess(Officer.staffRecord.LocationStaffLocationCatalogueid);
                }
                else
                {
                    RestrictAccess();
                        }
            }
            else
                UnrestrictedAccess();




        }

    }


    public partial class StaffBusinessRules : DatatecnixOfficerII.Rules.SharedBusinessRules
    {

        // For an officer only show Staff record with his id

        [AccessControl("Staff", "StaffUid")]
        public void restrictByStaffCode()
        {

            if (UserIsInRole("Officer"))
                RestrictAccess(Officer.staffRecord.StaffUid);
            else
                UnrestrictedAccess();

        }

    }


    public partial class TrolleyPersonalBusinessRules : DatatecnixOfficerII.Rules.SharedBusinessRules
    {


        // For an officer only show Staff record with his id

        [AccessControl("TrolleyPersonal", "StaffUid")]
        public void restrictByStaffCode()
        {

            if (UserIsInRole("Officer"))

                RestrictAccess(Officer.staffRecord.StaffUid);
                
            else
                UnrestrictedAccess();

        }

    }

    public partial class ProfileBusinessRules : DatatecnixOfficerII.Rules.SharedBusinessRules
    {
        // For an officer only show Staff record with his id

        [AccessControl("Profile", "StaffUid")]
        public void restrictByStaffCode()
        {

            if (UserIsInRole("Officer"))
                RestrictAccess(Officer.staffRecord.StaffUid);
            // RestrictAccess(950);
            else
                UnrestrictedAccess();

        }
    }




    public partial class TrolleyLocationBusinessRules : DatatecnixOfficerII.Rules.SharedBusinessRules
    {


        // For an officer only show Staff record with his id

        [AccessControl("TrolleyLocation", "LocationCode")]
        public void restrictByStaffCode()
        {
            if (UserIsInRole("Location"))

                RestrictAccess(Officer.staffRecord.LocationCode);
            // RestrictAccess(950);
            else
                UnrestrictedAccess();

        }

    }


    public partial class TrolleyLinePersonalBusinessRules : DatatecnixOfficerII.Rules.SharedBusinessRules
    {


        // For an officer only show Staff record with his id

        [AccessControl("TrolleyLinePerson", "StaffUid")]
        public void restrictByStaffCode()
        {

            if (UserIsInRole("Officer"))

                RestrictAccess(Officer.staffRecord.StaffUid);

            else
                UnrestrictedAccess();

        }

    }

    public partial class TrolleyLineLocationBusinessRules : DatatecnixOfficerII.Rules.SharedBusinessRules
    {


        // For an officer only show Staff record with his id

        [AccessControl("TrolleyLineLocation", "LocationCode")]
        public void restrictByStaffCode()
        {

            if (UserIsInRole("Location"))

                RestrictAccess(Officer.staffRecord.LocationCode);

            else
                UnrestrictedAccess();

        }

    }


    public partial class ItemCatalogueLocationBusinessRules : DatatecnixOfficerII.Rules.SharedBusinessRules
    {


        // For an officer only show Staff record with his id

        [AccessControl("ItemCatalogueLocation", "LocationCatalogueid")]
        public void restrictByStaffCode()
        {

            if (UserIsInRole("Location"))
            {
                RestrictAccess(OPEX.everyLocationCatalogue);
                RestrictAccess(Officer.staffRecord.LocationCatalogueid);
            }
            // RestrictAccess(950);
            else
                UnrestrictedAccess();

        }

    }

    public partial class SerialNumbersStaffBusinessRules : DatatecnixOfficerII.Rules.SharedBusinessRules
    {       

        [AccessControl("SerialNumbersStaff", "StaffUid")]
        public void restrictByStaffCode()
        {

            if (UserIsInRole("Location"))
            {
                    RestrictAccess(Officer.staffRecord.StaffUid);
            }
     
            else
                UnrestrictedAccess();

        }

    }

    public partial class SerialNumbersLocationBusinessRules : DatatecnixOfficerII.Rules.SharedBusinessRules
    {

    
        [AccessControl("SerialNumbersLocation", "LocationCode")]
        public void restrictByLocationCode()
        {

            RestrictAccess(Officer.staffRecord.LocationCode);


        }
    }

}

