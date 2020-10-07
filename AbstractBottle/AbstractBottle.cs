namespace AbstractFactory
{
  public abstract class AbstractBottle
  {
    // заголовок метода взаимодействия любой бутылки
    // с любой водой
    public abstract void Interact(AbstractWater water);
  }
}