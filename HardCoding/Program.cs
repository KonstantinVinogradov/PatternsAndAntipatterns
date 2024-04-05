public class Program
{

   //   {0, "WellsPPPinj.txt" },
   //   {1, "WellsPPPprod.txt" },
   //   {2, "WWW_mix_prod.txt" },
   //   {3, "WWW_mix_inj.txt" }

   static readonly int kolWell = 1000;
   static readonly int kolphase = 3;
   static double[,] Data_prod = new double[kolWell, kolphase];
   static double[,] Data_inj = new double[kolWell, kolphase];
   static readonly Random R = new Random();
   static void ObtainData(uint Well)
   {
      for (uint iPhase = 0; iPhase < kolphase; iPhase++)
      {
         //Oil extraction stuff
         Data_prod[Well, iPhase] = Math.Abs(R.NextDouble());
         Data_inj[Well, iPhase] = Math.Abs(R.NextDouble());
      }
      return;
   }
   static void SafeData(int type)
   {
      if (type == 0)
      {
         double[] WellTotal = new double[kolphase];
         for (uint iWell = 0; iWell < kolWell; iWell++)
            for (uint iPhase = 0; iPhase < kolphase; iPhase++)
               WellTotal[iWell] = Data_inj[iWell, iPhase];
         for (uint iPhase = 0; iPhase < kolphase; iPhase++)
            using (StreamWriter writer = new StreamWriter("C:\\Users\\User\\Documents\\Wells" + iPhase.ToString() + "inj.txt"))
               writer.Write(WellTotal[iPhase].ToString() + "\n");
         return;
      }
      if (type == 1)
      {
         double[] WellTotal = new double[kolphase];
         for (uint iWell = 0; iWell < kolWell; iWell++)
            for (uint iPhase = 0; iPhase < kolphase; iPhase++)
               WellTotal[iWell] = Data_prod[iWell, iPhase];
         for (uint iPhase = 0; iPhase < kolphase; iPhase++)
            using (StreamWriter writer = new StreamWriter("C:\\Users\\User\\Documents\\Wells" + iPhase.ToString() + "prod.txt"))
               writer.Write(WellTotal[iPhase].ToString() + "\n");
         return;
      }
      if (type == 2)
      {
         double[] WellMix = Enumerable.Range(0, kolWell).Select(i => 0.0).ToArray();
         for (uint iWell = 0; iWell < kolWell; iWell++)
            for (uint iPhase = 0; iPhase < kolphase; iPhase++)
               WellMix[iWell] += Data_prod[iWell, iPhase];
         for (uint iWell = 0; iWell < kolphase; iWell++)
            using (StreamWriter writer = new StreamWriter("C:\\Users\\User\\Documents\\" + iWell.ToString() + "_mix_prod.txt"))
               writer.Write(WellMix[iWell].ToString() + "\n");
         return;
      }
      if (type == 3)
      {
         double[] WellMix = Enumerable.Range(0, kolWell).Select(i => 0.0).ToArray();
         for (uint iWell = 0; iWell < kolWell; iWell++)
            for (uint iPhase = 0; iPhase < kolphase; iPhase++)
               WellMix[iWell] += Data_inj[iWell, iPhase];
         for (uint iWell = 0; iWell < kolphase; iWell++)
            using (StreamWriter writer = new StreamWriter("C:\\Users\\User\\Documents\\" + iWell.ToString() + "_mix_inj.txt"))
               writer.Write(WellMix[iWell].ToString() + "\n");
         return;
      }
   }
   public static void Main()
   {
      for (uint iWell = 0; iWell < kolWell; iWell++)
         ObtainData(iWell);

      SafeData(0);
      SafeData(2);
      SafeData(3);
      return;
   }
}
