using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_Application_2
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // this is Application 2
            lakeside.classlib1.Class1 CS1 = new lakeside.classlib1.Class1();
            lakeside.classlib2.Class1 cs2 = new lakeside.classlib2.Class1();

        }
    }
}