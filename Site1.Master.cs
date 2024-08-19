using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
namespace taotrangweb
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        LopKetNoi ketnoi = new LopKetNoi();
        protected void dl_LoaiHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Logic xử lý khi sự kiện SelectedIndexChanged xảy ra ở DataList
        }
       
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;
         
            string sql = "SELECT*FROM LOAIHANG";
            DataTable dt = ketnoi.docdulieu(sql);

            dl_LoaiHang.DataSource = dt;
            dl_LoaiHang.DataBind();
         

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            string maloai = ((LinkButton)sender).CommandArgument;
            Response.Redirect("Default.aspx?ml="+ maloai);
        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            string username = Login1.UserName;
            string pass = Login1.Password;
            string sql = "SELECT * FROM KHACHHANG WHERE TenDangNhap='" + username + "' AND MatKhuau='" + pass + "'";
            DataTable dt = ketnoi.docdulieu(sql);
            if (dt != null && dt.Rows.Count > 0)
            {
                Session["username"] = username;
                Response.Redirect("Default.aspx");
               // DataTable dtt = ketnoi.docdulieu(sql);
            }
        }
    }
    
}