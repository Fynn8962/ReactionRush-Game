namespace LP4_übungDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {

                // Erstellen des Dictionary
                Dictionary<int, string> Modell992 = new Dictionary<int, string>
                {
                    {1, "GT3" },
                    {2, "GT3 RS" },
                    {3, "Dakar" },
                    {4, "S/T" },
                    {5, "Sport Classic" },
                    {6, "Turbo" },
                    {7, "Turbo S" },
                };

                Dictionary<int, int> Modell992_PS = new Dictionary<int, int>
                {
                    {1, 510},
                    {2, 525},
                    {3, 480},
                    {4, 525},
                    {5, 550},
                    {6, 580},
                    {7, 650},
                    {8, 385},
                };

                // Hinzufügen eines Wertes
                Modell992.Add(8, "Carrera");
                
                 // Alle Werte ausgeben mit dazugehörigem key
                foreach (KeyValuePair<int, string> Modell in Modell992)
                {
                    Console.WriteLine($"{Modell.Value} - {Modell.Key}");
                };

                foreach (KeyValuePair<int, int> Modell_PS in Modell992_PS)
                {
                    Console.WriteLine($"{Modell_PS.Value} - {Modell_PS.Key}");
                };

                Console.WriteLine("\n");

                // Alle Werte aus den zwei Dicitonary ausgeben und die passenden Schlüsselwerte kombiniert aufschreiben.
                foreach(int key in Modell992.Keys)
                {
                    if (Modell992_PS.ContainsKey(key))
                    {
                        Console.WriteLine("Porsche911 " + $"{Modell992[key]} -> {Modell992_PS[key]}" + "PS");
                    }
                }
            }
            catch
            {
                // Wenn in einem Dictionary ein key doppelt verwendet wird, erscheint diese Fehlermeldung
                Console.WriteLine("a key is used twice");
            }
          





            
        }
    }
}
