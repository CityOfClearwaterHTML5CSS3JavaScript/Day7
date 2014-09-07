<!DOCTYPE html>
<!--[if lt IE 7]>      <html class="no-js lt-ie9 lt-ie8 lt-ie7"> <![endif]-->
<!--[if IE 7]>         <html class="no-js lt-ie9 lt-ie8"> <![endif]-->
<!--[if IE 8]>         <html class="no-js lt-ie9"> <![endif]-->
<!--[if gt IE 8]><!-->
<html class="no-js">
<!--<![endif]-->
<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">

    <title>MyClearwater.com - The Official Web Site of the City of Clearwater, FL</title>

    <link rel="apple-touch-icon-precomposed" sizes="144x144" href="~/assets/icons/apple-touch-icon-144x144-precomposed.png">
    <link rel="apple-touch-icon-precomposed" sizes="114x114" href="~/assets/icons/apple-touch-icon-114x114-precomposed.png">
    <link rel="apple-touch-icon-precomposed" sizes="72x72" href="~/assets/icons/apple-touch-icon-72x72-precomposed.png">
    <link rel="apple-touch-icon-precomposed" href="~/assets/icons/apple-touch-icon-precomposed.png">
    <link rel="shortcut icon" href="~/assets/icons/favicon.png">

    <script src="~/assets/scripts/modernizr-2.8.3.min.js"></script>
    <link rel="stylesheet" href="~/assets/css/stylesheets.css">
    @RenderSection("styles", False)

</head>
<body>
    <div class="overlay2"></div>

    <header class="header navbar navbar-default navbar-fixed-top">
        <div class="container">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse"
                        data-target=".navbar-collapse">
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                <div class="logo navbar-brand">
                    <a href="index.html">
                        <img class="logo-img" src="~/assets/images/header/CityOfClearwater.png" alt="" />
                    </a>
                </div>
            </div>
            <nav class="navbar-collapse collapse">
                <ul class="nav navbar-nav">
                    <li class="nav-list-item is-active"><a class="nav-list-item-link" href="#">Home</a></li>
                    <li class=""><a class="nav-list-item-link" href="#">Information</a></li>
                    <li class=""><a class="nav-list-item-link" href="#">Services</a></li>
                    <li class=""><a class="nav-list-item-link" href="#">Activities</a></li>
                    <li class=""><a class="nav-list-item-link" href="#">Government</a></li>
                    <li class=""><a class="nav-list-item-link" href="#">Employment</a></li>
                </ul>
            </nav>
        </div>
    </header>

    <div class="content container">
        @RenderBody()
    </div><!-- div content container -->

    <footer class="footer container">
        <div class="row">
            <section class="col-sm-4">
                <h4 class="footer-heading">Browse Pages</h4>

                <ul class="fa-ul">
                    <li class="footer-browse-pages-list-item">
                        <i class="fa-li fa fa-angle-right"></i>
                        <a class="footer-browse-pages-link" href="#">Home</a>
                    </li>
                    <li class="footer-browse-pages-list-item">
                        <i class="fa-li fa fa-cog fa-spin"></i>
                        <a class="footer-browse-pages-link" href="#">Information</a>
                    </li>
                    <li class="footer-browse-pages-list-item">
                        <i class="fa-li fa fa-check-square"></i>
                        <a class="footer-browse-pages-link" href="#">Services</a>
                    </li>
                    <li class="footer-browse-pages-list-item">
                        <i class="fa-li fa fa-spinner fa-spin"></i>
                        <a class="footer-browse-pages-link" href="#">Activities</a>
                    </li>
                    <li class="footer-browse-pages-list-item">
                        <i class="fa-li fa fa-square"></i>
                        <a class="footer-browse-pages-link" href="#">Government</a>
                    </li>
                    <li class="footer-browse-pages-list-item">
                        <i class="fa-li fa fa-cloud"></i>
                        <a class="footer-browse-pages-link" href="#">Employment</a>
                    </li>
                </ul>
            </section>

            <section class="col-sm-4">
                <h4 class="footer-heading">Recent Blog Posts</h4>

                <div class="footer-blog-post">
                    <a class="pull-left" href="#">
                        <img class="footer-blog-post-img" src="~/assets/images/footer/icon.png" width="25" height="25">
                    </a>
                    <h4>Consectetur adipiscing elit</h4>
                    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin ac nisl dui augue pulvinar elementum...</p>
                    <a class="pull-right" href="#">Read more</a>
                </div>

                <div class="footer-blog-post">
                    <a class="pull-left" href="#">
                        <img class="footer-blog-post-img" src="~/assets/images/footer/icon.png" width="25" height="25">
                    </a>
                    <h4>Consectetur adipiscing elit</h4>
                    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin ac nisl dui augue pulvinar elementum...</p>
                    <a class="pull-right" href="#">Read more</a>
                </div>
            </section>

            <section class="col-sm-4">
                <h4 class="footer-heading">Latest Tweets</h4>

                <ul class="fa-ul">
                    <li class="footer-latest-tweets-list-item">
                        <i class="fa-li fa fa-twitter fa-lg"></i>
                        <a href="#">about 14 days ago:</a>
                        We said, I want the mailbox Mac app so badly.
                    </li>
                    <li class="footer-latest-tweets-list-item">
                        <i class="fa-li fa fa-twitter fa-lg"></i>
                        <a href="#">about 23 days ago:</a>
                        We replied to <a href="#">@@onehundred_be</a> perhaps. Accepting pull requests
                    </li>
                    <li class="footer-latest-tweets-list-item">
                        <i class="fa-li fa fa-twitter fa-lg"></i>
                        <a href="#">about 24 days ago:</a>
                        We were serving coffee at <a href="#">@@heroku</a> <a href="#">#waza</a>
                        was one of my favorite moments – amazing chats with amazing customers
                    </li>
                </ul>
            </section>
        </div>

        <div class="footer-credits">

            <div class="row">
                <section class="col-sm-8">
                    <p class="">&copy; 2014 City of Clearwater | All Rights Reserved</p>
                </section>

                <section class="col-sm-4">
                    <ul class="footer-icons-list pull-right">
                        <li class="footer-icons-list-item">
                            <a class="footer-icons-list-item-link" href="https://www.facebook.com/cityofclearwater">
                                <i class="fa fa-facebook"></i>
                            </a>
                        </li>
                        <li class="footer-icons-list-item">
                            <a class="footer-icons-list-item-link" href="https://twitter.com/MyClearwater">
                                <i class="fa fa-twitter"></i>
                            </a>
                        </li>
                        <li class="footer-icons-list-item">
                            <a class="footer-icons-list-item-link" href="http://www.pinterest.com/myclearwater/">
                                <i class="fa fa-pinterest"></i>
                            </a>
                        </li>
                        <li class="footer-icons-list-item">
                            <a class="footer-icons-list-item-link" href="https://www.flickr.com/photos/city_of_clearwater/">
                                <i class="fa fa-flickr"></i>
                            </a>
                        </li>
                        <li class="footer-icons-list-item">
                            <a class="footer-icons-list-item-link" href="http://instagram.com/MyClearwater">
                                <i class="fa fa-instagram"></i>
                            </a>
                        </li>
                        <li class="footer-icons-list-item">
                            <a class="footer-icons-list-item-link" href="https://www.youtube.com/user/clearwaterpubsafety">
                                <i class="fa fa-youtube"></i>
                            </a>
                        </li>
                    </ul>
                </section>
            </div>
        </div>
    </footer>

    <script>
        var assetsPath = "@Url.Content("~/assets")";
        console.log(assetsPath);
    </script>
    <script src="~/assets/scripts/libraries.js"></script>

    @RenderSection("scripts", False)
</body>
</html>