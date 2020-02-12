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
    public partial class Kayit : System.Web.UI.Page
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
            if (TextBox1.Text != "" && TextBox2.Text != "" && TextBox3.Text != "" && TextBox4.Text != "")
            {
                baglanti.Open();
                komut = new SqlCommand("SELECT * FROM Kullanici WHERE id='" + TextBox1.Text + "'", baglanti);
                reader = komut.ExecuteReader();
                try
                {
                    if (reader.Read())
                    {
                        Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Bilgilendirme Mesajı", "<script>alert('Kullanıcı Adı Kullanılmaktadır.');</script>");
                        TextBox1.Text = "";
                        TextBox1.Focus();
                    }
                    else
                    {
                        if (TextBox2.Text == TextBox3.Text)
                        {
                            komut.Dispose();
                            reader.Dispose();
                            komut = new SqlCommand("INSERT INTO Kullanici (id, sifre, eposta) VALUES (@id, @sifre, @eposta)", baglanti);
                            komut.Parameters.AddWithValue("@id", TextBox1.Text);
                            komut.Parameters.AddWithValue("@sifre", TextBox2.Text);
                            komut.Parameters.AddWithValue("@eposta", TextBox4.Text);
                            komut.ExecuteNonQuery();
                            Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Bilgilendirme Mesajı", "<script>alert('Kayıt Oldunuz.');</script>");
                            TextBox1.Text = "";
                            TextBox2.Text = "";
                            TextBox3.Text = "";
                            TextBox4.Text = "";
                        }
                        else
                        {
                            Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Bilgilendirme Mesajı", "<script>alert('Şifreler Birbiriyle Uyuşmuyor.');</script>");
                            TextBox2.Text = "";
                            TextBox3.Text = "";
                            TextBox2.Focus();
                        }
                    }
                }
                catch (Exception)
                {
                    Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Bilgilendirme Mesajı", "<script>alert('Hata Oluştu.');</script>");
                }
                baglanti.Close();
            }
            else
            {
                Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Bilgilendirme Mesajı", "<script>alert('Boş Alan Bırakmayınız!');</script>");
            }
        }
    }
}