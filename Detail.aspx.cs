using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace taotrangweb
{
    public partial class Detail : System.Web.UI.Page
    {
        LopKetNoi ketnoi = new LopKetNoi();

        protected void dl_sanpham_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Xử lý logic khi sự kiện SelectedIndexChanged xảy ra trên DataList
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;
            string mahang = Request.QueryString["mh"] + "";
            if(mahang != "")
            {
                string sql = "Select*From MATHANG Where MaHang=" + mahang;
                dl_sanpham.DataSource = ketnoi.docdulieu(sql);
                dl_sanpham.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string tendangnhap = Session["username"] + "";
            if (tendangnhap != "")
            {
                Button btMua = (Button)sender;
                DataListItem dlItem = (DataListItem)btMua.Parent;
                TextBox txtSL = (TextBox)dlItem.FindControl("txtSoluong");
                string soluong = txtSL.Text;
                string mahang = btMua.CommandArgument;

                // Kiểm tra đơn hàng có hay chưa
                string sql_donhang = "SELECT * FROM DONHANG WHERE TenDangNhap='" + tendangnhap + "' AND MaHang=" + mahang;
                DataTable dt_donhang = ketnoi.docdulieu(sql_donhang);

                string sql = "";
                if (dt_donhang != null && dt_donhang.Rows.Count > 0)
                {
                    // Đơn hàng đã tồn tại, cập nhật số lượng
                    sql = "UPDATE DONHANG SET SoLuong = SoLuong + " + soluong + " WHERE TenDangNhap='" + tendangnhap + "' AND MaHang=" + mahang;
                }
                else
                {
                    // Đơn hàng chưa tồn tại, thêm mặt hàng mới vào đơn hàng
                    sql = "INSERT INTO DONHANG VALUES ('" + tendangnhap + "', " + mahang + ", " + soluong + ")";
                }

                int ketqua = ketnoi.CapNhat(sql);
                if (ketqua > 0)
                {
                    lbthongbao.Text = "Mua Hàng Thành CÔng";
                }
                else
                {
                    lbthongbao.Text = "Mua Hàng Không Thành công";
                }
            }
            else
            {
                lbthongbao.Text = "Bạn phải đăng nhập";
            }
        }

    }
}



