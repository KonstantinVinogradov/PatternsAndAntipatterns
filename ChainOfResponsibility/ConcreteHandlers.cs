namespace ChainOfResponsibility;
class MotherBoardHandler : Handler
{
   public override void HandleRequest(Request request)
   {
      if (!request.MotherboardCondition)
      {
         // motherboard repair stuff
         Console.WriteLine("Motherboard repaired");
         request.MotherboardCondition = true;
      }
      if (request.GetRequestCondition())
         return;
      if (Successor is not null)
         Successor.HandleRequest(request);
   }
}
class ProcessorHandler : Handler
{
   public override void HandleRequest(Request request)
   {
      if (!request.ProcessorCondition)
      {
         // processor repair stuff
         Console.WriteLine("Processor repaired");
         request.ProcessorCondition = true;
      }
      if (request.GetRequestCondition())
         return;
      if (Successor is not null)
         Successor.HandleRequest(request);
   }
}
class GraphicCardHandler : Handler
{
   public override void HandleRequest(Request request)
   {
      if (!request.GraphicsCardCondition)
      {
         // graphicCard repair stuff
         Console.WriteLine("GraphicCard repaired");
         request.GraphicsCardCondition = true;
      }
      if (request.GetRequestCondition())
         return;
      if (Successor is not null)
         Successor.HandleRequest(request);
   }
}
class CaseHandler : Handler
{
   public override void HandleRequest(Request request)
   {
      if (!request.CaseCondition)
      {
         // case repair stuff
         Console.WriteLine("Case repaired");
         request.CaseCondition = true;
      }
      if (request.GetRequestCondition())
         return;
      if (Successor is not null)
         Successor.HandleRequest(request);
   }
}
