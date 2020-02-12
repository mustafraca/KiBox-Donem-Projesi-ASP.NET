<%@ Page Title="Şifre Güncelleme" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="SifreDegistir.aspx.cs" Inherits="KiBoxASP.SifreDegistir" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

<div id="main">
    <div style="text-align:center">
        <span class="fa-4x"><%: Page.Title %></span>
        <br />
        <br />
        <span style="color:mediumblue">Şifrenizin güvenliği açısından güçlü bir parola seçiniz.</span>
        <div class="divider"></div>
        <br />
    </div>
    <div style="font-size:medium">
    <table style="width:100%; height:100%">
        <tr>
            <td align="center">
            <asp:Panel ID="Panel1" runat="server">
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
                    <td>
                        Güncel Şifreniz:
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td><br /></td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Button ID="Button1" Width="200" runat="server" Text="Onayla" OnClick="Button1_Click" />
                    </td>
                </tr>
            </table>
            </asp:Panel>
            <asp:Panel ID="Panel2" runat="server">
            <table style="text-align:center">
                <tr>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>Yeni Şifre:</td>
                    <td>
                        <asp:TextBox ID="TextBox3" runat="server" TextMode="Password"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><br /></td>
                </tr>
                <tr>
                    <td>Yeni Şifre Tekrar:</td>
                    <td>
                        <asp:TextBox ID="TextBox4" runat="server" TextMode="Password"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><br /></td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                <td>
                    <asp:Button ID="Button2" Width="200" runat="server" Text="Güncelle" OnClick="Button2_Click" />
                </td>
                </tr>
            </table>
            </asp:Panel>
            </td>
        </tr>
    </table>
    <div class="divider"></div>
    </div>
</div>

</asp:Content>
