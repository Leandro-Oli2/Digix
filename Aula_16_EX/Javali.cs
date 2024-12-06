using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_16_EX
{
    public class Javali : Animal
    {
        public bool Selvagem;

        public Javali(bool vivo, bool selvagem) : base(vivo)
        {
            this.Selvagem = selvagem;
        }
        public int GetVelocidade(){
            return 100;
        }

        public virtual void SetSelvagem(bool s){
            this.Selvagem = s;
            if(this.Selvagem == true){
                Console.WriteLine("Javali se encontra em estado selvagem");
            }else{
                Console.WriteLine("Javali se encontra em estado não selvagem");
            }
        }
    }
}