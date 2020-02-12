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
    public partial class SifreDegistir : System.Web.UI.Page
    {
        static string baglanStr = ConfigurationManager.ConnectionStrings["KiBoxVTBaglanti"].ConnectionString;
        SqlConnection baglanti = new SqlConnection(baglanStr);
        SqlCommand komut;
        SqlDataReader reader;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack == true)
            {
                Panel2.Visible = false;
                TextBox1.Focus();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text != "" && TextBox2.Text != "")
            {
                baglanti.Open();
                komut = new SqlCommand("SELECT * FROM Kullanici WHERE id='"
                    + TextBox1.Text + "' AND sifre='" + TextBox2.Text + "'", baglanti);
                reader = komut.ExecuteReader();
                try
                {
                    if (reader.Read())
                    {
                        Panel1.Enabled = false;
                        Panel2.Visible = true;
                        TextBox3.Focus();
                    }
                    else
                    {

                        Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Bilgi",
                            "<script>alert('Kullanıcı Adı veya Şifre Yanlış veya Hatalı Giriş Yaptınız.!');</script>");
                        TextBox1.Text = "";
                        TextBox2.Text = "";
                        TextBox1.Focus();
                    }
                }
                catch (Exception)
                {
                    Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Bilgi",
                        "<script>alert('Hata Oluştu.');</script>");
                }
                finally
                {
                    baglanti.Close();
                }
            }
            else
            {
                Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Bilgi",
                    "<script>alert('Boş Alanları Doldurunuz!');</script>");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (TextBox3.Text == TextBox4.Text)
            {
                try
                {
                    baglanti.Open();
                    komut = new SqlCommand("UPDATE Kullanici SET sifre=@sifre WHERE id='" + TextBox1.Text + "'", baglanti);
                    komut.Parameters.AddWithValue("@sifre", TextBox3.Text);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Bilgi",
                        "<script>alert('Şifre Güncellendi.');</script>");
                    TextBox3.Text = "";
                    TextBox4.Text = "";
                    TextBox1.Text = "";
                    TextBox2.Text = "";
                    Panel1.Enabled = true;
                    Panel2.Visible = false;
                }
                catch (Exception)
                {
                    Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Bilgi",
                        "<script>alert('Hata Oluştu.');</script>");
                }
                finally
                {
                    baglanti.Close();
                }
            }
            else
            {
                Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Bilgi",
                    "<script>alert('Şifreler Birbiriyle Uyuşmuyor!');</script>");
            }
        }
    }
}