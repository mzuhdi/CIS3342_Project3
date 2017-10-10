using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Utilities;

namespace Yelp
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO Users (userType, firstName, lastName) VALUES ('" + ddlUserType.SelectedItem + "','" + txtFirstName.Text + "','" + txtLastName.Text + "')";
            DBConnect db = new DBConnect();
            int retVal = db.DoUpdate(sql);
        }
    }
}