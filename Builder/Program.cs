namespace Builder;
public class Program
{
   public static void Main()
   {
      ComputerBuilder GameComputerBuilder = new ComputerBuilder();
      Computer? GameComputer = GameComputerBuilder.AddMotherboard("Asus")
                              .AddProcessor("Intel")
                              .AddMemory(64)
                              .AddGraphicCard("GeForce")
                              .AddOS("Windows")
                              .AddScreen("Samsung")
                              .AddKeyboard("Varmilo")
                              .AddMouse("Razer")
                              .AddCase("BlackCase")
                              .Build();

      ServerBuilder OrdinaryServerBuilder = new();
      Director Store = new Director();
      Store.BuildOrdinaryServer(OrdinaryServerBuilder);
      Computer? OrdinaryServer = OrdinaryServerBuilder.Build();

      if (GameComputer is not null)
      {
         Console.WriteLine("GameComputer");
         Console.WriteLine(GameComputer.ToString());
      }
      if (OrdinaryServer is not null)
      {
         Console.WriteLine("OrdinaryServer");
         Console.WriteLine(OrdinaryServer.ToString());
      }
   }
}
