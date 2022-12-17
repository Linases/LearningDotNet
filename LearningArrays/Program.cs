using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace LearningArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] valuearray = new string[5] { "First", "Second", "Third", "Thourth", "Fifth" };
            
            for (int i = 0; i < valuearray.Length; i++)
            {
                string word = valuearray[i];
                Console.WriteLine(word);
            }


            int[] intArray = new int[20];

            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = i;
            }

            for (int i = intArray.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(intArray[i]);
            }
        }
                 
        }
    }

