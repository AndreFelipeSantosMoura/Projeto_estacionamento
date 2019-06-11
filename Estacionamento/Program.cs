using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Estacionamento {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("BEM VINDO AO E-CAR_SYSTEM");
            Console.WriteLine("Olá");
            Console.WriteLine("1 = SIM");
            Console.WriteLine("2 = NÃO");
            Console.WriteLine();

           var list = new List<Veiculo>();

            while (true) {
                Console.WriteLine("É Saída de veiculo?");
                bool saida = (Console.ReadLine().ToLower() == "1") ? true : false;

                if (!saida) {
                    Console.WriteLine("Digite a placa do veículo que irá estacionar: ");
                    var placa = Console.ReadLine();
                    Console.WriteLine("Digite o Marca: ");
                    var marca = Console.ReadLine();
                    Console.WriteLine("Digite a Modelo: ");
                    var modelo = Console.ReadLine();

                    list.Add(new Veiculo(placa, marca, modelo));

                    foreach (Veiculo obj in list) {
                        Console.WriteLine(obj);
                    }
                }

                    if (saida) {
                        Console.WriteLine("Digite a Placa do veículo que irá sair ");
                        var placa = Console.ReadLine();

                        var veiculo = list.FirstOrDefault(_ => _.Placa == placa);
                        list.Remove(veiculo);
                        foreach (Veiculo obj in list) {
                            Console.WriteLine(obj);
                        }
                    }
                }







                /*  if (x == '1') {
                      Console.WriteLine("Entrada de Veículo");
                      Console.Write("Placa: ");
                      string placa = Console.ReadLine();
                      Console.Write("Marca: ");
                      string marca = Console.ReadLine();
                      Console.Write("Modelo: ");
                      string modelo = Console.ReadLine();


                      list.Add(new Veiculo(placa, marca, modelo));
                  }

                  if (x == '2') {
                      var myobj = list.FirstOrDefault(_ => _.Placa == "cts");
                      list.Remove(myobj);
                  }

                  Console.WriteLine("Lista Atualizada");
                  foreach(Veiculo obj in list) {
                      Console.WriteLine(obj);
                  }
              }
              */


            }
        }
    }
