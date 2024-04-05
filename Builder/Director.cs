namespace Builder;
class Director
{
   public void BuildOrdinaryComputer(ComputerBuilder builder)
   {
      builder.AddProcessor("Baikal")
             .AddMemory(2)
             .AddGraphicCard("Gorenje")
             .AddMotherboard("Google")
             .AddCase("Lamborghini")
             .AddKeyboard("Aeroflot")
             .AddMouse("Mercedes")
             .AddScreen("Adidas");
   }
   public void BuildOrdinaryServer(ServerBuilder builder)
   {
      builder.AddProcessor("Elbrus")
             .AddMotherboard("Beeline")
             .AddCase("MacDonalds");
   }
}
