using AnimalTest.Contracts.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalTest.Contracts.Interface;

namespace AnimalTest.Contracts.Object
{
    internal class Cat : Animal, ILand
    {
        internal Cat(int mood = 0) : base(true, true, mood)
        {

        }

        public int GetNumberOfLegs()
        {
            return 4;
        }

        internal override void SayHello()
        {
            switch (_mood)
            {
                case 1:
                    Console.WriteLine("Purr");
                    break;
                case 2:
                    Console.WriteLine("Hiss");
                    break;
                default:
                    Console.WriteLine("Meow");
                    break;
            }
        }

        internal override void SayHello(int mood)
        {
            _mood = mood;
            SayHello();
        }
    }
}
