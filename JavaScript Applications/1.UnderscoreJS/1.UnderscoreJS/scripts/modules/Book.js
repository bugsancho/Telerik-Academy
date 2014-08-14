define(function () {
    var Book;

    Book = (function () {

        function Book(title,author) {

            if ((typeof title).toLowerCase() !== 'string') {
                throw 'Book title must be of type string!';
            }
            if ((typeof author).toLowerCase() !== 'string') {
                throw 'Book author must be of type string!';
            }
            if (title.length < 5) {
                throw 'The book title must be at least five symbols long!'
            }
            this.title = title;
            this.author = author;
            
        }


        return Book;
    })();

    return Book;
});