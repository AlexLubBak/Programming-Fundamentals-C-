using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Different_Integers_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = (Console.ReadLine());

            try
            {
                sbyte.Parse(number);

                if (sbyte.Parse(number)< 0)
                {
                    Console.WriteLine($"{number} can fit in:");
                    Console.WriteLine("* sbyte");
                    Console.WriteLine("* short");
                    Console.WriteLine("* int");
                    Console.WriteLine("* long");
                }
                else
                {
                    Console.WriteLine($"{number} can fit in:");
                    Console.WriteLine("* sbyte");
                    Console.WriteLine("* byte");
                    Console.WriteLine("* short");
                    Console.WriteLine("* ushort");
                    Console.WriteLine("* int");
                    Console.WriteLine("* uint");
                    Console.WriteLine("* long");
                }
               
            }
            catch (Exception)
            {

                try
                {
                    byte.Parse(number);

                    if (byte.Parse(number)<0)
                    {
                        Console.WriteLine($"{number} can fit in:");

                        
                        Console.WriteLine("* short");
                        Console.WriteLine("* int");
                        Console.WriteLine("* long");
                    }
                    else
                    {
                        Console.WriteLine($"{number} can fit in:");

                        Console.WriteLine("* byte");
                        Console.WriteLine("* short");
                        Console.WriteLine("* ushort");
                        Console.WriteLine("* int");
                        Console.WriteLine("* uint");
                        Console.WriteLine("* long");
                    }

                   

                }
                catch (Exception)
                {

                    try
                    {
                        short.Parse(number);
                        if (short.Parse(number)<0)
                        {
                            Console.WriteLine($"{number} can fit in:");

                            Console.WriteLine("* short");
                            Console.WriteLine("* int");
                            Console.WriteLine("* long");
                        }
                        else
                        {
                            Console.WriteLine($"{number} can fit in:");

                            Console.WriteLine("* short");
                            Console.WriteLine("* ushort");
                            Console.WriteLine("* int");
                            Console.WriteLine("* uint");
                            Console.WriteLine("* long");
                        }

                        
                    }
                    catch (Exception)
                    {

                        try
                        {
                            ushort.Parse(number);
                            if (ushort.Parse(number)<0)
                            {
                                Console.WriteLine($"{number} can fit in:");

                                
                                Console.WriteLine("* int");
                                Console.WriteLine("* long");
                            }
                            else
                            {
                                Console.WriteLine($"{number} can fit in:");

                                Console.WriteLine("* ushort");
                                Console.WriteLine("* int");
                                Console.WriteLine("* uint");
                                Console.WriteLine("* long");
                            }

                           
                        }
                        catch (Exception)
                        {

                            try
                            {
                                int.Parse(number);
                                if (int.Parse(number)<0)
                                {
                                    Console.WriteLine($"{number} can fit in:");

                                    Console.WriteLine("* int");
                                    Console.WriteLine("* long");
                                }
                                else
                                {
                                    Console.WriteLine($"{number} can fit in:");

                                    Console.WriteLine("* int");
                                    Console.WriteLine("* uint");
                                    Console.WriteLine("* long");
                                }

                                
                            }
                            catch (Exception)
                            {

                                try
                                {
                                    uint.Parse(number);
                                    if (uint.Parse(number)<0)
                                    {
                                        Console.WriteLine($"{number} can fit in:");
                                        
                                        Console.WriteLine("* long");
                                    }
                                    else
                                    {
                                        Console.WriteLine($"{number} can fit in:");
                                        
                                        Console.WriteLine("* uint");
                                        Console.WriteLine("* long");
                                    }

                                    
                                }
                                catch (Exception)
                                {
                                    try
                                    {
                                        long.Parse(number);

                                        Console.WriteLine($"{number} can fit in:");
                                        Console.WriteLine("* long");
                                    }
                                    catch (Exception)
                                    {

                                        Console.WriteLine($"{number} can't fit in any type");
                                    }
                                    
                                }
                            }
                        }
                    }
                }
            }

        }
    }
}
