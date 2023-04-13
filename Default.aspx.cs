using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using StrategyPattern.Models;

namespace StrategyPattern
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connDB"].ConnectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Product", conn);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    conn.Open();
                    rpProducts.DataSource = ds;
                    rpProducts.DataBind();
                }
            }
        }
        
        protected void AddToCart(object sender, EventArgs e)
        {
            var totalActual = Decimal.Parse(totalCart.Text);
            var price = Decimal.Parse(((Button)sender).CommandArgument);
            totalCart.Text = (totalActual + price).ToString();
        }

        protected void GoToCheckOut(object sender, EventArgs e)
        {
            Response.Redirect("CheckOut.aspx");
        }
    }
}