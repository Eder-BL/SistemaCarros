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

            while (opcao != 7) {
                Console.Clear();
                Tela.telaInicial();
                opcao = int.Parse(Console.ReadLine());

                Console.ReadLine();
            }

        }
    }
}
