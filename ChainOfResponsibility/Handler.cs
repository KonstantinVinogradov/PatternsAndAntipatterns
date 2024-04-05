namespace ChainOfResponsibility;
public class Request
{
   public bool MotherboardCondition { get; set; }
   public bool ProcessorCondition { get; set; }
   public bool GraphicsCardCondition { get; set; }
   public bool CaseCondition { get; set; }

   public bool GetRequestCondition() => MotherboardCondition && ProcessorCondition &&
                                        GraphicsCardCondition && CaseCondition;
   public Request(bool Motherboard, bool Processor, bool GraphicCard, bool Case)
   {
      MotherboardCondition = Motherboard;
      ProcessorCondition = Processor;
      GraphicsCardCondition = GraphicCard;
      CaseCondition = Case;
   }
}
abstract class Handler
{
   public Handler? Successor { get; set; }
   public abstract void HandleRequest(Request request);
}
