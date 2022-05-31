using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.SetInTime();
            car.SetOutTime();

            Random random = new Random();
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));

            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble() * 10);

            /*
            List<int> list = new List<int>();
    
            list.Add(2);
            list.Add(419);
            list.Add(429);
            list.Add(303);
            */

            List<int> list = new List<int> { 52, 273, 32, 24 };
            list.Remove(52);


            foreach (var item in list)
            {
                Console.WriteLine("Count : " + list.Count + "\titem : " + item);
            }

            Console.WriteLine(Math.Abs(-52273));
            Console.WriteLine(Math.Ceiling(52.273));
            Console.WriteLine(Math.Floor(52.273));
            Console.WriteLine(Math.Max(52, 273));
            Console.WriteLine(Math.Min(52, 273));
            Console.WriteLine(Math.Round(52.273));
            Console.WriteLine(Math.PI);

            Hamburger nyam = new Hamburger();

            Product productA = new Product();
            productA.name = "포켓몬빵";
            productA.price = 1500;

            // 인스턴스 변수를 생성과 동시에 초기화(C# 고유 문법)
            Product productB = new Product() { name = "소금빵", price = 2000 };
            Product productC = new Product() { price = 5500, name = "당근케이크" };
            Product productD = new Product() { name = "보름달" };


            /*

            List<Student> students = new List<Student>();
            students.Add(new Student() { name = "조혜라", grade = 2 });
            students.Add(new Student() { name = "이민지", grade = 1 });
            students.Add(new Student() { name = "양지나", grade = 1 });
            students.Add(new Student() { name = "홍의서", grade = 3 });
            students.Add(new Student() { name = "김민서", grade = 4 });
            students.Add(new Student() { name = "김유리", grade = 2 });
            students.Add(new Student() { name = "오민경", grade = 6 });

            */

            List<Student> students = new List<Student>()
            {
             new Student() { name = "조혜라", grade = 2 },
             new Student() { name = "이민지", grade = 1 },
             new Student() { name = "양지나", grade = 1 },
             new Student() { name = "홍의서", grade = 3 },
             new Student() { name = "김민서", grade = 4 },
             new Student() { name = "김유리", grade = 2 },
             new Student() { name = "오민경", grade = 6 },
        };

            /*

            foreach (var item in students)
            {
                if(item.grade > 2)
                {
                    students.Remove(item);
                }

                Console.WriteLine(item);
            }

            */

            for(int i = students.Count - 1; i >= 0; i--)
            {
                if(students[i].grade > 2)
                {
                    students.RemoveAt(i);
                }
            }


            Method method = new Method();
            Console.WriteLine(method.Multi(52.1, 273));
            Console.WriteLine(method.Sum(1, 100));
            Console.WriteLine(method.Multiply(1, 10));

        }


    }
}
