define(function () {
    'use strict';
    var Item,
        ITEM_TYPES;

    //enumeration for the allowed item types
    ITEM_TYPES = {
        'accessory': 'accessory',
        'smart-phone': 'smart-phone',
        'notebook': 'notebook',
        'pc': 'pc',
        'tablet': 'tablet'
    }

    Item = (function () {

        function Item(type, name, price) {
            //inpit data validation
            if (!ITEM_TYPES[type]) {
                throw 'Invalid item type!';
            }
            //using toLowerCase to handle the two possibble results when using typeof -> 'string' and 'String'.
            if (((typeof name).toLowerCase() !== 'string') || (name.length < 6 || name.length > 40)) {
                throw 'Invalid item name!';
            }
            if ((typeof price).toLowerCase() !== 'number' || price < 0) {
                throw 'Invalid item price';
            }

            this.type = type;
            this.name = name;
            this.price = price;

        }
       
        return Item;
    })();
    return Item;
});