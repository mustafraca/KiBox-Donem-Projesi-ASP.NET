<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="KiBox.aspx.cs" Inherits="KiBoxASP.KiBox" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
<div id="main">
    <div style="text-align:center">
        <span class="fa-4x"><%: Page.Title %></span>
        <br />
        <div class="divider"></div>
        <br />
    </div>

<table style="width:100%; height:100%">
    <tr>
        <td align="center">
    <table>
        <tr>
            <td style="width:200px; height:75px">
                <asp:Button ID="Button1" runat="server" Text="EKLE" Width="150px" OnClick="Button1_Click"/>
            </td>
            <td style="width:200px">
                <asp:Button ID="Button2" runat="server" Text="DÜZENLE" Width="150px" OnClick="Button2_Click"/>
            </td>
            <td style="width:200px">
                <asp:Button ID="Button3" runat="server" Text="SİL" Width="150px" OnClick="Button3_Click"/>
            </td>
            <td style="width:200px">
                <asp:Button ID="Button4" runat="server" Text="KAYDET" Width="150px" OnClick="Button4_Click"/>
            </td>               
        </tr>
    </table>
        </td>
    </tr>
</table>

<table style="width:100%; height:100%">
    <tr>
        <td align="center">
    <table>
        <tr>
        <asp:Panel ID="Panel1" runat="server">
            <td>
                <strong>Kişisel Bilgiler</strong> 
            <table style="text-align:left">
                <tr style="width:225px; height:40px">
                <td>
                    Adı Soyadı:
                </td>
                <td>                 
                    <asp:TextBox ID="TextBox1" runat="server" style="width:160px" MaxLength="30"></asp:TextBox>
                </td>
                </tr>
                <tr style="height:40px">
                <td>
                    Ev Adresi:
                </td>
                <td>                 
                    <asp:TextBox ID="TextBox2" runat="server" style="width:160px" MaxLength="150"></asp:TextBox>
                </td>
                </tr>
                <tr style="height:40px">
                <td>
                    Meslek:
                </td>
                <td>                 
                    <asp:TextBox ID="TextBox3" runat="server" style="width:160px" MaxLength="30"></asp:TextBox>
                </td>
                </tr>
                <tr style="height:40px">
                <td>                 
                    Ev Telefonu:
                </td>
                <td>                 
                 <asp:TextBox ID="TextBox4" runat="server" style="width:160px" TextMode="Phone" MaxLength="11"></asp:TextBox>
                </td>
                </tr>
                <tr style="height:40px">
                <td>                 
                    Cep Telefonu:
                </td>
                <td>                 
                    <asp:TextBox ID="TextBox5" runat="server" style="width:160px" TextMode="Phone" MaxLength="11"></asp:TextBox>
                </td>
                </tr>
                <tr style="height:40px">
                <td>                 
                    E-Posta:
                </td>
                <td>                 
                    <asp:TextBox ID="TextBox6" runat="server" style="width:160px" TextMode="Email" MaxLength="30"></asp:TextBox>
                </td>
                </tr>
                <tr style="height:40px">
                <td>                 
                    Web Adresi:
                </td>
                <td>                 
                    <asp:TextBox ID="TextBox7" runat="server" style="width:160px" MaxLength="30"></asp:TextBox>
                </td>
                </tr>
                <tr style="height:40px">
                <td>                 
                    Cinsiyet:
                </td>
                <td>                 
                <asp:DropDownList ID="DropDownList1" runat="server" style="width:160px">
                    <asp:ListItem Selected="True">Seçiniz</asp:ListItem>
                    <asp:ListItem>Bay</asp:ListItem>
                    <asp:ListItem>Bayan</asp:ListItem>
                </asp:DropDownList>
                </td>
                </tr>
                </table>
               <br />
               <br />
               <br />
               <br />
               <br />
               <br />
               <br />
               <br />
               <br />
               <br />
               <br />
               <br />
               <br />
               <br />
               <br />
                </td>
                <td style="width:25px">

                </td>
                <td>
            <strong>İş Bilgileri</strong> 
            <table style="text-align:left">
                <tr style="width:225px; height:40px">
                <td>                 
                    Firma Adı:
                </td>
                <td>                 
                    <asp:TextBox ID="TextBox8" runat="server" style="width:160px" MaxLength="100"></asp:TextBox>
                </td>
                </tr>
                <tr style="height:40px">
                <td>                 
                    Firma Adresi:
                </td>
                <td>                 
                    <asp:TextBox ID="TextBox9" runat="server" style="width:160px" MaxLength="150"></asp:TextBox>
                </td>
                </tr>
                <tr style="height:40px">
                <td>                 
                    Araç Plakası:
                </td>
                <td>                 
                    <asp:TextBox ID="TextBox10" runat="server" style="width:160px" MaxLength="10"></asp:TextBox>
                </td>
                </tr>
                <tr style="height:40px">
                <td>                 
                    Vergi No:
                </td>
                <td>                 
                    <asp:TextBox ID="TextBox11" runat="server" style="width:160px" MaxLength="50"></asp:TextBox>
                </td>
                </tr>
                <tr style="height:40px">
                <td>                 
                 Vergi Dairesi:
                </td>
                <td>                 
                    <asp:TextBox ID="TextBox12" runat="server" style="width:160px" MaxLength="50"></asp:TextBox>
                </td>
                </tr>
                <tr style="height:40px">
                <td>                 
                    Firma Telefonu:
                </td>
                <td>                 
                    <asp:TextBox ID="TextBox13" runat="server" style="width:160px" TextMode="Phone" MaxLength="11"></asp:TextBox>
                </td>
                </tr>
                <tr style="height:40px">
                <td>                 
                    Firma Faks:
                </td>
                <td>                 
                    <asp:TextBox ID="TextBox14" runat="server" style="width:160px" TextMode="Phone" MaxLength="11"></asp:TextBox>
                </td>
                </tr>
                <tr style="height:40px">
                <td>                 
                    Firma E-Posta:
                </td>
                <td>                 
                    <asp:TextBox ID="TextBox15" runat="server" style="width:160px" TextMode="Email" MaxLength="30"></asp:TextBox>
                </td>
                </tr>
                <tr style="height:40px">
                <td>                 
                    Firma Web Adresi:
                </td>
                <td>                 
                    <asp:TextBox ID="TextBox16" runat="server" style="width:160px" TextMode="Url" MaxLength="30"></asp:TextBox>
                </td>
                </tr>
                <tr style="height:40px">
                <td>                 
                    Firma Şehir:
                </td>
                <td>                 
                <asp:DropDownList ID="DropDownList2" runat="server" style="width:160px" DataSourceID="SqlDataSource1" DataTextField="Sehir" DataValueField="Sehir">
                    <asp:ListItem Selected="True">Seçiniz</asp:ListItem>
                 </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:KiBoxVTConnectionString %>" SelectCommand="SELECT * FROM [Sehir]"></asp:SqlDataSource>
                </td>
                </tr>
                <tr style="height:40px">
                <td>                 
                    Firma İlçe:
                </td>
                <td>                 
                    <asp:TextBox ID="TextBox17" runat="server" style="width:160px" MaxLength="30"></asp:TextBox>
                </td>
                </tr> 
                </table>
               <br />
               <br />
               <br />
               <br />
               <br />
               <br />
               <br />
               <br />
               <br />  
                </td>
                <td style="width:25px">

                </td>
                <td>
            <strong>Kimlik Bilgileri</strong> 
            <table style="text-align:left">
                <tr style="width:200px; height:40px">
                <td>                 
                    Kimlik Türü:
                </td>
                <td>                 
                    <asp:TextBox ID="TextBox18" runat="server" style="width:160px" MaxLength="50"></asp:TextBox>
                </td>
                </tr>
                <tr style="height:40px">
                <td>                 
                    T.C. Numarası:
                </td>
                <td>                 
                    <asp:TextBox ID="TextBox19" runat="server" style="width:160px" MaxLength="11"></asp:TextBox>
                </td>
                </tr>
                <tr style="height:40px">
                <td>                 
                    Baba Adı:
                </td>
                <td>                 
                    <asp:TextBox ID="TextBox20" runat="server" style="width:160px" MaxLength="30"></asp:TextBox>
                </td>
                </tr>
                <tr style="height:40px">
                <td>                 
                 Anne Adı:
                </td>
                <td>                 
                    <asp:TextBox ID="TextBox21" runat="server" style="width:160px" MaxLength="30"></asp:TextBox>
                </td>
                </tr>
                <tr style="height:40px">
                <td>                 
                    Doğum Tarihi:
                </td>
                <td>                 
                    <asp:TextBox ID="TextBox22" runat="server" style="width:160px" TextMode="Date"></asp:TextBox>
                </td>
                </tr>
                <tr style="height:40px">
                <td>                 
                    Doğum Yeri:
                </td>
                <td>                 
                    <asp:TextBox ID="TextBox23" runat="server" style="width:160px" MaxLength="50"></asp:TextBox>
                </td>
                </tr>
                <tr style="height:40px">
                <td>                 
                    Kimlik Seri No:
                </td>
                <td>                 
                    <asp:TextBox ID="TextBox24" runat="server" style="width:160px" MaxLength="20"></asp:TextBox>
                </td>
                </tr>
                <tr style="height:40px">
                <td>                 
                    Cilt No:
                </td>
                <td>                 
                    <asp:TextBox ID="TextBox25" runat="server"  style="width:160px" TextMode="Number" MaxLength="20"></asp:TextBox>
                </td>
                </tr>
                <tr style="height:40px">
                <td>                 
                    Aile Sıra No:
                </td>
                <td>                 
                    <asp:TextBox ID="TextBox26" runat="server" style="width:160px" TextMode="Number" MaxLength="20"></asp:TextBox>
                </td>
                </tr>
                <tr style="height:40px">
                <td>                 
                    Sıra No:
                </td>
                <td>                 
                    <asp:TextBox ID="TextBox27" runat="server" style="width:160px" TextMode="Number" MaxLength="20"></asp:TextBox>
                </td>
                </tr>
                <tr style="height:40px">
                <td>                 
                    Verildiği Yer:
                </td>
                <td>                 
                    <asp:TextBox ID="TextBox28" runat="server" style="width:160px" MaxLength="50" ></asp:TextBox>
                </td>
                </tr>
                <tr style="height:40px">
                <td>                 
                    Verildiği Tarih:
                </td>
                <td>                 
                    <asp:TextBox ID="TextBox29" runat="server" style="width:160px" TextMode="Date"></asp:TextBox>
                </td>
                </tr>
                <tr style="height:40px">
                <td>                 
                    İli:
                </td>
                <td>                 
                 <asp:DropDownList ID="DropDownList3" runat="server" style="width:160px" DataSourceID="SqlDataSource1" DataTextField="Sehir" DataValueField="Sehir">
                     <asp:ListItem Selected="True">Seçiniz</asp:ListItem>
                 </asp:DropDownList>
                </td>
                </tr>
                <tr style="height:40px">
                <td>                 
                    İlçesi:
                </td>
                <td>                 
                    <asp:TextBox ID="TextBox30" runat="server" style="width:160px" MaxLength="30"></asp:TextBox>
                </td>
                </tr>
                <tr style="height:40px">
                <td>                 
                    Mahalle veya Köy:
                </td>
                <td>                 
                    <asp:TextBox ID="TextBox31" runat="server" style="width:160px" MaxLength="50"></asp:TextBox>
                </td>
                </tr>              
            </table> 
            <br />
            </td>
        </asp:Panel> 
            <td style="width:25px">

            </td>
            <td>
        <strong>Kişi Listesi ve Arama Kutusu</strong>  
        <table style="text-align:left">
            <tr style="height:40px">
                <td>
                    <asp:TextBox ID="TextBox32" runat="server" style="width:100px" OnTextChanged="TextBox32_TextChanged"></asp:TextBox>
                    <asp:Button ID="Button5" runat="server" Text="Ara" style="width:50px; height:33px" OnClick="Button5_Click"/>
                    <asp:Button ID="Button6" runat="server" style="width:60px; height:33px" Text="Yenile" OnClick="Button6_Click" />
                </td>
                </tr>
                <tr>
                <td>
                    <asp:ListBox ID="ListBox1" runat="server" style="width:215px; height:550px" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" AutoPostBack="True"></asp:ListBox>
                </td>
            </tr>
        </table>
        </td>
    </tr>  
</table>
        </td>
    </tr>
</table>
    <div class="divider"></div>
</div>

</asp:Content>

