define(function() {
  'use strict';
  var Section;
  Section = (function() {
    function Section(title) {
        this.title = title;
        this._items = [];
    }
    Section.prototype.add = function add(item) {
        this._items.push(item);
    }
    Section.prototype.getData = function getData() {
        var content = [],
            i;
        for (i = 0; i < this._items.length; i++) {
            content.push(this._items[i].getData());
        }
        return{
            title: this.title,
            items: content
        }
    }
	return Section;
  }());
  return Section;
})