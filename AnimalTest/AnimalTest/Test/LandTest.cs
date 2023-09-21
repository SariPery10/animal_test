using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalTest.Contracts.Interface;
using AssertLibrary;

namespace AnimalTest.Test
{
    internal static class LandTest
    {
        internal static void GetNumberOfLegs(ILand land, int num)
        {
            Assert.IsEqual(land.GetNumberOfLegs(), num);
        }

    }
}
