using System;
using System.Web.UI;
using IMSReportGenerator.Utils;

namespace IMSReportGenerator.Pages
{
    public partial class Login : System.Web.UI.Page
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
            ScriptManager.RegisterStartupScript(this, GetType(), "LoginModel", Helper.GetScriptTag(ResolveUrl("../Widgets/Login/Scripts/LoginModel.js")), false);
            ScriptManager.RegisterStartupScript(this, GetType(), "LoginCollection", Helper.GetScriptTag(ResolveUrl("../Widgets/Login/Scripts/LoginCollection.js")), false);
            ScriptManager.RegisterStartupScript(this, GetType(), "LoginView", Helper.GetScriptTag(ResolveUrl("../Widgets/Login/Scripts/LoginView.js")), false);
        }
    }
}