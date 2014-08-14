/// <reference path="libs/underscore.js" />
(function () {
    require.config({
        paths: {
            'Student': 'modules/Student',
            'Book': 'modules/Book',
            "Animal": "modules/Animal",
            'underscore': 'libs/underscore'
        },
        shim: {
            "underscore": {
                exports: "_"
            }
        }
    });

    require(['Student', 'Animal', 'Book', 'underscore'], function (Student, Animal, Book, _) {
        var students,
            animals,
            books,
            firstNameBeforeSecondStudents,
            selectedStudentsNames,
            highestMarkStudent,
            animalsByGroups,
            animalsByGroupsSorted,
            numberOfLegs,
            numberOfBooksByAuthor,
            mostPopularAuthor,
            studentsByFirstName,
            studentsByLastName,
            mostPopularFirstName,
            mostPopularLastName;

        students = [new Student('Ivan', 'Ivanov', 21, 53),
        new Student('Peter', 'Ivanov', 32, 78),
        new Student('John', 'Jackson', 17, 95),
        new Student('Maria', 'Petrova', 44, 57),
        new Student('Katia', 'Georgieva', 23, 16),
        new Student('Paul', 'Nesterov', 22, 72),
        new Student('Mario', 'Vanchev', 22, 33),
        new Student('Mario', 'Nedkov', 22, 26)];

        animals = [new Animal('Cho', 'cat', 4),
        new Animal('Sharo', 'dog', 4),
        new Animal('Pisa', 'cat', 4),
        new Animal('Fluffy', 'unicorn', 4),
        new Animal('Evtim', 'unicorn', 4),
        new Animal('Moo', 'cow', 4),
        new Animal('Aragog', 'spider', 8),
        new Animal('Shelob', 'spider', 8),
        new Animal('Muci', 'cockroach', 6),
        new Animal('Justin', 'beaver', 2)];

        books = [new Book('Lord of the rings', 'J.R.R. Tolkien'),
        new Book('The Hobbit', 'J.R.R. Tolkien'),
        new Book('Harry Potter and the Philospopher`s Stone', ' J. K. Rowling'),
        new Book('Harry Potter and the Chamber of Secrets', ' J. K. Rowling'),
        new Book('Harry Potter and the Prisoner of Azkaban', ' J. K. Rowling'),
        new Book('Harry Potter and the Goblet of Fire', ' J. K. Rowling'),
        new Book('Harry Potter and the Order of the Phoenix', ' J. K. Rowling'),
        new Book('Harry Potter and the Half-Blood Prince', ' J. K. Rowling'),
        new Book('Harry Potter and the Deathly Hallows', ' J. K. Rowling'), ];



        // Task 1
        // Students with first name before the last name, sorted alphabetically in descending order.
        firstNameBeforeSecondStudents = _.chain(students)
          .filter(function (stud) {
              return stud.fname < stud.lname;

          })
            .sortBy(function (stud) {
                return stud.fname + stud.lname;
            })
            .reverse()
            .value();
        console.log('Students with first name before the last name, sorted alphabetically in descending order:');
        console.log(firstNameBeforeSecondStudents);

        // Task 2
        // Students'names whose age is between 18 and 24
        selectedStudentsNames = _.chain(students)
        .filter(function (stud) {
            return stud.age >= 18 && stud.age <= 24;
        }).map(function (stud) {
            return {
                'first-name': stud.fname,
                'last-name': stud.lname
            }
        }).value();

        console.log("\nStudents'names whose age is between 18 and 24:");
        console.log(selectedStudentsNames);

        // Task 3 
        // The student with the highest mark
        highestMarkStudent = _.max(students, function (stud) {
            return stud.mark;
        })

        console.log("\nThe student with the highest mark:");
        console.log(highestMarkStudent);

        // Task 4
        // Animals grouped by their species and sorted by the number of legs of the species
        animalsByGroups = _.groupBy(animals, 'species');
        animalsByGroupsSorted = _.sortBy(animalsByGroups, function (group) {
            return group[0].legCount;
        })

        console.log("\nAnimals grouped by their species and sorted by the number of legs of the species:");
        console.log(animalsByGroupsSorted);

        // Task 5
        // The total number of legs of all animals.
        numberOfLegs = _.reduce(animals, function (memo, animal) {
            return memo + animal.legCount;
        }, 0)

        console.log("\nThe total number of legs of all animals:");
        console.log(numberOfLegs);


        // Task 6
        // The author with most books.
        numberOfBooksByAuthor = _.groupBy(books, 'author');
        mostPopularAuthor = (_.max(numberOfBooksByAuthor, function (books) {
            return books.length;
        }))[0].author;

        console.log("\nThe author with most books:");
        console.log(mostPopularAuthor);

        // Task 7
        // The most common first and last name.
        studentsByFirstName = _.groupBy(students, 'fname');
        studentsByLastName = _.groupBy(students, 'lname');

        mostPopularFirstName = (_.max(studentsByFirstName, function (students) {
            return students.length;
        }))[0].fname;

        console.log("\nThe most common first name:");
        console.log(mostPopularFirstName);

        mostPopularLastName = (_.max(studentsByLastName, function (students) {
            return students.length;
        }))[0].lname;

        console.log("\nThe most common last name:");
        console.log(mostPopularLastName);


    });

})();