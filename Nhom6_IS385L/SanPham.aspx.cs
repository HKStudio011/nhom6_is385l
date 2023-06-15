using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Nhom6_IS385L
{
    public partial class SanPham : System.Web.UI.Page
    {
        KetNoi Kn = new KetNoi();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) { return; }
            string query = "";
            string ma = Context.Items["ma"] !=null? Context.Items["ma"].ToString():"";
            if (ma==string.Empty)
            {
                query = "select * from MATHANG";
            }
            else query = $"select * from MATHANG where MaLoai = {ma}";
            DataList1.DataSource = Kn.LayDuLieu(query);
            DataList1.DataBind();
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            string mahang = ((LinkButton)sender).CommandArgument.ToString();
            Context.Items["mahang"] = mahang;
            Server.Transfer("ChiTietSP.aspx");
        }
    }
}