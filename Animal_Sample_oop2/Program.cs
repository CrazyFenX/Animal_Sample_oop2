using System;

namespace Animal_Sample_oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Animal cat = new Animal("Pushok", 2.3f, 'b');
            ////cat.color = 'w';
            ////cat.name = "pushok";
            ////cat.mass = 2.3f;
            //cat.say();

            Cat cat = new Cat("Pushok", 2.3f, 'w', 0.4f);
            Dog dog = new Dog("Sharik", 5.3f, 'g');

            cat.say();
            Console.WriteLine();
            dog.say();
        }
    }
}
