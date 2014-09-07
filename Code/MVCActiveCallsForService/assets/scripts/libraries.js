Modernizr.load([
    {
        load: "//code.jquery.com/jquery-1.11.1.min.js",
        complete: function () {
            if (!window.jQuery) {
                var test = assetsPath + '/scripts/jquery-1.11.1.min.js';
                Modernizr.load([{
                    load: assetsPath + '/scripts/jquery-1.11.1.min.js',
                    complete: function () {
                        console.info("jQuery had to be loaded locally");
                    }
                }]);
            }
            else console.info("jQuery loaded from CDN");

            Modernizr.load([{
                load: {
                    "bootstrap" : "//maxcdn.bootstrapcdn.com/bootstrap/3.2.0/js/bootstrap.min.js", 
                    "jquery.vegas": assetsPath + "/scripts/jquery.vegas.min.js",
                },
                callback : {  
                    "bootstrap": function (url, result, key) {
                        console.info("bootstrap loaded...");
                        $('#bsCarousel').carousel()
                    },
                    "jquery.vegas" : function(url, result, key){      
                        console.info("jquery.vegas loaded...");

                        $.vegas('slideshow', {
                            delay: 15000,
                            fade: 1000,
                            loading: false,
                            backgrounds: [
                                { src: assetsPath + '/images/backgrounds/ClearwaterBeach2.jpg' },
                                { src: assetsPath + '/images/backgrounds/ClearwaterBeach1.jpg' }
                            ],
                        })('overlay', {
                            src: assetsPath + '/images/backgrounds/overlay.png'
                        });
                    },
                }
            }])
        }
    },
    
    /*,
    {
        test: Modernizr.geolocation,
        yep : "geo.js",
        nope: "geo-polyfill.js",
        both: "geo-common.js"
    }*/
]);