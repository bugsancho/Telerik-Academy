define(function () {
    var Student;

    Student = (function () {

        function Student(fname, lname, age, mark) {

            if ((typeof fname).toLowerCase() !== 'string' || (typeof lname).toLowerCase() !== 'string') {
                throw 'Names must be of type string!';
            }
            if (fname.length < 3 || lname.length < 3) {
                throw 'Names must be at least three symbols long!'
            }
            if ((typeof age).toLowerCase() !== 'number') {
                throw 'Age must be a number!';
            }
            if (age < 5) {
                throw 'A student cannot be less than 5 years old!';
            }
            if ((typeof mark).toLowerCase() !== 'number') {
                throw 'Mark must be a number!';
            }
            if (mark < 0) {
                throw 'Mark cannot be a negative number!';
            }
            this.fname = fname;
            this.lname = lname;
            this.age = age;
            this.mark = mark;
        }


        return Student;
    })();

    return Student;
});