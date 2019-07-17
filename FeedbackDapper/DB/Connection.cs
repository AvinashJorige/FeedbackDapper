using System.Configuration;
using System.Web.Configuration;

namespace FeedbackDapper.DB
{
    public class Connection
    {
        private readonly Configuration config;
        private readonly ConnectionStringsSection sec;
        public Connection()
        {
            this.config = WebConfigurationManager.OpenWebConfiguration("~");
            sec = (ConnectionStringsSection)config.GetSection("connectionStrings");
            sec.ConnectionStrings["myConnectionString"].ConnectionString = "Data Source=DESKTOP-13LL2HE\\SQLSERVER;Initial Catalog=Practice;Persist Security Info=True;User ID=sa;Password=jorige";
            config.Save();
        }
    }
}