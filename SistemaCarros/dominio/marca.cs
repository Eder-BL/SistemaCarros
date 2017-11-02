using System.Collections.Generic;

namespace SistemaCarros.dominio {
    class marca {
        public int codigo { get; set; }
        public string nome { get; set; }
        public string pais { get; set; }
        public List<carro> carros;

        public marca(int codigo, string nome, string pais) {
            this.codigo = codigo;
            this.nome = nome;
            this.pais = pais;
            carros = new List<carro>();
        }

        public void addCarro(carro c) {
            carros.Add(c);
            carros.Sort();
        }

        public override string ToString() {
            return codigo
                + ", "
                + nome
                + ", País: "
                + pais
                + ", Número de carros: "
                + carros.Count;
        }

    }
}
