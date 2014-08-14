function hasProperty(object, property) {

    if (typeof property !== 'string'){
        throw TypeError('The looked-up property must be passed as a string!');
    }

    if (object[property]) {
        return true;
    }
    return false;
}