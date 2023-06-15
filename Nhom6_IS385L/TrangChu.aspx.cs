using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Nhom6_IS385L
{
    public partial class TrangChu : System.Web.UI.Page
    {
        KetNoi kn = new KetNoi();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) { return; }
            string query = "select top 4 * from MATHANG order by MaHang desc";
            DataList1.DataSource = kn.LayDuLieu(query);
            DataList1.DataBind();
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            string mahang =((LinkButton)sender).CommandArgument.ToString();
            Context.Items["mahang"]=mahang;
            Server.Transfer("ChiTietSP.aspx");
        }
    }
}