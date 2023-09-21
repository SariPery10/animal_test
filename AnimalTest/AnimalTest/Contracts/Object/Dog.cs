using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalTest.Contracts.Interface;

namespace AnimalTest.Contracts.Object
{
    internal class Dog : Animal, ILand
    {
        private bool _isWaggingTheirTails = false;
        internal Dog(int mood = 0) : base(true, true, mood)
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
                    Console.WriteLine("Bark loudly");
                    break;

                case 2:
                    Console.WriteLine("Whooping");
                    break;
                default:
                    _isWaggingTheirTails = true;
                    Console.WriteLine("Wagging their tails");
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
