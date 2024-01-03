using DesignPatternCsharp.Criacao;


// Exemplo Factory Method
var factoryLogistic = new LogisticsSystem();
factoryLogistic.RoadLogistic().Deliver();
factoryLogistic.AirLogistic().Deliver();
factoryLogistic.WaterLogistic().Deliver();
