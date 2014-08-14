/// <reference path="G:\Code\JavaScript_UI_And_DOM\ExamPreparation\2.Task2\jquery.min.js" />
$.fn.tabs = function () {
    var $tabsContainer = $(this);
    $tabsContainer.addClass('tabs-container');
    $tabsContainer.find('.tab-item-content').hide()
    $tabsContainer.on('click', '.tab-item-title', function () {
        var $elementTitle = $(this);
        $tabsContainer.find('.current').removeClass('current');
        $tabsContainer.find('.tab-item-content').hide()
        $elementTitle.parent().addClass('current').find('.tab-item-content').show();
    })
};