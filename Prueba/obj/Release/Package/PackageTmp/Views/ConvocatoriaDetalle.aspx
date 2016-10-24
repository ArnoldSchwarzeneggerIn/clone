﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConvocatoriaDetalle.aspx.cs" Inherits="Prueba.Views.ConvocatoriaDetalle" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <meta charset="utf-8" />
    <title>Sistema Electoral</title>
    <link href="https://fonts.googleapis.com/css?family=Roboto:400,300,100,500,700,900" rel="stylesheet" type="text/css">
    <link href="assets/css/icons/icomoon/styles.css" rel="stylesheet" type="text/css">
    <link href="assets/css/minified/bootstrap.min.css" rel="stylesheet" type="text/css">
    <link href="assets/css/minified/core.min.css" rel="stylesheet" type="text/css">
    <link href="assets/css/minified/components.min.css" rel="stylesheet" type="text/css">
    <link href="assets/css/minified/colors.min.css" rel="stylesheet" type="text/css">

    <script type="text/javascript" src="assets/js/plugins/loaders/pace.min.js"></script>
    <script type="text/javascript" src="assets/js/core/libraries/jquery.min.js"></script>
    <script type="text/javascript" src="assets/js/core/libraries/bootstrap.min.js"></script>
    <script type="text/javascript" src="assets/js/plugins/loaders/blockui.min.js"></script>
    <!-- /core JS files -->

    <!-- Theme JS files -->
    <script type="text/javascript" src="assets/js/plugins/forms/selects/select2.min.js"></script>
    <script type="text/javascript" src="assets/js/plugins/forms/styling/uniform.min.js"></script>
    <script type="text/javascript" src="assets/js/plugins/ui/moment/moment.min.js"></script>
    <script type="text/javascript" src="assets/js/plugins/ui/fullcalendar/fullcalendar.min.js"></script>
    <script type="text/javascript" src="assets/js/plugins/visualization/echarts/echarts.js"></script>

    <script type="text/javascript" src="assets/js/core/app.js"></script>
    <script type="text/javascript" src="assets/js/pages/user_pages_profile.js"></script>

</head>
<body>
    <form id="form1" runat="server">
        <div class="navbar navbar-inverse">
            <div class="navbar-header">
                <a class="navbar-brand" href="index.html">
                    <img src="assets/images/logo_light.png" alt=""></a>

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
                            <li><a href="#"><i class="icon-switch2"></i>Salir</a></li>
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
                                    <a href="#" class="media-left">
                                        <img src="assets/images/placeholder.jpg" class="img-circle img-sm" alt=""></a>
                                    <div class="media-body">
                                        <span class="media-heading text-semibold">Electoral</span>
                                        <div class="text-size-mini text-muted">
                                            <i class="icon-pin text-size-small">Prueba Token</i>
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
                                    <li class="active"><a href="Index.aspx"><i class="icon-home4"></i><span>Principal</span></a></li>
                                    <li>
                                        <a href="#"><i class="icon-stack2"></i><span>Convocatorias</span></a>
                                        <ul>
                                            <li><a href="VConvocatoria.aspx">Gestionar convocatoria</a></li>
                                            <li><a href="#">Lanzar convocatoria</a></li>
                                        </ul>
                                    </li>
                                    <li>
                                        <a href="#"><i class="icon-vcard"></i><span>Candidatos</span></a>
                                        <ul>
                                            <li><a href="VCandidato.aspx">Gestionar candidatos</a></li>
                                            <li><a href="#">Mi candidatura</a></li>
                                        </ul>
                                    </li>
                                    <li>
                                        <a href="#"><i class="icon-puzzle"></i><span>Parametricas</span></a>
                                        <ul>
                                            <li><a href="VCobertura.aspx">Cobertura</a></li>
                                            <li><a href="Causaderetiro.aspx">Causa de retiro</a></li>
                                            <li><a href="Instancias.aspx">Instancias</a></li>
                                            <li><a href="InstancConformacion.aspx">Instancia conformacion</a></li>
                                        </ul>
                                    </li>
                                    <li>
                                        <a href="#"><i class="icon-stack-text"></i><span>Votaciones</span></a>
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
                  <div class="page-header no-margin">
				 	<div class="page-header-content">
						<div class="page-title">
							<h4><i class="icon-arrow-left52 position-left"></i> <span class="text-semibold">User Pages</span> - Profile Cover</h4>
						</div>

						<div class="heading-elements">
							<div class="heading-btn-group">
								<a href="#" class="btn btn-link btn-float has-text"><i class="icon-bars-alt text-primary"></i><span>Statistics</span></a>
								<a href="#" class="btn btn-link btn-float has-text"><i class="icon-calculator text-primary"></i> <span>Invoices</span></a>
								<a href="#" class="btn btn-link btn-float has-text"><i class="icon-calendar5 text-primary"></i> <span>Schedule</span></a>
							</div>
						</div>
					</div>

					<div class="breadcrumb-line">
						<ul class="breadcrumb">
							<li><a href="index.html"><i class="icon-home2 position-left"></i> Home</a></li>
							<li><a href="user_pages_profile_cover.html">User pages</a></li>
							<li class="active">Profile cover</li>
						</ul>

						<ul class="breadcrumb-elements">
							<li><a href="#"><i class="icon-comment-discussion position-left"></i> Support</a></li>
							<li class="dropdown">
								<a href="#" class="dropdown-toggle" data-toggle="dropdown">
									<i class="icon-gear position-left"></i>
									Settings
									<span class="caret"></span>
								</a>

								<ul class="dropdown-menu dropdown-menu-right">
									<li><a href="#"><i class="icon-user-lock"></i> Account security</a></li>
									<li><a href="#"><i class="icon-statistics"></i> Analytics</a></li>
									<li><a href="#"><i class="icon-accessibility"></i> Accessibility</a></li>
									<li class="divider"></li>
									<li><a href="#"><i class="icon-gear"></i> All settings</a></li>
								</ul>
							</li>
						</ul>
					</div>
				</div>
				<!-- /page header -->
				<!-- Toolbar -->
				<div class="navbar navbar-default navbar-xs content-group">
					<ul class="nav navbar-nav visible-xs-block">
						<li class="full-width text-center"><a data-toggle="collapse" data-target="#navbar-filter"><i class="icon-menu7"></i></a></li>
					</ul>

					<div class="navbar-collapse collapse" id="navbar-filter">
						<ul class="nav navbar-nav element-active-slate-400">
							<li class="active"><a href="#activity" data-toggle="tab"><i class="icon-menu7 position-left"></i> Candidatos </a></li>
							<li><a href="#schedule" data-toggle="tab"><i class="icon-calendar3 position-left"></i> Información  </a></li>
							<li><a href="#settings" data-toggle="tab"><i class="icon-cog3 position-left"></i> Configuración </a></li>
						</ul>
					</div>
				</div>
                    <!-- /page header -->


                    <!-- Content area -->
                    <div class="content">

                        <div class="row">
						<div class="col-lg-9">
							<div class="tabbable">
								<div class="tab-content">
									<div class="tab-pane fade in active" id="activity">

										<!-- Timeline -->
										<div class="timeline timeline-left content-group">
											<div class="timeline-container">

												<!-- Sales stats -->
												<div class="timeline-row">
													<div class="timeline-icon">
														<a href="#"><img src="assets/images/placeholder.jpg" alt=""></a>
													</div>

													<div class="panel panel-flat timeline-content">
														<div class="panel-heading">
															<h6 class="panel-title">Daily statistics</h6>
															<div class="heading-elements">
																<span class="heading-text"><i class="icon-history position-left text-success"></i> Updated 3 hours ago</span>

																<ul class="icons-list">
											                		<li><a data-action="reload"></a></li>
											                	</ul>
										                	</div>
														</div>

														<div class="panel-body">
															<div class="chart-container">
																<div class="chart has-fixed-height" id="sales"></div>
															</div>
														</div>
													</div>
												</div>
												<!-- /sales stats -->


												<!-- Blog post -->
												<div class="timeline-row">
													<div class="timeline-icon">
														<img src="assets/images/placeholder.jpg" alt="">
													</div>

													<div class="panel panel-flat timeline-content">
														<div class="panel-heading">
															<h6 class="panel-title">Himalayan sunset</h6>
															<div class="heading-elements">
																<span class="heading-text"><i class="icon-checkmark-circle position-left text-success"></i> 49 minutes ago</span>
																<ul class="icons-list">
																	<li class="dropdown">
																		<a href="#" class="dropdown-toggle" data-toggle="dropdown">
																			<i class="icon-arrow-down12"></i>
																		</a>

																		<ul class="dropdown-menu dropdown-menu-right">
																			<li><a href="#"><i class="icon-user-lock"></i> Hide user posts</a></li>
																			<li><a href="#"><i class="icon-user-block"></i> Block user</a></li>
																			<li><a href="#"><i class="icon-user-minus"></i> Unfollow user</a></li>
																			<li class="divider"></li>
																			<li><a href="#"><i class="icon-embed"></i> Embed post</a></li>
																			<li><a href="#"><i class="icon-blocked"></i> Report this post</a></li>
																		</ul>
																	</li>
											                	</ul>
										                	</div>
														</div>

														<div class="panel-body">
															<a href="#" class="display-block content-group">
																<img src="assets/images/cover.jpg" class="img-responsive content-group" alt="">
															</a>

															<h6 class="content-group">
																<i class="icon-comment-discussion position-left"></i>
																Comment from <a href="#">Jason Ansley</a>:
															</h6>

															<blockquote>
																<p>When suspiciously goodness labrador understood rethought yawned grew piously endearingly inarticulate oh goodness jeez trout distinct hence cobra despite taped laughed the much audacious less inside tiger groaned darn stuffily metaphoric unihibitedly inside cobra.</p>
																<footer>Jason, <cite title="Source Title">10:39 am</cite></footer>
															</blockquote>
														</div>

														<div class="panel-footer">
															<ul>
																<li><a href="#"><i class="icon-eye4 position-left"></i> 438</a></li>
																<li><a href="#"><i class="icon-comment-discussion position-left"></i> 71</a></li>
															</ul>

															<ul class="pull-right">
																<li><a href="#">Read post <i class="icon-arrow-right14 position-right"></i></a></li>
															</ul>
														</div>
													</div>
												</div>
												<!-- /blog post -->


												<!-- Date stamp -->
												<div class="timeline-date text-muted">
													<i class="icon-history position-left"></i> <span class="text-semibold">Monday</span>, April 18
												</div>
												<!-- /date stamp -->


												<!-- Invoices -->
												<div class="timeline-row">
													<div class="timeline-icon">
														<div class="bg-warning-400">
															<i class="icon-cash3"></i>
														</div>
													</div>

													<div class="row">
														<div class="col-lg-6">
															<div class="panel border-left-lg border-left-danger invoice-grid timeline-content">
																<div class="panel-body">
																	<div class="row">
																		<div class="col-sm-6">
																			<h6 class="text-semibold no-margin-top">Leonardo Fellini</h6>
																			<ul class="list list-unstyled">
																				<li>Invoice #: &nbsp;0028</li>
																				<li>Issued on: <span class="text-semibold">2015/01/25</span></li>
																			</ul>
																		</div>

																		<div class="col-sm-6">
																			<h6 class="text-semibold text-right no-margin-top">$8,750</h6>
																			<ul class="list list-unstyled text-right">
																				<li>Method: <span class="text-semibold">SWIFT</span></li>
																				<li class="dropdown">
																					Status: &nbsp;
																					<a href="#" class="label bg-danger-400 dropdown-toggle" data-toggle="dropdown">Overdue <span class="caret"></span></a>
																					<ul class="dropdown-menu dropdown-menu-right">
																						<li class="active"><a href="#"><i class="icon-alert"></i> Overdue</a></li>
																						<li><a href="#"><i class="icon-alarm"></i> Pending</a></li>
																						<li><a href="#"><i class="icon-checkmark3"></i> Paid</a></li>
																						<li class="divider"></li>
																						<li><a href="#"><i class="icon-spinner2 spinner"></i> On hold</a></li>
																						<li><a href="#"><i class="icon-cross2"></i> Canceled</a></li>
																					</ul>
																				</li>
																			</ul>
																		</div>
																	</div>
																</div>

																<div class="panel-footer">
																	<ul>
																		<li><span class="status-mark border-danger position-left"></span> Due: <span class="text-semibold">2015/02/25</span></li>
																	</ul>

																	<ul class="pull-right">
																		<li><a href="#" data-toggle="modal" data-target="#invoice"><i class="icon-eye8"></i></a></li>
																		<li class="dropdown">
																			<a href="#" class="dropdown-toggle" data-toggle="dropdown"><i class="icon-menu7"></i> <span class="caret"></span></a>
																			<ul class="dropdown-menu dropdown-menu-right">
																				<li><a href="#"><i class="icon-printer"></i> Print invoice</a></li>
																				<li><a href="#"><i class="icon-file-download"></i> Download invoice</a></li>
																				<li class="divider"></li>
																				<li><a href="#"><i class="icon-file-plus"></i> Edit invoice</a></li>
																				<li><a href="#"><i class="icon-cross2"></i> Remove invoice</a></li>
																			</ul>
																		</li>
																	</ul>
																</div>
															</div>
														</div>

														<div class="col-lg-6">
															<div class="panel border-left-lg border-left-success invoice-grid timeline-content">
																<div class="panel-body">
																	<div class="row">
																		<div class="col-sm-6">
																			<h6 class="text-semibold no-margin-top">Rebecca Manes</h6>
																			<ul class="list list-unstyled">
																				<li>Invoice #: &nbsp;0027</li>
																				<li>Issued on: <span class="text-semibold">2015/02/24</span></li>
																			</ul>
																		</div>

																		<div class="col-sm-6">
																			<h6 class="text-semibold text-right no-margin-top">$5,100</h6>
																			<ul class="list list-unstyled text-right">
																				<li>Method: <span class="text-semibold">Paypal</span></li>
																				<li class="dropdown">
																					Status: &nbsp;
																					<a href="#" class="label bg-success-400 dropdown-toggle" data-toggle="dropdown">Paid <span class="caret"></span></a>
																					<ul class="dropdown-menu dropdown-menu-right">
																						<li><a href="#"><i class="icon-alert"></i> Overdue</a></li>
																						<li><a href="#"><i class="icon-alarm"></i> Pending</a></li>
																						<li class="active"><a href="#"><i class="icon-checkmark3"></i> Paid</a></li>
																						<li class="divider"></li>
																						<li><a href="#"><i class="icon-spinner2 spinner"></i> On hold</a></li>
																						<li><a href="#"><i class="icon-cross2"></i> Canceled</a></li>
																					</ul>
																				</li>
																			</ul>
																		</div>
																	</div>
																</div>

																<div class="panel-footer">
																	<ul>
																		<li><span class="status-mark border-success position-left"></span> Due: <span class="text-semibold">2015/03/24</span></li>
																	</ul>

																	<ul class="pull-right">
																		<li><a href="#" data-toggle="modal" data-target="#invoice"><i class="icon-eye8"></i></a></li>
																		<li class="dropdown">
																			<a href="#" class="dropdown-toggle" data-toggle="dropdown"><i class="icon-menu7"></i> <span class="caret"></span></a>
																			<ul class="dropdown-menu dropdown-menu-right">
																				<li><a href="#"><i class="icon-printer"></i> Print invoice</a></li>
																				<li><a href="#"><i class="icon-file-download"></i> Download invoice</a></li>
																				<li class="divider"></li>
																				<li><a href="#"><i class="icon-file-plus"></i> Edit invoice</a></li>
																				<li><a href="#"><i class="icon-cross2"></i> Remove invoice</a></li>
																			</ul>
																		</li>
																	</ul>
																</div>
															</div>
														</div>
													</div>
												</div>
												<!-- /invoices -->


												<!-- Messages -->
												<div class="timeline-row">
													<div class="timeline-icon">
														<div class="bg-info-400">
															<i class="icon-comment-discussion"></i>
														</div>
													</div>

													<div class="panel panel-flat timeline-content">
														<div class="panel-heading">
															<h6 class="panel-title">Conversation with James</h6>
															<div class="heading-elements">
																<ul class="icons-list">
																	<li class="dropdown">
																		<a href="#" class="dropdown-toggle" data-toggle="dropdown">
																			<i class="icon-circle-down2"></i>
																		</a>

																		<ul class="dropdown-menu dropdown-menu-right">
																			<li><a href="#"><i class="icon-user-lock"></i> Hide user posts</a></li>
																			<li><a href="#"><i class="icon-user-block"></i> Block user</a></li>
																			<li><a href="#"><i class="icon-user-minus"></i> Unfollow user</a></li>
																			<li class="divider"></li>
																			<li><a href="#"><i class="icon-embed"></i> Embed post</a></li>
																			<li><a href="#"><i class="icon-blocked"></i> Report this post</a></li>
																		</ul>
																	</li>
											                	</ul>
										                	</div>
														</div>

														<div class="panel-body">
															<ul class="media-list chat-list content-group">
																<li class="media date-step">
																	<span>Today</span>
																</li>

																<li class="media reversed">
																	<div class="media-body">
																		<div class="media-content">Thus superb the tapir the wallaby blank frog execrably much since dalmatian by in hot. Uninspiringly arose mounted stared one curt safe</div>
																		<span class="media-annotation display-block mt-10">Tue, 8:12 am <a href="#"><i class="icon-pin-alt position-right text-muted"></i></a></span>
																	</div>

																	<div class="media-right">
																		<a href="assets/images/placeholder.jpg">
																			<img src="assets/images/placeholder.jpg" class="img-circle" alt="">
																		</a>
																	</div>
																</li>

																<li class="media">
																	<div class="media-left">
																		<a href="assets/images/placeholder.jpg">
																			<img src="assets/images/placeholder.jpg" class="img-circle" alt="">
																		</a>
																	</div>

																	<div class="media-body">
																		<div class="media-content">Tolerantly some understood this stubbornly after snarlingly frog far added insect into snorted more auspiciously heedless drunkenly jeez foolhardy oh.</div>
																		<span class="media-annotation display-block mt-10">Wed, 4:20 pm <a href="#"><i class="icon-pin-alt position-right text-muted"></i></a></span>
																	</div>
																</li>

																<li class="media reversed">
																	<div class="media-body">
																		<div class="media-content">Satisfactorily strenuously while sleazily dear frustratingly insect menially some shook far sardonic badger telepathic much jeepers immature much hey.</div>
																		<span class="media-annotation display-block mt-10">2 hours ago <a href="#"><i class="icon-pin-alt position-right text-muted"></i></a></span>
																	</div>

																	<div class="media-right">
																		<a href="assets/images/placeholder.jpg">
																			<img src="assets/images/placeholder.jpg" class="img-circle" alt="">
																		</a>
																	</div>
																</li>

																<li class="media">
																	<div class="media-left">
																		<a href="assets/images/placeholder.jpg">
																			<img src="assets/images/placeholder.jpg" class="img-circle" alt="">
																		</a>
																	</div>

																	<div class="media-body">
																		<div class="media-content">Grunted smirked and grew less but rewound much despite and impressive via alongside out and gosh easy manatee dear ineffective yikes.</div>
																		<span class="media-annotation display-block mt-10">13 minutes ago <a href="#"><i class="icon-pin-alt position-right text-muted"></i></a></span>
																	</div>
																</li>

																<li class="media reversed">
																	<div class="media-body">
																		<div class="media-content"><i class="icon-menu display-block"></i></div>
																	</div>

																	<div class="media-right">
																		<a href="assets/images/placeholder.jpg">
																			<img src="assets/images/placeholder.jpg" class="img-circle" alt="">
																		</a>
																	</div>
																</li>
															</ul>

									                    	<textarea name="enter-message" class="form-control content-group" rows="3" cols="1" placeholder="Enter your message..."></textarea>

									                    	<div class="row">
									                    		<div class="col-xs-6">
										                        	<ul class="icons-list icons-list-extended mt-10">
										                                <li><a href="#" data-popup="tooltip" title="Send photo" data-container="body"><i class="icon-file-picture"></i></a></li>
										                            	<li><a href="#" data-popup="tooltip" title="Send video" data-container="body"><i class="icon-file-video"></i></a></li>
										                                <li><a href="#" data-popup="tooltip" title="Send file" data-container="body"><i class="icon-file-plus"></i></a></li>
										                            </ul>
									                    		</div>

									                    		<div class="col-xs-6 text-right">
										                            <button type="button" class="btn bg-teal-400 btn-labeled btn-labeled-right"><b><i class="icon-circle-right2"></i></b> Send</button>
									                    		</div>
									                    	</div>
														</div>
													</div>
												</div>
												<!-- /messages -->

											</div>
									    </div>
									    <!-- /timeline -->

									</div>

									<div class="tab-pane fade" id="schedule">

										<!-- Available hours -->
										<div class="panel panel-flat">
											<div class="panel-heading">
												<h6 class="panel-title">Available hours</h6>
												<div class="heading-elements">
													<ul class="icons-list">
								                		<li><a data-action="collapse"></a></li>
								                		<li><a data-action="reload"></a></li>
								                		<li><a data-action="close"></a></li>
								                	</ul>
							                	</div>
											</div>

											<div class="panel-body">
												<div class="chart-container">
													<div class="chart has-fixed-height" id="plans"></div>
												</div>
											</div>
										</div>
										<!-- /available hours -->


										<!-- Calendar -->
										<div class="panel panel-flat">
											<div class="panel-heading">
												<h6 class="panel-title">My schedule</h6>
												<div class="heading-elements">
													<ul class="icons-list">
								                		<li><a data-action="collapse"></a></li>
								                		<li><a data-action="reload"></a></li>
								                		<li><a data-action="close"></a></li>
								                	</ul>
							                	</div>
											</div>

											<div class="panel-body">
												<div class="schedule"></div>
											</div>
										</div>
										<!-- /calendar -->

									</div>

									<div class="tab-pane fade" id="settings">

										<!-- Profile info -->
										<div class="panel panel-flat">
											<div class="panel-heading">
												<h6 class="panel-title">Profile information</h6>
												<div class="heading-elements">
													<ul class="icons-list">
								                		<li><a data-action="collapse"></a></li>
								                		<li><a data-action="reload"></a></li>
								                		<li><a data-action="close"></a></li>
								                	</ul>
							                	</div>
											</div>

											<div class="panel-body">
												<form action="#">
													<div class="form-group">
														<div class="row">
															<div class="col-md-6">
																<label>Username</label>
																<input type="text" value="Eugene" class="form-control">
															</div>
															<div class="col-md-6">
																<label>Full name</label>
																<input type="text" value="Kopyov" class="form-control">
															</div>
														</div>
													</div>

													<div class="form-group">
														<div class="row">
															<div class="col-md-6">
																<label>Address line 1</label>
																<input type="text" value="Ring street 12" class="form-control">
															</div>
															<div class="col-md-6">
																<label>Address line 2</label>
																<input type="text" value="building D, flat #67" class="form-control">
															</div>
														</div>
													</div>

													<div class="form-group">
														<div class="row">
															<div class="col-md-4">
																<label>City</label>
																<input type="text" value="Munich" class="form-control">
															</div>
															<div class="col-md-4">
																<label>State/Province</label>
																<input type="text" value="Bayern" class="form-control">
															</div>
															<div class="col-md-4">
																<label>ZIP code</label>
																<input type="text" value="1031" class="form-control">
															</div>
														</div>
													</div>

													<div class="form-group">
														<div class="row">
															<div class="col-md-6">
																<label>Email</label>
																<input type="text" readonly="readonly" value="eugene@kopyov.com" class="form-control">
															</div>
															<div class="col-md-6">
									                            <label>Your country</label>
									                            <select class="select">
									                                <option value="germany" selected="selected">Germany</option> 
									                                <option value="france">France</option> 
									                                <option value="spain">Spain</option> 
									                                <option value="netherlands">Netherlands</option> 
									                                <option value="other">...</option> 
									                                <option value="uk">United Kingdom</option> 
									                            </select>
															</div>
														</div>
													</div>

							                        <div class="form-group">
							                        	<div class="row">
							                        		<div class="col-md-6">
																<label>Phone #</label>
																<input type="text" value="+99-99-9999-9999" class="form-control">
																<span class="help-block">+99-99-9999-9999</span>
							                        		</div>

															<div class="col-md-6">
																<label>Upload profile image</label>
							                                    <input type="file" class="file-styled">
							                                    <span class="help-block">Accepted formats: gif, png, jpg. Max file size 2Mb</span>
															</div>
							                        	</div>
							                        </div>

							                        <div class="text-right">
							                        	<button type="submit" class="btn btn-primary">Save <i class="icon-arrow-right14 position-right"></i></button>
							                        </div>
												</form>
											</div>
										</div>
										<!-- /profile info -->


										<!-- Account settings -->
										<div class="panel panel-flat">
											<div class="panel-heading">
												<h6 class="panel-title">Account settings</h6>
												<div class="heading-elements">
													<ul class="icons-list">
								                		<li><a data-action="collapse"></a></li>
								                		<li><a data-action="reload"></a></li>
								                		<li><a data-action="close"></a></li>
								                	</ul>
							                	</div>
											</div>

											<div class="panel-body">
												<form action="#">
													<div class="form-group">
														<div class="row">
															<div class="col-md-6">
																<label>Username</label>
																<input type="text" value="Kopyov" readonly="readonly" class="form-control">
															</div>

															<div class="col-md-6">
																<label>Current password</label>
																<input type="password" value="password" readonly="readonly" class="form-control">
															</div>
														</div>
													</div>

													<div class="form-group">
														<div class="row">
															<div class="col-md-6">
																<label>New password</label>
																<input type="password" placeholder="Enter new password" class="form-control">
															</div>

															<div class="col-md-6">
																<label>Repeat password</label>
																<input type="password" placeholder="Repeat new password" class="form-control">
															</div>
														</div>
													</div>

													<div class="form-group">
														<div class="row">
															<div class="col-md-6">
																<label>Profile visibility</label>

																<div class="radio">
																	<label>
																		<input type="radio" name="visibility" class="styled" checked="checked">
																		Visible to everyone
																	</label>
																</div>

																<div class="radio">
																	<label>
																		<input type="radio" name="visibility" class="styled">
																		Visible to friends only
																	</label>
																</div>

																<div class="radio">
																	<label>
																		<input type="radio" name="visibility" class="styled">
																		Visible to my connections only
																	</label>
																</div>

																<div class="radio">
																	<label>
																		<input type="radio" name="visibility" class="styled">
																		Visible to my colleagues only
																	</label>
																</div>
															</div>

															<div class="col-md-6">
																<label>Notifications</label>

																<div class="checkbox">
																	<label>
																		<input type="checkbox" class="styled" checked="checked">
																		Password expiration notification
																	</label>
																</div>

																<div class="checkbox">
																	<label>
																		<input type="checkbox" class="styled" checked="checked">
																		New message notification
																	</label>
																</div>

																<div class="checkbox">
																	<label>
																		<input type="checkbox" class="styled" checked="checked">
																		New task notification
																	</label>
																</div>

																<div class="checkbox">
																	<label>
																		<input type="checkbox" class="styled">
																		New contact request notification
																	</label>
																</div>
															</div>
														</div>
													</div>

							                        <div class="text-right">
							                        	<button type="submit" class="btn btn-primary">Save <i class="icon-arrow-right14 position-right"></i></button>
							                        </div>
						                        </form>
											</div>
										</div>
										<!-- /account settings -->

									</div>
								</div>
							</div>
						</div>

						<div class="col-lg-3">

							<!-- Navigation -->
					    	<div class="panel panel-flat">
								<div class="panel-heading">
									<h6 class="panel-title">Navigation</h6>
									<div class="heading-elements">
										<a href="#" class="heading-text">See all &rarr;</a>
				                	</div>
								</div>

								<div class="list-group list-group-borderless no-padding-top">
									<a href="#" class="list-group-item"><i class="icon-user"></i> My profile</a>
									<a href="#" class="list-group-item"><i class="icon-cash3"></i> Balance</a>
									<a href="#" class="list-group-item"><i class="icon-tree7"></i> Connections <span class="badge bg-danger pull-right">29</span></a>
									<a href="#" class="list-group-item"><i class="icon-users"></i> Friends</a>
									<div class="list-group-divider"></div>
									<a href="#" class="list-group-item"><i class="icon-calendar3"></i> Events <span class="badge bg-teal-400 pull-right">48</span></a>
									<a href="#" class="list-group-item"><i class="icon-cog3"></i> Account settings</a>
								</div>
							</div>
							<!-- /navigation -->


							<!-- Share your thoughts -->
							<div class="panel panel-flat">
								<div class="panel-heading">
									<h6 class="panel-title">Share your thoughts</h6>
									<div class="heading-elements">
										<ul class="icons-list">
					                		<li><a data-action="close"></a></li>
					                	</ul>
				                	</div>
								</div>

								<div class="panel-body">
									<form action="#">
										<div class="form-group">
											<textarea name="enter-message" class="form-control mb-15" rows="3" cols="1" placeholder="What's on your mind?"></textarea>
										</div>

										<div class="row">
				                    		<div class="col-sm-6">
					                        	<ul class="icons-list icons-list-extended mt-10">
					                                <li><a href="#" data-popup="tooltip" title="Add photo" data-container="body"><i class="icon-images2"></i></a></li>
					                            	<li><a href="#" data-popup="tooltip" title="Add video" data-container="body"><i class="icon-film2"></i></a></li>
					                                <li><a href="#" data-popup="tooltip" title="Add event" data-container="body"><i class="icon-calendar2"></i></a></li>
					                            </ul>
				                    		</div>

				                    		<div class="col-sm-6 text-right">
					                            <button type="button" class="btn btn-primary btn-labeled btn-labeled-right">Share <b><i class="icon-circle-right2"></i></b></button>
				                    		</div>
				                    	</div>
			                    	</form>
		                    	</div>
							</div>
							<!-- /share your thoughts -->


							<!-- Balance chart -->
							<div class="panel panel-flat">
								<div class="panel-heading">
									<h6 class="panel-title">Balance changes</h6>
									<div class="heading-elements">
										<span class="heading-text"><i class="icon-arrow-down22 text-danger"></i> <span class="text-semibold">- 29.4%</span></span>
				                	</div>
								</div>

								<div class="panel-body">
									<div class="chart-container">
										<div class="chart" id="visits" style="height: 300px;"></div>
									</div>
		                    	</div>
							</div>
							<!-- /balance chart -->


							<!-- Connections -->
					    	<div class="panel panel-flat">
								<div class="panel-heading">
									<h6 class="panel-title">Latest connections</h6>
									<div class="heading-elements">
										<span class="badge badge-success heading-text">+32</span>
				                	</div>
								</div>

								<ul class="media-list media-list-linked pb-5">
									<li class="media-header">Office staff</li>

									<li class="media">
										<a href="#" class="media-link">
											<div class="media-left"><img src="assets/images/placeholder.jpg" class="img-circle" alt=""></div>
											<div class="media-body">
												<span class="media-heading text-semibold">James Alexander</span>
												<span class="media-annotation">UI/UX expert</span>
											</div>
											<div class="media-right media-middle">
												<span class="status-mark bg-success"></span>
											</div>
										</a>
									</li>

									<li class="media">
										<a href="#" class="media-link">
											<div class="media-left"><img src="assets/images/placeholder.jpg" class="img-circle" alt=""></div>
											<div class="media-body">
												<span class="media-heading text-semibold">Jeremy Victorino</span>
												<span class="media-annotation">Senior designer</span>
											</div>
											<div class="media-right media-middle">
												<span class="status-mark bg-danger"></span>
											</div>
										</a>
									</li>

									<li class="media">
										<a href="#" class="media-link">
											<div class="media-left"><img src="assets/images/placeholder.jpg" class="img-circle" alt=""></div>
											<div class="media-body">
												<div class="media-heading"><span class="text-semibold">Jordana Mills</span></div>
												<span class="text-muted">Sales consultant</span>
											</div>
											<div class="media-right media-middle">
												<span class="status-mark bg-grey-300"></span>
											</div>
										</a>
									</li>

									<li class="media">
										<a href="#" class="media-link">
											<div class="media-left"><img src="assets/images/placeholder.jpg" class="img-circle" alt=""></div>
											<div class="media-body">
												<div class="media-heading"><span class="text-semibold">William Miles</span></div>
												<span class="text-muted">SEO expert</span>
											</div>
											<div class="media-right media-middle">
												<span class="status-mark bg-success"></span>
											</div>
										</a>
									</li>

									<li class="media-header">Partners</li>

									<li class="media">
										<a href="#" class="media-link">
											<div class="media-left"><img src="assets/images/placeholder.jpg" class="img-circle" alt=""></div>
											<div class="media-body">
												<span class="media-heading text-semibold">Margo Baker</span>
												<span class="media-annotation">Google</span>
											</div>
											<div class="media-right media-middle">
												<span class="status-mark bg-success"></span>
											</div>
										</a>
									</li>

									<li class="media">
										<a href="#" class="media-link">
											<div class="media-left"><img src="assets/images/placeholder.jpg" class="img-circle" alt=""></div>
											<div class="media-body">
												<span class="media-heading text-semibold">Beatrix Diaz</span>
												<span class="media-annotation">Facebook</span>
											</div>
											<div class="media-right media-middle">
												<span class="status-mark bg-warning-400"></span>
											</div>
										</a>
									</li>

									<li class="media">
										<a href="#" class="media-link">
											<div class="media-left"><img src="assets/images/placeholder.jpg" class="img-circle" alt=""></div>
											<div class="media-body">
												<span class="media-heading text-semibold">Richard Vango</span>
												<span class="media-annotation">Microsoft</span>
											</div>
											<div class="media-right media-middle">
												<span class="status-mark bg-grey-300"></span>
											</div>
										</a>
									</li>
								</ul>
							</div>
							<!-- /connections -->

						</div>
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
    </form>
</body>
</html>
