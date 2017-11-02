using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace SistemaCarros.dominio {
    class carro {
        public int codigo { get; set; }
        public string modelo { get; set; }
        public int ano { get; set; }
        public double precoBasico { get; set; }

        public carro(int codigo, string modelo, int ano, double precoBasico) {
            this.codigo = codigo;
            this.modelo = modelo;
            this.ano = ano;
            this.precoBasico = precoBasico;
        }

        public void precoTotal() {

        }

        public override string ToString() {
            return codigo
                + ", "
                + modelo
                + ", Ano: "
                + ano
                + ", Preço básico: "
                + precoBasico.ToString("F2", CultureInfo.InvariantCulture)
                + ", Preço total: ";
        }

    }
}
