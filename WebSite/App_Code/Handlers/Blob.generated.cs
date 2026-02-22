namespace DatatecnixOfficerII.Handlers
{


    public partial class BlobFactoryConfig : BlobFactory
    {

        public static void Initialize()
        {
            // register blob handlers
            RegisterHandler("site_contentdata", "`opex`.`site_content`", "`data`", new string[] {
                        "`site_content_id`"}, "Opex Site Content Data", "opex_site_content", "data");
            RegisterHandler("st_itemPicture1", "`opex`.`st_item`", "`Picture1`", new string[] {
                        "`Rowid`"}, "Opexst Item Picture1", "Item", "Picture1");
            RegisterHandler("st_itemPicture", "`opex`.`st_item`", "`Picture`", new string[] {
                        "`Rowid`"}, "Opexst Item Picture", "Item", "Picture");
        }
    }
}
