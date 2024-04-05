namespace Builder;
class ComputerBuilder : IComputerBuilder
{
   string? _Motherboard;
   string? _Processor;
   int _Memory = 0;
   string? _GraphicsCard;
   string? _Keyboard;
   string? _Mouse;
   string? _Case;
   string? _Screen;
   string? _OS;
   public IComputerBuilder AddCase(string Case)
   {
      _Case = Case;
      return this;
   }

   public IComputerBuilder AddGraphicCard(string GraphicCard)
   {
      _GraphicsCard = GraphicCard;
      return this;
   }

   public IComputerBuilder AddKeyboard(string Keyboard)
   {
      _Keyboard = Keyboard;
      return this;
   }

   public IComputerBuilder AddMemory(int Memory)
   {
      _Memory = Memory;
      return this;
   }

   public IComputerBuilder AddMotherboard(string Motherboard)
   {
      _Motherboard = Motherboard;
      return this;
   }

   public IComputerBuilder AddMouse(string Mouse)
   {
      _Mouse = Mouse;
      return this;
   }

   public IComputerBuilder AddOS(string OS)
   {
      _OS = OS;
      return this;
   }

   public IComputerBuilder AddProcessor(string Processor)
   {
      _Processor = Processor;
      return this;
   }

   public IComputerBuilder AddScreen(string Screen)
   {
      _Screen = Screen;
      return this;
   }

   public Computer? Build()
   {
      if (_Motherboard == null || _Processor == null || _Memory <= 0)
         return null;
      return new Computer(_Motherboard, _Processor, _Memory, _GraphicsCard, _Keyboard, _Mouse, _Case, _Screen, _OS);
   }
}