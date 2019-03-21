using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Class_Library;

namespace PBFrontEnd
{
    public partial class MainCartAppointment : System.Web.UI.Page
    {
        clsCart MyCart = new clsCart();

        protected void Page_Load(object sender, EventArgs e)
        {
            //upon loading the page you need to read in the cart from the session object
            MyCart = (clsCart)Session["MyCart"];
            //if the cart is null then we need to initialise it
            if (MyCart == null)
            {
                MyCart = new clsCart();
            }
            //then you can display how many items are in your cart
            //lblCartCount.Text = MyCart.Products.Count.ToString();
        }

        protected void Page_UnLoad(object sender, EventArgs e)
        {
            //you must also save the cart every time the unload event takes place
            Session["MyCart"] = MyCart;
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("AnAppointment.aspx");
        }
    }
}