/*!-----------------------------------------------------------------
  Name: PiliPala - WindVane
  Version: 0.0.1
  Author: PseudoJunZi
  GitHub: https://github.com/PseudoJunZi/WindVane
  GitHub Pages: https://pseudojunzi.github.io
  ZhiHu: https://zhihu.com/people/hypocritez
  cnblogs: https://cnblogs.com/PseudoJunZi
  License: MIT
  Copyright 2019.
-------------------------------------------------------------------*/

; (function () {
    'use strict';

    /*------------------------------------------------------------------
    
    Theme Options
    
    -------------------------------------------------------------------*/

    var PiliPala = {} || window.PiliPala;

    /*------------------------------------------------------------------
    
    Navbar
    
    -------------------------------------------------------------------*/
    PiliPala.Navbar = function () {
        const pathname = window.location.href;
        $("nav.navbar ul.navbar-nav li.nav-item a.nav-link").map(function (index, element) {
            const href = element.href;
            if (pathname === href) {
                element.classList.add('active');
                return false;
            }
        });
    };

    $(window).on('load', function () {
        PiliPala.Navbar();
    });
})();