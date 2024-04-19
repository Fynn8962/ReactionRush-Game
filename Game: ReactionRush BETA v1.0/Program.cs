using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace LP4_PressTheButtons
{
    internal class Program
    {

        static bool repeat;
        static int score = 0;
        static int highScore;
        static string highScoreText;
        static bool gameOver = false;
        static string difficulty;
        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            bool startGame = false;
            bool stopGame = false;

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write("\n  ~ReactionRush~  ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine(" BETA v1.0  ");
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
                    highScoreText = File.ReadAllText("highscore.txt");
                    Console.CursorVisible = false;

                    Console.Clear();
                    
                    Console.WriteLine("\nDifficulty options:\n " +
                             "2000ms..Easy.....[6]\n " +
                             "1500ms..Medium...[7]\n " +
                             "1000ms..Hard.....[8]\n " +
                             "500ms...Extreme..[9]");

                    Console.WriteLine("\nStats:");
                    Console.ForegroundColor= ConsoleColor.DarkYellow;
                    Console.WriteLine(" High Score: " + highScoreText);
                    Console.ResetColor();
                    Nullable<TimeSpan> reactionSpeed = null;
                    difficulty = "";
                    while (reactionSpeed == null)
                    {
                        switch (Console.ReadKey(true).Key)
                        {
                            case ConsoleKey.D6: reactionSpeed = TimeSpan.FromMilliseconds(2000); difficulty = "Mode: Easy"; break;
                            case ConsoleKey.D7: reactionSpeed = TimeSpan.FromMilliseconds(1500); difficulty = "Mode: Medium";  break;
                            case ConsoleKey.D8: reactionSpeed = TimeSpan.FromMilliseconds(1000); difficulty = "Mode: Hard";  break;
                            case ConsoleKey.D9: reactionSpeed = TimeSpan.FromMilliseconds(500); difficulty = "Mode: Extreme";  break; 
                        }
                    }

                    Console.Clear();
                    switch(difficulty)
                    {
                        case "Mode: Easy": Console.ForegroundColor = ConsoleColor.DarkGreen; break;
                        case "Mode: Medium": Console.ForegroundColor = ConsoleColor.Yellow; break;
                        case "Mode: Hard": Console.ForegroundColor = ConsoleColor.Red; break;
                        case "Mode: Extreme": Console.ForegroundColor = ConsoleColor.DarkRed; break;
                    }
                    

                    Console.WriteLine(difficulty);
                    Console.ResetColor();
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
                    
                    Stopwatch stopwatch = new();


                    while (gameOver == false)
                    {
                        score++;
                        Random button = new Random();
                        int number = button.Next(1, 5);
                        string center = number.ToString();

                        int screenWidth = Console.WindowWidth;
                        int stringWidth = center.Length;
                        int centering = (screenWidth - stringWidth) / 2;

                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("\n\n\n" + center.PadLeft(centering + stringWidth));
                        Console.ResetColor();

                        stopwatch.Restart();

                        ConsoleKeyInfo KeyInfo;
                        KeyInfo = Console.ReadKey(true);

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
            Console.Clear();

            int finalscore = score - 1;
            
            
            
            
            switch (difficulty)
            {
                case "Mode: Easy": Console.ForegroundColor = ConsoleColor.DarkGreen; break;
                case "Mode: Medium": Console.ForegroundColor = ConsoleColor.Yellow; break;
                case "Mode: Hard": Console.ForegroundColor = ConsoleColor.Red; break;
                case "Mode: Extreme": Console.ForegroundColor = ConsoleColor.DarkRed; break;
            }
            Console.WriteLine(difficulty+ "\n");
            Console.ResetColor();
            if (finalscore > highScore)
            {
                highScore = finalscore;
                File.WriteAllText("highscore.txt", highScore.ToString());
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("   New highscore!   ");
                Console.ResetColor();
            }
            Console.ForegroundColor = ConsoleColor.DarkYellow;
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
