﻿using System;

namespace CSClass
{
    public class Dog:Animal
    {
        public string Color { get; set; }


        public void Eat()
        {
            Console.WriteLine("냠냠 먹겠습니다.");
        }

        public void Sleep()
        {
            Console.WriteLine("쿨쿨 잠을 잡니다.");
        }

        public void Bark()
        {
            Console.WriteLine("왈왈 짖습니다.");
        }
    }
}