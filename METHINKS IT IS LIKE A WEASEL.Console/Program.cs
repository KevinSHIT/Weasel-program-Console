using System;
using static System.Console;

namespace METHINKS_IT_IS_LIKE_A_WEASEL.Console
{
    class Program
    {
        static public string defaultStr = "METHINKS IT IS LIKE A WEASEL";
        static private string[] storageStr; // Storage Str
        static private int step, targetMark, thisMark, maxMark = new int();
        static private string targetStr = null;

        static private void info()
        {
            Clear();
            WriteLine("METHINKS IT IS LIKE A WEASEL.Console");
            WriteLine("Author: Kucashu");
            WriteLine("Language: C# with dotNet 4.5\r\n\r\n");
    }
        static void Main(string[] args)
        {
            info();
            WriteLine("This is a simulator to simulate \"Infinite monkey theorem\"\r\n");
            ForegroundColor = ConsoleColor.Blue;
            Write("Richard Dawkins \"The Blind Watchmaker\"");
            ForegroundColor = ConsoleColor.Gray;
            WriteLine(": I don't know who it was first pointed out that, given enough time, amonkeybashing away atrandomon atypewritercould produce all the works ofShakespeare. The operative phrase is, of course, given enough time. Let us limit the task facing our monkey somewhat. Suppose that he has to produce, not the complete works of Shakespeare but just the short sentence 'Methinks it is like aweasel', and we shall make it relatively easy by giving him a typewriter with a restricted keyboard, one with just the 26 (capital) letters, and a space bar. How long will he take to write this one little sentence?");
            WriteLine("");
            WriteLine("Press any key to start to simulate...");
            ReadKey();
            info();
            targetStr = defaultStr;
            targetMark = targetStr.Length;
            storageStr = new string[105];
            storageStr[0] = GeneralRandomString(targetMark);
            WriteLine("storageStr                    " +
                              "targetStr                     thisMark targetMark");
            do
            {
                InitializeStorage(100);
                for (int loop = 1; loop <= 100; loop++)
                {

                    if (MatchMark(storageStr[loop], targetStr) > thisMark)
                    {
                        thisMark = MatchMark(storageStr[loop], targetStr);
                        storageStr[0] = storageStr[loop];
                    }
                }
                step += 1;
                if (thisMark < 10)
                    WriteLine($"{storageStr[0]}  {targetStr}  0{thisMark}       {targetMark}");
                else
                    WriteLine($"{storageStr[0]}  {targetStr}  {thisMark}       {targetMark}");
                //Debug.WriteLine($"{step},{thisMark},{targetMark}");
            } while (thisMark < targetMark);
            //MessageBox.Show(step.ToString());
            ForegroundColor = ConsoleColor.Green;
            WriteLine($"Final steps: {step}");
            ForegroundColor = ConsoleColor.Gray;
            WriteLine("Press any key to exit...");
            ReadKey();
            //storageStr = new string[105];
        }

        static public Random Random = new Random(); // New a new random object

        static private string GeneralRandomString(int Number)
        {
            string str = null;
            for (int loop = 0; loop < Number; loop++)
            {
                str += GeneralRandomChar();
            }
            return str;
        }

        static private char GeneralRandomChar()
        {
            //Random Random = new Random();
            switch (Random.Next(0, 27))
            {
                case 0:
                    return ' ';
                case 1:
                    return 'A';
                case 2:
                    return 'B';
                case 3:
                    return 'C';
                case 4:
                    return 'D';
                case 5:
                    return 'E';
                case 6:
                    return 'F';
                case 7:
                    return 'G';
                case 8:
                    return 'H';
                case 9:
                    return 'I';
                case 10:
                    return 'J';
                case 11:
                    return 'K';
                case 12:
                    return 'L';
                case 13:
                    return 'M';
                case 14:
                    return 'N';
                case 15:
                    return 'O';
                case 16:
                    return 'P';
                case 17:
                    return 'Q';
                case 18:
                    return 'R';
                case 19:
                    return 'S';
                case 20:
                    return 'T';
                case 21:
                    return 'U';
                case 22:
                    return 'V';
                case 23:
                    return 'W';
                case 24:
                    return 'X';
                case 25:
                    return 'Y';
                case 26:
                    return 'Z';
                default:
                    throw new Exception("Can't reach target char!");
            }

        }


        static private int MatchMark(string str1, string str2)
        {
            int matchMark = new int();
            char[] char1 = str1.ToCharArray();
            char[] char2 = str2.ToCharArray();
            for (int loop = 0; loop < str1.Length; loop++)
            {
                if (char1[loop] == char2[loop])
                    matchMark += 1;
            }
            return matchMark;
        }

        static private bool NeedChange(int num1, int num2)
        {
            //Random Random = new Random();
            if (Random.Next(0, num2) < num1)
            {
                //Debug.WriteLine($"TRUE!");
                return true;

            }
            else
                return false;
        }

        static private void InitializeStorage(int EndPoint)
        {
            for (int loop = 1; loop <= EndPoint; loop++)
            {
                storageStr[loop] = GeneralRandomedString(storageStr[0]);
            }
        }

        static private string GeneralRandomedString(string str)
        {
            char[] char1 = str.ToCharArray();
            for (int loop = 0; loop < char1.Length; loop++)
            {
                if (NeedChange(5, 100))
                    char1[loop] = GeneralRandomChar();
            }
            str = new string(char1);
            //Debug.WriteLine($"{str}");
            return str;
        }
    }
}
