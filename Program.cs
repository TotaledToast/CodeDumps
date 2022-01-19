using System;
using System.Linq;
using System.Collections.Generic;

namespace Kaprekar_s_Constant
{
    class Program
    {
        static void Main(string[] args)
        {
            CallAnagramInString();
            
        }
        static void CallKaprekarsConstant()
        {
            methods Test = new methods();
            int input;
            Console.WriteLine("Enter your 4 digit number with at least 2 different digits");
            input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Test.KaprekarsConstant(input));
        }
        static void CallFindVertex()
        {
            methods Test = new methods();
            int a, b, c;
            Console.WriteLine("An example equation is y = ax^2 + bx + x");
            Console.WriteLine("Enter a");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter c");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Test.FindVertex(a, b, c));
        }
        static void CallCupSwapping()
        {
            methods Test = new methods();
            List<string> Commands = new List<string>();
            string Command;
            bool LoopStopped = false;
            Console.WriteLine("Commands for swapping cups are given with the 2 letters of the cups next to each other e.g(\"AB\", \"CB\", \"BA\"). Only the letters A, B ,and C may be used.");
            do
            {
                Console.WriteLine("Please Enter a command. (To Stop Enter \"STOP\")");
                Command = Console.ReadLine();
                if (Command == "STOP")
                {
                    LoopStopped = true;
                }
                else
                {
                    Commands.Add(Command);
                }
            } while (LoopStopped == false);
            Console.WriteLine(Test.CupSwapping(Commands));
        }    
        static void CallAnagramInString()
        {
            methods Test = new methods();
            string Word, Sentence;
            Console.WriteLine("Pick the word you want to find anagrams of.");
            Word = Console.ReadLine();
            Word = Word.ToLower();
            Console.WriteLine("Pick the sentence you want to search in");
            Sentence = Console.ReadLine();
            Sentence = Sentence.ToLower();
            Console.WriteLine(Test.AnagramInString(Word, Sentence));
        }    
        static void CallWordScrambler()
        {
            methods Test = new methods();
            string Word;
            Console.WriteLine("Enter the word you want to scramble.");
            Word = Console.ReadLine();
            Word = Word.ToLower();
            Console.WriteLine(Test.WordScambler(Word));
        }
        static void CallOldEnoughToDrive()
        {
            methods Test = new methods();
            int age = 0;
            bool Valid = false;
            do
            {
                try
                {
                    Console.WriteLine("Please enter your age");
                    age = Convert.ToInt32(Console.ReadLine());
                    Valid = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid Input type. Please try again");
                }
            } while (Valid == false);
            Console.WriteLine(Test.OldEnoughToDrive(age));
        }
        static void CallPasswordLongEnough()
        {
            methods Test = new methods();
            string password;
            try
            {
                Console.WriteLine("Enter Your Password");
                password = Console.ReadLine();
                Console.WriteLine(Test.IsPasswordLongEnough(password));
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid data type");
            }
        }
        static void CallHolidayPackage()
        {
            int Groupsize;
            methods Test = new methods();
            try
            {
                Console.WriteLine("Enter your group size");
                Groupsize = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(Test.HolidayPackage(Groupsize));
            }
            catch (Exception)
            {
                throw new Exception("Invalid data type, or value.");
            }
        }
    }

    class methods
    {
        public int KaprekarsConstant(int input)

        {
            int temp,Size1, Size2, Size3, Size4,Count = 0;
            string Largernumber, Smallernumber, inputstringver;
            do      // starts the loop which will continue until the process is complete
            {
                Size1 = -1;
                Size2 = -1;
                Size3 = -1;
                Size4 = -1;     //sets all 'array' numbers as less than 0 so that they will always be overridden by the new numbers. This prevents old, larger numbers from breaking the system
                Count++;        // increments count
                for (int i = 0; i < 4; i++)     // loops for all 4 characters in number
                {
                    inputstringver = input.ToString();
                    Size4 = (Convert.ToInt32(Convert.ToString(inputstringver[i])));     // sets input as a string to allow single characters to be extracted. Then extracts the character, converts that character to a string and then converts that string to an integer. The single character to converted to a string to prevent it being turned into a ASCCI value which happens if you use convert.toint32 on a character
                    if (Size4 > Size3)
                    {
                        temp = Size4;
                        Size4 = Size3;
                        Size3 = temp;
                        if (Size3 > Size2)
                        {
                            temp = Size3;
                            Size3 = Size2;
                            Size2 = temp;
                            if (Size2 > Size1)
                            {
                                temp = Size2;
                                Size2 = Size1;
                                Size1 = temp;       // sorts through the values and aranges digits in size order
                            }
                        }
                    }
                }
                Largernumber = string.Concat(Convert.ToString(Size1), Convert.ToString(Size2), Convert.ToString(Size3), Convert.ToString(Size4));
                Smallernumber = string.Concat(Convert.ToString(Size4), Convert.ToString(Size3), Convert.ToString(Size2), Convert.ToString(Size1));  // sets the large and small numbers using characters
                input = Convert.ToInt32(Largernumber) - Convert.ToInt32(Smallernumber); // sets new input for next loop.
            } while (Convert.ToInt32(input) != 6174); // stops loop if 6174 is reached
            return Count;
        }
        public string FindVertex(int a, int b, int c)
        {
            int x, y;
            string output = "hi";
            x = ((-b)/(2*a));
            y = ((a * (x * x)) + (b * x) + (c));

            output = "The Vertex of y=" + a + "x^2+" + b + "x+" + c + "  is: [" + x + "," + y + "]";
            return output;
        }
        public char CupSwapping(List<string> Commands)
        {
            char Cup1, Cup2, output;
            Cups CupA = new Cups();
            Cups CupB = new Cups();
            Cups CupC = new Cups();
            CupA.BallIsUnder = false;
            CupA.Name = 'A';
            CupB.BallIsUnder = true;
            CupB.Name = 'B';
            CupC.BallIsUnder = false;
            CupC.Name = 'C';
            foreach (string x in Commands)
            {
                Cup1 = x[0];
                Cup2 = x[1];

                if (Cup1 == 'A' && Cup2 == 'B' || Cup1 == 'B' && Cup2 == 'A')
                {
                    if (CupA.BallIsUnder == true)
                    {
                        Console.WriteLine("Cups " + Cup1 + " and " + Cup2 + " swap places. The Ball is now in Cup B");
                        CupA.BallIsUnder = false;
                        CupB.BallIsUnder = true;
                    }
                    else if (CupB.BallIsUnder == true)
                    {
                        Console.WriteLine("Cups " + Cup1 + " and " + Cup2 + " swap places. The Ball is now in Cup A");
                        CupB.BallIsUnder = false;
                        CupA.BallIsUnder = true;
                    }
                    else
                    {
                        Console.WriteLine("Cups " + Cup1 + " and " + Cup2 + " swap places. The Ball does not swap places");
                    }
                }
                else if (Cup1 == 'A' && Cup2 == 'C' || Cup1 == 'C' && Cup2 == 'A')
                {
                    if (CupA.BallIsUnder == true)
                    {
                        Console.WriteLine("Cups " + Cup1 + " and " + Cup2 + " swap places. The Ball is now in Cup C");
                        CupA.BallIsUnder = false;
                        CupC.BallIsUnder = true;
                    }
                    else if (CupC.BallIsUnder == true)
                    {
                        Console.WriteLine("Cups " + Cup1 + " and " + Cup2 + " swap places. The Ball is now in Cup A");
                        CupC.BallIsUnder = false;
                        CupA.BallIsUnder = true;
                    }
                    else
                    {
                        Console.WriteLine("Cups " + Cup1 + " and " + Cup2 + " swap places. The Ball does not swap places");
                    }
                }
                else if (Cup1 == 'C' && Cup2 == 'B' || Cup1 == 'B' && Cup2 == 'C')
                {
                    if (CupC.BallIsUnder == true)
                    {
                        Console.WriteLine("Cups " + Cup1 + " and " + Cup2 + " swap places. The Ball is now in Cup B");
                        CupC.BallIsUnder = false;
                        CupB.BallIsUnder = true;
                    }
                    else if (CupB.BallIsUnder == true)
                    {
                        Console.WriteLine("Cups " + Cup1 + " and " + Cup2 + " swap places. The Ball is now in Cup C");
                        CupB.BallIsUnder = false;
                        CupC.BallIsUnder = true;
                    }
                    else
                    {
                        Console.WriteLine("Cups " + Cup1 + " and " + Cup2 + " swap places. The Ball does not swap places");
                    }
                }
                else
                {
                    Console.WriteLine("This is not a valid command");
                }
            }
            if (CupA.BallIsUnder == true)
            {
                output = CupA.Name;
            }
            else if (CupB.BallIsUnder == true)
            {
                output = CupB.Name;
            }
            else
            {
                output = CupC.Name;
            }
            return output;
        }
        public bool AnagramInString(string Word, string Sentence)
        {
            int LoopCount = 0;
            bool AnagramFound = false, LoopEnded = false;
            List<char> Characters = new List<char>();
            List<char> CharactersBackup = new List<char>();
            foreach (char x in Word)
            {
                Characters.Add(x);
            }
            CharactersBackup = Characters;

            for (int i = 0; i < Sentence.Length-1; i++)
            {
                if (Characters.Contains(Sentence[i]))
                {
                    CharactersBackup = Characters;
                    LoopCount = 0;
                    while (AnagramFound == false || LoopEnded == false)
                    {
                        try
                        {
                            CharactersBackup.Remove(Sentence[i + LoopCount]);
                        }
                        catch (Exception)
                        {
                            LoopEnded = true;
                            break;
                        }
                        LoopCount++;
                        if (CharactersBackup.Count == 0)
                        {
                            AnagramFound = true;
                        }
                        try
                        {
                            if (CharactersBackup.Contains(Sentence[i + LoopCount]))
                            {
                            }
                            else
                            {
                                LoopEnded = true;
                                break;
                            }
                        }
                        catch (Exception x)
                        {
                            LoopEnded = true;
                            break;
                        }
                    }

                }
            }
            if (AnagramFound == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string WordScambler(string WordInput)
        {
            Random RandInt = new Random(); //makes a random number
            List<int> WordOrder = new List<int>(); //makes new lis to hold order of scrambled values
            int Count = 0, Temp;
            string WordOutput = "", WordInputReplacement;
            WordInputReplacement = WordInput; //allows us to edit wordinput non permanently
            foreach (char x in WordInput) // runs thorugh each character in wordinput and asigns them each an order for the new scrambled word
            {
                Temp = RandInt.Next(0, WordInput.Length - Count);
                Count++;
                WordOrder.Add(Temp);
            }
            foreach (int y in WordOrder)
            {
                WordOutput = WordOutput + WordInputReplacement[y];      //build word output by taking the specified character from wordinput
                WordInputReplacement = WordInputReplacement.Remove(y,1); // removes the used character from wordinput
            }
            return WordOutput;  // returns output
        }
        public string OldEnoughToDrive(int age)
        {
            if (age < 17)
            {
                return "You are not old enough to drive";
            }
            else if (age < 18)
            {
                return "You are old enough to dive a car but not a lorry";
            }
            else
            {
                return "You are old enough to drive a car and a lorry";
            }
        }
        public string IsPasswordLongEnough(string password)
        {
            if (password.Length > 8)
            {
                return "Password Allowed";
            }
            else
            {
                return "Password Not Allowed";
            }
        }
        public float HolidayPackage(int GroupSize)
        {
            float output;
            if (GroupSize < 2 || GroupSize > 10)
            {
                throw new Exception("Invalid Group Size. Must be between 2 and 10.");
            }
            else
            {
                output = (GroupSize * 50) + 10;
                return output;
            }
        }
    }
    class Cups
    {
        public bool BallIsUnder;
        public char Name;
    }
