using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using JG_Prospect.BLL;
namespace JG_Prospect.Sr_App
{
    public partial class ContractFooter : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string url = ConfigurationManager.AppSettings["URL"].ToString();
            img1.ImageUrl = url + "/img/bar1.png";
            //DataSet ds = new DataSet();
            //ds = AdminBLL.Instance.FetchingContractTemplateDetail("Contract_Template");

            //string resultFooter = "";
            //if (ds.Tables[0].Rows.Count > 0)
            //{

            //    resultFooter = ds.Tables[0].Rows[0][2].ToString();
            //}
            //lblFoooter.Text = resultFooter;
            
        }
    }
}