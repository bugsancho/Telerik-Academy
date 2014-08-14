function Person(firstName, lastName, age) {
    if (typeof firstName !== 'string' || typeof lastName !== 'string' || typeof age !== 'number') {
        throw new TypeError("Invalid constructor paremeters for Person!");
    }
    this.firstName = firstName;
    this.lastName = lastName;
    this.age = age;

}


function groupPeopleByProperty(peopleArray, property) {
    if (!peopleArray.length) {
        throw new TypeError('Required parameter must be an array of Person!');
    }

    if (!(property === 'firstName' || property === 'lastName' || property === 'age')) {
        throw new ReferenceError('Invalid input for property! Possible properties: "firstName", "lastName", "age"');
    }

    var groupedPeople = {};
    for (var i = 0; i < peopleArray.length; i++) {
      
        var propertyValue = eval('peopleArray[i].' + property);

        if (groupedPeople[propertyValue]) {
            groupedPeople[propertyValue].push(peopleArray[i]);
        }
        else {
            groupedPeople[propertyValue] = [peopleArray[i]];
        }
       
    }

    return groupedPeople;
}


var maria = new Person('maria', 'mariina', 145);
var gogo = new Person('tosho', 'toshin', 145);
var pesho = new Person('pesho', 'peshin', 5411);
var gosho = new Person('tosho', 'toshin', 175);
var goggg = new Person('gogo', 'tomin', 5411);
var arr = new Array(maria, gogo, pesho, goggg, gosho);
console.log(groupPeopleByProperty(arr, 'firstName'));