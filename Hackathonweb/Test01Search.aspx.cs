using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SampleWbFormsApp.Hackathon2
{
    public partial class Test01Search : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Words.Count == 0)
                {
                    Words.Add("Home", "");
                    Words.Add("fun", "");
                    Words.Add("Sequel", "");
                }
                BindGrid();
                txtTranslation.Visible = false;
            }
        }
        private Dictionary<string, string> Words
        {
            get
            {
                if (Session["Words"] == null)
                    Session["Words"] = new Dictionary<string, string>();
                return (Dictionary<string, string>)Session["words"];
            }
        }
        protected void btnSearch_Click(object sender, EventArgs e)
        {
            string searchWord = txtSearch.Text.Trim();
            var found = Words.FirstOrDefault(w => w.Key.Equals(searchWord, StringComparison.OrdinalIgnoreCase));
            if (!string.IsNullOrEmpty(found.Key))
            {
                if (string.IsNullOrEmpty(found.Value))
                {
                    lblMsg.Text = $"Word '{found.Key}' found. Please add its translation.";
                    txtTranslation.Visible = true;
                    txtTranslation.Text = "";
                }
                else
                {
                    lblMsg.Text = $"Word: {found.Key}, Translation: {found.Value}";
                    txtTranslation.Visible = false;
                }
            }
            else
            {
                Response.Redirect("WordNotFound.aspx?word=" + Server.UrlEncode(searchWord));
            }

            BindGrid();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            string word = txtSearch.Text.Trim();
            string translation = txtTranslation.Text.Trim();

            Words[word] = translation; 
            lblMsg.Text = $"Translation for '{word}' added: {translation}";
            txtTranslation.Visible = false;
            BindGrid();
        }
        private void BindGrid()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Word");
            dt.Columns.Add("Translation");

            foreach (var kv in Words)
            {
                dt.Rows.Add(kv.Key, kv.Value);
            }
            var grid = this.FindControl("gvWords") as GridView;
            if (grid != null)
            {
                grid.DataSource = dt;
                grid.DataBind();
            }
        }
    }
}