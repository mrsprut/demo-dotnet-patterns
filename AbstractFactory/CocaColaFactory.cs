using System;

namespace AbstractFactory
{
    class CocaColaFactory : AbstractFactory
    {
        // реализация метода порождения экземпляра класса AbstractWater:
        // вернуть экземпляр дочернего класса CocaColaWater
        public override AbstractWater CreateWater()
        {
            return new CocaColaWater();
        }

        // реализация метода порождения экземпляра класса AbstractBottle:
        // вернуть экземпляр дочернего класса CocaColaBottle
        public override AbstractBottle CreateBottle()
        {
            return new CocaColaBottle();
        }
    }
}
