<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SpLoginApp.Default" %>

<!DOCTYPE html>
<html lang="en">
    <head>
        
        <meta charset="utf-8">
        <meta http-equiv="X-UA-Compatible" content="IE=edge">
        <meta name="viewport" content="width=device-width, initial-scale=1">
        <title>Welcome</title>
        
        
    </head>

    <body>
       <div class="all_container">
       </div>
        <!-- Top menu -->
		<a href="Logout.aspx"><i class="fa fa-users"></i><br>Logout</a>
		
        <!-- Slider -->
        <form runat="server">
          
        </form>
        <!-- Footer -->
        <footer>
            <div class="container">
                <div class="row">
                    <div class="col-sm-4 footer-box wow fadeInUp">
                        <h4>About Us</h4>
                        <div class="footer-box-text">
	                        <p>
	                        	Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et. 
	                        	Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et.
	                        </p>
	                        <p><a href="About.aspx">Read more...</a></p>
                        </div>
                    </div>
                    <div class="col-sm-4 footer-box wow fadeInDown">
                        <h4>Email Updates</h4>
                        <div class="footer-box-text footer-box-text-subscribe">
                        	<p>Enter your email and you'll be one of the first to get new updates:</p>
                        	<form role="form" action="../assets/subscribe.php" method="post">
		                    	<div class="form-group">
		                    		<label class="sr-only" for="subscribe-email">Email address</label>
		                        	<input type="text" name="email" placeholder="Email..." class="subscribe-email" id="subscribe-email">
		                        </div>
		                        <button type="submit" class="btn">Subscribe</button>
		                    </form>
		                    <p class="success-message"></p>
		                    <p class="error-message"></p>
                        </div>
                    </div>
                    
                    <div class="col-sm-4 footer-box wow fadeInDown">
                        <h4>Contact Us</h4>
                        <div class="footer-box-text footer-box-text-contact">
	                        <p><i class="fa fa-map-marker"></i> Address: 35/A, Dhanmondi 32, Dhaka 1207, Bangladesh</p>
	                        <p><i class="fa fa-phone"></i> Phone: +880 01917723939</p>
	                        <p><i class="fa fa-user"></i> Skype: travel.tourism</p>
	                        <p><i class="fa fa-envelope"></i> Email: <a href="#">contact@traveltourism.com.bd</a></p>
                        </div>
                    </div>
                </div>
                <div class="row">
                	<div class="col-sm-12 wow fadeIn">
                		<div class="footer-border"></div>
                	</div>
                </div>
                <div class="row">
                    <div class="col-sm-7 footer-copyright wow fadeIn">
                        <p>Copyright © 2015 Travel Tourism Automation- All rights reserved. Developed by <a href="http://taukirhasan.com">Taukir Hasan</a>.</p>
                    </div>
                    <div class="col-sm-5 footer-social wow fadeIn">
                        <a href="#"><i class="fa fa-facebook"></i></a>
                        <a href="#"><i class="fa fa-github"></i></a>
                        <a href="#"><i class="fa fa-twitter"></i></a>
                        <a href="#"><i class="fa fa-linkedin"></i></a>
                    </div>
                </div>
            </div>
        </footer>        
        
        

        <!-- Javascript -->
        
    </body>

</html>
