﻿using System;

namespace test_pratico_master
{
    class Program
    {
        static void Main(string[] args)
        {

            int dAB = 5;
            int dBC = 4;
            int dCD = 8;
            int dDC = 8;
            int dDE = 6;
            int dAD = 5;
            int dCE = 2;
            int dEB = 3;
            int dAE = 7;

            String cidAm;
            String cidGo;
            string cidGoGo;
            string resp;

            Console.WriteLine("Qual cidade você está:  (ex: cidadeA,etc..) ");
            cidAm = Console.ReadLine();

            switch (cidAm)
            {
                //verrificação
                case "cidadeA":

                    Console.WriteLine("Qual cidade você irá  (ex: cidadeA,etc..)");
                    cidGo = Console.ReadLine();

                    if (cidGo == "cidadeB")
                    {
                        Console.WriteLine("Distancia da rota é 5 , cidadeA até cidadeB ");
                        Console.WriteLine("Deseja adicionar mais uma rota? sim digite 's'");
                        resp = Console.ReadLine();

                        if (resp == "s")
                        {
                            Console.WriteLine("Qual seria esta rota? :");
                            cidGoGo = Console.ReadLine();
                            if (cidGoGo == "cidadeC")
                            {
                                Console.WriteLine("Distancia da rota é 9 , cidadeA até cidadeB ao cidade C");
                            }
                            else
                            {
                                Console.WriteLine("Rota não registrada");

                            }
                        }
                        else
                        {
                            break;
                        }

                    }

                    else if (cidGo == "cidadeC")
                    {
                        Console.WriteLine("Distancia da rota é 9 , cidadeA até cidadeC");
                        Console.WriteLine("Deseja adicionar mais uma rota? sim digite 's'");
                        cidGoGo = Console.ReadLine();
                    }

                    else if (cidGo == "cidadeD")
                    {
                        Console.WriteLine("Distancia da rota é 5 , cidadeA até cidadeD");
                        Console.WriteLine("Deseja adicionar mais uma rota? sim digite 's'");
                        resp = Console.ReadLine();

                        if (resp == "s")
                        {
                            Console.WriteLine("Qual seria esta rota? :");
                            cidGoGo = Console.ReadLine();
                            if (cidGoGo == "cidadeC")
                            {
                                Console.WriteLine("Distancia da rota é 9 , cidadeA até cidadeB ao cidade C");
                            }

                        }
                        else
                        {
                            break;
                        }
                    }
                    else if (cidGo == "cidadeE")
                    {
                        Console.WriteLine("Distancia da rota é 7 , cidadeA até cidadeE");
                        Console.WriteLine("Deseja adicionar mais uma rota? sim digite 's'");
                        cidGoGo = Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Valor Inválido");
                    }
                    break;

                case "cidadeB":

                    Console.WriteLine("Qual cidade você irá  (ex: cidadeA,etc..)");
                    cidGo = Console.ReadLine();


                    if (cidGo == "cidadeA")
                    {
                        Console.WriteLine("se houver , Distancia da rota é 5 , cidadeB até cidadeB ");
                        Console.WriteLine("Deseja adicionar mais uma rota? sim digite 's'");
                        cidGoGo = Console.ReadLine();
                    }
                    else if (cidGo == "cidadeC")
                    {
                        Console.WriteLine("Distancia da rota é 4 , cidadeB até cidadeC");
                        Console.WriteLine("Deseja adicionar mais uma rota? sim digite 's'");
                        cidGoGo = Console.ReadLine();
                    }
                    else if (cidGo == "cidadeD")
                    {
                        Console.WriteLine("Distancia da rota é 5 , cidadeB até cidadeD");
                        Console.WriteLine("Deseja adicionar mais uma rota? sim digite 's'");
                        cidGoGo = Console.ReadLine();
                    }
                    else if (cidGo == "cidadeE")
                    {
                        Console.WriteLine("Distancia da rota é 7 , cidadeB até cidadeE");
                        Console.WriteLine("Deseja adicionar mais uma rota? sim digite 's'");
                        cidGoGo = Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Valor Inválido , ou rota Inválida");
                        Console.WriteLine("Deseja adicionar mais uma rota? sim digite 's'");
                        cidGoGo = Console.ReadLine();
                    }

                    break;

                case "cidadeC":

                    Console.WriteLine("Qual cidade você irá  (ex: cidadeC,etc..)");
                    cidGo = Console.ReadLine();

                    if (cidGo == "cidadeA")
                    {
                        Console.WriteLine("se houver , Distancia da rota é 5 , cidadeB até cidadeB ");
                        Console.WriteLine("Deseja adicionar mais uma rota? sim digite 's'");
                        cidGoGo = Console.ReadLine();


                    }
                    else if (cidGo == "cidadeB")
                    {
                        Console.WriteLine("Distancia da rota é 4 , cidadeC até cidadeC");
                        Console.WriteLine("Deseja adicionar mais uma rota? sim digite 's'");
                        cidGoGo = Console.ReadLine();
                    }
                    else if (cidGo == "cidadeD")
                    {
                        Console.WriteLine("Distancia da rota é 5 , cidadeC até cidadeD");
                        Console.WriteLine("Deseja adicionar mais uma rota? sim digite 's'");
                        cidGoGo = Console.ReadLine();
                    }
                    else if (cidGo == "cidadeE")
                    {
                        Console.WriteLine("Distancia da rota é 7 , cidadeC até cidadeE");
                        Console.WriteLine("Deseja adicionar mais uma rota? sim digite 's'");
                        cidGoGo = Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Valor Inválido , ou rota Inválida");
                    }

                    break;

                case "cidadeD":

                    Console.WriteLine("Qual cidade você irá  (ex: cidadeC,etc..)");
                    cidGo = Console.ReadLine();
                    if (cidGo == "cidadeA")
                    {
                        Console.WriteLine("se houver , Distancia da rota é 5 , cidadeB até cidadeB ");
                        Console.WriteLine("Deseja adicionar mais uma rota? sim digite 's'");
                        cidGoGo = Console.ReadLine();
                    }
                    else if (cidGo == "cidadeC")
                    {
                        Console.WriteLine("Distancia da rota é 4 , cidadeB até cidadeC");
                        Console.WriteLine("Deseja adicionar mais uma rota? sim digite 's'");
                        cidGoGo = Console.ReadLine();
                    }
                    else if (cidGo == "cidadeD")
                    {
                        Console.WriteLine("Distancia da rota é 5 , cidadeB até cidadeD");
                        Console.WriteLine("Deseja adicionar mais uma rota? sim digite 's'");
                        cidGoGo = Console.ReadLine();
                    }
                    else if (cidGo == "cidadeE")
                    {
                        Console.WriteLine("Distancia da rota é 7 , cidadeB até cidadeE");
                        Console.WriteLine("Deseja adicionar mais uma rota? sim digite 's'");
                        cidGoGo = Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Valor Inválido , ou rota Inválida");
                    }

                    break;

                case "cidadeE":

                    Console.WriteLine("Qual cidade você irá  (ex: cidadeC,etc..)");
                    cidGo = Console.ReadLine();
                    if (cidGo == "cidadeA")
                    {
                        Console.WriteLine("se houver , Distancia da rota é 5 , cidadeB até cidadeB ");
                        Console.WriteLine("Deseja adicionar mais uma rota? sim digite 's'");
                        cidGoGo = Console.ReadLine();

                    }
                    else if (cidGo == "cidadeC")
                    {
                        Console.WriteLine("Distancia da rota é 4 , cidadeB até cidadeC");
                        Console.WriteLine("Deseja adicionar mais uma rota? sim digite 's'");
                        cidGoGo = Console.ReadLine();
                    }
                    else if (cidGo == "cidadeD")
                    {
                        Console.WriteLine("Distancia da rota é 5 , cidadeB até cidadeD");
                        Console.WriteLine("Deseja adicionar mais uma rota? sim digite 's'");
                        cidGoGo = Console.ReadLine();
                    }
                    else if (cidGo == "cidadeE")
                    {
                        Console.WriteLine("Distancia da rota é 7 , cidadeB até cidadeE");
                        Console.WriteLine("Deseja adicionar mais uma rota? sim digite 's'");
                        cidGoGo = Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Valor Inválido , ou rota Inválida");
                    }

                    break;
            }
        }
    }
}
