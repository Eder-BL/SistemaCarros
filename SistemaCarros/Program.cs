using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SistemaCarros.dominio;

namespace SistemaCarros {
    class Program {

        public static List<carro> carro = new List<dominio.carro>();
        public static List<marca> marca = new List<dominio.marca>();

        static void Main(string[] args) {

            int opcao = 0;

            // Iniciando as marcas
            marca m1 = new marca(1001, "Volkswagen", "Alemanha");
            marca m2 = new marca(1002, "General Motors", "Estados Unidos");

            // Iniciando os carros
            carro c1 = new carro(101, "Fusca", 1980, 5000.00, m1);
            m1.addCarro(c1);
            carro c2 = new carro(102, "Golf", 2016, 60000.00, m1);
            m1.addCarro(c2);
            carro c3 = new carro(103, "Fox", 2017, 30000.00, m1);
            m1.addCarro(c3);
            carro c4 = new carro(104, "Cruze", 2016, 30000.00, m2);
            m2.addCarro(c4);
            carro c5 = new carro(105, "Cobalt", 2015, 25000.00, m2);
            m2.addCarro(c5);
            carro c6 = new carro(106, "Cobalt", 2017, 35000.00, m2);
            m2.addCarro(c6);

            // ARMAZENANDO AS MARCAS E CARROS NAS LISTAS LOCAIS DO PROGRAMA:
            marca.Add(m1);
            marca.Add(m2);
            carro.Add(c1);
            carro.Add(c2);
            carro.Add(c3);
            carro.Add(c4);
            carro.Add(c5);
            carro.Add(c6);
            
            while (opcao != 7) {
                Console.Clear();
                Tela.telaInicial();
                try {
                    opcao = int.Parse(Console.ReadLine());
                }
                catch (Exception e) {
                    Console.WriteLine("Erro inesperado: " + e.Message);
                    opcao = 0;
                }
                if (opcao == 1) {
                    Tela.mostrarMarcas();
                }
                else if (opcao == 2) {
                    Tela.mostrarCarrosDeUmaMarca();

                }
                else if (opcao == 3) {
                    Tela.cadastrarMarca();
                }
                else if (opcao == 4) {
                    try {
                        Tela.cadastrarCarro();
                    }
                    catch (ModelException e) {
                        Console.WriteLine("Erro de negócio: " + e.Message);
                    }
                    catch (Exception e) {
                        Console.WriteLine("Erro inesperado: " + e.Message);
                    }

                }
                else if (opcao == 5) {

                }
                else if (opcao == 6) {

                }
                else if (opcao == 7) {
                    Console.WriteLine("Fim do programa!");
                }
                else {
                    Console.WriteLine("Opção inválida!");
                }

                Console.ReadLine();
            }


        }
    }
}
