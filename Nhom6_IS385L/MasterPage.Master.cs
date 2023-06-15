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
            if (IsPostBack) { return; }
                this.DataList1.DataSource = kn.LayDuLieu("SELECT * FROM LOAIHANG");
                this.DataList1.DataBind();

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            string ma = ((LinkButton)sender).CommandArgument.ToString();
            Context.Items["ma"]= ma;
            Server.Transfer("SanPham.aspx");
        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {

        }
    }
}