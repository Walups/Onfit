using System;

namespace IDontKnow{

    public class Aluno
    {
        
        public string name {get,set};
        public string age {get,set};
        public string email {get,set};
        public double altura {get,set};
        public double peso {get,set};
        public double IMC = peso / altura;

        private string senha;

        public string senha {get => senha, set => senha = value; }

    }

}
