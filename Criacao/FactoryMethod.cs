namespace DesignPatternCsharp.Criacao
{

  public enum ETransportType
  {
    Air = 1,
    Water = 2,
    Land = 3
  }

  // Interface dos produtos
  public interface ITransport
  {
    void Deliver();
  }

  // Implementacao das classes concretas
  public class AirTransport : ITransport
  {
    public void Deliver()
    {
      Console.WriteLine("A entrega sera feita via: Ar!");
    }
  }

  public class WaterTransport : ITransport
  {
    public void Deliver()
    {
      Console.WriteLine("A entrega sera feita via: Agua!");
    }
  }

  public class LandTransport : ITransport
  {
    public void Deliver()
    {
      Console.WriteLine("A entrega sera feita via: Terra!");
    }
  }

  // Factory Method (Criador)
  public class LogisticsSystem
  {
    public ITransport CreateTransport(ETransportType transportType)
    {
      switch (transportType)
      {
        case ETransportType.Air:
          return new AirTransport();
        case ETransportType.Water:
          return new WaterTransport();
        case ETransportType.Land:
          return new LandTransport();
        default:
          throw new ArgumentException("Tipo de veiculo invalido");
      }
    }
  }
}