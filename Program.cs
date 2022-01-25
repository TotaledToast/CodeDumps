using System;
using System.Linq;
using System.Collections.Generic;

namespace Kaprekar_s_Constant
{
    class Program
    {
        static void Main(string[] args)
        {
            CallOvertimePay();
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
                if (Command == "STOP")  //stops the loop if the user inputs "STOP"
                {
                    LoopStopped = true;
                }
                else
                {
                    Commands.Add(Command); //lets the user add commands
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
        static void CallConvertToBinary()
        {
            methods Test = new methods();
            int numTester, num;
            try
            {
                Console.WriteLine("Please input a length");
                num = Convert.ToInt32(Console.ReadLine());
                numTester = Convert.ToInt32(num);
                Console.WriteLine(Test.ConvertToBinary(num));
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Input Type");
            }

        }
        static List<string> CallAllNonConsecutiveBinaryPermutations()
        {
            methods Test = new methods();
            List<string> NonConsecutiveBinaryPermutations = new List<string>();
            int Length;
            try
            {
                Console.WriteLine("Enter the limit of numbers you want to check (Largest Number)");
                Length = Convert.ToInt32(Console.ReadLine());
                NonConsecutiveBinaryPermutations = Test.AllNonConsecutiveBinaryPermutations(Length);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Input Type");
            }
            return NonConsecutiveBinaryPermutations;
        }
        static void CallOvertimePay()
        {
            double StartOfDay, EndOfDay, HourlyRate, OvertimeBonus;
            List<double> Values = new List<double>();
            methods Test = new methods();
            try
            {
                Console.WriteLine("When Does Your Day Start (24 Hour Clock)");
                StartOfDay = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("When Does Your Day End (24 Hour Clock)");
                EndOfDay = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("What is You Houry Rate (2 s.f)");
                HourlyRate = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("What is your overtime bonus (2 s.f)");
                OvertimeBonus = Convert.ToDouble(Console.ReadLine());
                Values.Add(StartOfDay);
                Values.Add(EndOfDay);
                Values.Add(HourlyRate);
                Values.Add(OvertimeBonus);
                Console.WriteLine(Test.OvertimePay(Values));

            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Inputs");
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
                        if (Size3 > Size2)  //if number is larger than the next number in the list, it switched them
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
            string output = "";
            x = ((-b)/(2*a));
            y = ((a * (x * x)) + (b * x) + (c));    //maths for turning point of a quadratic

            output = "The Vertex of y=" + a + "x^2+" + b + "x+" + c + "  is: [" + x + "," + y + "]";    //outputs results in text format
            return output;
        }
        public char CupSwapping(List<string> Commands)
        {
            char Cup1, Cup2, output;
            Cups CupA = new Cups();
            Cups CupB = new Cups();
            Cups CupC = new Cups();     //callc new classes for each of the 3 cups
            CupA.BallIsUnder = false;
            CupA.Name = 'A';
            CupB.BallIsUnder = true; //determines the ball is under this one
            CupB.Name = 'B';
            CupC.BallIsUnder = false;
            CupC.Name = 'C';        //identifies each ball
            foreach (string x in Commands)
            {
                Cup1 = x[0];
                Cup2 = x[1];    //reads users input to find what cups they want to swap

                if (Cup1 == 'A' && Cup2 == 'B' || Cup1 == 'B' && Cup2 == 'A')//for cups A and B
                {
                    if (CupA.BallIsUnder == true)
                    {
                        Console.WriteLine("Cups " + Cup1 + " and " + Cup2 + " swap places. The Ball is now in Cup B");
                        CupA.BallIsUnder = false;
                        CupB.BallIsUnder = true;
                    }
                    else if (CupB.BallIsUnder == true)
                    {
                        Console.WriteLine("Cups " + Cup1 + " and " + Cup2 + " swap places. The Ball is now in Cup A");  //variation for each order of swapping
                        CupB.BallIsUnder = false;
                        CupA.BallIsUnder = true;
                    }
                    else
                    {
                        Console.WriteLine("Cups " + Cup1 + " and " + Cup2 + " swap places. The Ball does not swap places"); //if the ball isnt under either cup it wont de anything
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
                        Console.WriteLine("Cups " + Cup1 + " and " + Cup2 + " swap places. The Ball does not swap places");     //repeats same thing for each set of cups
                    }
                }//cycles for each variation of cups
                else
                {
                    Console.WriteLine("This is not a valid command"); //catches invalid commands
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
                output = CupC.Name;     //checks which cup the ball is under
            }
            return output;
        }
        public bool AnagramInString(string Word, string Sentence)
        {
            int LoopCount = 0;
            bool AnagramFound = false, LoopEnded = false;
            List<char> Characters = new List<char>();
            List<char> CharactersBackup = new List<char>();     //defines new lists, and variables
            foreach (char x in Word)
            {
                Characters.Add(x);  //for each charcter in the input word it adds that character to the character list
            }
            CharactersBackup = Characters; //creates a backup of the characters list

            for (int i = 0; i < Sentence.Length-1; i++) //loops for the length of the sentence string inputted
            {
                if (Characters.Contains(Sentence[i])) // check if the current character we're checking in the string is a letter in the word we are trying to find
                {
                    CharactersBackup = Characters;//re-sets backup as the characters list
                    LoopCount = 0;
                    while (AnagramFound == false || LoopEnded == false)     //will continue loop while it hasnt found an anagram or the loop isnt finished
                    {
                        try     //will try to do this and catch it if it doesnt work
                        {
                            CharactersBackup.Remove(Sentence[i + LoopCount]);   //removes the next character in the sequence
                        }
                        catch (Exception)
                        {
                            LoopEnded = true;   //ends loop
                            break;
                        }
                        LoopCount++;    //increases the loop count to move to the next character
                        if (CharactersBackup.Count == 0)    //if youve gotten rid of every letter in the word
                        {
                            AnagramFound = true;    //stops loop with the anagram found
                        }
                        try
                        {
                            if (CharactersBackup.Contains(Sentence[i + LoopCount])) //checks if the character is in the word
                            {
                            }
                            else
                            {
                                LoopEnded = true;   //loop ends
                                break;
                            }
                        }
                        catch (Exception x)
                        {
                            LoopEnded = true;   //loop ends
                            break;
                        }
                    }

                }
            }
            if (AnagramFound == true)   //checks if an anagram was found
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
        //Old Denary To Binary Code (Very Bad)   
        /*public string ConvertToBinary(int num)
        {
            int LengthOfNum, BinaryLargest = 1, Number, LargestBackup = 0, LoopCount = 0;
            string BinaryString = "";
            List<int> BinaryNum = new List<int>();
            Number = num;
            LengthOfNum = (num.ToString().Length);
            if (Number == 1 || Number == 2)
            {
                BinaryLargest = 1;  //if the number inputted is 1 or 2 the largest binary number it is divisible by is 1
            }
            else if (num == 0)
            {
                Number = 0;
            }
            else
            {
                BinaryLargest = 2;
                while (BinaryLargest < Number)
                {
                    LargestBackup = BinaryLargest;
                    BinaryLargest = BinaryLargest * 2;  //cycles though c^n until it finds a number bigger than the number inputted. This allows the program to find the largest binary number you can minus from the main number
                }
                BinaryLargest = LargestBackup; // sets binary largest to largest number not bigger than inputted number
            }
            if (num / 2 == BinaryLargest) //Messy way of dealing with numbers that equal 2^n. e.g. 2,4,8,16 ect. 
            {
                int ZeroLength;
                ZeroLength = (ConvertToBinary(num - 1)).Length; //finds out how many zeros there should be by finding  the length of the binary number 1 smaller than this one
                BinaryNum.Add(1);       //add the starting 1 to the number
                for (int i = 1; i < ZeroLength; i++)
                {
                    BinaryNum.Add(0);   //loops through for every time there should be a 0 and adds one
                }
                Number = 0; //bypasses rest of the code
            }
            while (Number != 0)
            {
                if ((Number - BinaryLargest) >= 0)
                {
                    BinaryNum.Add(1);
                    Number = Number - BinaryLargest;    //if the number minus the binary largest is greater than 0 you can add 1 to the binary output
                }
                else
                {
                    BinaryNum.Add(0);   //if the number minus binary largest is less than 1 you can add a 0 to the binary output
                }
                BinaryLargest = BinaryLargest / 2; //cycles to next binary largest
            }
            if (num % 2 == 0)
            {
                BinaryNum.Add(0);       //adds the 0 at the end if the inputted number is even
            }
            foreach (int x in BinaryNum)
            {
                BinaryString = BinaryString.Insert(LoopCount, Convert.ToString(x)); //convertes the list storing each binary digit into a string
                LoopCount++; // allows the .Insert to insert at the right place
            }
            return BinaryString;
        }*/
        public string ConvertToBinary(int num)
        {
            return Convert.ToString(num, 2);
        }
        public List<string> AllNonConsecutiveBinaryPermutations(int Length)
        {
            bool RemoveBinary = false;
            List<string> BinaryValue = new List<string>();  //List for all out binary values
            List<string> BinaryRemoval = new List<string>();    //List of values to remove from main list
            for (int i = 0; i <= Length; i++)
            {
                BinaryValue.Add(ConvertToBinary(i));    //cycles through all designated numbers and adds their binary value to the list
            }
            foreach (string x in BinaryValue)
            {
                int Count = 0;
                foreach (char y in x)   //checks every character in every string
                {
                    Count++;
                    try
                    {
                        if (y == x[Count] && y == '1')  //checks if 2 consecutive are the same, and if they're 1
                        {
                            RemoveBinary = true;    //sets the binary value to be deleted and breaks out the loop
                            break;
                        }
                    }
                    catch (Exception)   //stops program from crashing if value is too small to have a second digit (0 and 1)
                    {
                    }
                }
                if (RemoveBinary == true)
                {
                    BinaryRemoval.Add(x);   //if the value needs to be deleted, adds it to the deltion list and resets the removebinary boolean
                    RemoveBinary = false;
                }
            }
            foreach (string x in BinaryRemoval)
            {
                BinaryValue.Remove(x);  //goes through removal list and removes all binary values specified from main list
            }
            return BinaryValue; //returns cleaned list
        }
        public string OvertimePay(List<double> Values)
        {
            double StartOfDay, EndOfDay, HourlyRate, OvertimeBonus, NormalHours, OvertimeHours, totalpay;
            StartOfDay = Values[0];
            EndOfDay = Values[1];
            HourlyRate = Values[2];
            OvertimeBonus = Values[3];
            if (EndOfDay < StartOfDay)
            {
                EndOfDay = EndOfDay + 24;
                NormalHours = 17 - StartOfDay;
                OvertimeHours = EndOfDay - 17;      //does different maths if you worked into the morning
            }
            else if (EndOfDay <= 17)
            {
                NormalHours = EndOfDay - StartOfDay;    // if theres no overtime
                OvertimeHours = 0;
            }
            else
            {
                NormalHours = 17 - StartOfDay;
                OvertimeHours = EndOfDay - 17;
            }
            totalpay = (NormalHours * HourlyRate) + (OvertimeHours * HourlyRate * OvertimeBonus);       //simple maths
            return "£" + totalpay.ToString();
        }
    }
    class Cups  //class for giving the cups in "CupSwapping" properties
    {
        public bool BallIsUnder;
        public char Name;
    }
}
