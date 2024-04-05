using ChainOfResponsibility;
public class Program
{
   public static void Main()
   {
      Request request = new Request(Motherboard: true, Processor: false, GraphicCard: false, Case: false);

      Handler ServiceDesk = new MotherBoardHandler();
      ServiceDesk.Successor = new ProcessorHandler();
      ServiceDesk.Successor.Successor = new GraphicCardHandler();
      ServiceDesk.Successor.Successor.Successor = new CaseHandler();
      ServiceDesk.Successor.Successor.Successor.Successor = new ProcessorHandler();
      ServiceDesk.Successor.Successor.Successor.Successor.Successor = new ProcessorHandler();

      ServiceDesk.HandleRequest(request);
      if (request.GetRequestCondition())
         Console.WriteLine("Repair is done");
      else
         Console.WriteLine("Something went wrong");
   }
}
