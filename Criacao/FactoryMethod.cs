namespace DesignPatternCsharp.Criacao
{

  // Interface dos produtos
  public interface ITransport
  {
    void Deliver();
  }

  // Implementacao das classes concretas (Produtos)
  public class Airplane : ITransport
  {
    public void Deliver()
    {
      Console.WriteLine("A entrega sera feita via: Ar!");
    }
  }

  public class Ship : ITransport
  {
    public void Deliver()
    {
      Console.WriteLine("A entrega sera feita via: Agua!");
    }
  }

  public class Truck : ITransport
  {
    public void Deliver()
    {
      Console.WriteLine("A entrega sera feita via: Terra!");
    }
  }

  // Factory Method (Criador)
  public class LogisticsSystem
  {
    public ITransport RoadLogistic()
    {
     return new Truck();
    }
	
	   public ITransport WaterLogistic() {
	      return new Ship();
	   }
	
	   public ITransport AirLogistic() {
       return new Airplane();}
    }
  }
}