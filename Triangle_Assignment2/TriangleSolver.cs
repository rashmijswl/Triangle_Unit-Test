using System;
using System.Collections.Generic;
using System.Text;

namespace Triangle_Assignment2
{
    public static class TriangleSolver
    {
        public static string triangle_type = string.Empty;

        public static string Analyze(int a, int b, int c)
        {
            // checking sum of 2 sides
            int c1 = a + b;
            int b1 = a + c;
            int a1 = b + c;
            //it would enter the if only if the sides satisfy the condition "sum of 2 sides is always greater than 3rd"
            if(c1>c && b1>b && a1>a)
            {
                //if all 3 are equal only it enter equilateral else it would be isoceles if only 2 sides are equal
                if(a == b && b == c && c == a)
                {
                    triangle_type = "Equilateral";                
                }
                else if(a == b || b == c || a == c)
                {
                    triangle_type = "Isosceles";
                }
                else // it would be a scalene triangle if it is not a equlateral or isosceles
                {
                    triangle_type = "Scalene";
                }                
            }
            else
            {
                triangle_type = "Not a Triangle";               
            }
            return triangle_type;
        }
    }
}
