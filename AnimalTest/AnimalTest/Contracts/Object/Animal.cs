using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalTest.Contracts.Object
{
    internal abstract class Animal
    {
        private bool _carnivorous { get; set; }

        private bool _mammalian { get; set; }

        protected int _mood;
        protected Animal(bool carnivorous, bool mammalian, int mood)
        {
            _carnivorous = carnivorous;
            _mammalian = mammalian;
            _mood = mood;
        }

        internal abstract void SayHello();
        internal abstract void SayHello(int mood);

        internal bool IsMammalian()
        {
            return this._mammalian;
        }

        internal void SetMammalian(bool isMammalian)
        {
            this._mammalian = isMammalian;
        }

        internal bool IsCarnivorous()
        {
            return this._carnivorous;
        }

        internal void SetCarnivorous(bool isCarnivorous)
        {
            this._carnivorous = isCarnivorous;
        }
    }
}
