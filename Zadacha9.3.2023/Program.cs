using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha9._3._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("--------------------------------------------");
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            string commands = Console.ReadLine();
            while (commands != "print")
            {
                string[] token = commands.Split();
                string action = token[0];

                if (action == "push")
                {
                    int n = int.Parse(token[1]);
                    nums.Add(n);
                }
                else if (action == "pop")
                {
                    if (nums.Count > 0)
                    {
                        int number = nums[nums.Count - 1];
                        nums.RemoveAt(nums.Count - 1);
                        Console.WriteLine("Output 1: ");
                        Console.WriteLine("-----------------");
                        Console.WriteLine(number);
                        Console.WriteLine("-----------------");
                    }
                }
                else if (action == "shift")
                {
                    if (nums.Count > 0)
                    {
                        int number = nums[nums.Count - 1];
                        nums.RemoveAt(nums.Count - 1);
                        nums.Insert(0, number);
                    }
                }
                else if (action == "addMany")
                {
                    int ind = int.Parse(token[1]);
                    if (ind >= 0 && ind < nums.Count)
                    {
                        List<int> numbersToAdd = new List<int>();
                        for (int i = 2; i < token.Length; i++)
                        {
                            int numberAdd = int.Parse(token[i]);
                            numbersToAdd.Add(numberAdd);
                        }
                        nums.InsertRange(ind, numbersToAdd);
                    }
                }
                else if (action == "remove")
                {
                    int index = int.Parse(token[1]);
                    if (index >= 0 && index < nums.Count)
                    {
                        nums.RemoveAt(index);
                    }
                }
                commands = Console.ReadLine();
            }
            nums.Reverse();
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Output 2: ");
            Console.WriteLine(string.Join(" - ", nums));
            Console.WriteLine("--------------------------------------------");
        }
    }
}
