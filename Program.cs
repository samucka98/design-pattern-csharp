using DesignPatternCsharp.Criacao;


// Exemplo Factory Method
var logisticsSystem = new LogisticsSystem();
var transport = logisticsSystem.CreateTransport(ETransportType.Air);
transport.Deliver();
