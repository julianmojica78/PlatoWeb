<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPagePrincipal.master" AutoEventWireup="true" CodeFile="~/Controller/Inicio.aspx.cs" Inherits="View_Inicio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<!DOCTYPE HTML>
<!--
	Aesthetic by gettemplates.co
	Twitter: http://twitter.com/gettemplateco
	URL: http://gettemplates.co
-->
<html>
	<head>
	<meta charset="utf-8"/>
	<meta http-equiv="X-UA-Compatible" content="IE=edge"/>
	<title>Inicio</title>


	<link href="https://fonts.googleapis.com/css?family=Lato:300,400,700" rel="stylesheet"/>
	<link href="https://fonts.googleapis.com/css?family=Kaushan+Script" rel="stylesheet"/>
	

	<link rel="stylesheet" href="../Styles/css/animate.css"/>
	<link rel="stylesheet" href="../Styles/css/icomoon.css"/>
	<link rel="stylesheet" href="../Styles/css/themify-icons.css"/>
	<link rel="stylesheet" href="../Styles/css/bootstrap.css"/>
	<link rel="stylesheet" href="../Styles/css/magnific-popup.css"/>
	<link rel="stylesheet" href="../Styles/css/bootstrap-datetimepicker.min.css"/>
	<link rel="stylesheet" href="../Styles/css/owl.carousel.min.css"/>
	<link rel="stylesheet" href="../Styles/css/owl.theme.default.min.css"/>
	<link rel="stylesheet" href="../Styles/css/style.css"/>
	<script src="../Styles/js/modernizr-2.6.2.min.js"></script>


	</head>
	<body>
		
	<div class="gtco-loader"></div>
	
	<div id="page">
	<header id="gtco-header" class="gtco-cover gtco-cover-sm" role="banner" style="background-image: url(../imagen/fondo.jpeg)" data-stellar-background-ratio="0.5">
		<div class="overlay"></div>
		<div class="gtco-container">
			<div class="row">
				<div class="col-md-12 col-md-offset-0 text-center">
					

					<div class="row row-mt-15em">
						<div class="col-md-12 mt-text animate-box" data-animate-effect="fadeInUp">
							<span class="intro-text-small">LA MEJOR PAGINA DE RESTAURANTES</span>
							<h1 class="cursive-font">Plato Web</h1>	
						</div>
						
					</div>
							
					
				</div>
			</div>
		</div>
	</header>

	
	
	<div class="gtco-section">
		<div class="gtco-container">
			<div class="row">
				<div class="col-md-8 col-md-offset-2 text-center gtco-heading">
					<h2 class="cursive-font primary-color">Platos Populares</h2>
					<p>Las Mejores Opciones.</p>
				</div>
			</div>
			<div class="row">

				<div class="col-lg-4 col-md-4 col-sm-6">
					<a href="../Imagen/arroz.jpg" class="fh5co-card-item image-popup">
						<figure>
							<div class="overlay"><i class="ti-plus"></i></div>
							<img src="../Imagen/arroz.jpg" alt="Image" class="img-responsive"/>
						</figure>
						<div class="fh5co-text">
							<h2>Arroz</h2>
							<p>El mejor arroz del mundo.</p>
							<p><span class="price cursive-font">$10.000</span></p>
						</div>
					</a>
				</div>
				<div class="col-lg-4 col-md-4 col-sm-6">
					<a href="../Imagen/salchipapa.jpg" class="fh5co-card-item image-popup">
						<figure>
							<div class="overlay"><i class="ti-plus"></i></div>
							<img src="../Imagen/salchipapa.jpg" alt="Image" class="img-responsive">
						</figure>
						<div class="fh5co-text">
							<h2>Salchipapa</h2>
							<p>La mejor salchipapa.</p>
							<p><span class="price cursive-font">$15.000</span></p>
						</div>
					</a>
				</div>
				<div class="col-lg-4 col-md-4 col-sm-6">
					<a href="../Imagen/sushi.jpg" class="fh5co-card-item image-popup">
						<figure>
							<div class="overlay"><i class="ti-plus"></i></div>
							<img src="../Imagen/sushi.jpg" alt="Image" class="img-responsive">
						</figure>
						<div class="fh5co-text">
							<h2>Sushi</h2>
							<p>El mejor sushi.</p>
							<p><span class="price cursive-font">$20.000</span></p>

						</div>
					</a>
				</div>


<%--				<div class="col-lg-4 col-md-4 col-sm-6">
					<a href="images/img_4.jpg" class="fh5co-card-item image-popup">
						<figure>
							<div class="overlay"><i class="ti-plus"></i></div>
							<img src="images/img_4.jpg" alt="Image" class="img-responsive">
						</figure>
						<div class="fh5co-text">
							<h2>Organic Egg</h2>
							<p>Far far away, behind the word mountains, far from the countries Vokalia..</p>
							<p><span class="price cursive-font">$12.99</span></p>
						</div>
					</a>
				</div>

				<div class="col-lg-4 col-md-4 col-sm-6">
					<a href="images/img_5.jpg" class="fh5co-card-item image-popup">
						<figure>
							<div class="overlay"><i class="ti-plus"></i></div>
							<img src="images/img_5.jpg" alt="Image" class="img-responsive">
						</figure>
						<div class="fh5co-text">
							<h2>Tomato Soup with Chicken</h2>
							<p>Far far away, behind the word mountains, far from the countries Vokalia..</p>
							<p><span class="price cursive-font">$23.10</span></p>
						</div>
					</a>
				</div>

				<div class="col-lg-4 col-md-4 col-sm-6">
					<a href="images/img_6.jpg" class="fh5co-card-item image-popup">
						<figure>
							<div class="overlay"><i class="ti-plus"></i></div>
							<img src="images/img_6.jpg" alt="Image" class="img-responsive">
						</figure>
						<div class="fh5co-text">
							<h2>Salad with Crispy Chicken</h2>
							<p>Far far away, behind the word mountains, far from the countries Vokalia..</p>
							<p><span class="price cursive-font">$5.59</span></p>
						</div>
					</a>
				</div>--%>

			</div>
		</div>
	</div>
	<!-- </div> -->

	</div>
	
	<script src="../Styles/js/jquery.min.js"></script>
	<script src="../Styles/js/jquery.easing.1.3.js"></script>
	<script src="../Styles/js/bootstrap.min.js"></script>
	<script src="../Styles/js/jquery.waypoints.min.js"></script>
	<script src="../Styles/js/owl.carousel.min.js"></script>
	<script src="../Styles/js/jquery.countTo.js"></script>
	<script src="../Styles/js/jquery.stellar.min.js"></script>
	<script src="../Styles/js/jquery.magnific-popup.min.js"></script>
	<script src="../Styles/js/magnific-popup-options.js"></script>
	
	<script src="../Styles/js/moment.min.js"></script>
	<script src="../Styles/js/bootstrap-datetimepicker.min.js"></script>
	<script src="../Styles/js/main.js"></script>

	</body>
</html>

</asp:Content>

