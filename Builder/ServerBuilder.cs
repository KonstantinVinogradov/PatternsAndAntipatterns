namespace Builder;
class ServerBuilder : IComputerBuilder
{
   string? _Motherboard;
   string? _Processor;
   int    _Memory = 128;
   string? _Case;
   string? _OS;
   public IComputerBuilder AddCase(string Case)
   {
      _Case = Case;
      return this;
   }
   public IComputerBuilder AddMemory(int Memory)
   {
      _Memory = Memory > 128 ? Memory : 128;
      return this;
   }
   public IComputerBuilder AddMotherboard(string Motherboard)
   {
      _Motherboard = Motherboard;
      return this;
   }
   public IComputerBuilder AddProcessor(string Processor)
   {
      _Processor = Processor;
      return this;
   }
   public IComputerBuilder AddOS(string OS)
   {
      _OS = OS;
      return this;
   }
   public IComputerBuilder AddGraphicCard(string GraphicCard)
   {
      return this;
   }
   public IComputerBuilder AddKeyboard(string Keyboard)
   {
      return this;
   }
   public IComputerBuilder AddMouse(string Mouse)
   {
      return this;
   }
   public IComputerBuilder AddScreen(string Screen)
   {
      return this;
   }
   public Computer? Build()
   {
      if (_Motherboard is null || _Processor is null || _Memory <= 0)
         return null;
      return new Computer(_Motherboard, _Processor, _Memory, null, null, null, _Case, null, _OS);
   }
}
