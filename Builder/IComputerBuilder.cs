namespace Builder;
interface IComputerBuilder
{
   IComputerBuilder AddMotherboard(string Motherboard);
   IComputerBuilder AddProcessor(string Processor);
   IComputerBuilder AddMemory(int Memory);
   IComputerBuilder AddGraphicCard(string GraphicCard);
   IComputerBuilder AddKeyboard(string Keyboard);
   IComputerBuilder AddMouse(string Mouse);
   IComputerBuilder AddCase(string Case);
   IComputerBuilder AddScreen(string Screen);
   IComputerBuilder AddOS(string OS);
   Computer? Build();
}
