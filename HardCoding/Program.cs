public static class StaticRandom
{
   static int seed = Environment.TickCount;

   static readonly ThreadLocal<Random> random =
       new ThreadLocal<Random>(() => new Random(Interlocked.Increment(ref seed)));

   static double Maximum { get; set; } = 10000.0;
   static double Minimum { get; set; } = 0.0;

   public static double Rand()
   {
      Random? rnd = random.Value;

      if (rnd is not null)
         return rnd.NextDouble() * (Maximum - Minimum) + Minimum;
      else
         return 0;
   }
}

public class Program
{

   //   {0, "WellsPPPinj.txt" },
   //   {1, "WellsPPPprod.txt" },
   //   {2, "WWW_mix_prod.txt" },
   //   {3, "WWW_mix_inj.txt" }

   static readonly int kolWell = 1000;
   static readonly int kolPhase = 3;
   static double[,] DataProd = new double[kolWell, kolPhase];
   static double[,] DataInj = new double[kolWell, kolPhase];
   static void ObtainData(uint Well)
   {
      for (uint iPhase = 0; iPhase < kolPhase; iPhase++)
      {
         //Oil extraction stuff
         DataProd[Well, iPhase] = Math.Abs(StaticRandom.Rand());
         DataInj[Well, iPhase] = Math.Abs(StaticRandom.Rand());
      }
      return;
   }
   static void SaveData(int type)
   {
      if (type == 0)
      {
         double[] WellTotal = new double[kolPhase];
         for (uint iWell = 0; iWell < kolWell; iWell++)
            for (uint iPhase = 0; iPhase < kolPhase; iPhase++)
               WellTotal[iWell] = DataInj[iWell, iPhase];
         for (uint iPhase = 0; iPhase < kolPhase; iPhase++)
            using (StreamWriter writer = new StreamWriter("C:\\Users\\User\\Documents\\Wells" + iPhase.ToString() + "inj.txt"))
               writer.Write(WellTotal[iPhase].ToString() + "\n");
         return;
      }
      if (type == 1)
      {
         double[] WellTotal = new double[kolPhase];
         for (uint iWell = 0; iWell < kolWell; iWell++)
            for (uint iPhase = 0; iPhase < kolPhase; iPhase++)
               WellTotal[iWell] = DataProd[iWell, iPhase];
         for (uint iPhase = 0; iPhase < kolPhase; iPhase++)
            using (StreamWriter writer = new StreamWriter("C:\\Users\\User\\Documents\\Wells" + iPhase.ToString() + "prod.txt"))
               writer.Write(WellTotal[iPhase].ToString() + "\n");
         return;
      }
      if (type == 2)
      {
         double[] WellMix = Enumerable.Range(0, kolWell).Select(i => 0.0).ToArray();
         for (uint iWell = 0; iWell < kolWell; iWell++)
            for (uint iPhase = 0; iPhase < kolPhase; iPhase++)
               WellMix[iWell] += DataProd[iWell, iPhase];
         for (uint iWell = 0; iWell < kolPhase; iWell++)
            using (StreamWriter writer = new StreamWriter("C:\\Users\\User\\Documents\\" + iWell.ToString() + "_mix_prod.txt"))
               writer.Write(WellMix[iWell].ToString() + "\n");
         return;
      }
      if (type == 3)
      {
         double[] WellMix = Enumerable.Range(0, kolWell).Select(i => 0.0).ToArray();
         for (uint iWell = 0; iWell < kolWell; iWell++)
            for (uint iPhase = 0; iPhase < kolPhase; iPhase++)
               WellMix[iWell] += DataInj[iWell, iPhase];
         for (uint iWell = 0; iWell < kolPhase; iWell++)
            using (StreamWriter writer = new StreamWriter("C:\\Users\\User\\Documents\\" + iWell.ToString() + "_mix_inj.txt"))
               writer.Write(WellMix[iWell].ToString() + "\n");
         return;
      }
   }
   public static void Main()
   {
      for (uint iWell = 0; iWell < kolWell; iWell++)
         ObtainData(iWell);

      SaveData(0);
      SaveData(2);
      SaveData(3);
      return;
   }
}
