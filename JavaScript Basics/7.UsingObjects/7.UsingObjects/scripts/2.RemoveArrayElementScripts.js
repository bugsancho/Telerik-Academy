Array.prototype.remove = function (value) {
    'use strict';
    var index = 0;
    while (index < this.length) {

        if (this[index] === value) {
            this.splice(index, 1);
        } else {
            index++;
        }

    }

    return this;
};