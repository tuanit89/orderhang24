$(function () {
        var countitem = $('.slider-news .slider-width .item-slider').length;
        if (countitem > 1) {
            $('.slider-news .slider-width').before('<div id="nav">').cycle({
                fx: 'fade',
                speed: 'fast',
                timeout: 5000,
                pager: '#nav',
                pause: true
            });
        }
}); 