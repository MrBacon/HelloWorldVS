using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldVS
{
    class Program
    {

        /// <summary>
        /// A method is a series of statements
        /// statement is an instruction, something you want the program to do / read a line write a line / all statement end with semicolons
        /// statements are executed in the order they appear, from top to bottom
        /// expressions are statements that produce a value, for example (int x = 10) the value 10 is an expression (int answer = x + x) + is an operator 
        /// x+x is an expression that uses an operator
        /// nummeratic values and string values
        /// long answer = x + y; answer is a variable
        /// = means assignment (example: long answer = x + y;) assigning answer to x+y
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string name = args[0];
            long x = 4;                                                     ///assign the variable x  to the value 4 
            x +=  6;                                                        ///plus equals oprerator(+=) multiply (*=) / x = x + 6 (same as  / x += 6;) this will be assigned back to the variable x, so the variabla x will have the value 10
                                                                            ///example: x *= 2; multiply 4 times 2 / this will give the variable x the value 8
                                                                            ///x++; add one to x 
                                                                          
                                                                
            long result = 4 + x;                                            ///int or int32 / long or int64  (I capitol sensitive)    result is a variable
            long y = 2;
            long answer = x + y;          
           

            long a = 5;
            long b = 4;
            if (a !=b)                                                      ///preform a test if a is not equal to b than preform the following action
            { 
                a++;                                                        ///variable a add one to value 5
            }
            else
            {
                b += a;                                                     ///else if a is equal to b preform this action
            }
            long aaa = a + b;


            Console.WriteLine(aaa);
            Console.WriteLine(answer);
            Console.WriteLine(result.GetType().AssemblyQualifiedName);      ///shows fully qualified typename

            Console.WriteLine(result);                                      ///show result of the 4+4
            Console.WriteLine("Hello, " + name);                            ///run as helloworldvs.exe jord from command
            Console.WriteLine("Hello, World!");                             ///just the program holloworldvs.exe
            Console.WriteLine("Just a test");                               ///just a test                                 
            Console.ReadLine();                                             ///force you to press a key
                                                            
        }
    }
}


///RESULT = :)
///
///C:\temp\HelloWorldVS\HelloWorldVS\bin\Debug>helloworldvs.exe jord
///6
///System.Int64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c5
///61934e089
///8
///Hello, jord
///Hello, World!
///Just a test