using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalTest.Contracts.Interface;

namespace AnimalTest.Contracts
{
    public class WaterType
    {
        private IWater _water;

        public WaterType(IWater water)
        {
            _water = water;
        }

       internal bool HasGills()
        {
            return _water.HasGills();
        }

        internal bool HasLaysEggs()
        {
            return _water.HasLaysEggs();
        }

    }
}
