using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;

namespace LP4_PressTheButtons
{
    internal class Program
    {

        static bool repeat;
        static int score = 0;
        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            bool startGame = false;
            bool stopGame = false;

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("\n ReactionRush V1.0 ");
            Console.ResetColor();

            Console.WriteLine("\nstart game: Enter");
            Console.WriteLine("leave game: Escape");
        
            while (startGame == false && stopGame == false)
            {
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.Enter: startGame = true; break;
                    case ConsoleKey.Escape: stopGame = true; break;
                }
            }
            if (stopGame == true)
            {
                Endgame();
            }
            else
            {
                Game();
            }
            
        }

        private static void Game()
        {
            Console.Clear();

            try
            {
                repeat = false;
                while (!repeat)
                {
                    Console.CursorVisible = false;

                    


                    Console.Clear();
                    Console.WriteLine("\nDifficulty options:\n " +
                             "2000ms..Easy.....[6]\n " +
                             "1500ms..Medium...[7]\n " +
                             "1000ms..Hard.....[8]\n " +
                             "500ms...Extreme..[9]");
                    bool gameOver = false;

                    Nullable<TimeSpan> reactionSpeed = null;

                    while (reactionSpeed == null)
                    {
                        switch (Console.ReadKey(true).Key)
                        {
                            case ConsoleKey.D6: reactionSpeed = TimeSpan.FromMilliseconds(2000); break;
                            case ConsoleKey.D7: reactionSpeed = TimeSpan.FromMilliseconds(1500); break;
                            case ConsoleKey.D8: reactionSpeed = TimeSpan.FromMilliseconds(1000); break;
                            case ConsoleKey.D9: reactionSpeed = TimeSpan.FromMilliseconds(500); break;
                        }
                    }

                    Console.Clear();
                     
                    Stopwatch stopwatch = new();
                    
                    
                    for (int i = 3; i > 0; i--)
                    {
                        string centercountdown = i.ToString();
                        int screenWidth = Console.WindowWidth;
                        int stringWidth = centercountdown.Length;
                        int centering = (screenWidth - stringWidth) / 2;
                        Console.WriteLine(centercountdown.PadLeft(centering + stringWidth));
                        Thread.Sleep(1000);
                       
                    }

                    Console.Clear();

                    while (gameOver == false)
                    {

                        score++;
                        Random button = new Random();
                        int number = button.Next(1, 5);
                        string center = number.ToString();

                        int screenWidth = Console.WindowWidth;
                        int stringWidth = center.Length;
                        int centering = (screenWidth - stringWidth) / 2;

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\n\n\n" + center.PadLeft(centering + stringWidth));
                        Console.ResetColor();

                        stopwatch.Restart();

                        ConsoleKeyInfo KeyInfo = Console.ReadKey(true);
                        if (int.TryParse(KeyInfo.KeyChar.ToString(), out int keyPressed) && keyPressed == number && stopwatch.Elapsed < reactionSpeed)
                        {

                            gameOver = false;
                            Console.Clear();

                        }
                        else
                        {
                            Console.Clear();
                            string centergameover = "GAME OVER";
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\n\n" + centergameover.PadLeft(centering + stringWidth));
                            Console.ResetColor();
                            Thread.Sleep(750);
                            Restart();
                        }


                    }
                }
            }
            catch
            {
                Console.WriteLine("Error");
                Thread.Sleep(750);
                Endgame();
            }
        }

        private static void Restart()
        {
            int finalscore = score - 1;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nScore: " + finalscore + "\n");
            Console.ResetColor();
            score = 0;
            finalscore = 0;
            Console.WriteLine("\n-------------------\nRestart? yes [Enter]\n \t no  [Escape]\n-------------------");

            string retry = "yes";
            do
            {
                switch (Console.ReadKey(true).Key)

                {
                    case ConsoleKey.Enter:
                        retry = "no";
                        Game();
                        break;
                    case ConsoleKey.Escape:
                        retry = "no";
                        Endgame();
                        break;


                }
            }
            while (retry == "yes");
        }

        private static void Endgame()
        {
            Console.Clear();
            Console.WriteLine("closing...");
            repeat = true;
            Thread.Sleep(750);
            Environment.Exit(0);

        }

    }
}
