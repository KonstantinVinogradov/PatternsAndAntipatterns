class Computer
{
   public string Motherboard { get; private set; }
   public string Processor { get; private set; }
   public int Memory { get; private set; }
   public string? GraphicsCard { get; private set; }
   public string? Keyboard { get; private set; }
   public string? Mouse { get; private set; }
   public string? Case { get; private set; }
   public string? Screen { get; private set; }
   public string? OS { get; private set; }

   public Computer(string motherboard, string processor, int memory, string? graphicsCard, string? keyboard, string? mouse, string? @case, string? screen, string? os)
   {
      Motherboard = motherboard;
      Processor = processor;
      Memory = memory;
      GraphicsCard = graphicsCard;
      Keyboard = keyboard;
      Mouse = mouse;
      Case = @case;
      Screen = screen;
      OS = os;
   }

   public override string ToString()
   {
      return "Motherboard: " + Motherboard + "\nProcessor: " + Processor +
         "\nMemory: " + Memory.ToString() + "\nGraphicCard: " + GraphicsCard +
         "\nKeyBoard: " + Keyboard + "\nMouse: " + Mouse + "\nCase " + Case + 
         "\nScreen: " + Screen + "\nOS: "+OS+"\n";
   }
}
