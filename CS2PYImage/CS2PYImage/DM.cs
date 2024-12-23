using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS2PYImage
{
    internal class DM
    {
        public class Human // System.Text.Json 似乎不支持私有属性序列化
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public List<Dog> Dogs { get; set; }

            public class Dog
            {
                public string Color { get; set; }

                public Dog(string color)
                {
                    Color = color;
                }
            }

            public Human(string name, int age)
            {
                Name = name;
                Age = age;
                Dogs = new List<Dog>();
            }

            public void AddDog(string color)
            {
                Dogs.Add(new Dog(color));
            }
        }
    }
}
