<%@ Page Title="Anasayfa" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="KiBoxASP.Anasayfa" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        
<div id="extra">
    <div class="container">
        <div class="row">
            <section class="3u">
                <header>
                    <h2>KAYIT OLUN</h2>
				</header>
				<span class="fa fa-magic"></span>
					<p>KiBox'a kayıt olarak ücretsiz kullanıma başlayabilirsiniz. Kayıt olmadan programa erişilemez.</p>
					<a href="Kayit.aspx" class="button medium">KİBOX'A KAYIT OLUN</a>
            </section>
			<section class="3u">
				<header>
					<h2>ŞİFRENİZİ GÜNCELLEYİN</h2>
				</header>
				<span class="fa fa-wrench"></span>
					<p>Şifreniz güvenliğiniz için önemlidir. Şifre güvenliğiniz için belli aralıklarla güncelleyiniz.</p>
					<a href="SifreDegistir.aspx" class="button medium">ŞİFREMİ GÜNCELLE</a>
            </section>
			<section class="3u">
				<header>
					<h2>ŞİFRENİZİ Mİ UNUTTUNUZ?</h2>
				</header>
				<span class="fa fa-chain"></span>
					<p>Şifrenizi unuttuysanız endişelenmenize gerek yok. Şifrenize erişebilmek için gerekli bilgileri bilmeniz yeter.</p>
					<a href="SifremiUnuttum.aspx" class="button medium">ŞİFREMİ UNUTTUM</a>
            </section>
			<section class="3u">
				<header>
					<h2>HAKKIMIZDA</h2>
				</header>
				<span class="fa fa-briefcase"></span>
					<p>KiBox ücretsiz bir programdır. KiBox Kocaeli Üniversitesi ders projesidir. Detaylı bilgiler ile</p>
					<a href="Hakkimizda.aspx" class="button medium">BİZİ TANIYIN</a>
            </section>
        </div>
    </div>
</div>

<div id="main">		
    <div class="container">
        <section>
            <header>
                <h2>KİBOX - KİŞİSEL BİLGİ KUTUSU</h2>
            <span class="byline">KİBOX HAKKINDA BİLGİLER &ndash; KİBOX'IN YAPIM AŞAMASI</span>
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
