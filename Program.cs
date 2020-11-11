using System;

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

            string cidAm;
            string resp;
            string cidGo;
            string cidGoGo;
            string cidGoGoGo;
            string cidGoGoGoGo;

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
                            Console.WriteLine("Qual seria esta rota? : (ex: cidadeA,etc..)");
                            cidGoGo = Console.ReadLine();
                            if (cidGoGo == "cidadeC")
                            {
                                Console.WriteLine("Distancia da rota é 9 , cidadeA até cidadeB ao cidade C");
                                Console.WriteLine("Serão 3 rotas possiveis: A para C(via B,C,D) , A para C(via D,C,D); e A para C(via D,E,B");
                                Console.WriteLine("Distância de 3");
                                Console.WriteLine("\n");
                                Console.WriteLine("O Tamanho (da menor distancia) de A para C ");
                                Console.WriteLine("Distância de 8");
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
                            Console.WriteLine("Qual seria esta rota? : (ex: cidadeA,etc..)");
                            cidGoGo = Console.ReadLine();
                            if (cidGoGo == "cidadeC")
                            {
                                Console.WriteLine("Distancia da rota é 13 , cidadeA até cidadeB ao cidade C");

                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                    else if (cidGo == "cidadeE")
                    {
                        Console.WriteLine("Distancia da rota é 7 , cidadeA até cidade cidadeE\n");
                        Console.WriteLine("Deseja adicionar mais uma rota? sim digite 's' ");
                        resp = Console.ReadLine();

                        if (resp == "s")
                        {
                            Console.WriteLine("Qual seria esta rota? : (ex: cidadeA,etc..)");
                            cidGoGo = Console.ReadLine();

                            if (cidGoGo == "cidadeB")
                            {
                                Console.WriteLine("Distancia da rota é 10 , cidadeA até cidadeE ao cidade C \n");
                                Console.WriteLine("Digite a proxima rota (ex: cidadeA,etc..)");
                                cidGoGoGo = Console.ReadLine();

                                if (cidGoGoGo == "cidadeC")
                                {
                                    Console.WriteLine("Distancia da rota é 14 , cidadeA até cidadeE cidadeB  ao cidade C \n");
                                    Console.WriteLine("Digite a proxima rota (ex: cidadeA,etc..)");
                                    cidGoGoGoGo = Console.ReadLine();

                                    if (cidGoGoGoGo == "cidadeD")
                                    {
                                        Console.WriteLine("Distancia da rota é 22 , cidadeA até cidadeE e cidadeB ao cidade C e cidade D \n");
                                    }
                                }
                            }
                            else if (cidGoGo == "cidadeD")
                            {
                                Console.WriteLine("Rota não existente \n");
                            }
                        }
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
                        resp = Console.ReadLine();
                    }
                    if (cidGo == "cidadeB")
                    {
                        Console.WriteLine("o Tamanho da menor distancia B para B");
                        Console.WriteLine("Distância de 9");

                    }
                    else if (cidGo == "cidadeC")
                    {
                        Console.WriteLine("Distancia da rota é 4 , cidadeB até cidadeC");
                        Console.WriteLine("Deseja adicionar mais uma rota? sim digite 's'");
                        resp = Console.ReadLine();
                    }
                    else if (cidGo == "cidadeD")
                    {
                        Console.WriteLine("Distancia da rota é 5 , cidadeB até cidadeD");
                        Console.WriteLine("Deseja adicionar mais uma rota? sim digite 's'");
                        resp = Console.ReadLine();
                    }
                    else if (cidGo == "cidadeE")
                    {
                        Console.WriteLine("Distancia da rota é 7 , cidadeB até cidadeE");
                        Console.WriteLine("Deseja adicionar mais uma rota? sim digite 's'");
                        resp = Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Valor Inválido , ou rota Inválida");
                        Console.WriteLine("Deseja adicionar mais uma rota? sim digite 's'");
                        resp = Console.ReadLine();
                    }
                    break;

                case "cidadeC":

                    Console.WriteLine("Qual cidade você irá  (ex: cidadeC,etc..)");
                    cidGo = Console.ReadLine();

                    if (cidGo == "cidadeA")
                    {
                        Console.WriteLine("se houver , Distancia da rota é 5 , cidadeC até cidadeA ");
                        Console.WriteLine("Deseja adicionar mais uma rota? sim digite 's'");
                        resp = Console.ReadLine();

                        if (resp == "s")
                        {
                            Console.WriteLine("Qual seria esta rota? : (ex: cidadeA,etc..)");
                            cidGoGo = Console.ReadLine();
                            if (cidGoGo == "cidadeC") ;
                            {
                                Console.WriteLine("distancia de 2");
                                Console.WriteLine("Serão duas rotas possíveis: C-D-C (2 paradas) e C-E-B-C (3 paradas).");
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                    else if (cidGo == "cidadeB")
                    {
                        Console.WriteLine("Distancia da rota é 4 , cidadeC até cidadeC");
                        Console.WriteLine("Deseja adicionar mais uma rota? sim digite 's'");
                        resp = Console.ReadLine();
                        if (resp == "s")
                        {
                            Console.WriteLine("Qual seria esta rota? : (ex: cidadeA,etc..)");
                            cidGoGo = Console.ReadLine();
                            if (cidGoGo == "cidadeC")
                            {
                                Console.WriteLine("Serão duas rotas possíveis: C-D-C (2 paradas) e C-E-B-C (3 paradas).");
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                    else if (cidGo == "cidadeC")
                    {
                        Console.WriteLine("Serão as rotas segintes: C-D-C  e C-E-B-C , CEBCDC , CDCEBC, CDEBC , CEBCEBC.");
                        Console.WriteLine("Distancia de 7");
                    }
                    else if (cidGo == "cidadeD")
                    {
                        Console.WriteLine("Distancia da rota é 5 , cidadeC até cidadeD");
                        Console.WriteLine("Deseja adicionar mais uma rota? sim digite 's'");
                        resp = Console.ReadLine();
                        if (resp == "s")
                        {
                            Console.WriteLine("Qual seria esta rota? : (ex: cidadeA,etc..)");
                            cidGoGo = Console.ReadLine();
                            if (cidGoGo == "cidadeC")
                            {
                                Console.WriteLine("Serão duas rotas possíveis: C-D-C (2 paradas) e C-E-B-C (3 paradas).");

                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                    else if (cidGo == "cidadeE")
                    {
                        Console.WriteLine("Distancia da rota é 7 , cidadeC até cidadeE");
                        Console.WriteLine("Deseja adicionar mais uma rota? sim digite 's'");
                        resp = Console.ReadLine();
                        if (resp == "s")
                        {
                            Console.WriteLine("Qual seria esta rota? : (ex: cidadeA,etc..)");
                            cidGoGo = Console.ReadLine();
                            if (cidGoGo == "cidadeC")
                            {
                                Console.WriteLine("Serão duas rotas possíveis: C-D-C (2 paradas) e C-E-B-C (3 paradas).");

                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                    break;

                case "cidadeD":

                    Console.WriteLine("Qual cidade você irá  (ex: cidadeC,etc..)");
                    cidGo = Console.ReadLine();
                    if (cidGo == "cidadeA")
                    {
                        Console.WriteLine("se houver , Distancia da rota é 5 , cidadeB até cidadeB ");
                        Console.WriteLine("Deseja adicionar mais uma rota? sim digite 's'");
                        resp = Console.ReadLine();
                        if (resp == "s")
                        {
                            Console.WriteLine("Qual seria esta rota? : (ex: cidadeA,etc..)");
                            cidGoGo = Console.ReadLine();
                            if (cidGoGo == "cidadeC")
                            {
                                Console.WriteLine("Serão duas rotas possíveis: C-D-C (2 paradas) e C-E-B-C (3 paradas).");

                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                    else if (cidGo == "cidadeC")
                    {
                        Console.WriteLine("Distancia da rota é 4 , cidadeB até cidadeC");
                        Console.WriteLine("Deseja adicionar mais uma rota? sim digite 's'");
                        resp = Console.ReadLine();
                        if (resp == "s")
                        {
                            Console.WriteLine("Qual seria esta rota? : (ex: cidadeA,etc..)");
                            cidGoGo = Console.ReadLine();
                            if (cidGoGo == "cidadeC")
                            {
                                Console.WriteLine("Serão duas rotas possíveis: C-D-C (2 paradas) e C-E-B-C (3 paradas).");

                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                    else if (cidGo == "cidadeD")
                    {
                        Console.WriteLine("Distancia da rota é 5 , cidadeB até cidadeD");
                        Console.WriteLine("Deseja adicionar mais uma rota? sim digite 's'");
                        resp = Console.ReadLine();
                        if (resp == "s")
                        {
                            Console.WriteLine("Qual seria esta rota? : (ex: cidadeA,etc..)");
                            cidGoGo = Console.ReadLine();
                            if (cidGoGo == "cidadeC")
                            {
                                Console.WriteLine("Serão duas rotas possíveis: C-D-C (2 paradas) e C-E-B-C (3 paradas).");

                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                    else if (cidGo == "cidadeE")
                    {
                        Console.WriteLine("Distancia da rota é 7 , cidadeB até cidadeE");
                        Console.WriteLine("Deseja adicionar mais uma rota? sim digite 's'");
                        resp = Console.ReadLine();
                        if (resp == "s")
                        {
                            Console.WriteLine("Qual seria esta rota? : (ex: cidadeA,etc..)");
                            cidGoGo = Console.ReadLine();
                            if (cidGoGo == "cidadeC")
                            {
                                Console.WriteLine("Serão duas rotas possíveis: C-D-C (2 paradas) e C-E-B-C (3 paradas).");

                            }
                        }
                        else
                        {
                            break;
                        }
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
