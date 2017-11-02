using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace SistemaCarros.dominio {
    class carro : IComparable {
        public int codigo { get; set; }
        public string modelo { get; set; }
        public int ano { get; set; }
        public double precoBasico { get; set; }
        public marca marca { get; set; }
        public List<Acessorio> acessorios;

        public carro(int codigo, string modelo, int ano, double precoBasico, marca marca) {
            this.codigo = codigo;
            this.modelo = modelo;
            this.ano = ano;
            this.precoBasico = precoBasico;
            this.marca = marca;
            acessorios = new List<Acessorio>();
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
