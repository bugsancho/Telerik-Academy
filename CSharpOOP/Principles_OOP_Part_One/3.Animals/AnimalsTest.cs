using System;
using System.Linq;
class AnimalsTest
{
    static void Main()
    {
        Frog[] frogs = new Frog[2];
        frogs[0] = new Frog("Kermit", 10, 'm');
        frogs[1] = new Frog("Quacky", 5, 'f');

        Dog[] dogs = new Dog[2];
        dogs[0] = new Dog("Sharo", 2, 'm');
        dogs[1] = new Dog("kucho", 5, 'm');

        Kitten[] kittens = new Kitten[2];
        kittens[0] = new Kitten("Kitty", 1);
        kittens[1] = new Kitten("Mitty", 4);
       
        double averageDogAge = dogs.Average(x => x.Age);
        Console.WriteLine(averageDogAge);
        double averageFrogAge = frogs.Average(x => x.Age);
        Console.WriteLine(averageFrogAge);
        double averageKittenAge = kittens.Average(x => x.Age);
        Console.WriteLine(averageKittenAge);
    }
}
