using System;
using System.Collections.Generic;

namespace Lab9
{
    class Program
    {
        //THIS IS CHAOS AND I AM SORRY..  
        //I lost down the while loop hole and it felt like my own recursive hell.
        public static int GetInput()
        {
            string input = Console.ReadLine();
            int newInput = int.Parse(input);
            return newInput;
        }
        static void Main(string[] args)
        {
            bool start = true;
            bool again = true;
            bool again2 = true;
            bool doAgain = true;
            bool repeat = true;
            bool repeat2 = true;
            bool repeat3 = true;
            List<string> name = new List<string>()
            {
                "",
                "Elisa",
                "Owen",
                "Agnes",
                "Mike",
                "Sharon",
                "Tony",
                "Abi",
                "Linda",
                "Jim",
                "Scott"
            };
            List<string> age = new List<string>()
            {
                "",
                "36",
                "3",
                "1",
                "67",
                "66",
                "29",
                "28",
                "60",
                "67",
                "57"
            };
            List<string> color = new List<string>()
            {
                "",
                "Pink",
                "Blue",
                "Yellow",
                "Red",
                "Green",
                "Navy",
                "Maize",
                "Purple",
                "Black",
                "Grey"
            };
            List<string> city = new List<string>()
            {
                "",
                "Chicago",
                "Los Angeles",
                "New Orleans",
                "New York",
                "Dublin",
                "Austin",
                "Seattle",
                "Detroit",
                "Toronto",
                "Vancouver"
            };
            List<string> options = new List<string>()
            {
                "",
                "Favorite Food",
                "Current Age",
                "Favorite City",
                "Favorite Color"
            };
            List<string> food = new List<string>()
            {
                "",
                "Pasta",
                "Chicken Nuggets",
                "Yogurt",
                "Chicken",
                "Salmon",
                "Burgers",
                "Cheesy Potatoes",
                "Desert",
                "Pizza",
                "Breakfast"
            };
            List<string> hometown = new List<string>()
            {
                "",
                "Minneapolis",
                "Ann Arbor",
                "Ann Arbor",
                "Wayne",
                "Dearborn",
                "Detroit",
                "Marquette",
                "Canada",
                "Detroit",
                "Detroit"
            };
            Console.WriteLine("Let me tell you about someone in the class!\n\n--------------------------------------------------\n");
            Console.WriteLine("Please choose from one of the following students:\n");

            while (start)
            {
                for (int index = 1; index < name.Count; index++)
                {
                    string s = name[index];
                    Console.WriteLine(index + " for " + s);
                }
                while (again)
                {
                    try
                    {
                        int choice = GetInput();
                        if (choice == 0)
                        {
                            Console.WriteLine("Please enter a number from the list.\n");
                            again = true;
                        }
                        else
                        {
                            Console.WriteLine($"\n{name[choice]} is from {hometown[choice]}.\n");
                            Console.WriteLine($"\nWould you like to learn more about {name[choice]}?  Please enter either 'Y' or 'N'");
                            again = false;
                        }

                        while (doAgain && again == false)
                        {
                            string keepGoing = Console.ReadLine();
                            if (keepGoing == "n" || keepGoing == "N")
                            {
                                while (doAgain && again == false)
                                {
                                    Console.WriteLine("Would you like to add more people");
                                    string addMore = Console.ReadLine();
                                    if (addMore == "n" || addMore == "N")
                                    {
                                        Console.WriteLine("\nThanks for the chat.  Have a great day!\n");
                                        return;
                                    }
                                    else if (addMore == "y" || addMore == "Y")

                                    {
                                        StudentInfo student = new StudentInfo("Drew", "Detroit", "Chicken");

                                        List<StudentInfo> studentList = new List<StudentInfo>();

                                        studentList.Add(student);

                                        Console.WriteLine("Add new student");
                                        while (repeat3)
                                        {

                                            Console.WriteLine("Give Me a new students name");
                                            string name2 = Console.ReadLine();
                                            Console.WriteLine("Give Me a new students hometown");
                                            string homeTown = Console.ReadLine();
                                            Console.WriteLine("Give Me a new students favorite food");
                                            string favoriteFood = Console.ReadLine();

                                            StudentInfo newStudent = new StudentInfo(name2, homeTown, favoriteFood);

                                            studentList.Add(new StudentInfo(name2, homeTown, favoriteFood));

                                            Console.WriteLine("Continue?");
                                            string input = Console.ReadLine();
                                            if (input.ToLower() != "y")
                                            {
                                                repeat3 = false;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("\nPlease enter either 'Y' or 'N'\n");
                                        doAgain = true;
                                    }
                                }
                            }
                            else if (keepGoing == "y" || keepGoing == "Y")

                            {
                                Console.WriteLine("\nGreat!  Please choose from the following:\n");
                                doAgain = false;
                            }
                            else
                            {
                                Console.WriteLine("\nPlease enter either 'Y' or 'N'\n");
                                doAgain = true;
                            }
                        }
                        while (repeat && again == false)
                        {
                            for (int index = 1; index < options.Count; index++)
                            {
                                string s = options[index];
                                Console.WriteLine(index + " for " + s);
                            }
                            repeat = false;
                            try
                            {
                                int choice2 = GetInput();
                                if (choice2 == 0)
                                {
                                    Console.WriteLine("\nPlease enter a number from the list:\n");
                                    repeat = true;
                                    again = false;
                                }
                                if (choice2 == 1)
                                {
                                    Console.WriteLine($"{name[choice]}'s favorite food is {food[choice]}.");
                                    again = false;
                                }
                                if (choice2 == 2)
                                {
                                    Console.WriteLine($"{name[choice]} is {age[choice]} years old.");
                                    again = false;
                                }
                                if (choice2 == 3)
                                {
                                    Console.WriteLine($"{name[choice]}'s favorite city is {city[choice]}.");
                                    again = false;
                                }
                                if (choice2 == 4)
                                {
                                    Console.WriteLine($"{name[choice]}'s favorite color is {color[choice]}.");
                                    again = false;
                                }
                                if (choice2 >= options.Count)
                                {
                                    Console.WriteLine("\nPlease enter a number from the list:\n");
                                    repeat = true;
                                    again = false;
                                }
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Please enter a number from the list.\n");
                                repeat = true;
                                again = false;
                            }

                            Console.WriteLine($"Would you like to learn more about {name[choice]}. Please enter either 'Y' or 'N'");

                            while (repeat2 && again2 == false)
                            {
                                string moreInfo = Console.ReadLine();
                                if (moreInfo == "n" || moreInfo == "N")
                                {
                                    Console.WriteLine("\nOK!\n");
                                    repeat = false;
                                    again = true;
                                }
                                else if (moreInfo == "y" || moreInfo == "Y")
                                {
                                    Console.WriteLine("\nGreat!  Please choose from the following:\n");
                                    repeat = true;
                                    again = false;
                                }
                                else
                                {
                                    Console.WriteLine("\nPlease enter either 'Y' or 'N'\n");
                                    repeat2 = true;
                                    again2 = false;
                                }
                            }
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Please enter a number from the list.\n");
                        again = true;
                    }
                    while (doAgain && again == false)
                    {
                        string keepGoing = Console.ReadLine();
                        if (keepGoing == "n" || keepGoing == "N")
                        {
                            Console.WriteLine("\nThanks for the chat.  Have a great day!\n");
                            return;
                        }
                        else if (keepGoing == "y" || keepGoing == "Y")

                        {
                            Console.WriteLine("\nGreat!  Please choose from the following:\n");
                            doAgain = false;
                        }
                        else
                        {
                            Console.WriteLine("\nPlease enter either 'Y' or 'N'\n");
                            doAgain = true;
                        }
                    }
                }
                start = false;
            }
            for (int index = 1; index < name.Count; index++)
            {
                string s = name[index];
                Console.WriteLine(index + " for " + s);
            }
        }
    }
}
