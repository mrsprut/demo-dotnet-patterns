using System;

namespace AbstractFactory
{
    class CocaColaBottle : AbstractBottle
    {
        // реализация абстрактного метода взаимодействия
        // бутылки с водой
        public override void Interact(AbstractWater water)
        {
            Console.WriteLine(this + " interacts with " + water);
        }
    }
}
