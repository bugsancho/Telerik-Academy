define(function () {
    var Animal;

    Animal = (function () {
        var ANIMAL_SPECIES,
            ANIMALS_LEG_COUNT;

        ANIMAL_SPECIES = {
            dog: 'dog',
            cat: 'cat',
            squirrel: 'squirrel',
            moth: 'moth',
            unicorn: 'unicorn',
            cow: 'cow',
            spider: 'spider',
            cockroach: 'cockroach',
            beaver:'beaver'
        }

        ANIMALS_LEG_COUNT = [2, 4, 6, 8, 100];

        function Animal(name, species, legCount) {
            if ((typeof name).toLowerCase() !== 'string' ) {
                throw 'Names must be of type string!';
            }
            if (name.length < 2) {
                throw 'Animal name must be at least two symbols long!'
            }
            if (!(ANIMAL_SPECIES[species])) {
                throw 'Not a valid species!';
            }
            if (ANIMALS_LEG_COUNT.indexOf(legCount) === -1) {
                throw 'Invalid animal leg count!';
            }
            this.species = species;
            this.legCount = legCount;
        }

        return Animal;
    })()
    return Animal;
});