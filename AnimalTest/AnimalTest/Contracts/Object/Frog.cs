using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalTest.Contracts.Interface;

namespace AnimalTest.Contracts.Object
{
    internal class Frog : Animal, ILand, IWater
    {
        internal bool isInWater = false;
        public Frog(int mood = 0) : base(false, false, mood)
        {

        }
        public int GetNumberOfLegs()
        {
            return 4;
        }

        public bool HasGills()
        {
            return false;
        }

        public bool HasLaysEggs()
        {
            return true;
        }

        internal override void SayHello()
        {
            switch (_mood)
            {
                case 1:
                    Console.WriteLine("Quack quack quack");
                    isInWater = false;
                    break;
                case 2:
                    isInWater = true;
                    Console.WriteLine("Plop into the water");
                    break;
                default:
                    Console.WriteLine("Does not do anything");
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
