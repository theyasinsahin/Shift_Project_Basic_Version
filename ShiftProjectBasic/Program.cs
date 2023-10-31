using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int round = 1;
            bool control = true;
            int a1 = 0;
            string str_a1;
            int a2 = 0;
            string str_a2;
            int a3 = 0;
            string str_a3;
            int b1 = 0;
            string str_b1;
            int b2 = 0;
            string str_b2;
            int b3 = 0;
            string str_b3;
            int c1 = 0;
            string str_c1;
            int c2 = 0;
            string str_c2;
            int c3 = 0;
            string str_c3;


            while (control)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Please enter a number from 1 to 9 for x1-y1: ");
                str_a1 = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Red;
                if (int.TryParse(str_a1, out a1))
                {
                    if((1 <= a1 & a1 <= 9))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a number between 1-9");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid number");
                }
                Console.ResetColor();
            }

            while (control)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Please enter a number from 1 to 9 for x1-y2: ");
                str_a2 = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Red;
                if (int.TryParse(str_a2, out a2))
                {
                    if ((1 <= a2 & a2 <= 9))
                    {
                        if(!(a1 == a2))
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Please don't enter the same numbers");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter a number between 1-9");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid number");
                }
                Console.ResetColor();

            }

            while (control)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Please enter a number from 1 to 9 for x1-y3: ");
                str_a3 = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Red;
                if (int.TryParse(str_a3, out a3))
                {
                    if((1 <= a3 & a3 <= 9))
                    {
                        if (!(a3 == a2 || a3 == a1))
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Please don't enter the same numbers");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter a number between 1-9");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid number");
                }
                Console.ResetColor();
            }

            while (control)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Please enter a number from 1 to 9 for x2-y1: ");
                str_b1 = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Red;
                if (int.TryParse(str_b1, out b1))
                {
                    if((1 <= b1 & b1 <= 9))
                    {
                        if (!(b1 == a1 || b1 == a2 || b1 == a3))
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Please don't enter the same numbers");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter a number between 1-9");
                    }

                }
                else
                {
                    Console.WriteLine("Please enter a valid number");
                }
                Console.ResetColor();
            }

            while (control)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Please enter a number from 1 to 9 for x2-y2: ");
                str_b2 = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Red;
                if (int.TryParse(str_b2, out b2))
                {
                    if ((1 <= b2 & b2 <= 9))
                    {
                        if (!((b2 == b1 || b2 == a1 || b2 == a2 || b2 == a3)))
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Please don't enter the same numbers");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter a number between 1-9");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid number");
                }
                Console.ResetColor();
            }

            while (control)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Please enter a number from 1 to 9 for x2-y3: ");
                str_b3 = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Red;
                if (int.TryParse(str_b3, out b3))
                {
                    if ((1 <= b3 & b3 <= 9))
                    {
                        if (!(b3 == b2 || b3 == b1 || b3 == a1 || b3 == a2 || b3 == a3))
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Please don't enter the same numbers");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter a number between 1-9");
                    }

                }
                else
                {
                    Console.WriteLine("Please enter a valid number");
                }
                Console.ResetColor();
            }

            while (control)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Please enter a number from 1 to 9 for x3-y1: ");
                str_c1 = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Red;
                if (int.TryParse(str_c1, out c1))
                {
                    if ((1 <= c1 & c1 <= 9))
                    {
                        if (!((c1 == a1) || (c1 == a2) || (c1 == a3) || (c1 == b1) || (c1 == b2) || (c1 == b3)))
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Please don't enter the same numbers");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter a number between 1-9");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid number");
                }
                Console.ResetColor();
            }

            while (control)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Please enter a number from 1 to 9 for x3-y2: ");
                str_c2 = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Red;
                if (int.TryParse(str_c2, out c2))
                {
                    if ((1 <= c2 & c2 <= 9))
                    {
                        if (!(c2 == a1 || c2 == a2 || c2 == a3 || c2 == b1 || c2 == b2 || c2 == b3 || c2 == c1))
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Please don't enter the same numbers");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter a number between 1-9");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid number");
                }
                Console.ResetColor();
            }

            while (control)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Please enter a number from 1 to 9 for x3-y3: ");
                str_c3 = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Red;
                if (int.TryParse(str_c3, out c3))
                {
                    if ((1 <= c3 & c3 <= 9))
                    {
                        if (!((c3 == a1 || c3 == a2 || c3 == a3 || (c3 == b1) || (c3 == b2) || (c3 == b3) || (c3 == c1) || (c3 == c2))))
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Please don't enter the same numbers");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter a number between 1-9");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid number");
                }
                Console.ResetColor();
            }


            Console.ResetColor();

            // print board 
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"----------Round {round}----------");
            Console.WriteLine("    1 2 3 ");
            Console.WriteLine("  + - - - +");
            Console.WriteLine($"1 | {a1} {a2} {a3} |");
            Console.WriteLine($"2 | {b1} {b2} {b3} |");
            Console.WriteLine($"3 | {c1} {c2} {c3} |");
            Console.WriteLine("  + - - - +");
            Console.ResetColor();
            int comboCounter = 0;
            int score = 0;
            //first row controlling
            if (((a1 == a2 - 1) && (a2 == a3 - 1)) || ((a1 == a2 + 1) && (a2 == a3 + 1)))
            {
                comboCounter++;
            }
            //second row controlling
            if (((b1 == b2 - 1) && (b2 == b3 - 1)) || ((b1 == b2 + 1) && (b2 == b3 + 1)))
            {
                comboCounter++;
            }
            //third row controlling
            if (((c1 == c2 - 1) && (c2 == c3 - 1)) || ((c1 == c2 + 1) && (c2 == c3 + 1)))
            {
                comboCounter++;
            }
            //first column controlling
            if (((a1 == b1 - 1) && (b1 == c1 - 1)) || ((a1 == b1 + 1) && (b1 == c1 + 1)))
            {
                comboCounter++;
            }
            //second column controlling
            if (((a2 == b2 - 1) && (b2 == c2 - 1)) || ((a2 == b2 + 1) && (b2 == c2 + 1)))
            {
                comboCounter++;
            }
            //third column controlling
            if (((a3 == b3 - 1) && (b3 == c3 - 1)) || ((a3 == b3 + 1) && (b3 == c3 + 1)))
            {
                comboCounter++;
            }
            //right to left diagonal controlling
            if (((a3 == b2 - 1) && (b2 == c1 - 1)) || ((a3 == b2 + 1) && (b2 == c1 + 1)))
            {
                comboCounter++;
            }
            //left to right diagonal controlling
            if (((a1 == b2 - 1) && (b2 == c3 - 1)) || ((a1 == b2 + 1) && (b2 == c3 + 1)))
            {
                comboCounter++;
            }

            if (comboCounter == 1)
            {
                score = 1;
            }
            if (comboCounter == 2)
            {
                score = 4;
            }
            if (comboCounter == 3)
            {
                score = 9;
            }

            int boardScore = score;
            int playerScore = 0;
            int computerScore = 0;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Board Score: {boardScore}");
            Console.WriteLine($"Player Score: {playerScore}");
            Console.WriteLine($"Computer Score: {computerScore}");
            Console.ResetColor();


            bool turn = true;
            int moveCounter = 1;
            string whoPlays;

            while (boardScore != 0)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                if (turn)
                {
                    whoPlays = "Player";
                    Console.WriteLine($"Turn : {moveCounter} / {whoPlays}");
                }
                else
                {
                    whoPlays = "Computer";
                    Console.WriteLine($"Turn : {moveCounter} / {whoPlays}");
                }
                Console.ResetColor();

                // move the selected column 
                int move;
                string str_move;
                if (turn)
                {
                    while (true)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Which move do you want to make?");
                        Console.ResetColor(); str_move = Console.ReadLine();
                        if (int.TryParse(str_move, out move))
                        {
                            Console.ForegroundColor= ConsoleColor.DarkMagenta;
                            Console.WriteLine($"Command: {move}");
                            Console.ResetColor();
                            break;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Please choose a number between 1 and 6");
                            Console.ResetColor();
                        }
                    }
                }
                else
                {
                    Console.ForegroundColor=ConsoleColor.DarkGreen;
                    Console.WriteLine("When you enter any key computer going to play");
                    Console.ResetColor();
                    Console.ReadLine();
                    Random random = new Random();
                    move = random.Next(1, 7);
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine($"Command: {move}");
                    Console.ResetColor();
                }
                int a_1 = a1;
                int a_2 = a2;
                int a_3 = a3;
                int b_1 = b1;
                int b_2 = b2;
                int b_3 = b3;
                int c_1 = c1;
                int c_2 = c2;
                int c_3 = c3;
                // swich is a statement 
                bool istrue = true;
                while (istrue)
                {
                    istrue = false;
                    switch (move)
                    {
                        case (1):
                            a1 = a_3;
                            a2 = a_1;
                            a3 = a_2;
                            break;
                        case (2):
                            b1 = b_3;
                            b2 = b_1;
                            b3 = b_2;
                            break;
                        case (3):
                            c1 = c_3;
                            c2 = c_1;
                            c3 = c_2;
                            break;
                        case (4):
                            a1 = c_1;
                            b1 = a_1;
                            c1 = b_1;
                            break;
                        case (5):
                            a2 = c_2;
                            b2 = a_2;
                            c2 = b_2;
                            break;
                        case (6):
                            a3 = c_3;
                            b3 = a_3;
                            c3 = b_3;
                            break;
                        default:
                            istrue = true;

                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("The move must be between 1-6");
                            Console.ResetColor();
                            move = Convert.ToInt32(Console.ReadLine());
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.WriteLine($"Command: {move}");
                            Console.ResetColor(); break;
                    }
                }
                // print moved board 
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine($"----------Round {round}----------");
                Console.WriteLine("   1 2 3  ");
                Console.WriteLine(" + - - - +");
                Console.WriteLine($"1| {a1} {a2} {a3} |");
                Console.WriteLine($"2| {b1} {b2} {b3} |");
                Console.WriteLine($"3| {c1} {c2} {c3} |");
                Console.WriteLine(" + - - - +");
                Console.ResetColor();

                //SCORE CONTROL
                comboCounter = 0;
                score = 0;
                //first row controlling
                if (((a1 == a2 - 1) && (a2 == a3 - 1)) || ((a1 == a2 + 1) && (a2 == a3 + 1)))
                {
                    comboCounter++;
                }
                //second row controlling
                if (((b1 == b2 - 1) && (b2 == b3 - 1)) || ((b1 == b2 + 1) && (b2 == b3 + 1)))
                {
                    comboCounter++;
                }
                //third row controlling
                if (((c1 == c2 - 1) && (c2 == c3 - 1)) || ((c1 == c2 + 1) && (c2 == c3 + 1)))
                {
                    comboCounter++;
                }
                //first column controlling
                if (((a1 == b1 - 1) && (b1 == c1 - 1)) || ((a1 == b1 + 1) && (b1 == c1 + 1)))
                {
                    comboCounter++;
                }
                //second column controlling
                if (((a2 == b2 - 1) && (b2 == c2 - 1)) || ((a2 == b2 + 1) && (b2 == c2 + 1)))
                {
                    comboCounter++;
                }
                //third column controlling
                if (((a3 == b3 - 1) && (b3 == c3 - 1)) || ((a3 == b3 + 1) && (b3 == c3 + 1)))
                {
                    comboCounter++;
                }
                //right to left diagonal controlling
                if (((a3 == b2 - 1) && (b2 == c1 - 1)) || ((a3 == b2 + 1) && (b2 == c1 + 1)))
                {
                    comboCounter++;
                }
                //left to right diagonal controlling 
                if (((a1 == b2 - 1) && (b2 == c3 - 1)) || ((a1 == b2 + 1) && (b2 == c3 + 1)))
                {
                    comboCounter++;
                }

                if (comboCounter == 1)
                {
                    score = 1;
                }
                if (comboCounter == 2)
                {
                    score = 4;
                }
                if (comboCounter == 3)
                {
                    score = 9;
                }
                boardScore = score;

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Board Score: {boardScore}");
                Console.WriteLine($"Player Score: {playerScore}");
                Console.WriteLine($"Computer Score: {computerScore}");
                Console.ResetColor();

                if (turn)
                    turn = false;
                else
                    turn = true;
                moveCounter++;
            }
            // we write code in while loop because we want to play when we have new series
            int preround = round;
            int precomputerscore = 0;
            int preplayerscore = 0;
            while (round < 6)
            {
                if (preround != round)
                {
                    turn = true;
                    moveCounter = 1;
                    preround = round;
                }
                Console.ForegroundColor = ConsoleColor.Blue;
                if (turn)
                {
                    whoPlays = "Player";
                    Console.WriteLine($"Turn : {moveCounter} / {whoPlays}");
                }
                else
                {
                    whoPlays = "Computer";
                    Console.WriteLine($"Turn : {moveCounter} / {whoPlays}");
                }
                Console.ResetColor();

                // move the selected column 
                int move;
                string str_move;
                int a_1 = a1;
                int a_2 = a2;
                int a_3 = a3;
                int b_1 = b1;
                int b_2 = b2;
                int b_3 = b3;
                int c_1 = c1;
                int c_2 = c2;
                int c_3 = c3;
                if (turn)
                {
                    while(true)
                    {
                        Console.ForegroundColor= ConsoleColor.DarkGreen;
                        Console.WriteLine("Which move do you want to make?");
                        Console.ResetColor();
                        str_move = Console.ReadLine();
                        if (int.TryParse(str_move, out move))
                        {
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.WriteLine($"Command: {move}");
                            Console.ResetColor(); break;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Please choose a number between 1 and 6");
                            Console.ResetColor();
                        }
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("When you enter any key computer going to play");
                    Console.ResetColor(); Console.ReadLine();
                    Random random = new Random();

                    // check the right move if it can ************************************************
                    int checkCounter = 1;
                    int bestOption = 0;
                    int option = 0;
                    int bestPoint = 0;

                    while (checkCounter < 7)
                    {
                        switch (checkCounter)
                        {
                            case (1):
                                a1 = a_3;
                                a2 = a_1;
                                a3 = a_2;
                                break;
                            case (2):
                                b1 = b_3;
                                b2 = b_1;
                                b3 = b_2;
                                break;
                            case (3):
                                c1 = c_3;
                                c2 = c_1;
                                c3 = c_2;
                                break;
                            case (4):
                                a1 = c_1;
                                b1 = a_1;
                                c1 = b_1;
                                break;
                            case (5):
                                a2 = c_2;
                                b2 = a_2;
                                c2 = b_2;
                                break;
                            case (6):
                                a3 = c_3;
                                b3 = a_3;
                                c3 = b_3;
                                break;
                        }

                        comboCounter = 0;
                        score = 0;
                        //first row controlling
                        if (((a1 == a2 - 1) && (a2 == a3 - 1)) || ((a1 == a2 + 1) && (a2 == a3 + 1)))
                        {
                            comboCounter++;
                        }
                        //second row controlling
                        if (((b1 == b2 - 1) && (b2 == b3 - 1)) || ((b1 == b2 + 1) && (b2 == b3 + 1)))
                        {
                            comboCounter++;
                        }
                        //third row controlling
                        if (((c1 == c2 - 1) && (c2 == c3 - 1)) || ((c1 == c2 + 1) && (c2 == c3 + 1)))
                        {
                            comboCounter++;
                        }
                        //first column controlling
                        if (((a1 == b1 - 1) && (b1 == c1 - 1)) || ((a1 == b1 + 1) && (b1 == c1 + 1)))
                        {
                            comboCounter++;
                        }
                        //second column controlling
                        if (((a2 == b2 - 1) && (b2 == c2 - 1)) || ((a2 == b2 + 1) && (b2 == c2 + 1)))
                        {
                            comboCounter++;
                        }
                        //third column controlling
                        if (((a3 == b3 - 1) && (b3 == c3 - 1)) || ((a3 == b3 + 1) && (b3 == c3 + 1)))
                        {
                            comboCounter++;
                        }
                        //right to left diagonal controlling
                        if (((a3 == b2 - 1) && (b2 == c1 - 1)) || ((a3 == b2 + 1) && (b2 == c1 + 1)))
                        {
                            comboCounter++;
                        }
                        //left to right diagonal controlling
                        if (((a1 == b2 - 1) && (b2 == c3 - 1)) || ((a1 == b2 + 1) && (b2 == c3 + 1)))
                        {
                            comboCounter++;
                        }

                        if (comboCounter == 1)
                        {
                            score = 1;

                        }
                        if (comboCounter == 2)
                        {
                            score = 4;

                        }
                        if (comboCounter == 3)
                        {
                            score = 9;
                        }
                        if (bestPoint < score)
                        {
                            bestPoint = score;
                            option = checkCounter;
                        }

                        if (option > bestOption)
                        {
                            bestOption = option;
                        }
                        switch (checkCounter)
                        {
                            case (1):
                                a1 = a_1;
                                a2 = a_2;
                                a3 = a_3;
                                break;
                            case (2):
                                b1 = b_1;
                                b2 = b_2;
                                b3 = b_3;
                                break;
                            case (3):
                                c1 = c_1;
                                c2 = c_2;
                                c3 = c_3;
                                break;
                            case (4):
                                a1 = a_1;
                                b1 = b_1;
                                c1 = c_1;
                                break;
                            case (5):
                                a2 = a_2;
                                b2 = b_2;
                                c2 = c_2;
                                break;
                            case (6):
                                a3 = a_3;
                                b3 = b_3;
                                c3 = c_3;
                                break;
                        }
                        checkCounter++;
                    }

                    if (bestOption > 0)
                    {
                        move = bestOption;
                    }
                    else
                    {
                        move = random.Next(1, 7);
                    }
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine($"Command: {move}");
                    Console.ResetColor();
                }
                if (boardScore != 0)
                {
                    // swich is a statement 
                    bool istrue = true;
                    while (istrue)
                    {
                        istrue = false;
                        switch (move)
                        {
                            case (1):
                                a1 = a_3;
                                a2 = a_1;
                                a3 = a_2;
                                break;
                            case (2):
                                b1 = b_3;
                                b2 = b_1;
                                b3 = b_2;
                                break;
                            case (3):
                                c1 = c_3;
                                c2 = c_1;
                                c3 = c_2;
                                break;
                            case (4):
                                a1 = c_1;
                                b1 = a_1;
                                c1 = b_1;
                                break;
                            case (5):
                                a2 = c_2;
                                b2 = a_2;
                                c2 = b_2;
                                break;
                            case (6):
                                a3 = c_3;
                                b3 = a_3;
                                c3 = b_3;
                                break;
                            default:
                                istrue = true;

                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("The move must be between 1-6");
                                Console.ResetColor(); move = Convert.ToInt32(Console.ReadLine());
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine($"Command: {move}");
                                Console.ResetColor(); 
                                break;
                        }
                    }
                    // print moved board 
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine($"----------Round {round}----------");
                    Console.WriteLine("   1 2 3  ");
                    Console.WriteLine(" + - - - +");
                    Console.WriteLine($"1| {a1} {a2} {a3} |");
                    Console.WriteLine($"2| {b1} {b2} {b3} |");
                    Console.WriteLine($"3| {c1} {c2} {c3} |");
                    Console.WriteLine(" + - - - +");
                    Console.ResetColor();

                    //SCORE CONTROL
                    comboCounter = 0;
                    score = 0;
                    //first row controlling
                    if (((a1 == a2 - 1) && (a2 == a3 - 1)) || ((a1 == a2 + 1) && (a2 == a3 + 1)))
                    {
                        comboCounter++;
                    }
                    //second row controlling
                    if (((b1 == b2 - 1) && (b2 == b3 - 1)) || ((b1 == b2 + 1) && (b2 == b3 + 1)))
                    {
                        comboCounter++;
                    }
                    //third row controlling
                    if (((c1 == c2 - 1) && (c2 == c3 - 1)) || ((c1 == c2 + 1) && (c2 == c3 + 1)))
                    {
                        comboCounter++;
                    }
                    //first column controlling
                    if (((a1 == b1 - 1) && (b1 == c1 - 1)) || ((a1 == b1 + 1) && (b1 == c1 + 1)))
                    {
                        comboCounter++;
                    }
                    //second column controlling
                    if (((a2 == b2 - 1) && (b2 == c2 - 1)) || ((a2 == b2 + 1) && (b2 == c2 + 1)))
                    {
                        comboCounter++;
                    }
                    //third column controlling
                    if (((a3 == b3 - 1) && (b3 == c3 - 1)) || ((a3 == b3 + 1) && (b3 == c3 + 1)))
                    {
                        comboCounter++;
                    }
                    //right to left diagonal controlling
                    if (((a3 == b2 - 1) && (b2 == c1 - 1)) || ((a3 == b2 + 1) && (b2 == c1 + 1)))
                    {
                        comboCounter++;
                    }
                    //left to right diagonal controlling
                    if (((a1 == b2 - 1) && (b2 == c3 - 1)) || ((a1 == b2 + 1) && (b2 == c3 + 1)))
                    {
                        comboCounter++;
                    }

                    if (comboCounter == 1)
                    {
                        score = 1;
                    }
                    if (comboCounter == 2)
                    {
                        score = 4;
                    }
                    if (comboCounter == 3)
                    {
                        score = 9;
                    }

                    if (turn)
                    {
                        turn = false;
                        moveCounter++;
                    }
                    else
                    {
                        turn = true;
                        moveCounter++;
                    }

                    boardScore = score;

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"Board Score: {boardScore}");
                    Console.WriteLine($"Player Score: {playerScore}");
                    Console.WriteLine($"Computer Score: {computerScore}");
                    Console.ResetColor();
                }

                else
                {
                    // swich is a statement 
                    bool istrue = true;
                    while (istrue)
                    {
                        istrue = false;
                        switch (move)
                        {
                            case (1):
                                a1 = a_3;
                                a2 = a_1;
                                a3 = a_2;
                                break;
                            case (2):
                                b1 = b_3;
                                b2 = b_1;
                                b3 = b_2;
                                break;
                            case (3):
                                c1 = c_3;
                                c2 = c_1;
                                c3 = c_2;
                                break;
                            case (4):
                                a1 = c_1;
                                b1 = a_1;
                                c1 = b_1;
                                break;
                            case (5):
                                a2 = c_2;
                                b2 = a_2;
                                c2 = b_2;
                                break;
                            case (6):
                                a3 = c_3;
                                b3 = a_3;
                                c3 = b_3;
                                break;
                            default:
                                istrue = true;

                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("The move must be between 1-6");
                                Console.ResetColor(); move = Convert.ToInt32(Console.ReadLine());
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine($"Command: {move}");
                                Console.ResetColor();
                                break;
                        }
                    }
                    // print moved board 
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine($"----------Round {round}----------");
                    Console.WriteLine("   1 2 3  ");
                    Console.WriteLine(" + - - - +");
                    Console.WriteLine($"1| {a1} {a2} {a3} |");
                    Console.WriteLine($"2| {b1} {b2} {b3} |");
                    Console.WriteLine($"3| {c1} {c2} {c3} |");
                    Console.WriteLine(" + - - - +");
                    Console.ResetColor();

                    //SCORE CONTROL
                    comboCounter = 0;
                    score = 0;
                    //first row controlling
                    if (((a1 == a2 - 1) && (a2 == a3 - 1)) || ((a1 == a2 + 1) && (a2 == a3 + 1)))
                    {
                        comboCounter++;
                    }
                    //second row controlling
                    if (((b1 == b2 - 1) && (b2 == b3 - 1)) || ((b1 == b2 + 1) && (b2 == b3 + 1)))
                    {
                        comboCounter++;
                    }
                    //third row controlling
                    if (((c1 == c2 - 1) && (c2 == c3 - 1)) || ((c1 == c2 + 1) && (c2 == c3 + 1)))
                    {
                        comboCounter++;
                    }
                    //first column controlling
                    if (((a1 == b1 - 1) && (b1 == c1 - 1)) || ((a1 == b1 + 1) && (b1 == c1 + 1)))
                    {
                        comboCounter++;
                    }
                    //second column controlling
                    if (((a2 == b2 - 1) && (b2 == c2 - 1)) || ((a2 == b2 + 1) && (b2 == c2 + 1)))
                    {
                        comboCounter++;
                    }
                    //third column controlling
                    if (((a3 == b3 - 1) && (b3 == c3 - 1)) || ((a3 == b3 + 1) && (b3 == c3 + 1)))
                    {
                        comboCounter++;
                    }
                    //right to left diagonal controlling
                    if (((a3 == b2 - 1) && (b2 == c1 - 1)) || ((a3 == b2 + 1) && (b2 == c1 + 1)))
                    {
                        comboCounter++;
                    }
                    //left to right diagonal controlling
                    if (((a1 == b2 - 1) && (b2 == c3 - 1)) || ((a1 == b2 + 1) && (b2 == c3 + 1)))
                    {
                        comboCounter++;
                    }

                    if (comboCounter == 1)
                    {
                        score = 1;
                    }
                    if (comboCounter == 2)
                    {
                        score = 4;
                    }
                    if (comboCounter == 3)
                    {
                        score = 9;
                    }

                    if (turn)
                    {
                        playerScore += score;
                        turn = false;
                        moveCounter++;
                    }
                    else
                    {
                        computerScore += score;
                        turn = true;
                        moveCounter++;
                    }
                    if (score != 0)
                    {
                        boardScore = score;
                    }

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"Board Score: {boardScore}");
                    Console.WriteLine($"Player Score: {playerScore}");
                    Console.WriteLine($"Computer Score: {computerScore}");
                    Console.ResetColor();

                    if (computerScore > precomputerscore)
                    {
                        if (score != 0)
                        {
                            precomputerscore = computerScore;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("End of Round!");
                            boardScore = 0;
                            round++;
                            if (round < 6)
                            {
                                Console.WriteLine($"Enter any key for start to Round {round}");
                                Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine("Game Over");
                                if (playerScore > computerScore)
                                {
                                    Console.WriteLine("PLAYER WON");
                                }
                                else if (playerScore < computerScore)
                                {
                                    Console.WriteLine("COMPUTER WON");
                                }
                                else
                                {
                                    Console.WriteLine("DRAW");
                                }
                                Console.ReadLine();
                                break;
                            }
                            Console.ResetColor();

                            if (round != 1)
                            {
                                Random createBoard = new Random();
                                a1 = createBoard.Next(1, 10);
                                a2 = createBoard.Next(1, 10);
                                while (a1 == a2)
                                {
                                    a2 = createBoard.Next(1, 10);
                                }
                                a3 = createBoard.Next(1, 10);
                                while (a3 == a2 || a3 == a1)
                                {
                                    a3 = createBoard.Next(1, 10);
                                }
                                b1 = createBoard.Next(1, 10);
                                while (b1 == a1 || b1 == a2 || b1 == a3)
                                {
                                    b1 = createBoard.Next(1, 10);
                                }
                                b2 = createBoard.Next(1, 10);
                                while (b2 == b1 || b2 == a1 || b2 == a2 || b2 == a3)
                                {
                                    b2 = createBoard.Next(1, 10);
                                }
                                b3 = createBoard.Next(1, 10);
                                while (b3 == b2 || b3 == b1 || b3 == a1 || b3 == a2 || b3 == a3)
                                {
                                    b3 = createBoard.Next(1, 10);
                                }
                                c1 = createBoard.Next(1, 10);
                                while ((c1 == a1) || (c1 == a2) || (c1 == a3) || (c1 == b1) || (c1 == b2) || (c1 == b3))
                                {
                                    c1 = createBoard.Next(1, 10);
                                }
                                c2 = createBoard.Next(1, 10);
                                while (c2 == a1 || c2 == a2 || c2 == a3 || c2 == b1 || c2 == b2 || c2 == b3 || c2 == c1)
                                {
                                    c2 = createBoard.Next(1, 10);
                                }
                                c3 = createBoard.Next(1, 10);
                                while (c3 == a1 || c3 == a2 || c3 == a3 || (c3 == b1) || (c3 == b2) || (c3 == b3) || (c3 == c1) || (c3 == c2))
                                {
                                    c3 = createBoard.Next(1, 10);
                                }
                                //SCORE CONTROL
                                comboCounter = 0;
                                score = 0;
                                //first row controlling
                                if (((a1 == a2 - 1) && (a2 == a3 - 1)) || ((a1 == a2 + 1) && (a2 == a3 + 1)))
                                {
                                    comboCounter++;
                                }
                                //second row controlling
                                if (((b1 == b2 - 1) && (b2 == b3 - 1)) || ((b1 == b2 + 1) && (b2 == b3 + 1)))
                                {
                                    comboCounter++;
                                }
                                //third row controlling
                                if (((c1 == c2 - 1) && (c2 == c3 - 1)) || ((c1 == c2 + 1) && (c2 == c3 + 1)))
                                {
                                    comboCounter++;
                                }
                                //first column controlling
                                if (((a1 == b1 - 1) && (b1 == c1 - 1)) || ((a1 == b1 + 1) && (b1 == c1 + 1)))
                                {
                                    comboCounter++;
                                }
                                //second column controlling
                                if (((a2 == b2 - 1) && (b2 == c2 - 1)) || ((a2 == b2 + 1) && (b2 == c2 + 1)))
                                {
                                    comboCounter++;
                                }
                                //third column controlling
                                if (((a3 == b3 - 1) && (b3 == c3 - 1)) || ((a3 == b3 + 1) && (b3 == c3 + 1)))
                                {
                                    comboCounter++;
                                }
                                //right to left diagonal controlling
                                if (((a3 == b2 - 1) && (b2 == c1 - 1)) || ((a3 == b2 + 1) && (b2 == c1 + 1)))
                                {
                                    comboCounter++;
                                }
                                //left to right diagonal controlling
                                if (((a1 == b2 - 1) && (b2 == c3 - 1)) || ((a1 == b2 + 1) && (b2 == c3 + 1)))
                                {
                                    comboCounter++;
                                }

                                if (comboCounter == 1)
                                {
                                    score = 1;
                                }
                                if (comboCounter == 2)
                                {
                                    score = 4;
                                }
                                if (comboCounter == 3)
                                {
                                    score = 9;
                                }
                                boardScore = score;
                            }

                        }
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine($"----------Round {round} ----------");
                        Console.WriteLine("   1 2 3  ");
                        Console.WriteLine(" + - - - +");
                        Console.WriteLine($"1| {a1} {a2} {a3} |");
                        Console.WriteLine($"2| {b1} {b2} {b3} |");
                        Console.WriteLine($"3| {c1} {c2} {c3} |");
                        Console.WriteLine(" + - - - +");
                        Console.ForegroundColor= ConsoleColor.Yellow;
                        Console.WriteLine($"Board Score: {boardScore}");
                        Console.WriteLine($"Player Score: {playerScore}");
                        Console.WriteLine($"Computer Score: {computerScore}");
                        Console.ResetColor();


                    }
                    if (playerScore > preplayerscore)
                    {
                        if (score != 0)
                        {
                            preplayerscore = playerScore;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("End of Round!");
                            boardScore = 0;
                            round++;
                            if (round < 6)
                            {
                                Console.WriteLine($"Enter any key for start to Round {round}");
                                Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine("Game Over");
                                if (playerScore > computerScore)
                                {
                                    Console.WriteLine("PLAYER WON");
                                }
                                else if (playerScore < computerScore)
                                {
                                    Console.WriteLine("COMPUTER WON");
                                }
                                else
                                {
                                    Console.WriteLine("DRAW");
                                }
                                Console.ReadLine();
                                break;
                            }
                            Console.ResetColor();

                            if (round != 1)
                            {
                                Random createBoard = new Random();
                                a1 = createBoard.Next(1, 10);
                                a2 = createBoard.Next(1, 10);
                                while (a1 == a2)
                                {
                                    a2 = createBoard.Next(1, 10);
                                }
                                a3 = createBoard.Next(1, 10);
                                while (a3 == a2 || a3 == a1)
                                {
                                    a3 = createBoard.Next(1, 10);
                                }
                                b1 = createBoard.Next(1, 10);
                                while (b1 == a1 || b1 == a2 || b1 == a3)
                                {
                                    b1 = createBoard.Next(1, 10);
                                }
                                b2 = createBoard.Next(1, 10);
                                while (b2 == b1 || b2 == a1 || b2 == a2 || b2 == a3)
                                {
                                    b2 = createBoard.Next(1, 10);
                                }
                                b3 = createBoard.Next(1, 10);
                                while (b3 == b2 || b3 == b1 || b3 == a1 || b3 == a2 || b3 == a3)
                                {
                                    b3 = createBoard.Next(1, 10);
                                }
                                c1 = createBoard.Next(1, 10);
                                while ((c1 == a1) || (c1 == a2) || (c1 == a3) || (c1 == b1) || (c1 == b2) || (c1 == b3))
                                {
                                    c1 = createBoard.Next(1, 10);
                                }
                                c2 = createBoard.Next(1, 10);
                                while (c2 == a1 || c2 == a2 || c2 == a3 || c2 == b1 || c2 == b2 || c2 == b3 || c2 == c1)
                                {
                                    c2 = createBoard.Next(1, 10);
                                }
                                c3 = createBoard.Next(1, 10);
                                while (c3 == a1 || c3 == a2 || c3 == a3 || (c3 == b1) || (c3 == b2) || (c3 == b3) || (c3 == c1) || (c3 == c2))
                                {
                                    c3 = createBoard.Next(1, 10);
                                }
                                //SCORE CONTROL
                                comboCounter = 0;
                                score = 0;
                                //first row controlling
                                if (((a1 == a2 - 1) && (a2 == a3 - 1)) || ((a1 == a2 + 1) && (a2 == a3 + 1)))
                                {
                                    comboCounter++;
                                }
                                //second row controlling
                                if (((b1 == b2 - 1) && (b2 == b3 - 1)) || ((b1 == b2 + 1) && (b2 == b3 + 1)))
                                {
                                    comboCounter++;
                                }
                                //third row controlling
                                if (((c1 == c2 - 1) && (c2 == c3 - 1)) || ((c1 == c2 + 1) && (c2 == c3 + 1)))
                                {
                                    comboCounter++;
                                }
                                //first column controlling
                                if (((a1 == b1 - 1) && (b1 == c1 - 1)) || ((a1 == b1 + 1) && (b1 == c1 + 1)))
                                {
                                    comboCounter++;
                                }
                                //second column controlling
                                if (((a2 == b2 - 1) && (b2 == c2 - 1)) || ((a2 == b2 + 1) && (b2 == c2 + 1)))
                                {
                                    comboCounter++;
                                }
                                //third column controlling
                                if (((a3 == b3 - 1) && (b3 == c3 - 1)) || ((a3 == b3 + 1) && (b3 == c3 + 1)))
                                {
                                    comboCounter++;
                                }
                                //right to left diagonal controlling
                                if (((a3 == b2 - 1) && (b2 == c1 - 1)) || ((a3 == b2 + 1) && (b2 == c1 + 1)))
                                {
                                    comboCounter++;
                                }
                                //left to right diagonal controlling
                                if (((a1 == b2 - 1) && (b2 == c3 - 1)) || ((a1 == b2 + 1) && (b2 == c3 + 1)))
                                {
                                    comboCounter++;
                                }

                                if (comboCounter == 1)
                                {
                                    score = 1;
                                }
                                if (comboCounter == 2)
                                {
                                    score = 4;
                                }
                                if (comboCounter == 3)
                                {
                                    score = 9;
                                }
                            }
                            boardScore = score;
                        }
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine($"----------Round {round}----------");
                        Console.WriteLine("   1 2 3  ");
                        Console.WriteLine(" + - - - +");
                        Console.WriteLine($"1| {a1} {a2} {a3} |");
                        Console.WriteLine($"2| {b1} {b2} {b3} |");
                        Console.WriteLine($"3| {c1} {c2} {c3} |");
                        Console.WriteLine(" + - - - +");
                        Console.ForegroundColor= ConsoleColor.Yellow;
                        Console.WriteLine($"Board Score: {boardScore}");
                        Console.WriteLine($"Player Score: {playerScore}");
                        Console.WriteLine($"Computer Score: {computerScore}");
                        Console.ResetColor();
                    }
                }
            }
            Console.ReadLine();

        }
    }
}


