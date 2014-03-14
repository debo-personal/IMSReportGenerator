using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using IMSReportGenerator.Utils;

namespace ReportGeneratorService.Pages
{
    public partial class Listing : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RegisterScripts();
        }

        private void RegisterScripts()
        {
            ScriptManager.RegisterStartupScript(this, GetType(), "BootstrapCss", Helper.GetStyleTag(ResolveUrl("../Utils/Stylesheets/bootstrap1.min.css")), false);
            ScriptManager.RegisterStartupScript(this, GetType(), "Local", Helper.GetStyleTag(ResolveUrl("../Utils/Stylesheets/local.css")), false);

            //base scripts
            ScriptManager.RegisterStartupScript(this, GetType(), "Jquery", Helper.GetScriptTag(ResolveUrl("../Utils/Scripts/Jquery.js")), false);
            ScriptManager.RegisterStartupScript(this, GetType(), "Mustache", Helper.GetScriptTag(ResolveUrl("../Utils/Scripts/Mustache.js")), false);
            ScriptManager.RegisterStartupScript(this, GetType(), "Bootstrap", Helper.GetScriptTag(ResolveUrl("../Utils/Scripts/bootstrap.js")), false);
            ScriptManager.RegisterStartupScript(this, GetType(), "Underscore", Helper.GetScriptTag(ResolveUrl("../Utils/Scripts/Underscore.js")), false);
            ScriptManager.RegisterStartupScript(this, GetType(), "Backbone", Helper.GetScriptTag(ResolveUrl("../Utils/Scripts/Backbone.js")), false);

            //register views
            ScriptManager.RegisterStartupScript(this, GetType(), "ViewTemplates", Helper.GetScriptTag(ResolveUrl("../Widgets/Templates/ViewTemplates.js")), false);
            ScriptManager.RegisterStartupScript(this, GetType(), "ListingModel", Helper.GetScriptTag(ResolveUrl("../Widgets/Listing/Scripts/ListingModel.js")), false);
            ScriptManager.RegisterStartupScript(this, GetType(), "ListingCollection", Helper.GetScriptTag(ResolveUrl("../Widgets/Listing/Scripts/ListingCollection.js")), false);
            ScriptManager.RegisterStartupScript(this, GetType(), "ListingView", Helper.GetScriptTag(ResolveUrl("../Widgets/Listing/Scripts/ListingView.js")), false);
        }
    }
}