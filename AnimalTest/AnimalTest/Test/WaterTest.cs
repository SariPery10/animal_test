using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalTest.Contracts.Interface;
using AssertLibrary;

namespace AnimalTest.Test
{
    internal static class WaterTest
    {
        internal static void HasLaysEggs(IWater water, bool hasLaysEggs)
        {
            Assert.IsEqual(water.HasLaysEggs(), hasLaysEggs);
        }

        internal static void HasGills(IWater water, bool hasGills)
        {
            Assert.IsEqual(water.HasGills(), hasGills);
        }
    }
}
