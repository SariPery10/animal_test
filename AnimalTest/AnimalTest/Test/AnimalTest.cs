using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalTest.Contracts.Object;
using AssertLibrary;

namespace AnimalTest.Test
{
    internal class AnimalTest
    {
        internal static void AnimalWithMood_ChangeMood_ValidatePrintSuccess(Animal animal, int changeMood)
        {
            //print mood
            animal.SayHello();
            //change mood and print
            animal.SayHello(changeMood);
        }

        internal static void AnimalIsCarnivorous_SetCarnivorous_ValidateIsCarnivorous(Animal animal, bool isCarnivorous, bool setCarnivorous)
        {
            ;
            Assert.IsEqual(animal.IsCarnivorous(), isCarnivorous);
            animal.SetCarnivorous(setCarnivorous);
            Assert.IsEqual(animal.IsCarnivorous(), setCarnivorous);
        }

        internal static void AnimalIsMammalian_SetMammalian_ValidateIsMammalian(Animal animal, bool isMammalian, bool setMammalian)
        {
            ;
            Assert.IsEqual(animal.IsMammalian(), isMammalian);
            animal.SetMammalian(setMammalian);
            Assert.IsEqual(animal.IsMammalian(), setMammalian);

        }
    }
}
