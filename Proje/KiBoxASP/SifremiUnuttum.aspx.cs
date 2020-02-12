using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace KiBoxASP
{
    public partial class SifremiUnuttum : System.Web.UI.Page
    {
        static string baglanStr = ConfigurationManager.ConnectionStrings["KiBoxVTBaglanti"].ConnectionString;
        SqlConnection baglanti = new SqlConnection(baglanStr);
        SqlCommand komut;
        SqlDataReader reader;

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text != "" && TextBox2.Text != "")
            {
                baglanti.Open();
                komut = new SqlCommand("SELECT * FROM Kullanici WHERE id='"
                    + TextBox1.Text + "' AND eposta='" + TextBox2.Text + "'", baglanti);
                reader = komut.ExecuteReader();
                try
                {
                    if (reader.Read())
                    {
                        Label1.Text = "Sayın " + reader["id"].ToString() + " KiBox giriş şifreniz<strong> " + reader["sifre"].ToString() + " </strong>. Hesabınızın güvenliği için şifreinizi güncelleyin.";

                        Label1.Visible = true;

                    }
                    else
                    {
                        Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Bilgi", "<script>alert('Kullanıcı Adı veya E-Posta Yanlış.');</script>");
                    }
                }
                catch (Exception)
                {
                    Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Bilgi",
                        "<script>alert('Hata oluştu.');</script>");
                }
                finally
                {
                    baglanti.Close();
                }
            }
            else
            {
                Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Bilgi",
                           "<script>alert('Gerekli Alanları Doldurunuz.');</script>");

            }
        }
    }
}