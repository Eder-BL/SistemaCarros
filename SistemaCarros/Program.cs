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
            

            // Iniciando os carros
            carro c1 = new dominio.carro(101, "Fusca", 1980, 5000.00, m1)

           
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

                }
                else if (opcao == 3) {

                }
                else if (opcao == 4) {

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
