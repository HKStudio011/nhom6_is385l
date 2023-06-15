using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Nhom6_IS385L
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        KetNoi kn = new KetNoi();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false) 
            {
                this.DataList1.DataSource = kn.LayDuLieu("SELECT * FROM ");
                this.DataList1.DataBind();
            }
        }
    }
}