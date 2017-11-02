using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCarros.dominio {
    class Tela {

        public static void telaInicial() {
            Console.WriteLine("1 - Listar marcas");
            Console.WriteLine("2 - Listar carros de uma marca ordenadamente");
            Console.WriteLine("3 - Cadastrar marca");
            Console.WriteLine("4 - Cadastrar carro");
            Console.WriteLine("5 - Cadastrar acessório");
            Console.WriteLine("6 - Mostrar detalhes de um carro");
            Console.WriteLine("7 - Sair");
        }

        public static void mostrarMarcas() {
            Console.WriteLine("LISTAGEM DE MARCAS:");
            for (int i = 0; i<Program.marca.Count; i++) {
                Console.WriteLine(Program.marca[i]);
            }
            Console.WriteLine();
        }

        public static void mostrarCarrosDeUmaMarca() {
            Console.Write("Digite o código da marca: ");
            int codMarca = int.Parse(Console.ReadLine());
            int pos = Program.marca.FindIndex(x => x.codigo == codMarca);
            if (pos == -1) {
                throw new ModelException("Código de marca não encontrado: " + codMarca);
            }
            Console.WriteLine("Carros da marca " + Program.marca[pos].nome + ":");
            List<carro> lista = Program.marca[pos].carros;
            for (int i=0; i<lista.Count; i++) {
                Console.WriteLine(lista[i]);
            }
            Console.WriteLine();
        }

    }
}
