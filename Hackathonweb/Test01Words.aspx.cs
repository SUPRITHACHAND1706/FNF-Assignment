using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SampleWbFormsApp.Hackathon2
{
    public partial class Test01Words : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var words = Session["Words"] as Dictionary<string, string>;

            DataTable dt = new DataTable();

            dt.Columns.Add("Word");

            dt.Columns.Add("Translation");

            if (words != null)

            {

                foreach (var kv in words)

                    dt.Rows.Add(kv.Key, kv.Value);

            }

            gvWords.DataSource = dt;

            gvWords.DataBind();

        }
    }
}