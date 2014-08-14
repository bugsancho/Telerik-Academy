define(function() {
  'use strict';
  var Container;
  Container = (function() {
   function Container() {
       this._items = [];
   }
   Container.prototype.add = function add(item) {
       this._items.push(item);
   }
   Container.prototype.getData = function getData() {
       var content = [],
           i;
       for (i = 0; i < this._items.length; i++) {
           content.push(this._items[i].getData());
       }

       return content;
   }
   return Container;
  }());
  return Container;
});