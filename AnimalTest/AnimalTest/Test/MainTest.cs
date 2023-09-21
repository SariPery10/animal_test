using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AnimalTest.Contracts;
using AnimalTest.Contracts.Enum;
using AnimalTest.Contracts.Interface;
using AnimalTest.Contracts.Object;
using AssertLibrary;
using Microsoft.Extensions.DependencyInjection;

namespace AnimalTest.Test
{
    public class MainTest
    {
        //I would open a unit test project and add a data row,
        // But according to the requirement you should use Main(string[] args)
        static void Main(string[] args)
        {
            Animal cat = new Cat();
            Animal dog = new Dog();
            Animal frog = new Frog();
            //test 1
            AnimalTest.AnimalWithMood_ChangeMood_ValidatePrintSuccess(dog, (int)Mood.Happy);
            AnimalTest.AnimalWithMood_ChangeMood_ValidatePrintSuccess(cat, (int)Mood.Happy);
            AnimalTest.AnimalWithMood_ChangeMood_ValidatePrintSuccess(frog, (int)Mood.Happy);

            //test 2
            AnimalTest.AnimalWithMood_ChangeMood_ValidatePrintSuccess(dog, (int)Mood.Scared);
            AnimalTest.AnimalWithMood_ChangeMood_ValidatePrintSuccess(cat, (int)Mood.Scared);
            AnimalTest.AnimalWithMood_ChangeMood_ValidatePrintSuccess(frog,(int)Mood.Scared);
            ////test 3
            AnimalTest.AnimalWithMood_ChangeMood_ValidatePrintSuccess(dog, (int)Mood.Normal);
            AnimalTest.AnimalWithMood_ChangeMood_ValidatePrintSuccess(cat, (int)Mood.Normal);
            AnimalTest.AnimalWithMood_ChangeMood_ValidatePrintSuccess(frog, (int)Mood.Normal);
            //test 4
            AnimalTest.AnimalIsCarnivorous_SetCarnivorous_ValidateIsCarnivorous(cat, true, false);
            AnimalTest.AnimalIsCarnivorous_SetCarnivorous_ValidateIsCarnivorous(dog, true, false);
            AnimalTest.AnimalIsCarnivorous_SetCarnivorous_ValidateIsCarnivorous(frog, false, true);
            //test 5
            AnimalTest.AnimalIsMammalian_SetMammalian_ValidateIsMammalian(cat, true, false);
            AnimalTest.AnimalIsMammalian_SetMammalian_ValidateIsMammalian(dog, true, false);
            AnimalTest.AnimalIsMammalian_SetMammalian_ValidateIsMammalian(frog, false, true);
           
            ILand catLegs = new Cat();
            LandTest.GetNumberOfLegs(catLegs, 4);

            ILand DogLand = new Dog();
            LandTest.GetNumberOfLegs(DogLand, 4);

            ILand frogLand = new Cat();
            LandTest.GetNumberOfLegs(frogLand, 4);

            IWater frogWater = new Frog();
            WaterTest.HasGills(frogWater, false);
            WaterTest.HasLaysEggs(frogWater, true);
        }
    }
}
