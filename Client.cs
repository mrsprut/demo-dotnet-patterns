using System;

namespace AbstractFactory
{
    class Client
    {
        private AbstractWater water;
        private AbstractBottle bottle;
        // нужно явно вызвать конструктор класса-клиента
        // и передать ему один аргумент -
        // ссылку на экземпляр конкретного класса-наследника AbstractFactory
        public Client(AbstractFactory factory)
        {
            // получение от фабрики набора компонент,
            // которые гарантированно подходат для взаимодействия
            water = factory.CreateWater();
            bottle = factory.CreateBottle();
        }

        public void Run()
        {
            // вызов взаимодействия между объектами
            // бутылки и воды заранее неизвестных конкретных типов -
            // наследников абстрактной бутлки и абстрактной воды
            bottle.Interact(water);
        }
    }
}
