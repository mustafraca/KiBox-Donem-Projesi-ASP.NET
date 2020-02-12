<%@ Page Title="Yardım" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="Yardim.aspx.cs" Inherits="KiBoxASP.Yardim" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

<div id="main">
    <div class="container">
        <span class="fa-4x"><%: Page.Title %></span>
        <div class="divider"></div>
        <br />
        <table style="width:100%; height:100%">
        <tr>
            <td align="center">
            <table style="text-align:center; width:700px">
                <tr>
                    <img src="images/Bilgi.jpg" alt="">
                </tr>
                <tr>
                    <td style="width:180px">
                    <asp:Button ID="Button1" runat="server" Text="Ekle Butonu Yardım" OnClick="Button1_Click" />
                    </td>
                    <td>
                    <asp:Button ID="Button2" runat="server" Text="Düzenle Butonu Yardım" OnClick="Button2_Click" />
                    </td>
                    <td>
                    <asp:Button ID="Button3" runat="server" Text="Sil Butonu Yardım" OnClick="Button3_Click" />
                    <td>
                    <asp:Button ID="Button4" runat="server" Text="Arama Kutusu Yardım" OnClick="Button4_Click" />
                    </td>
                </tr>
            </table>
            
            <asp:MultiView ID="MultiView1" runat="server">
            <asp:View ID="View1" runat="server">
                <span><img src="images/Ekle.jpg" alt=""></span>
            </asp:View>
            <asp:View ID="View2" runat="server">
                <span><img src="images/Duzenle.jpg" alt=""></span>
            </asp:View>
            <asp:View ID="View3" runat="server">
                <span><img src="images/Sil.jpg" alt=""></span>
            </asp:View>
            <asp:View ID="View4" runat="server">
                <span><img src="images/Arama.jpg" alt=""></span>
            </asp:View>
            </asp:MultiView>
                </td>
        </tr>
        </table>
	    <div class="divider"></div>
	</div>
</div>

</asp:Content>