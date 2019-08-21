using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExercises
{
    class UniqueArray
    {
        public void Unique()
        {
            Random rng = new Random();
            Program pr = new Program();
            int[] newArray = new int[5];
            bool x = true;
            int count = 0;
            int[] check = new int[5];
            for (int i = 0; i < 5; i++)
            {
                newArray[i] = rng.Next(1,30);
                Console.WriteLine(newArray[i]);
                check[i] = newArray[i];
            }
            for (int i = 0; i < 5; i++)
            {
                if (newArray[0] == check[i])
                {
                    count += 1;
                }
                if (newArray[1] == check[i])
                {
                    count += 1;
                }
                if (newArray[2] == check[i])
                {
                    count += 1;
                }
                if (newArray[3] == check[i])
                {
                    count += 1;
                }
                if (newArray[4] == check[i])
                {
                    count += 1;
                }
            }
            if (count > 5)
            {
                x = false;
            }
            Console.WriteLine(count);
            Console.WriteLine($"IS IT UNIQUE: {x}");
            Console.ReadLine();
        }
    }
}
