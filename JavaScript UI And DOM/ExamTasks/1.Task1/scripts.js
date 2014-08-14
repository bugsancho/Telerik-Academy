function createImagesPreviewer(selector, items) {
    var container = document.querySelector(selector),
        selectedItemContainer = document.createElement('div'),
        listItemsContainer = document.createElement('div'),
        filter = document.createElement('input'),
        filterHeading = document.createElement('span'),
        selectedImageHeading = document.createElement('h1'),
        imageContainer = document.createElement('div'),
        imageHeading = document.createElement('h4'),
        image = document.createElement('img'),
        HOVERED_COLOR = 'green',
        DEFAULT_COLOR = 'white';

    setListItemsAttrs();
    setFilterAttrs();
    setContainerAttrs();
    setListItemsContainerAttrs();
    setSelectedItemContainerAttrs();
    setImageHeadingStyles();

    var imagesFragment = document.createDocumentFragment();
    for (var i = 0; i < items.length; i++) {
        var currentItem = createImageContainer(items[i].url, items[i].title);

        currentItem.addEventListener('click', onListItemClick);
        currentItem.addEventListener('mouseover', onListItemMousein);
        currentItem.addEventListener('mouseout', onListItemMouseout);
        currentItem.setAttribute('data-id', i);

        imagesFragment.appendChild(currentItem);
    }

    listItemsContainer.appendChild(filterHeading);
    listItemsContainer.appendChild(filter);
    listItemsContainer.appendChild(imagesFragment);

    container.appendChild(selectedItemContainer);
    container.appendChild(listItemsContainer);

    listItemsContainer.getElementsByClassName('list-item')[0].click();

    function setContainerAttrs() {
        container.style.border = '1px solid black';
        container.style.width = '500px';
        container.style.height = '400px';
        container.style.margin = 0;
        container.style.padding = '5px';
    }

    function setListItemsAttrs() {
        image.style.width = '100%';
        image.style.height = '100%';
        image.style.borderRadius = '10px'
        image.style.display = 'inline-block'
        image.classList.add('list-item-img');

        imageHeading.style.margin = 0;
        imageHeading.classList.add('list-item-heading');

        imageContainer.classList.add('list-item');
    }

    function setSelectedItemContainerAttrs() {
        selectedItemContainer.classList.add('selected-item')

        selectedItemContainer.style.cssFloat = 'left';
        selectedItemContainer.style.width = '350px';
        selectedItemContainer.style.height = '350px';
        selectedItemContainer.style.margin = 0;
        selectedItemContainer.style.padding = 0;
    }

    function setListItemsContainerAttrs() {
        listItemsContainer.style.textAlign = 'center';
        listItemsContainer.style.display = 'inline-block';
        listItemsContainer.style.width = '140px';
        listItemsContainer.style.height = '380px';
        listItemsContainer.style.margin = 0;
        listItemsContainer.style.padding = '5px';
        listItemsContainer.style.overflowY = 'scroll';

        listItemsContainer.classList.add('aside-items');
    }

    function setFilterAttrs() {
        filterHeading.innerHTML = 'Filter';
        filter.setAttribute('type', 'text');
        filter.style.width = '100%';
        filter.style.display = 'block';
        filter.classList.add('filter');
        filter.addEventListener('keyup', onFilterKeyup);
    }

    function setImageHeadingStyles() {
        selectedImageHeading.style.textAlign = 'center';
        selectedImageHeading.style.display = 'block'
        selectedImageHeading.style.margin = 0;
    }

    function createImageContainer(url, title) {
        var imgContainer = imageContainer.cloneNode(true),
            img = image.cloneNode(true),
            heading = imageHeading.cloneNode(true);

        img.setAttribute('src', url);
        heading.innerHTML += title;

        imgContainer.appendChild(heading);
        imgContainer.appendChild(img);

        return imgContainer;
    }

    function onListItemClick(ev) {
        clearSelectedItemContainer();
        var dataId = parseInt(ev.target.getAttribute('data-id') || ev.target.parentNode.getAttribute('data-id')),
            selectedheading = selectedImageHeading.cloneNode(true),
            selectedImg = image.cloneNode(true);

        selectedheading.textContent = items[dataId].title;
        selectedImg.setAttribute('src', items[dataId].url)

        selectedItemContainer.appendChild(selectedheading);
        selectedItemContainer.appendChild(selectedImg);
    }

    function onListItemMousein(ev) {
        var divTarget = getClosestDiv(ev);
        divTarget.style.backgroundColor = HOVERED_COLOR;
    }

    function onListItemMouseout(ev) {
        var divTarget = getClosestDiv(ev);
        divTarget.style.backgroundColor = DEFAULT_COLOR;
    }

    function onFilterKeyup() {
        var headings = listItemsContainer.getElementsByClassName('list-item-heading'),
            filterValue = filter.value.toLowerCase();

        for (var i = 0; i < headings.length; i++) {
            headings[i].parentNode.style.display = '';
        }

        if (filterValue) {
            for (var i = 0; i < headings.length; i++) {
                var title = headings[i].innerHTML.toLowerCase();
                if (title.indexOf(filterValue) === -1) {
                    headings[i].parentNode.style.display = 'none';
                }
            }
        }
    }

    function getClosestDiv(el) {
        return (el.target.tagName === 'DIV') ? el.target : el.target.parentNode
    }

    function clearSelectedItemContainer() {
        while (selectedItemContainer.firstChild) {
            selectedItemContainer.removeChild(selectedItemContainer.firstChild);
        }
    }
}