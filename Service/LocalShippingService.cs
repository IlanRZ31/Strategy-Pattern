using StrategyPattern.Models;
using System;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StrategyPattern.Service
{
    public class LocalShippingService : CheckOutService
    {

        public override decimal CalculateShipping(decimal orderTotal)
        {
            Page currentPage = HttpContext.Current.Handler as Page;
            Label lblTotal = currentPage.FindControl("lblTotal") as Label;

            if(lblTotal != null)
            {
                lblTotal.Text = "Local Shipping";
            }
            return orderTotal + 10;
        }
    }
}