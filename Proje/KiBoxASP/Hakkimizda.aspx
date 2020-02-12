<%@ Page Title="Hakkımızda" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="Hakkimizda.aspx.cs" Inherits="KiBoxASP.Hakkimizda" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

<div id="main">
    <div class="container">
        <span class="fa-4x"><%: Page.Title %></span>
        <div class="divider"></div>
        <br />
        <section>
            <header>
                <span class="byline" style="text-align:center">KİBOX HAKKINDA BİLGİLER &ndash; KİBOX'IN YAPIM AŞAMASI</span>
			</header>
		</section>
        <div class="row">
        <section class="6u right">
            <a class="image full"><img src="images/pics05.jpeg" alt=""></a>
			<p><strong>KiBox</strong>, üzerinde kişisel bilgi kutusu anlamını taşır. Program farklı amaçlar üzerine inşa edilmiştir. Sizin dileğinize göre kullanılabilir. İster kişisel bir rehber isterseniz ticari anlamda personel bilgilerini saklamakta kullanabilirsiniz. Veya bir okul, dershane, etüt merkezinde öğrenci bilgilerini saklayabilirsiniz. KiBox sizinle anlam taşır ve sizin hizmetinizdedir :)</p>
		</section>				
		<section class="6u left">
			<a class="image full"><img src="images/pics06.png" alt=""></a>
			<p><strong>KiBox</strong>, Kocaeli Üniversitesi Bilgisayar Programcılığı bölümü proje dersi kapsamında hazırlanmıştır. Microsoft Visual Studio derleyicisi ve ASP.NET altyapısı ile kodlanmıştır. Veri tabanı olarak Microsoft SQL SERVER kullanılmıştır. Sınırsız bilgi kaydı, girişi sayesinde kullanıcının isteklerini karşılar. KiBox sizinle anlam taşır ve sizin hizmetinizdedir :)</p>
		</section>
	    </div>
	    <div class="divider"></div>
	</div>
</div>

</asp:Content>
