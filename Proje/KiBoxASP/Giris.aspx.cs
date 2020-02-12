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
    public partial class Giris : System.Web.UI.Page
    {
        static string baglanStr = ConfigurationManager.ConnectionStrings["KiBoxVTBaglanti"].ConnectionString;
        SqlConnection baglanti = new SqlConnection(baglanStr);
        SqlConnection baglanti2 = new SqlConnection(baglanStr);
        SqlCommand komut;
        SqlCommand komut2;
        SqlDataReader reader;
        SqlDataReader reader2;
        public static string oturum;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text != "" && TextBox2.Text != "")
            {
                baglanti.Open();
                baglanti2.Open();
                komut = new SqlCommand("SELECT id FROM Kullanici WHERE id='" + TextBox1.Text + "'", baglanti);
                komut2 = new SqlCommand("SELECT id, sifre FROM Kullanici WHERE id='" + TextBox1.Text + "' AND sifre='" + TextBox2.Text + "'", baglanti2);
                reader = komut.ExecuteReader();
                reader2 = komut2.ExecuteReader();
                try
                {
                    if (reader.Read() && reader2.Read())
                    {
                        Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Bilgilendirme Mesajı", "<script>alert('Hoşgeldiniz..');</script>");
                        oturum = TextBox1.Text;
                        Response.Redirect("KiBox.aspx");
                    }
                    else
                    {
                        if ((reader.HasRows == true && reader2.HasRows == false) || (reader.HasRows == false && reader2.HasRows == true))
                        {
                            Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Bilgilendirme Mesajı", "<script>alert('Kullanıcı Adı veya Şifre Yanlış!');</script>");
                            TextBox1.Text = "";
                            TextBox2.Text = "";
                            TextBox1.Focus();
                        }
                        else
                        {
                            Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Bilgilendirme Mesajı", "<script>alert('Kullanıcı Kayıtlı Değil!');</script>");
                            TextBox1.Text = "";
                            TextBox2.Text = "";
                            TextBox1.Focus();
                        }
                    }
                }
                catch (Exception)
                {
                    Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Bilgilendirme Mesajı", "<script>alert('Oturum Açılırken Hata Oluştu.');</script>");
                }
                baglanti.Close();
                baglanti2.Close();
            }
            else
            {
                Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Bilgilendirme Mesajı", "<script>alert('Boş Alan Bırakmayınız!');</script>");
            }
        }
    }
}