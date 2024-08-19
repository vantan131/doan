using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace taotrangweb
{
    public partial class giohang : System.Web.UI.Page
    {
        LopKetNoi ketnoi = new LopKetNoi();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;

            // Lấy tên đăng nhập từ session
            string tendangnhap = Session["username"] as string;
            if (tendangnhap == null)
            {
                // Nếu tên đăng nhập không tồn tại, có thể chuyển hướng người dùng đến trang đăng nhập
                Response.Redirect("LoginPage.aspx");
                return;
            }

            string sql = "SELECT MATHANG.MaHang, TenHang, HinhAnh, DonGia, SoLuong, " +
                         "DonGia * SoLuong AS ThanhTien " +
                         "FROM MATHANG, DONHANG " +
                         "WHERE MATHANG.MaHang = DONHANG.MaHang AND TenDangNhap = '" + tendangnhap + "'";
            DataTable dt = ketnoi.docdulieu(sql);

            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
    }
}