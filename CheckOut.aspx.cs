using System;
using System.Web.UI;
using StrategyPattern.Service;


namespace StrategyPattern
{
    public partial class CheckOut : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Context context = new Context(new LocalShippingService());
            context.Execute();

        }

        protected void checkOut(object sender, EventArgs e)
        {
            switch (shipping.SelectedValue)
            {
                case "local":
                    LocalShippingService local = new LocalShippingService();
                    decimal total = local.CalculateShipping(100);
                    lblTotal.Text = total.ToString();
                    break;
                case "world":
                    WorldWideShippingService worldWide = new WorldWideShippingService();
                    decimal total2 = worldWide.CalculateShipping(100);
                    lblTotal.Text = total2.ToString();
                    break;
                case "free":
                    FreeShippingService free = new FreeShippingService();
                    decimal total3 = free.CalculateShipping(100);
                    lblTotal.Text = total3.ToString();
                    break;
            }
        }
    }
}