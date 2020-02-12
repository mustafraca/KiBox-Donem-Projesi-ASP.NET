<%@ Page Title="Kayıt Ol" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="Kayit.aspx.cs" Inherits="KiBoxASP.Kayit" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        
<div id="main">
    <div style="text-align:center">
        <span class="fa-4x"><%: Page.Title %></span>
        <br />
        <br />
        <span style="color:mediumblue">Tüm Alanların Doldurulması Zorunludur.</span>
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
            <td>
                <asp:TextBox ID="TextBox1" runat="server" MaxLength="20"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td><br /></td>
        </tr>
        <tr>
            <td>Şifre:</td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server" MaxLength="20" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td><br /></td>
        </tr>
        <tr>
            <td>Şifre Tekrar:</td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server" MaxLength="20" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td><br /></td>
        </tr>
        <tr>
            <td>E-Posta:</td>
            <td>
                <asp:TextBox ID="TextBox4" runat="server" TextMode="Email" MaxLength="50"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td><br /></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" Width="200" Text="Kayıt Ol" OnClick="Button1_Click" />
            </td>
        </tr>
    </table>
   </td>
  </tr>
 </table>
 </div> 
        <div class="divider"></div>
</div>

</asp:Content>
