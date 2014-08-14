define(['tech-store-models/item'], function (Item) {
    'use strict';
    var Store;
    Store = (function () {
        // private method for sorting lexicographically a collection of items
        function sortItemsByName(items) {
            var sorted;
            sorted = items.sort(function (a, b) {
                return a.name.localeCompare(b.name);
            })
            return sorted;
        }

        // private method for sorting a collection of items by price
        function sortItemsByPrice(items) {
            var sorted;
            sorted = items.sort(function (a, b) {
                return a.price - b.price;
            })
            return sorted;
        }

        // private method for filtering items by a desired type
        function filterItemsByType(items, queriedType) {
            var filteredItems = [],
                i;
            for (i = 0; i < items.length; i++) {
                if (items[i].type === queriedType) {
                    filteredItems.push(items[i]);
                }
            }
            return filteredItems;
        }

        // functions to be exposed following the revealing pattern

        // function that handles the store.addItem() method
        function addItem(item) {
            if (!(item instanceof Item)) {
                throw 'Parameter is not ot type Item!';
            }

            this._items.push(item);
            return this;
        }
        // store.getAll()
        function getAllItems() {
            var sortedItems;

            sortedItems = sortItemsByName(this._items);
            return sortedItems;
        }
        // store.getSmartPhones()
        function getSmartPhones() {
            var phones,
                sortedPhones,
                phoneType;

            phoneType = 'smart-phone';
            phones = filterItemsByType(this._items, phoneType);
            sortedPhones = sortItemsByName(phones);
            return sortedPhones;

        }
        // store.getMobiles()
        function getMobiles() {
            var phones,
                tablets,
                mobiles,
                mobilesSorted,
                phoneType,
                tabletType;

            phoneType = 'smart-phone';
            tabletType = 'tablet';

            phones = filterItemsByType(this._items, phoneType);
            tablets = filterItemsByType(this._items, tabletType);

            mobiles = phones.concat(tablets); //merge the two arrays into a third one
            mobilesSorted = sortItemsByName(mobiles);
            return mobilesSorted;
        }
        // store.getComputers()
        function getComputers() {
            var personalComputers,
               laptops,
               computers,
               computersSorted,
               personalComputerType,
               laptopType;

            personalComputerType = 'pc';
            laptopType = 'notebook';

            personalComputers = filterItemsByType(this._items, personalComputerType);
            laptops = filterItemsByType(this._items, laptopType);

            computers = personalComputers.concat(laptops);
            computersSorted = sortItemsByName(computers);
            return computersSorted;
        }
        // store.filterItemsByType()
        function getItemsByType(type) {
            var filteredItems,
                sortedItems;

            filteredItems = filterItemsByType(this._items, type);
            sortedItems = sortItemsByName(filteredItems);
            return sortedItems;
        }
        // store.filterItemsByPrice
        function getItemsByPrice(options) {
            var min,
                max,
                currentItemPrice,
                filteredItems = [],
                filteredItemsSorted,
                i;

            min = 0;
            if (options) {
                min = options.min || 0;
                max = options.max;
            }

            for (i = 0; i < this._items.length; i++) {
                currentItemPrice = this._items[i].price;
                if (currentItemPrice >= min) {
                    if (max) {
                        if (currentItemPrice > max) {
                            continue;
                        }
                    }
                    filteredItems.push(this._items[i]);
                }
            }

            filteredItemsSorted = sortItemsByPrice(filteredItems);
            return filteredItemsSorted;
        }
        // store.countItemsByType()
        function getItemsCountByType() {
            var result = {},
                currentItem,
                currentItemType,
                i;

            for (i = 0; i < this._items.length; i++) {
                currentItem = this._items[i];
                currentItemType = currentItem.type;
                if (result[currentItemType]) {
                    result[currentItemType] += 1;
                }
                else {
                    result[currentItemType] = 1;
                }
            }

            return result;
        }
        // store.filterItemsByName
        function getItemsByNameQuery(partOfName) {
            var filteredItems = [],
                filteredItemsSorted,
               currentItem,
               currentItemName,
               i;

            if (((typeof partOfName).toLowerCase() !== 'string') ) {
                throw 'The searched name must be a string!';
            }
            partOfName = partOfName.toLowerCase();

            for (i = 0; i < this._items.length; i++) {
                currentItem = this._items[i];
                currentItemName = currentItem.name.toLowerCase();
                if (currentItemName.indexOf(partOfName) !== -1) {
                    filteredItems.push(currentItem);
                }
            }

            filteredItemsSorted = sortItemsByName(filteredItems);
            return filteredItemsSorted;
        }

        // function constructor
        function Store(name) {
            if (((typeof name).toLowerCase() !== 'string') || (name.length < 6 || name.length > 30)) {
                throw 'Invalid store name!';
            }
            this.name = name;
            this._items = [];
        }

        // methods attached to the prototype with an object as there is no inheritence
        Store.prototype = {
            addItem: addItem,
            getAll: getAllItems,
            getSmartPhones: getSmartPhones,
            getMobiles: getMobiles,
            getComputers: getComputers,
            filterItemsByType: getItemsByType,
            filterItemsByPrice: getItemsByPrice,
            countItemsByType: getItemsCountByType,
            filterItemsByName: getItemsByNameQuery
        }

        return Store;
    })();
    return Store;
});