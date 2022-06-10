using System;

namespace CSClass
{
    public class Cat : Animal
    {

        public int Age { get; set; }

        public void Meow()
        {
            Console.WriteLine("냐옹냐옹 웁니다.");
        }

    }
}