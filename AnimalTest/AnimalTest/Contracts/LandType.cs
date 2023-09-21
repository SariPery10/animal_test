using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalTest.Contracts.Interface;

namespace AnimalTest.Contracts
{
    internal class LandType
    {
        private ILand _land;

        public LandType(ILand land)
        {
            _land = land;
        }

        internal int GetNumberOfLegs()
        {
            return _land.GetNumberOfLegs();
        }

    }
}
