<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Votar.aspx.cs" Inherits="Prueba.Views.Votar" %>

<!DOCTYPE html>
<html lang="en">
<head>
	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<title>Sistema Electoral</title>

	<!-- Global stylesheets -->
	<link href="https://fonts.googleapis.com/css?family=Roboto:400,300,100,500,700,900" rel="stylesheet" type="text/css">
	<link href="assets/css/icons/icomoon/styles.css" rel="stylesheet" type="text/css">
	<link href="assets/css/minified/bootstrap.min.css" rel="stylesheet" type="text/css">
	<link href="assets/css/minified/core.min.css" rel="stylesheet" type="text/css">
	<link href="assets/css/minified/components.min.css" rel="stylesheet" type="text/css">
	<link href="assets/css/minified/colors.min.css" rel="stylesheet" type="text/css">
	<!-- /global stylesheets -->

	<!-- Core JS files -->
    <script type="text/javascript" src="assets/js/plugins/forms/wizards/steps.min.js"></script>
	<script type="text/javascript" src="assets/js/plugins/loaders/pace.min.js"></script>
	<script type="text/javascript" src="assets/js/core/libraries/jquery.min.js"></script>
	<script type="text/javascript" src="assets/js/core/libraries/bootstrap.min.js"></script>
	<script type="text/javascript" src="assets/js/plugins/loaders/blockui.min.js"></script>
	<!-- /core JS files -->

	<!-- Theme JS files -->
    <script type="text/javascript" src="assets/js/pages/wizard_steps.js"></script>
	<script type="text/javascript" src="assets/js/core/app.js"></script>
	<script type="text/javascript" src="assets/js/pages/dashboard.js"></script>
	<!-- /theme JS files -->

</head>

<body>

	<!-- Main navbar -->
	<div class="navbar navbar-inverse">
		<div class="navbar-header">
			<a class="navbar-brand" href="index.html"><img src="assets/images/logo_light.png" alt=""></a>

			<ul class="nav navbar-nav visible-xs-block">
				<li><a data-toggle="collapse" data-target="#navbar-mobile"><i class="icon-tree5"></i></a></li>
				<li><a class="sidebar-mobile-main-toggle"><i class="icon-paragraph-justify3"></i></a></li>
			</ul>
		</div>

		<div class="navbar-collapse collapse" id="navbar-mobile">
			<ul class="nav navbar-nav">
				<li><a class="sidebar-control sidebar-main-toggle hidden-xs"><i class="icon-paragraph-justify3"></i></a></li>
			</ul>

			<ul class="nav navbar-nav navbar-right">
				<li class="dropdown dropdown-user">
					<a class="dropdown-toggle" data-toggle="dropdown">
						<img src="assets/images/placeholder.jpg" alt="">
						<span>Usuario</span>
						<i class="caret"></i>
					</a>

					<ul class="dropdown-menu dropdown-menu-right">
						<li><a href="#"><i class="icon-switch2"></i> Salir</a></li>
					</ul>
				</li>
			</ul>
		</div>
	</div>
	<!-- /main navbar -->


	<!-- Page container -->
	<div class="page-container">

		<!-- Page content -->
		<div class="page-content">

			<!-- Main sidebar -->
			<div class="sidebar sidebar-main">
				<div class="sidebar-content">

					<!-- User menu -->
					<div class="sidebar-user">
						<div class="category-content">
							<div class="media">
								<a href="#" class="media-left"><img src="assets/images/placeholder.jpg" class="img-circle img-sm" alt=""></a>
								<div class="media-body">
									<span class="media-heading text-semibold">Electoral</span>
									<div class="text-size-mini text-muted">
										<i class="icon-pin text-size-small" > Prueba Token</i> 
									</div>
								</div>

								<div class="media-right media-middle">
									<ul class="icons-list">
										<li>
											<a href="#"><i class="icon-cog3"></i></a>
										</li>
									</ul>
								</div>
							</div>
						</div>
					</div>
					<!-- /user menu -->


					<!-- Main navigation -->
						<div class="sidebar-category sidebar-category-visible">
						<div class="category-content no-padding">
							<ul class="navigation navigation-main navigation-accordion">

								<!-- Main -->
								<li class="navigation-header"><span>Convocatorias</span> <i class="icon-menu" title="Convocatorias"></i></li>
								<li class="active"><a href="Index.aspx"><i class="icon-home4"></i> <span>Principal</span></a></li>
								<li>
									<a href="#"><i class="icon-stack2"></i> <span>Convocatorias</span></a>
									<ul>
										<li><a href="VConvocatoria.aspx">Gestionar convocatoria</a></li>
                                        <li><a href="#">Lanzar convocatoria</a></li>
									</ul>
								</li>
                                <li>
									<a href="#"><i class="icon-vcard"></i> <span>Candidatos</span></a>
									<ul>
										<li><a href="VCandidato.aspx">Gestionar candidatos</a></li>
                                        <li><a href="#">Mi candidatura</a></li>
									</ul>
								</li>
                                <li>
									<a href="#"><i class="icon-puzzle"></i> <span>Parametricas</span></a>
									<ul>
										<li><a href="VCobertura.aspx">Cobertura</a></li>
                                        <li><a href="Causaderetiro.aspx">Causa de retiro</a></li>
                                        <li><a href="Instancias.aspx">Instancias</a></li>
                                        <li><a href="InstancConformacion.aspx">Instancia conformacion</a></li>
									</ul>
								</li>
                                 <li>
									<a href="#"><i class="icon-stack-text"></i> <span>Votaciones</span></a>
									<ul>
										<li><a href="Votar.aspx">Votar</a></li>
                                        <li><a href="#">Resultados</a></li>
									</ul>
								</li>
                                
							</ul>
						</div>
					</div>
					<!-- /main navigation -->

				</div>
			</div>
			<!-- /main sidebar -->


			<!-- Main content -->
			<div class="content-wrapper">
				<div class="page-header">
					<div class="breadcrumb-line">
						<ul class="breadcrumb">
							<li><a href="Index.aspx"><i class="icon-home2 position-left"></i> Index</a></li>
						</ul>
					</div>
				</div>
				<!-- /page header -->


				<!-- Content area -->
				<div class="content">
				
				<div class="panel panel-white">
						<div class="panel-heading">
							<h6 class="panel-title">Basic example</h6>
							<div class="heading-elements">
								<ul class="icons-list">
			                		<li><a data-action="collapse"></a></li>
			                		<li><a data-action="reload"></a></li>
			                		<li><a data-action="close"></a></li>
			                	</ul>
		                	</div>
						<a class="heading-elements-toggle"><i class="icon-menu"></i></a></div>

	                	<form class="steps-basic wizard clearfix" action="#" role="application" id="steps-uid-0"><div class="steps clearfix"><ul role="tablist"><li role="tab" class="first done" aria-disabled="false" aria-selected="false"><a id="steps-uid-0-t-0" href="#steps-uid-0-h-0" aria-controls="steps-uid-0-p-0"><span class="number">1</span> Personal data</a></li><li role="tab" class="current" aria-disabled="false" aria-selected="true"><a id="steps-uid-0-t-1" href="#steps-uid-0-h-1" aria-controls="steps-uid-0-p-1"><span class="current-info audible">current step: </span><span class="number">2</span> Your education</a></li><li role="tab" class="disabled" aria-disabled="true"><a id="steps-uid-0-t-2" href="#steps-uid-0-h-2" aria-controls="steps-uid-0-p-2"><span class="number">3</span> Your experience</a></li><li role="tab" class="disabled last" aria-disabled="true"><a id="steps-uid-0-t-3" href="#steps-uid-0-h-3" aria-controls="steps-uid-0-p-3"><span class="number">4</span> Additional info</a></li></ul></div><div class="content clearfix">
							<h6 id="steps-uid-0-h-0" tabindex="-1" class="title">Personal data</h6>
							<fieldset id="steps-uid-0-p-0" role="tabpanel" aria-labelledby="steps-uid-0-h-0" class="body" aria-hidden="true" style="display: none;">
								<div class="row">
									<div class="col-md-6">
										<div class="form-group">
											<label>Select location:</label>
											<div class="select2-container select" id="s2id_autogen1"><a href="javascript:void(0)" class="select2-choice select2-default" tabindex="-1">   <span class="select2-chosen" id="select2-chosen-2">Select position</span><abbr class="select2-search-choice-close"></abbr>   <span class="select2-arrow" role="presentation"><b role="presentation"></b></span></a><label for="s2id_autogen2" class="select2-offscreen"></label><input class="select2-focusser select2-offscreen" type="text" aria-haspopup="true" role="button" aria-labelledby="select2-chosen-2" id="s2id_autogen2"><div class="select2-drop select2-display-none select2-with-searchbox">   <div class="select2-search">       <label for="s2id_autogen2_search" class="select2-offscreen"></label>       <input type="text" autocomplete="off" autocorrect="off" autocapitalize="off" spellcheck="false" class="select2-input" role="combobox" aria-expanded="true" aria-autocomplete="list" aria-owns="select2-results-2" id="s2id_autogen2_search" placeholder="">   </div>   <ul class="select2-results" role="listbox" id="select2-results-2">   </ul></div></div><select name="location" data-placeholder="Select position" class="select select2-offscreen" tabindex="-1" title="">
												<option></option>
												<optgroup label="North America">
													<option value="1">United States</option>
													<option value="2">Canada</option>
												</optgroup>

												<optgroup label="Latin America">
													<option value="3">Chile</option>
													<option value="4">Argentina</option>
													<option value="5">Colombia</option>
													<option value="6">Peru</option>
												</optgroup>

												<optgroup label="Europe">
													<option value="8">Croatia</option>
													<option value="9">Hungary</option>
													<option value="10">Ukraine</option>
													<option value="11">Greece</option>
												</optgroup>

												<optgroup label="Middle East &amp; Africa">
													<option value="21">Egypt</option>
													<option value="22">Israel</option>
													<option value="23">Nigeria</option>
													<option value="24">United Arab Emirates</option>
												</optgroup>

												<optgroup label="Asia Pacific">
													<option value="26">Australia</option>
													<option value="27">China</option>
													<option value="28">India</option>
													<option value="29">Singapore</option>
												</optgroup>
											</select>
										</div>
									</div>

									<div class="col-md-6">
										<div class="form-group">
											<label>Select position:</label>
											<div class="select2-container select" id="s2id_autogen3"><a href="javascript:void(0)" class="select2-choice select2-default" tabindex="-1">   <span class="select2-chosen" id="select2-chosen-4">Select position</span><abbr class="select2-search-choice-close"></abbr>   <span class="select2-arrow" role="presentation"><b role="presentation"></b></span></a><label for="s2id_autogen4" class="select2-offscreen"></label><input class="select2-focusser select2-offscreen" type="text" aria-haspopup="true" role="button" aria-labelledby="select2-chosen-4" id="s2id_autogen4"><div class="select2-drop select2-display-none select2-with-searchbox">   <div class="select2-search">       <label for="s2id_autogen4_search" class="select2-offscreen"></label>       <input type="text" autocomplete="off" autocorrect="off" autocapitalize="off" spellcheck="false" class="select2-input" role="combobox" aria-expanded="true" aria-autocomplete="list" aria-owns="select2-results-4" id="s2id_autogen4_search" placeholder="">   </div>   <ul class="select2-results" role="listbox" id="select2-results-4">   </ul></div></div><select name="position" data-placeholder="Select position" class="select select2-offscreen" tabindex="-1" title="">
												<option></option>
												<optgroup label="Developer Relations">
													<option value="1">Sales Engineer</option>
													<option value="2">Ads Solutions Consultant</option>
													<option value="3">Technical Solutions Consultant</option>
													<option value="4">Business Intern</option>
												</optgroup>

												<optgroup label="Engineering &amp; Design">
													<option value="5">Interaction Designer</option>
													<option value="6">Technical Program Manager</option>
													<option value="7">Software Engineer</option>
													<option value="8">Information Security Engineer</option>
												</optgroup>

												<optgroup label="Marketing &amp; Communications">
													<option value="13">Media Outreach Manager</option>
													<option value="14">Research Manager</option>
													<option value="15">Marketing Intern</option>
													<option value="16">Business Intern</option>
												</optgroup>

												<optgroup label="Sales Operations">
													<option value="17">Sales Operations Analyst</option>
													<option value="18">Technology Product Manager</option>
													<option value="19">Product Expert</option>
													<option value="20">Sales Insights Analyst</option>
													<option value="21">Customer Operations Analyst</option>
												</optgroup>
											</select>
										</div>
									</div>
								</div>

								<div class="row">
									<div class="col-md-6">
										<div class="form-group">
											<label>Applicant name:</label>
											<input type="text" name="name" class="form-control" placeholder="John Doe">
										</div>
									</div>

									<div class="col-md-6">
										<div class="form-group">
											<label>Email address:</label>
											<input type="email" name="email" class="form-control" placeholder="your@email.com">
										</div>
									</div>
								</div>

								<div class="row">
									<div class="col-md-6">
										<div class="form-group">
											<label>Phone #:</label>
											<input type="text" name="tel" class="form-control" placeholder="+99-99-9999-9999" data-mask="+99-99-9999-9999">
										</div>
									</div>

									<div class="col-md-6">
										<label>Date of birth:</label>
										<div class="row">
											<div class="col-md-4">
												<div class="form-group">
													<div class="select2-container select" id="s2id_autogen5"><a href="javascript:void(0)" class="select2-choice select2-default" tabindex="-1">   <span class="select2-chosen" id="select2-chosen-6">Month</span><abbr class="select2-search-choice-close"></abbr>   <span class="select2-arrow" role="presentation"><b role="presentation"></b></span></a><label for="s2id_autogen6" class="select2-offscreen"></label><input class="select2-focusser select2-offscreen" type="text" aria-haspopup="true" role="button" aria-labelledby="select2-chosen-6" id="s2id_autogen6"><div class="select2-drop select2-display-none select2-with-searchbox">   <div class="select2-search">       <label for="s2id_autogen6_search" class="select2-offscreen"></label>       <input type="text" autocomplete="off" autocorrect="off" autocapitalize="off" spellcheck="false" class="select2-input" role="combobox" aria-expanded="true" aria-autocomplete="list" aria-owns="select2-results-6" id="s2id_autogen6_search" placeholder="">   </div>   <ul class="select2-results" role="listbox" id="select2-results-6">   </ul></div></div><select name="birth-month" data-placeholder="Month" class="select select2-offscreen" tabindex="-1" title="">
														<option></option>
														<option value="1">January</option>
														<option value="2">February</option>
														<option value="3">March</option>
														<option value="4">April</option>
														<option value="5">May</option>
														<option value="6">June</option>
														<option value="7">July</option>
														<option value="8">August</option>
														<option value="9">September</option>
														<option value="10">October</option>
														<option value="11">November</option>
														<option value="12">December</option>
													</select>
												</div>
											</div>

											<div class="col-md-4">
												<div class="form-group">
													<div class="select2-container select" id="s2id_autogen7"><a href="javascript:void(0)" class="select2-choice select2-default" tabindex="-1">   <span class="select2-chosen" id="select2-chosen-8">Day</span><abbr class="select2-search-choice-close"></abbr>   <span class="select2-arrow" role="presentation"><b role="presentation"></b></span></a><label for="s2id_autogen8" class="select2-offscreen"></label><input class="select2-focusser select2-offscreen" type="text" aria-haspopup="true" role="button" aria-labelledby="select2-chosen-8" id="s2id_autogen8"><div class="select2-drop select2-display-none select2-with-searchbox">   <div class="select2-search">       <label for="s2id_autogen8_search" class="select2-offscreen"></label>       <input type="text" autocomplete="off" autocorrect="off" autocapitalize="off" spellcheck="false" class="select2-input" role="combobox" aria-expanded="true" aria-autocomplete="list" aria-owns="select2-results-8" id="s2id_autogen8_search" placeholder="">   </div>   <ul class="select2-results" role="listbox" id="select2-results-8">   </ul></div></div><select name="birth-day" data-placeholder="Day" class="select select2-offscreen" tabindex="-1" title="">
														<option></option>
														<option value="1">1</option>
														<option value="2">2</option>
														<option value="3">3</option>
														<option value="4">4</option>
														<option value="5">5</option>
														<option value="6">6</option>
														<option value="7">7</option>
														<option value="8">8</option>
														<option value="9">9</option>
														<option value="...">...</option>
														<option value="31">31</option>
													</select>
												</div>
											</div>

											<div class="col-md-4">
												<div class="form-group">
													<div class="select2-container select" id="s2id_autogen9"><a href="javascript:void(0)" class="select2-choice select2-default" tabindex="-1">   <span class="select2-chosen" id="select2-chosen-10">Year</span><abbr class="select2-search-choice-close"></abbr>   <span class="select2-arrow" role="presentation"><b role="presentation"></b></span></a><label for="s2id_autogen10" class="select2-offscreen"></label><input class="select2-focusser select2-offscreen" type="text" aria-haspopup="true" role="button" aria-labelledby="select2-chosen-10" id="s2id_autogen10"><div class="select2-drop select2-display-none select2-with-searchbox">   <div class="select2-search">       <label for="s2id_autogen10_search" class="select2-offscreen"></label>       <input type="text" autocomplete="off" autocorrect="off" autocapitalize="off" spellcheck="false" class="select2-input" role="combobox" aria-expanded="true" aria-autocomplete="list" aria-owns="select2-results-10" id="s2id_autogen10_search" placeholder="">   </div>   <ul class="select2-results" role="listbox" id="select2-results-10">   </ul></div></div><select name="birth-year" data-placeholder="Year" class="select select2-offscreen" tabindex="-1" title="">
														<option></option>
														<option value="1">1980</option>
														<option value="2">1981</option>
														<option value="3">1982</option>
														<option value="4">1983</option>
														<option value="5">1984</option>
														<option value="6">1985</option>
														<option value="7">1986</option>
														<option value="8">1987</option>
														<option value="9">1988</option>
														<option value="10">1989</option>
														<option value="11">1990</option>
													</select>
												</div>
											</div>
										</div>
									</div>
								</div>
							</fieldset>

							<h6 id="steps-uid-0-h-1" tabindex="-1" class="title current">Your education</h6>
							<fieldset id="steps-uid-0-p-1" role="tabpanel" aria-labelledby="steps-uid-0-h-1" class="body current" aria-hidden="false" style="display: block;">
								<div class="row">
									<div class="col-md-6">
										<div class="form-group">
											<label>University:</label>
			                                <input type="text" name="university" placeholder="University name" class="form-control">
		                                </div>
									</div>

									<div class="col-md-6">
										<div class="form-group">
											<label>Country:</label>
		                                    <div class="select2-container select" id="s2id_autogen11"><a href="javascript:void(0)" class="select2-choice select2-default" tabindex="-1">   <span class="select2-chosen" id="select2-chosen-12">Choose a Country...</span><abbr class="select2-search-choice-close"></abbr>   <span class="select2-arrow" role="presentation"><b role="presentation"></b></span></a><label for="s2id_autogen12" class="select2-offscreen"></label><input class="select2-focusser select2-offscreen" type="text" aria-haspopup="true" role="button" aria-labelledby="select2-chosen-12" id="s2id_autogen12"><div class="select2-drop select2-display-none select2-with-searchbox">   <div class="select2-search">       <label for="s2id_autogen12_search" class="select2-offscreen"></label>       <input type="text" autocomplete="off" autocorrect="off" autocapitalize="off" spellcheck="false" class="select2-input" role="combobox" aria-expanded="true" aria-autocomplete="list" aria-owns="select2-results-12" id="s2id_autogen12_search" placeholder="">   </div>   <ul class="select2-results" role="listbox" id="select2-results-12">   </ul></div></div><select name="university-country" data-placeholder="Choose a Country..." class="select select2-offscreen" tabindex="-1" title="">
		                                        <option></option> 
		                                        <option value="1">United States</option> 
		                                        <option value="2">France</option> 
		                                        <option value="3">Germany</option> 
		                                        <option value="4">Spain</option> 
		                                    </select>
	                                    </div>
									</div>
								</div>

								<div class="row">
									<div class="col-md-6">
										<div class="form-group">
											<label>Degree level:</label>
			                                <input type="text" name="degree-level" placeholder="Bachelor, Master etc." class="form-control">
		                                </div>

										<div class="form-group">
											<label>Specialization:</label>
			                                <input type="text" name="specialization" placeholder="Design, Development etc." class="form-control">
		                                </div>
									</div>

									<div class="col-md-6">
										<div class="row">
											<div class="col-md-6">
												<label>From:</label>
												<div class="row">
													<div class="col-md-6">
														<div class="form-group">
						                                    <div class="select2-container select" id="s2id_autogen13"><a href="javascript:void(0)" class="select2-choice select2-default" tabindex="-1">   <span class="select2-chosen" id="select2-chosen-14">Month</span><abbr class="select2-search-choice-close"></abbr>   <span class="select2-arrow" role="presentation"><b role="presentation"></b></span></a><label for="s2id_autogen14" class="select2-offscreen"></label><input class="select2-focusser select2-offscreen" type="text" aria-haspopup="true" role="button" aria-labelledby="select2-chosen-14" id="s2id_autogen14"><div class="select2-drop select2-display-none select2-with-searchbox">   <div class="select2-search">       <label for="s2id_autogen14_search" class="select2-offscreen"></label>       <input type="text" autocomplete="off" autocorrect="off" autocapitalize="off" spellcheck="false" class="select2-input" role="combobox" aria-expanded="true" aria-autocomplete="list" aria-owns="select2-results-14" id="s2id_autogen14_search" placeholder="">   </div>   <ul class="select2-results" role="listbox" id="select2-results-14">   </ul></div></div><select name="education-from-month" data-placeholder="Month" class="select select2-offscreen" tabindex="-1" title="">
						                                    	<option></option>
						                                        <option value="January">January</option> 
						                                        <option value="...">...</option> 
						                                        <option value="December">December</option> 
						                                    </select>
					                                    </div>
													</div>

													<div class="col-md-6">
														<div class="form-group">
						                                    <div class="select2-container select" id="s2id_autogen15"><a href="javascript:void(0)" class="select2-choice select2-default" tabindex="-1">   <span class="select2-chosen" id="select2-chosen-16">Year</span><abbr class="select2-search-choice-close"></abbr>   <span class="select2-arrow" role="presentation"><b role="presentation"></b></span></a><label for="s2id_autogen16" class="select2-offscreen"></label><input class="select2-focusser select2-offscreen" type="text" aria-haspopup="true" role="button" aria-labelledby="select2-chosen-16" id="s2id_autogen16"><div class="select2-drop select2-display-none select2-with-searchbox">   <div class="select2-search">       <label for="s2id_autogen16_search" class="select2-offscreen"></label>       <input type="text" autocomplete="off" autocorrect="off" autocapitalize="off" spellcheck="false" class="select2-input" role="combobox" aria-expanded="true" aria-autocomplete="list" aria-owns="select2-results-16" id="s2id_autogen16_search" placeholder="">   </div>   <ul class="select2-results" role="listbox" id="select2-results-16">   </ul></div></div><select name="education-from-year" data-placeholder="Year" class="select select2-offscreen" tabindex="-1" title="">
						                                        <option></option> 
						                                        <option value="1995">1995</option> 
						                                        <option value="...">...</option> 
						                                        <option value="1980">1980</option> 
						                                    </select>
					                                    </div>
													</div>
												</div>
											</div>

											<div class="col-md-6">
												<label>To:</label>
												<div class="row">
													<div class="col-md-6">
														<div class="form-group">
						                                    <div class="select2-container select" id="s2id_autogen17"><a href="javascript:void(0)" class="select2-choice select2-default" tabindex="-1">   <span class="select2-chosen" id="select2-chosen-18">Month</span><abbr class="select2-search-choice-close"></abbr>   <span class="select2-arrow" role="presentation"><b role="presentation"></b></span></a><label for="s2id_autogen18" class="select2-offscreen"></label><input class="select2-focusser select2-offscreen" type="text" aria-haspopup="true" role="button" aria-labelledby="select2-chosen-18" id="s2id_autogen18"><div class="select2-drop select2-display-none select2-with-searchbox">   <div class="select2-search">       <label for="s2id_autogen18_search" class="select2-offscreen"></label>       <input type="text" autocomplete="off" autocorrect="off" autocapitalize="off" spellcheck="false" class="select2-input" role="combobox" aria-expanded="true" aria-autocomplete="list" aria-owns="select2-results-18" id="s2id_autogen18_search" placeholder="">   </div>   <ul class="select2-results" role="listbox" id="select2-results-18">   </ul></div></div><select name="education-to-month" data-placeholder="Month" class="select select2-offscreen" tabindex="-1" title="">
						                                    	<option></option>
						                                        <option value="January">January</option> 
						                                        <option value="...">...</option> 
						                                        <option value="December">December</option> 
						                                    </select>
					                                    </div>
													</div>

													<div class="col-md-6">
														<div class="form-group">
						                                    <div class="select2-container select" id="s2id_autogen19"><a href="javascript:void(0)" class="select2-choice select2-default" tabindex="-1">   <span class="select2-chosen" id="select2-chosen-20">Year</span><abbr class="select2-search-choice-close"></abbr>   <span class="select2-arrow" role="presentation"><b role="presentation"></b></span></a><label for="s2id_autogen20" class="select2-offscreen"></label><input class="select2-focusser select2-offscreen" type="text" aria-haspopup="true" role="button" aria-labelledby="select2-chosen-20" id="s2id_autogen20"><div class="select2-drop select2-display-none select2-with-searchbox">   <div class="select2-search">       <label for="s2id_autogen20_search" class="select2-offscreen"></label>       <input type="text" autocomplete="off" autocorrect="off" autocapitalize="off" spellcheck="false" class="select2-input" role="combobox" aria-expanded="true" aria-autocomplete="list" aria-owns="select2-results-20" id="s2id_autogen20_search" placeholder="">   </div>   <ul class="select2-results" role="listbox" id="select2-results-20">   </ul></div></div><select name="education-to-year" data-placeholder="Year" class="select select2-offscreen" tabindex="-1" title="">
						                                        <option></option> 
						                                        <option value="1995">1995</option> 
						                                        <option value="...">...</option> 
						                                        <option value="1980">1980</option> 
						                                    </select>
					                                    </div>
													</div>
												</div>
											</div>
										</div>

										<div class="form-group">
											<label>Language of education:</label>
			                                <input type="text" name="education-language" placeholder="English, German etc." class="form-control">
		                                </div>
									</div>
								</div>
							</fieldset>

							<h6 id="steps-uid-0-h-2" tabindex="-1" class="title">Your experience</h6>
							<fieldset id="steps-uid-0-p-2" role="tabpanel" aria-labelledby="steps-uid-0-h-2" class="body" aria-hidden="true" style="display: none;">
								<div class="row">
									<div class="col-md-6">
										<div class="form-group">
											<label>Company:</label>
			                                <input type="text" name="experience-company" placeholder="Company name" class="form-control">
		                                </div>

										<div class="form-group">
											<label>Position:</label>
			                                <input type="text" name="experience-position" placeholder="Company name" class="form-control">
		                                </div>

										<div class="row">
											<div class="col-md-6">
												<label>From:</label>
												<div class="row">
													<div class="col-md-6">
														<div class="form-group">
						                                    <div class="select2-container select" id="s2id_autogen21"><a href="javascript:void(0)" class="select2-choice select2-default" tabindex="-1">   <span class="select2-chosen" id="select2-chosen-22">Month</span><abbr class="select2-search-choice-close"></abbr>   <span class="select2-arrow" role="presentation"><b role="presentation"></b></span></a><label for="s2id_autogen22" class="select2-offscreen"></label><input class="select2-focusser select2-offscreen" type="text" aria-haspopup="true" role="button" aria-labelledby="select2-chosen-22" id="s2id_autogen22"><div class="select2-drop select2-display-none select2-with-searchbox">   <div class="select2-search">       <label for="s2id_autogen22_search" class="select2-offscreen"></label>       <input type="text" autocomplete="off" autocorrect="off" autocapitalize="off" spellcheck="false" class="select2-input" role="combobox" aria-expanded="true" aria-autocomplete="list" aria-owns="select2-results-22" id="s2id_autogen22_search" placeholder="">   </div>   <ul class="select2-results" role="listbox" id="select2-results-22">   </ul></div></div><select name="education-from-month" data-placeholder="Month" class="select select2-offscreen" tabindex="-1" title="">
						                                    	<option></option>
						                                        <option value="January">January</option> 
						                                        <option value="...">...</option> 
						                                        <option value="December">December</option> 
						                                    </select>
					                                    </div>
													</div>

													<div class="col-md-6">
														<div class="form-group">
						                                    <div class="select2-container select" id="s2id_autogen23"><a href="javascript:void(0)" class="select2-choice select2-default" tabindex="-1">   <span class="select2-chosen" id="select2-chosen-24">Year</span><abbr class="select2-search-choice-close"></abbr>   <span class="select2-arrow" role="presentation"><b role="presentation"></b></span></a><label for="s2id_autogen24" class="select2-offscreen"></label><input class="select2-focusser select2-offscreen" type="text" aria-haspopup="true" role="button" aria-labelledby="select2-chosen-24" id="s2id_autogen24"><div class="select2-drop select2-display-none select2-with-searchbox">   <div class="select2-search">       <label for="s2id_autogen24_search" class="select2-offscreen"></label>       <input type="text" autocomplete="off" autocorrect="off" autocapitalize="off" spellcheck="false" class="select2-input" role="combobox" aria-expanded="true" aria-autocomplete="list" aria-owns="select2-results-24" id="s2id_autogen24_search" placeholder="">   </div>   <ul class="select2-results" role="listbox" id="select2-results-24">   </ul></div></div><select name="education-from-year" data-placeholder="Year" class="select select2-offscreen" tabindex="-1" title="">
						                                        <option></option> 
						                                        <option value="1995">1995</option> 
						                                        <option value="...">...</option> 
						                                        <option value="1980">1980</option> 
						                                    </select>
					                                    </div>
													</div>
												</div>
											</div>

											<div class="col-md-6">
												<label>To:</label>
												<div class="row">
													<div class="col-md-6">
														<div class="form-group">
						                                    <div class="select2-container select" id="s2id_autogen25"><a href="javascript:void(0)" class="select2-choice select2-default" tabindex="-1">   <span class="select2-chosen" id="select2-chosen-26">Month</span><abbr class="select2-search-choice-close"></abbr>   <span class="select2-arrow" role="presentation"><b role="presentation"></b></span></a><label for="s2id_autogen26" class="select2-offscreen"></label><input class="select2-focusser select2-offscreen" type="text" aria-haspopup="true" role="button" aria-labelledby="select2-chosen-26" id="s2id_autogen26"><div class="select2-drop select2-display-none select2-with-searchbox">   <div class="select2-search">       <label for="s2id_autogen26_search" class="select2-offscreen"></label>       <input type="text" autocomplete="off" autocorrect="off" autocapitalize="off" spellcheck="false" class="select2-input" role="combobox" aria-expanded="true" aria-autocomplete="list" aria-owns="select2-results-26" id="s2id_autogen26_search" placeholder="">   </div>   <ul class="select2-results" role="listbox" id="select2-results-26">   </ul></div></div><select name="education-to-month" data-placeholder="Month" class="select select2-offscreen" tabindex="-1" title="">
						                                    	<option></option>
						                                        <option value="January">January</option> 
						                                        <option value="...">...</option> 
						                                        <option value="December">December</option> 
						                                    </select>
					                                    </div>
													</div>

													<div class="col-md-6">
														<div class="form-group">
						                                    <div class="select2-container select" id="s2id_autogen27"><a href="javascript:void(0)" class="select2-choice select2-default" tabindex="-1">   <span class="select2-chosen" id="select2-chosen-28">Year</span><abbr class="select2-search-choice-close"></abbr>   <span class="select2-arrow" role="presentation"><b role="presentation"></b></span></a><label for="s2id_autogen28" class="select2-offscreen"></label><input class="select2-focusser select2-offscreen" type="text" aria-haspopup="true" role="button" aria-labelledby="select2-chosen-28" id="s2id_autogen28"><div class="select2-drop select2-display-none select2-with-searchbox">   <div class="select2-search">       <label for="s2id_autogen28_search" class="select2-offscreen"></label>       <input type="text" autocomplete="off" autocorrect="off" autocapitalize="off" spellcheck="false" class="select2-input" role="combobox" aria-expanded="true" aria-autocomplete="list" aria-owns="select2-results-28" id="s2id_autogen28_search" placeholder="">   </div>   <ul class="select2-results" role="listbox" id="select2-results-28">   </ul></div></div><select name="education-to-year" data-placeholder="Year" class="select select2-offscreen" tabindex="-1" title="">
						                                        <option></option> 
						                                        <option value="1995">1995</option> 
						                                        <option value="...">...</option> 
						                                        <option value="1980">1980</option> 
						                                    </select>
					                                    </div>
													</div>
												</div>
											</div>
										</div>
									</div>

									<div class="col-md-6">
		                                <div class="form-group">
											<label>Brief description:</label>
		                                    <textarea name="experience-description" rows="4" cols="4" placeholder="Tasks and responsibilities" class="form-control"></textarea>
		                                </div>

										<div class="form-group">
											<label>Recommendations:</label>
		                                    <div class="uploader bg-warning"><input name="recommendations" type="file" class="file-styled"><span class="filename" style="-webkit-user-select: none;">No file selected</span><span class="action" style="-webkit-user-select: none;"><i class="icon-googleplus5"></i></span></div>
		                                    <span class="help-block">Accepted formats: pdf, doc. Max file size 2Mb</span>
		                                </div>
									</div>
								</div>
							</fieldset>

							<h6 id="steps-uid-0-h-3" tabindex="-1" class="title">Additional info</h6>
							<fieldset id="steps-uid-0-p-3" role="tabpanel" aria-labelledby="steps-uid-0-h-3" class="body" aria-hidden="true" style="display: none;">
								<div class="row">
									<div class="col-md-6">
										<div class="form-group">
											<label>Applicant resume:</label>
		                                    <div class="uploader bg-warning"><input type="file" name="resume" class="file-styled"><span class="filename" style="-webkit-user-select: none;">No file selected</span><span class="action" style="-webkit-user-select: none;"><i class="icon-googleplus5"></i></span></div>
		                                    <span class="help-block">Accepted formats: pdf, doc. Max file size 2Mb</span>
	                                    </div>
									</div>

									<div class="col-md-6">
										<div class="form-group">
											<label>Where did you find us?</label>
		                                    <div class="select2-container select-simple" id="s2id_autogen113"><a href="javascript:void(0)" class="select2-choice select2-default" tabindex="-1">   <span class="select2-chosen" id="select2-chosen-114">Choose an option...</span><abbr class="select2-search-choice-close"></abbr>   <span class="select2-arrow" role="presentation"><b role="presentation"></b></span></a><label for="s2id_autogen114" class="select2-offscreen"></label><input class="select2-focusser select2-offscreen" type="text" aria-haspopup="true" role="button" aria-labelledby="select2-chosen-114" id="s2id_autogen114"><div class="select2-drop select2-display-none">   <div class="select2-search select2-search-hidden select2-offscreen">       <label for="s2id_autogen114_search" class="select2-offscreen"></label>       <input type="text" autocomplete="off" autocorrect="off" autocapitalize="off" spellcheck="false" class="select2-input" role="combobox" aria-expanded="true" aria-autocomplete="list" aria-owns="select2-results-114" id="s2id_autogen114_search" placeholder="">   </div>   <ul class="select2-results" role="listbox" id="select2-results-114">   </ul></div></div><select name="source" data-placeholder="Choose an option..." class="select-simple select2-offscreen" tabindex="-1" title="">
		                                        <option></option> 
		                                        <option value="monster">Monster.com</option> 
		                                        <option value="linkedin">LinkedIn</option> 
		                                        <option value="google">Google</option> 
		                                        <option value="adwords">Google AdWords</option> 
		                                        <option value="other">Other source</option>
		                                    </select>
	                                    </div>
									</div>
								</div>

								<div class="row">
									<div class="col-md-6">
										<div class="form-group">
											<label>Availability:</label>
											<div class="radio">
												<label>
													<div class="choice"><span><input type="radio" name="availability" class="styled"></span></div>
													Immediately
												</label>
											</div>

											<div class="radio">
												<label>
													<div class="choice"><span><input type="radio" name="availability" class="styled"></span></div>
													1 - 2 weeks
												</label>
											</div>

											<div class="radio">
												<label>
													<div class="choice"><span><input type="radio" name="availability" class="styled"></span></div>
													3 - 4 weeks
												</label>
											</div>

											<div class="radio">
												<label>
													<div class="choice"><span><input type="radio" name="availability" class="styled"></span></div>
													More than 1 month
												</label>
											</div>
										</div>
									</div>

									<div class="col-md-6">
										<div class="form-group">
											<label>Additional information:</label>
		                                    <textarea name="additional-info" rows="5" cols="5" placeholder="If you want to add any info, do it here." class="form-control"></textarea>
	                                    </div>
									</div>
								</div>
							</fieldset>
						</div><div class="actions clearfix"><ul role="menu" aria-label="Pagination"><li class="" aria-disabled="false"><a href="#previous" role="menuitem">Previous</a></li><li aria-hidden="false" aria-disabled="false"><a href="#next" role="menuitem">Next</a></li><li aria-hidden="true" style="display: none;"><a href="#finish" role="menuitem">Submit</a></li></ul></div></form>
		            </div>

					<!-- Footer -->
					<div class="footer text-muted">
						&copy; 2016. <a href="#">Sistema electoral</a> by <a href="#" target="_blank">Giecom</a>
					</div>
					<!-- /footer -->

				</div>
				<!-- /content area -->

			</div>
			<!-- /main content -->

		</div>
		<!-- /page content -->

	</div>
	<!-- /page container -->

</body>
</html>

