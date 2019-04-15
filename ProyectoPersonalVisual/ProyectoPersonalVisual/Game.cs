using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPersonalVisual{
    class Game{
        public int Vidas = 5;
        public string SecretWord;
        public string ShownWord { get; private set; }
        public const string Hider = "*";
        public const char Space = ' ';
        public Game() {

        }
    }
}
