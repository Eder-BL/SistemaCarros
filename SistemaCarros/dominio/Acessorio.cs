using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace SistemaCarros.dominio {
    class Acessorio {
        public string nome { get; set; }
        public double preco { get; set; }
        public carro carro { get; set; }

        public Acessorio(string nome, double preco, carro carro) {
            this.nome = nome;
            this.preco = preco;
            this.carro = carro;
        }

        public override string ToString() {
            return nome + ", Preço"
                + preco.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
