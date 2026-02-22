using DatatecnixOfficerII.Handlers;
using DatatecnixOfficerII.Web;
using System.Web.Configuration;

namespace DatatecnixOfficerII.Services
{
    public class AppFrameworkConfig
    {

        public virtual void Initialize()
        {
            ApplicationServices.FrameworkAppName = "OPEX 2.3.7";
            ApplicationServices.FrameworkSiteContentControllerName = "opex_site_content";
            ApplicationServices.Version = "8.9.44.36";
            ApplicationServices.HostVersion = "1.2.5.0";
            var compilation = ((CompilationSection)(WebConfigurationManager.GetSection("system.web/compilation")));
            var releaseMode = !compilation.Debug;
            AquariumExtenderBase.EnableMinifiedScript = releaseMode;
            AquariumExtenderBase.EnableCombinedScript = releaseMode;
            ApplicationServices.EnableMinifiedCss = releaseMode;
            ApplicationServices.EnableCombinedCss = releaseMode;
            BlobFactoryConfig.Initialize();
        }
    }
}
