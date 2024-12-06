using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_16_EX
{
    public class Cobra : Animal
    {
        public bool Venenosa;

        public Cobra(bool vivo, bool venenosa) : base(vivo)
        {
            this.Venenosa = venenosa;
        }

        public void Alimento(string a){
            System.Console.WriteLine("Cobra Alimentada com " + a);
        }
        public virtual void venenosa(bool venenosa){
            this.Venenosa = venenosa;
            if(this.Venenosa == true){
                System.Console.WriteLine("Cobra Venenosa!");
            }else{
                System.Console.WriteLine("Cobra Não Venenosa!");
            }
        }
    }
}