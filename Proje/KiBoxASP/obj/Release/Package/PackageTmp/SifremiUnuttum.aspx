<%@ Page Title="Şifremi Unuttum" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="SifremiUnuttum.aspx.cs" Inherits="KiBoxASP.SifremiUnuttum" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        
<div id="main">
    <div style="text-align:center">
        <span class="fa-4x"><%: Page.Title %></span>
        <br />
        <br />
        <span style="color:mediumblue">Kullanıcı Adı ve E-Posta Bilgilerini Doldurunuz.</span>
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
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td><br /></td>
            </tr>
            <tr>
                <td>E-Posta:</td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td><br /></td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="Doğrula" OnClick="Button1_Click" />
                </td>
            </tr>
        </table>
            </td>
        </tr>
    </table>
    </div>
    <div style="text-align:center">
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
    </div>
    <div class="divider"></div>
</div>

</asp:Content>
