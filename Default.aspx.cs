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
    public partial class Default : System.Web.UI.Page
    {
        LopKetNoi ketNoi = new LopKetNoi();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;
            string maloai = Request.QueryString["ml"]+"";
            string sql = "";
            if (maloai == "") {

                 sql = "SELECT *FROM MATHANG";
            }
            else
            {
                sql = "Select* From MATHANG Where MaLoai=" + maloai;
            }

            dl_mathang.DataSource = ketNoi.docdulieu(sql);
            dl_mathang.DataBind();
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            string mahang = ((ImageButton)sender).CommandArgument;
            Response.Redirect("Detail.aspx?mh=" + mahang);
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            string mahang = ((LinkButton)sender).CommandArgument;
            Response.Redirect("Detail.aspx?mh=" + mahang);
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {

            string mahang = ((LinkButton)sender).CommandArgument;
            Response.Redirect("Detail.aspx?mh=" + mahang);
        }
    }
}