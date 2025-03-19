// See https://aka.ms/new-console-template for more information

using System;
using System.Runtime.InteropServices;

PascaleTriangle(5);
NumTriangle(6);
revNum();
revAlpha();
Kpattern(5);
SandGlass();
AlphaK();
Alpha();
RevAlpha();
PatternAlpha();

     /* 
A B C D 
A B C 
A B 
A 
A 
A B 
A B C 
A B C D 

	 */

/* Pascale's Triangle ///
*
**
***
****
*****
******
*****
****
***
**
*
*/
void PascaleTriangle(int n)
{
    for (int i = 1; i <= n; i++)
    {
        for (int j = 1; j <= i; j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
    for (int i = 6; i >= 1; i--)
    {
        for (int j = 1; j <= i; j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();

    }
}
    /*
    1
    12
    123
    1234
    12345
    123456
        */
    static void NumTriangle(int n)
{
    for (int i = 1; i <= n; i++)
    {
        for (int j = 1; j <= i; j++)
        {
            Console.Write(j);
        }
        Console.WriteLine();
    }
}
        /*
4
43
432
4321*/
        static void revNum()
    {
    for(int i = 4; i >= 1; i--)
        {
        for(int j = 4; j >= i; j--)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }
    }
/*
A B C D 
A B C 
A B 
A */
	 
    static void revAlpha()
{
    for(int i = 4; i >= 1; i--)
    {
        int ch = 65;
    for(int j = 1; j <= i; j++)
        {
    
            Console.Write((char)ch + " ");
            ch++;
        }
        Console.WriteLine();
    }
}
/*
*****
****
***
**
*
*
**
***
****
*****
*/
static void Kpattern(int n){
for(int i = n; i>=1; i--)
    {
for(int j = 1; j <= i; j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
    for (int i = 1; i<=n; i++)
    {
        for (int j = 1; j <= i; j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}
/*
* * * * * *
 * * * * *
  * * * *
   * * *
    * *
     *
    * *
   * * *
  * * * *
 * * * * *
* * * * * *


	*/
static void SandGlass()
{
    for(int i = 6; i >= 1; i--)
    {
        for(int j = 1; j <= 6 - i; j++)
        {
            Console.Write(" ");
        }
        for(int j = 1; j <= i; j++)
        {
            Console.Write("* ");
        }
        Console.WriteLine();
    }
    for (int i = 2; i<=6; i++)
    {
        for (int j = 1; j <= 6 - i; j++)
        {
            Console.Write(" ");
        }
        for (int j = 1; j <= i; j++)
        {
            Console.Write("* ");
        }
        Console.WriteLine();
    }
}
/*  Alphabate K
	 * 
A B C D 
A B C 
A B 
A 
A 
A B 
A B C 
A B C D 

	 */
static void AlphaK()
{
    for(int i = 4; i >= 1; i--)
    {
        int ch = 65;
        for(int j = 1; j <= i; j++)
        {
            Console.Write((char)ch + " ");
            ch++;
        }
        Console.WriteLine();
    }
    for (int i = 1; i<=4; i++)
    {
        int ch = 65;
        for (int j = 1; j <= i; j++)
        {
            Console.Write((char)ch + " ");
            ch++;
        }
        Console.WriteLine();
    }
}
/*
   A
  A  B
 A  B  C
A  B  C  D  */
static void Alpha()
{
    for(int i = 1; i <= 4; i++)
    {
        int ch = 65;
    for(int j = 1; j <= 4 - i; j++)
        {
            Console.Write(" ");
        }
    for(int j = 1; j <= i; j++)
        {
            Console.Write((char)ch + "  ");
            ch++;
        }
        Console.WriteLine();
    }
}
/*
 A B C D E F
 A B C D E
  A B C D
   A B C
    A B
     A
*/
static void RevAlpha()
{
for(int i = 6; i >= 1; i--)
    {
        int ch = 65;
    for(int j = 1; j <= 6 - i; j++)
        {
            Console.Write(" ");
        }
    for(int j = 1; j <= i; j++)
        {
            Console.Write((char)ch + " ");
            ch++;
        }
        Console.WriteLine();
    }
}
static void PatternAlpha()
{
for(int i = 1; i <= 6; i++)
    {
        int ch = 65;
    for(int j = 1; j <= i; j++)
        {
            Console.Write((char)ch + "");
            ch++;
        }
        Console.WriteLine();
    }
    for (int i = 6-1; i>=1; i--)
    {
        int ch = 65;
        for (int j = 1; j <= i; j++)
        {
            Console.Write((char)ch + "");
            ch++;
        }
        Console.WriteLine();
    }
}
