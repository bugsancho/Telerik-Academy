/// <reference path="G:\Code\JavaScript_UI_And_DOM\ExamTasks\2.Task2\jquery.min.js" />
$.fn.gallery = function (cols) {
    var $gallery = $(this),
        numberOfColumns = cols || 4,
        IMAGE_CONTAINER_WIDTH = 250,
        $selectedContainer,
        $galleryImageList,
        isImageSelected;

    $galleryImageList = $gallery.find('.gallery-list');
    $gallery.addClass('gallery');
    $gallery.width((numberOfColumns * 1.1) * IMAGE_CONTAINER_WIDTH + 'px');
    $selectedContainer = $gallery.find('.selected');
    $selectedContainer.empty();

    $gallery.on('click', '.image-container img', function () {
        if (!isImageSelected) {
            changeSelectedImages(this);
            isImageSelected = true;
            $galleryImageList.addClass('blurred');
            //$galleryImageList.addClass('disabled-background');  
        }
    })

    function changeSelectedImages(selectedImg) {
        var $clickedImage = $(selectedImg),
            clickedImageDataInfo = getDataInfoValue($clickedImage),
          $prevImage = getImageByDataInfo(clickedImageDataInfo - 1),
          $nextImage = getImageByDataInfo(clickedImageDataInfo + 1);

        $selectedContainer.empty();

        var $currentImageContainer = createImageInContainer($clickedImage.attr('src'), 'current-image', $clickedImage.attr('data-info')),
            $prevImageContainer = createImageInContainer($prevImage.attr('src'), 'previous-image', $prevImage.attr('data-info')),
            $nextImageContainer = createImageInContainer($nextImage.attr('src'), 'next-image', $nextImage.attr('data-info'));

        $prevImageContainer.on('click', 'img', function () {
            changeSelectedImages(this);
        })
        $nextImageContainer.on('click', 'img', function () {
            changeSelectedImages(this);
        })
        $currentImageContainer.on('click', 'img', function () {
            $selectedContainer.empty();
            $galleryImageList.removeClass('blurred');
           // $galleryImageList.removeClass('disabled-background');
            isImageSelected = false;
        })

        $selectedContainer.append($prevImageContainer);
        $selectedContainer.append($currentImageContainer);
        $selectedContainer.append($nextImageContainer);
    }

    function createImageInContainer(src, id, dataInfo) {
        var $container = $('<div>')
            .addClass(id);
        var $image = $('<img>')
            .attr({
                'src': src,
                'id': id,
                'data-info': dataInfo
            });
        $container.append($image);
        return $container;
    }

    function getDataInfoValue(item) {
        return parseInt($(item).attr('data-info'))
    }
    function getImageByDataInfo(dataInfo) {
        var imagesCount = $galleryImageList.children().length;
        if (dataInfo <= 0) {
            dataInfo = imagesCount;
        }
        else if (dataInfo > imagesCount) {
            dataInfo = 1;
        }
        return $galleryImageList.find('img[data-info=' + dataInfo + ']');
    }
};