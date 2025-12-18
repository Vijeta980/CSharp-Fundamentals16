using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*3- Write a program and ask the user to enter the width and height of an image. 
 * Then tell if the image is landscape or portrait.
 * */

namespace CSharp_Fundamentals.PracticeQue1
{
    class Prog3
    {
        public static void prac3()
        {
            float width = 50.5f;
            float height = 20.5f;

            if (height > width)
            {
                Console.WriteLine("The image is Portrait");
            }
            else
            {
                Console.WriteLine("The image is landscape");
            }
        }
    }
}
