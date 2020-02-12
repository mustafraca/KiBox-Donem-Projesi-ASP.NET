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
    public partial class KiBox : System.Web.UI.Page
    {
        static string baglanStr = ConfigurationManager.ConnectionStrings["KiBoxVTBaglanti"].ConnectionString;
        SqlConnection baglanti = new SqlConnection(baglanStr);
        SqlCommand komut;
        SqlDataReader reader;
        
        public static byte kaydetb = 0;

        public static void TextBoxTemizle(Panel panel)
        {
            foreach (Control c in panel.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = "";
                }
            }
        }

       
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Giris.oturum == null)
                {
                    Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Bilgi",
                            "<script>alert('Programa Erişim İçin Giriş Yapınız.!');</script>");

                    //Response.Redirect("Giris.aspx");

                }
                else
                {
                    //
                    Panel1.Enabled = false;
                    Button2.Enabled = false;
                    Button3.Enabled = false;
                    //Button4.Enabled = false;
                    //          
                    baglanti.Open();
                    komut = new SqlCommand("SELECT * FROM KiBoxVT", baglanti);
                    reader = komut.ExecuteReader();
                    try
                    {
                        while (reader.Read())
                        {
                            ListBox1.Items.Add(reader["Adsoyad"].ToString());
                        }
                    }
                    catch (Exception)
                    {
                        Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Bilgilendirme Mesajı", "<script>alert('Kişi Kaydı Bulunamadı.');</script>");
                    }
                    baglanti.Close();
                }
            }
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new SqlCommand("SELECT * FROM KiBoxVT WHERE Adsoyad='" + ListBox1.SelectedItem.Text + "'", baglanti);
            reader = komut.ExecuteReader();
            try
            {
                if (reader.Read())
                {
                    TextBox1.Text = reader["Adsoyad"].ToString();
                    TextBox2.Text = reader["Evadresi"].ToString();
                    TextBox3.Text = reader["Meslek"].ToString();
                    TextBox4.Text = reader["Etelefonu"].ToString();
                    TextBox5.Text = reader["Ctelefonu"].ToString();
                    TextBox6.Text = reader["Eposta"].ToString();
                    TextBox7.Text = reader["Web"].ToString();
                    DropDownList1.SelectedIndex = Convert.ToSByte(reader["Cinsiyet"]);
                    TextBox8.Text = reader["Fad"].ToString();
                    TextBox9.Text = reader["Fadresi"].ToString();
                    TextBox10.Text = reader["Aplaka"].ToString();
                    TextBox11.Text = reader["Vno"].ToString();
                    TextBox12.Text = reader["Vdairesi"].ToString();
                    TextBox13.Text = reader["Ftelefon"].ToString();
                    TextBox14.Text = reader["Ffaks"].ToString();
                    TextBox15.Text = reader["Feposta"].ToString();
                    TextBox16.Text = reader["Fweb"].ToString();
                    DropDownList2.SelectedIndex = Convert.ToSByte(reader["Fsehir"].ToString());
                    TextBox17.Text = reader["Filce"].ToString();
                    TextBox18.Text = reader["Kturu"].ToString();
                    TextBox19.Text = reader["Tc"].ToString();
                    TextBox20.Text = reader["Baba"].ToString();
                    TextBox21.Text = reader["Anne"].ToString();
                    TextBox22.Text = reader["Dtarihi"].ToString();
                    TextBox23.Text = reader["Dogumyeri"].ToString();
                    TextBox24.Text = reader["Kserino"].ToString();
                    TextBox25.Text = reader["Ciltno"].ToString();
                    TextBox26.Text = reader["Ailesirano"].ToString();
                    TextBox27.Text = reader["Sirano"].ToString();
                    TextBox28.Text = reader["Vyer"].ToString();
                    TextBox29.Text = reader["Vtarih"].ToString();
                    DropDownList3.SelectedIndex = Convert.ToSByte(reader["il"].ToString());
                    TextBox30.Text = reader["ilce"].ToString();
                    TextBox31.Text = reader["mkoy"].ToString();
                    //
                    Panel1.Enabled = false;
                    Button1.Enabled = true;
                    Button2.Enabled = true;
                    Button3.Enabled = true;
                    Button4.Enabled = false;
                    //
                }
            }
            catch (Exception hata)
            {
                Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Bilgilendirme Mesajı", "<script>alert('Hata Oluştu.');</script>" + hata);
            }
            baglanti.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Ekle
            Panel1.Enabled = true;
            TextBoxTemizle(Panel1);
            Button1.Enabled = false;
            Button2.Enabled = false;
            Button3.Enabled = false;
            Button4.Enabled = true;
            //
            kaydetb = 1;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //Düzenle
            Panel1.Enabled = true;
            Button1.Enabled = false;
            Button2.Enabled = false;
            Button3.Enabled = false;
            Button4.Enabled = true;
            //
            kaydetb = 0;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            //Sil
            baglanti.Open();
            komut = new SqlCommand("DELETE FROM KiBoxVT WHERE Adsoyad=@Adsoyad", baglanti);
            komut.Parameters.AddWithValue("@Adsoyad", ListBox1.SelectedItem.Text);
            try
            {               
                komut.ExecuteNonQuery();

                SqlCommand yenile = new SqlCommand("SELECT * FROM KiBoxVT", baglanti);
                reader = yenile.ExecuteReader();
                ListBox1.Items.Clear();
                while (reader.Read())
                {
                    ListBox1.Items.Add(reader["Adsoyad"].ToString());
                }
                ListBox1.SelectedIndex = 0;
                Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Bilgilendirme Mesajı", "<script>alert('Kişi Silindi.');</script>");
            }
            catch (Exception)
            {
                Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Bilgilendirme Mesajı", "<script>alert('Kişi Silinirken Hata Oluştu.');</script>");
            }
            baglanti.Close();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text != "")
            {

                if (kaydetb == 1)
                {
                    baglanti.Open();
                    komut = new SqlCommand("SELECT * FROM KiBoxVT WHERE Adsoyad='" + TextBox1.Text + "'", baglanti);
                    reader = komut.ExecuteReader();
                    if (reader.Read())
                    {
                        Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Bilgilendirme Mesajı", "<script>alert('Kullanıcı Adı Kullanılmaktadır.');</script>");
                        TextBox1.Text = "";
                        TextBox1.Focus();
                    }
                    else
                    {
                        //Ekle - Kaydet
                        komut.Dispose();
                        reader.Dispose();
                        komut = new SqlCommand("INSERT INTO KiBoxVT (Adsoyad, Evadresi, Meslek, Etelefonu, Ctelefonu, Eposta, Web, Cinsiyet, Fad, Fadresi, Aplaka, Vno, Vdairesi, Ftelefon, Ffaks, Feposta, Fweb, Fsehir, Filce, Kturu, Tc, Baba, Anne, Dtarihi, Dogumyeri, Kserino, Ciltno, Ailesirano, Sirano, Vyer, Vtarih, il, ilce, mkoy) VALUES (@Adsoyad,@Evadresi,@Meslek,@Etelefonu,@Ctelefonu,@Eposta,@Web,@Cinsiyet,@Fad,@Fadresi,@Aplaka,@Vno,@Vdairesi,@Ftelefon,@Ffaks,@Feposta,@Fweb,@Fsehir,@Filce,@Kturu,@Tc,@Baba,@Anne,@Dtarihi,@Dogumyeri,@Kserino,@Ciltno,@Ailesirano,@Sirano,@Vyer,@Vtarih,@il,@ilce,@mkoy)", baglanti);

                        komut.Parameters.AddWithValue("@Adsoyad", TextBox1.Text);
                        komut.Parameters.AddWithValue("@Evadresi", TextBox2.Text);
                        komut.Parameters.AddWithValue("@Meslek", TextBox3.Text);
                        komut.Parameters.AddWithValue("@Etelefonu", TextBox4.Text);
                        komut.Parameters.AddWithValue("@Ctelefonu", TextBox5.Text);
                        komut.Parameters.AddWithValue("@Eposta", TextBox6.Text);
                        komut.Parameters.AddWithValue("@Web", TextBox7.Text);
                        komut.Parameters.AddWithValue("@Cinsiyet", DropDownList1.SelectedIndex);
                        komut.Parameters.AddWithValue("@Fad", TextBox8.Text);
                        komut.Parameters.AddWithValue("@Fadresi", TextBox9.Text);
                        komut.Parameters.AddWithValue("@Aplaka", TextBox10.Text);
                        komut.Parameters.AddWithValue("@Vno", TextBox11.Text);
                        komut.Parameters.AddWithValue("@Vdairesi", TextBox12.Text);
                        komut.Parameters.AddWithValue("@Ftelefon", TextBox13.Text);
                        komut.Parameters.AddWithValue("@Ffaks", TextBox14.Text);
                        komut.Parameters.AddWithValue("@Feposta", TextBox15.Text);
                        komut.Parameters.AddWithValue("@Fweb", TextBox16.Text);
                        komut.Parameters.AddWithValue("@Fsehir", DropDownList2.SelectedIndex);
                        komut.Parameters.AddWithValue("@Filce", TextBox17.Text);
                        komut.Parameters.AddWithValue("@Kturu", TextBox18.Text);
                        komut.Parameters.AddWithValue("@Tc", TextBox19.Text);
                        komut.Parameters.AddWithValue("@Baba", TextBox20.Text);
                        komut.Parameters.AddWithValue("@Anne", TextBox21.Text);
                        komut.Parameters.AddWithValue("@Dtarihi", TextBox22.Text);
                        komut.Parameters.AddWithValue("@Dogumyeri", TextBox23.Text);
                        komut.Parameters.AddWithValue("@Kserino", TextBox24.Text);
                        komut.Parameters.AddWithValue("@Ciltno", TextBox25.Text);
                        komut.Parameters.AddWithValue("@Ailesirano", TextBox26.Text);
                        komut.Parameters.AddWithValue("@Sirano", TextBox27.Text);
                        komut.Parameters.AddWithValue("@Vyer", TextBox28.Text);
                        komut.Parameters.AddWithValue("@Vtarih", TextBox29.Text);
                        komut.Parameters.AddWithValue("@il", DropDownList3.SelectedIndex);
                        komut.Parameters.AddWithValue("@ilce", TextBox30.Text);
                        komut.Parameters.AddWithValue("@mkoy", TextBox31.Text);
                        try
                        {
                            komut.ExecuteNonQuery();

                            SqlCommand yenile = new SqlCommand("SELECT * FROM KiBoxVT", baglanti);
                            reader = yenile.ExecuteReader();
                            ListBox1.Items.Clear();
                            string ad = TextBox1.Text;
                            while (reader.Read())
                            {
                                ListBox1.Items.Add(reader["Adsoyad"].ToString());
                            }
                            //
                            Panel1.Enabled = false;
                            Button1.Enabled = true;
                            Button2.Enabled = false;
                            Button3.Enabled = true;
                            Button4.Enabled = false;
                            ListBox1.SelectedValue = ad;
                            //
                            Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Bilgilendirme Mesajı", "<script>alert('Kayıt Oldunuz.');</script>");
                        }
                        catch (Exception)
                        {
                            Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Bilgilendirme Mesajı", "<script>alert('Kişi Eklenirken Hata Oluştu.');</script>");
                        }
                    }
                    baglanti.Close();
                }
                else
                {
                    //Düzenle-Kaydet
                    baglanti.Open();
                    komut = new SqlCommand("UPDATE KiBoxVT SET Adsoyad=@Adsoyad, Evadresi=@Evadresi, Meslek=@Meslek, Etelefonu=@Etelefonu, Ctelefonu=@Ctelefonu, Eposta=@Eposta, Web=@Web, Cinsiyet=@Cinsiyet, Fad=@Fad, Fadresi=@Fadresi, Aplaka=@Aplaka, Vno=@Vno, Vdairesi=@Vdairesi, Ftelefon=@Ftelefon, Ffaks=@Ffaks, Feposta=@Feposta, Fweb=@Fweb, Fsehir=@Fsehir, Filce=@Filce, Kturu=@Kturu, Tc=@Tc, Baba=@Baba, Anne=@Anne, Dtarihi=@Dtarihi, Dogumyeri=@Dogumyeri, Kserino=@Kserino, Ciltno=@Ciltno, Ailesirano=@Ailesirano, Sirano=@Sirano, Vyer=@Vyer, Vtarih=@Vtarih, il=@il, ilce=@ilce, mkoy=@mkoy WHERE Adsoyad='" + ListBox1.SelectedItem.Text + "'", baglanti);

                    komut.Parameters.AddWithValue("@Adsoyad", TextBox1.Text);
                    komut.Parameters.AddWithValue("@Evadresi", TextBox2.Text);
                    komut.Parameters.AddWithValue("@Meslek", TextBox3.Text);
                    komut.Parameters.AddWithValue("@Etelefonu", TextBox4.Text);
                    komut.Parameters.AddWithValue("@Ctelefonu", TextBox5.Text);
                    komut.Parameters.AddWithValue("@Eposta", TextBox6.Text);
                    komut.Parameters.AddWithValue("@Web", TextBox7.Text);
                    komut.Parameters.AddWithValue("@Cinsiyet", DropDownList1.SelectedIndex);
                    komut.Parameters.AddWithValue("@Fad", TextBox8.Text);
                    komut.Parameters.AddWithValue("@Fadresi", TextBox9.Text);
                    komut.Parameters.AddWithValue("@Aplaka", TextBox10.Text);
                    komut.Parameters.AddWithValue("@Vno", TextBox11.Text);
                    komut.Parameters.AddWithValue("@Vdairesi", TextBox12.Text);
                    komut.Parameters.AddWithValue("@Ftelefon", TextBox13.Text);
                    komut.Parameters.AddWithValue("@Ffaks", TextBox14.Text);
                    komut.Parameters.AddWithValue("@Feposta", TextBox15.Text);
                    komut.Parameters.AddWithValue("@Fweb", TextBox16.Text);
                    komut.Parameters.AddWithValue("@Fsehir", DropDownList2.SelectedIndex);
                    komut.Parameters.AddWithValue("@Filce", TextBox17.Text);
                    komut.Parameters.AddWithValue("@Kturu", TextBox18.Text);
                    komut.Parameters.AddWithValue("@Tc", TextBox19.Text);
                    komut.Parameters.AddWithValue("@Baba", TextBox20.Text);
                    komut.Parameters.AddWithValue("@Anne", TextBox21.Text);
                    komut.Parameters.AddWithValue("@Dtarihi", TextBox22.Text);
                    komut.Parameters.AddWithValue("@Dogumyeri", TextBox23.Text);
                    komut.Parameters.AddWithValue("@Kserino", TextBox24.Text);
                    komut.Parameters.AddWithValue("@Ciltno", TextBox25.Text);
                    komut.Parameters.AddWithValue("@Ailesirano", TextBox26.Text);
                    komut.Parameters.AddWithValue("@Sirano", TextBox27.Text);
                    komut.Parameters.AddWithValue("@Vyer", TextBox28.Text);
                    komut.Parameters.AddWithValue("@Vtarih", TextBox29.Text);
                    komut.Parameters.AddWithValue("@il", DropDownList3.SelectedIndex);
                    komut.Parameters.AddWithValue("@ilce", TextBox30.Text);
                    komut.Parameters.AddWithValue("@mkoy", TextBox31.Text);
                    try
                    {
                        komut.ExecuteNonQuery();
                        Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Bilgilendirme Mesajı", "<script>alert('Kişi Güncellendi.');</script>");
                    }
                    catch (Exception)
                    {
                        Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Bilgilendirme Mesajı", "<script>alert('Kişi Güncellenirken Hata Oluştu.');</script>");
                    }
                    //
                    Button1.Enabled = true;
                    Button2.Enabled = false;
                    Button3.Enabled = true;
                    Button4.Enabled = false;
                    //
                    baglanti.Close();
                }
            }
            else
            {
                Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Bilgilendirme Mesajı", "<script>alert('Adı Soyadı Kısmı Boş Bırakılamaz.');</script>");
            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            if (TextBox32.Text != null)
            {
                baglanti.Open();
                komut = new SqlCommand("SELECT * FROM KiBoxVT WHERE Adsoyad LIKE '%" + TextBox32.Text + "%'", baglanti);
                reader = komut.ExecuteReader();
                try
                {
                    ListBox1.Items.Clear();
                    while (reader.Read())
                    {
                        ListBox1.Items.Add(reader["Adsoyad"].ToString());
                    }
                }
                catch
                {
                    Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Bilgilendirme Mesajı", "<script>alert('Hata Oluştu.');</script>");
                }
                baglanti.Close();

            }
            else
            {
                Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Bilgi",
                            "<script>alert('Sicil Giriniz');</script>");
            }
        }


        protected void TextBox32_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new SqlCommand("SELECT * FROM KiBoxVT", baglanti);
            reader = komut.ExecuteReader();
            try
            {
                TextBox32.Text = "";
                ListBox1.Items.Clear();
                while (reader.Read())
                {
                    ListBox1.Items.Add(reader["Adsoyad"].ToString());
                }
            }
            catch (Exception)
            {
                Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Bilgilendirme Mesajı", "<script>alert('Kişi Kaydı Bulunamadı.');</script>");
            }
            baglanti.Close();
        }
    }
}