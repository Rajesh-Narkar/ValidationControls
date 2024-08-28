using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ValidationControls
{
    public partial class ValidationControls : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            string str=TextBox4.Text;
            char ch = str[0];
            if(ch>='A' && ch <= 'Z')
            {
                args.IsValid= true;
            }
            else
            {
                args.IsValid = false;
            }
        }
    }
}