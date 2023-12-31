﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pila2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> pila = new Stack<int>();
            bool salir = true;

            while (salir)
            {
                Console.Clear();
                Console.WriteLine("// Select an option" +
                    "\n[1]: Enter a value " +
                    "\n[2]: Delete a value" +
                    "\n[3]: Show stack" +
                    "\n[4]: Exit");

                int opcion;

                try
                {
                    opcion = int.Parse(Console.ReadLine());

                    switch (opcion)
                    {

                        case 1:
                            Console.Clear();
                            Console.WriteLine("Enter a value:");
                            pila.Push(Convert.ToInt32(Console.ReadLine()));
                            break;

                        case 2:
                            Console.Clear();
                            if (pila.Count > 0)
                            {
                                int elementoDesapilado = pila.Pop();
                                Console.Clear();
                                Console.WriteLine("// Element popped from the stack: " + elementoDesapilado);
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("The stack is empty");
                            }

                            break;

                        case 3:
                            Console.Clear();
                            foreach (int i in pila)
                            {
                                Console.WriteLine(i);
                            }
                            break;

                        case 4:
                            salir = false;
                            Console.Clear();
                            Console.WriteLine("Good bye");
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.Clear();
                    Console.WriteLine("// Not a valid choice");
                }

                

                Console.ReadKey();
            }
        }
    }
}
