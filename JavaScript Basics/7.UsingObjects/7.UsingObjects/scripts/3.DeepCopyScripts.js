function deepCopy(object) {
    'use strict';
    if (typeof object !== 'object' || !object) {
        return object;
    }
    var newObject = {};

    for (var prop in object) {
        newObject[prop] = deepCopy(object[prop]);
    }
    return newObject;
}