using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExercises
{
    class Program
    {

        static void Main(string[] args)
        {
            string Ask(string _val)
            {
                Console.WriteLine(_val);
                return Console.ReadLine();
            }

            /* int x = 0;
              int[] values = { 2, 6, 10, 14 };
              Console.WriteLine(values[4]);
              Console.ReadKey();*/

            /*int[] data = new int[10];
            for (int i = 0; i < 10; i++)
            {
               
                data[i] = 10 - i;
                Console.WriteLine(data[i]);

            }
            Console.ReadKey();*/

            /*int[] numList = new int[5];
            int.TryParse(Ask("What is your first number?"), out numList[0]);
            int.TryParse(Ask("What is your second number?"), out numList[1]);
            int.TryParse(Ask("What is your third number?"), out numList[2]);
            int.TryParse(Ask("What is your fourth number?"), out numList[3]);
            int.TryParse(Ask("What is your fifth number?"), out numList[4]);
            Ask($"So your numbers are: {numList[4]} {numList[3]} {numList[2]} {numList[1]} {numList[0]}");*/

            /*int[] bigSmall = new int[2] {1000000000,-1000000000};
            int[] newNum = new int[10];
            int count = 1;
            for (int nums = 0; nums < 10; nums++)
            {
                int.TryParse(Ask("What is your " + count + " number?"), out newNum[nums]);
                count++;
                if (bigSmall[0] > newNum[nums])
                {
                    bigSmall[0] = newNum[nums];
                }
                if (bigSmall[1] < newNum[nums])
                {
                    bigSmall[1] = newNum[nums];
                }
            }
            Ask($"Your smallest and largest number is {bigSmall[0]} {bigSmall[1]}");*/

            /*int[,] grid = new int[3,3];
            int numAssigned = 1;
            for (int assign = 0; assign < 3; assign++)
            {
                for (int values = 0; values < 3; values++)
                {
                    grid[assign, values] = numAssigned;
                    numAssigned++;
                }
                Console.WriteLine($"{grid[assign, 0]} {grid[assign, 1]} {grid[assign, 2]}");
            }
            Console.ReadLine();*/

            /* int rowSum = 0;
             int columnSum = 0;
             int numAssigned = 1;
             int[,] days = new int [29,5];
             for (int assign = 0; assign < 29; assign++)
             {
                 for (int values = 0; values < 5; values++)
                 {
                     days[assign, values] = numAssigned;
                     numAssigned++;
                 }
             }
             for (int repeat = 0; repeat < 29; repeat++)
             {
                 for (int restart = 0; restart < 5; restart++)
                 {
                     rowSum += days[repeat, restart];
                 }
                 Console.WriteLine($"The sum of row {repeat + 1} is: {rowSum}");
                 rowSum = 0;
             }
             for (int repeat = 0; repeat < 5; repeat++)
             {
                 for (int restart = 0; restart < 29; restart++)
                 {
                     columnSum += days[restart, repeat];
                 }
                 Console.WriteLine($"The sum of column {repeat + 1} is: {columnSum}");
                 columnSum = 0;
             }
             Console.ReadLine();*/

            /*int[] characterHealth = new int[5] {100,100,100,100,100};
            int characterChosen;
            Random rng = new Random();
            int damage = 0;
            for (int moves = 0; moves < 5; moves++)
            {
                Console.WriteLine($"The current lifes are CH0:{characterHealth[0]} CH1:{characterHealth[1]} CH2:{characterHealth[2]}  CH3:{characterHealth[3]} CH4:{characterHealth[4]}");
                Console.WriteLine($"Your remaining moves are {5 - moves}");
                int.TryParse(Ask("What character do you want to pick to attack?"), out characterChosen);
                if (characterChosen != 0 && characterChosen != 1 && characterChosen != 2 && characterChosen != 3 && characterChosen != 4)
                {
                    Console.WriteLine("Please select an actual, usable number");
                    moves--;
                }
                else
                {
                    damage = rng.Next(30, 50);
                    Console.WriteLine(damage);
                    characterHealth[characterChosen] -= damage;
                    if (characterHealth[characterChosen] <= 0)
                    {
                        if (characterHealth[characterChosen] < -30)
                        {
                            moves--;
                        }
                        characterHealth[characterChosen] = 0;                   
                    }
                }
            }*/

            /*string[] dragonNames = new string[3] { "Biggie", "Smallie", "Average" };
            string[] dayNames = new string[7] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
            string exitCheck;
            int[,] dragonFood = new int[3, 7];
            int dragonType = 0;
            int dragonEaten = 0;
            float foodEaten = 0;
            float[] foodTotal = new float[3] {0,0,0};
            int[] recordFoodDragon = new int[2];
            int[] recordFoodAmount = new int[2];
            for (int assign = 0; assign < 100; assign++)
            {
                Console.WriteLine("Your dragons have been fed, fill out the paper work so I can give a report.");
                Console.WriteLine("REMEMBER: 0 is for Biggie 1 is for Smallie and 2 is for average");
                int.TryParse(Ask("What dragon's information are we filling out?"), out dragonType);
                if (dragonType == 0 || dragonType == 1 || dragonType == 2)
                {
                    for (int values = 0; values < 7; values++)
                    {
                        int.TryParse(Ask($"How much did {dragonNames[dragonType]} eat on {dayNames[values]}"), out dragonEaten);
                        dragonFood[dragonType, values] = dragonEaten;
                        foodEaten += dragonEaten;
                        if (dragonEaten > recordFoodAmount[0])
                        {
                            recordFoodAmount[0] = dragonEaten;
                            recordFoodDragon[0] = dragonType;
                        }
                        if (dragonEaten < recordFoodAmount[1])
                        {
                            recordFoodAmount[1] = dragonEaten;
                            recordFoodDragon[1] = dragonType;
                        }
                    }
                        Console.WriteLine($"The Dragon {dragonNames[assign]} ate a total of: {foodEaten}lbs!  Thats an average of {foodEaten / 7}lbs a day!");
                        foodTotal[dragonType] = foodEaten;
                        foodEaten = 0;
                }
                else
                {
                    Ask("Press ENTER and put a proper dragon value");
                    assign--;
                }
                exitCheck = Ask("WOULD YOU LIKE TO EXIT. <y/n>");
                if (exitCheck == "y")
                {
                    assign = 100;
                }
            }
            Console.WriteLine($"{dragonNames[0]} ate a total of {foodTotal[0]}, {dragonNames[1]} ate a total of {foodTotal[1]}, and {dragonNames[2]} ate a total of {foodTotal[2]}");
            Console.WriteLine($"{dragonNames[0]} {dragonNames[1] }{dragonNames[2]} ate a total of {foodTotal[0] + foodTotal[1] + foodTotal[2]}lbs! Thats an average of {(foodTotal[0] + foodTotal[1] + foodTotal[2])/7} a day!");
            Console.WriteLine($"The dragon who ate the most food was {recordFoodDragon[0]} with a whopping {recordFoodAmount[0]}lbs!");
            Console.WriteLine($"The dragon who ate the least food was {recordFoodDragon[1]} with a measly {recordFoodAmount[0]}lbs!");
            Console.ReadLine();*/
        }
    }
}