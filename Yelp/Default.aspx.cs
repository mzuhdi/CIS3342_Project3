using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilities;
using System.Data;

namespace Yelp
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (Authenticate(txtFirstName.Text, txtLastName.Text))
            {
                Panel1.Visible = false;
                Panel2.Visible = true;
            }
        }

        private bool Authenticate(string firstName, string lastName)
        {
            string sql = "SELECT * FROM USERS WHERE firstName ='" + firstName + "' AND lastName = '" + lastName + "'";
            DBConnect db = new DBConnect();
            DataSet ds = db.GetDataSet(sql);


            ////Count rows return true
            //if (ds.Tables[0].Rows.Count > 0)
            //{
                
            //    return true;
            //}

            //Loop through every row and return the first value that match
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                if (row[2].ToString() == firstName && row[3].ToString() == lastName)
                {
                    ddlUserType.DataSource = ds;
                    ddlUserType.DataTextField = "userType";
                    ddlUserType.DataBind();
                    return true;
                }
            }
            return false;
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            switch (ddlUserType.SelectedItem.ToString())
            {
                case "Reviewer":
                    Response.Redirect("ReviewerPage.aspx");
                    break;
                case "Visitor":
                    Response.Redirect("VisitorPage.aspx");
                    break;
                default:
                    break;
            }
        }
    }
}