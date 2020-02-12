<%@ Page Title="Oturum Aç" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="Giris.aspx.cs" Inherits="KiBoxASP.Giris" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
       
<div id="main">
    <div style="text-align:center">
        <span class="fa-4x"><%: Page.Title %></span>
        <br />
        <br />
        <span style="color:mediumblue">Kayıtlı değilseniz "KAYIT OL" bölümünden kayıt olunuz.</span>
        <div class="divider"></div>
        <br />
    </div> 
    <div style="font-size:medium">
    <table style="width:100%; height:100%">
        <tr>
            <td align="center">
            <table style="text-align:center">
                <tr>
                    <td>Kullanıcı Adı:</td>
                    <td><asp:TextBox ID="TextBox1" runat="server" MaxLength="20"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><br /></td>
                </tr>
                <tr>
                    <td>Şifre:</td>
                    <td><asp:TextBox ID="TextBox2" runat="server" TextMode="Password" MaxLength="20"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><br /></td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td><asp:Button ID="Button1" runat="server" Width="200" Text="Oturum Aç" OnClick="Button1_Click" /></td>
                </tr>
                <tr>
                    <td><br /></td>
                </tr>
                <tr>
                    <td><asp:LinkButton href="SifremiUnuttum.aspx" ID="sifremiunuttum" style="color:black" runat="server">Şifremi Unuttum</asp:LinkButton></td>
                    
                    <td><asp:LinkButton href="SifreDegistir.aspx" ID="sifredegistir" style="color:black" runat="server">Şifre Değiştir</asp:LinkButton></td>
                </tr>
           </table>
           </td>
        </tr>
    </table>
    </div>
    <div class="divider"></div>
</div>

</asp:Content>