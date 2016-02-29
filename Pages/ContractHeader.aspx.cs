using JG_Prospect.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JG_Prospect.Sr_App
{
    public partial class ContractHeader : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = AdminBLL.Instance.FetchingContractTemplateDetail("Contract_Template");
            string resultHeader = "";
            if (ds.Tables[0].Rows.Count > 0)
            {
                string url = ConfigurationManager.AppSettings["URL"];
                resultHeader = ds.Tables[0].Rows[0][0].ToString();
                resultHeader = resultHeader.Replace(@"""", @"'");
                resultHeader = resultHeader.Replace(@"src='../img", "src='" + url + @"/img");// @"src="" + url + @""/img");
                resultHeader = resultHeader.Replace("width='700'", "width='96%'");
                //resultHeader = resultHeader.Replace("width='450'", "width='200'");
                resultHeader = resultHeader.Replace("url(../img", "url(" + url + "/img");
                resultHeader = resultHeader.Replace(@"id=""t1""", @"style=""style=""font-family: Verdana, Geneva, sans-serif;      font-size: 8pt;     background: url("+url+@"/img/logo_bg.png) center no-repeat; background-size: 20%;");
                resultHeader = resultHeader.Replace(ConfigurationManager.AppSettings["UrlToReplaceForTemplates"], url);
                ltlHeader.Text = resultHeader;
            }
          
        }
    }
}