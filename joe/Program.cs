using System;

namespace joe
{
    class Person
    {
        Person Joe = new Person();
        public string name;

        public void IntroduceMyself()
        {
            Console.WriteLine($"Hi, I'm {name}");
        }
    }
}