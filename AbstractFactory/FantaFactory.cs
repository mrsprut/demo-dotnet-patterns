using System;

namespace AbstractFactory
{
    class FantaFactory : AbstractFactory
    {
        public override AbstractWater CreateWater()
        {
            return new FantaWater();
        }

        public override AbstractBottle CreateBottle()
        {
            return new FantaBottle();
        }
    }
}
