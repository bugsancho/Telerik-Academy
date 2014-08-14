/// <reference path="G:\Code\JavaScript_UI_And_DOM\9.JQueryOverview\9.JQueryOverview\libs/jquery-2.1.1.min.js" />
window.onload = function () {
    var $slider = $('#slider-content');
    $('#next').on('click', setNextSlide);
    $('#prev').on('click', setPrevSlide);
    setInterval(setNextSlide, 5000);
}
function setNextSlide() {
    var $current = $('.current').removeClass('current');
    if ($current.next().length !== 0) {
        $current.next().addClass('current')
    }
    else {
        $current.parent().children().first().addClass('current')
    }
}
function setPrevSlide() {
    var $current = $('.current').removeClass('current');
    if ($current.prev().length !== 0) {
        $current.prev().addClass('current')
    }
    else {
        $current.parent().children().last().addClass('current')
    }
}