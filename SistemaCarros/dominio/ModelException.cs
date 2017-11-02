using System;

namespace SistemaCarros.dominio {
    class ModelException : Exception {
        public ModelException(string msg) : base(msg) { }
    }
}
