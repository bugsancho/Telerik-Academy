function Person(firstName, lastName, age) {
    if (typeof firstName !== 'string' || typeof lastName !== 'string' || typeof age !== 'number') {
        throw new TypeError("Invalid constructor paremeters for Person!");
    }
    this.firstName = firstName;
    this.lastName = lastName;
    this.age = age;

}

var maria = new Person('maria', 'mariina', 145);
var gogo = new Person('tosho', 'toshin', 778);
var pesho = new Person('pesho', 'peshin', 5411);
var arr = new Array(maria, gogo, pesho);
console.log(findYoungestPerson(arr));


function findYoungestPerson(peopleArray) {

    if (!peopleArray.length) {
        throw new TypeError('Required parameter must be an array of Person!');
    }

    var youngestPerson = peopleArray[0];
    for (var i = 0; i < peopleArray.length; i++) {

        if (!peopleArray[i] instanceof Person) {
            throw new TypeError('The array must contain only instances of Person!');
        }

        if (youngestPerson.age > peopleArray[i].age) {
            youngestPerson = peopleArray[i];
        }

    }

    return youngestPerson.firstName + " " + youngestPerson.lastName;
}

