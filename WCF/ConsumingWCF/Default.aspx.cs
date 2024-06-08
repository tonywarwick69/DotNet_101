using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ConsumingWCF
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //For HTTP protocol
            //WCFEndpointsService.Service1Client _client = new WCFEndpointsService.Service1Client("WSHttpBinding_IService1");
            //For net.tcp protocol
            WCFEndpointsService.Service1Client _client = new WCFEndpointsService.Service1Client("NetTcpBinding_IService1");
            Label1.Text = _client.GetMessage("Khang Dong");
        }
    }
}