using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Nhom6_IS385L
{
    public partial class ChiTietSP : System.Web.UI.Page
    {
        KetNoi kn=new KetNoi();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) { return; }
            string mahang = Context.Items["mahang"] != null ? Context.Items["mahang"].ToString() : "";
            if (mahang != string.Empty)
            {
                string query = $"select * from MATHANG where MaHang = {mahang}";
                DataList1.DataSource = kn.LayDuLieu(query);
                DataList1.DataBind();
            }
        }
    }
}