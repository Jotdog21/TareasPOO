using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Dados
    {
        private int Valor = 0;
        private string Color = "";

        public Dados (int Valor, string Color)
        {
            this.Valor = Valor;
            this.Color = Color.ToString();
        }

        public Dados()
        {
        }


        public static Dados operator < (Dados dado1, Dados dado2)
        {
            if (dado1.Valor < dado2.Valor)
            {
                Console.WriteLine("El primer dado es menor que el segundo");
                return new Dados(dado2.Valor, dado2.Color);
            }
            else
            {
                Console.WriteLine("El primer dado no es menor que el segundo");
                return new Dados(dado1.Valor, dado1.Color);
            }
            
        }

        public static Dados operator <= (Dados dado1, Dados dado2)
        {
            return new Dados();
        }

        public static Dados operator > (Dados dado1, Dados dado2)
        {
            if (dado1.Valor > dado2.Valor)
            {
                Console.WriteLine("El segundo dado es menor que el primero");
                return new Dados();
            }
            
            else
            {
                Console.WriteLine("El segundo dado no es menor que el primero");
                return new Dados();
            }

        }

        public static Dados operator >= (Dados dado1, Dados dado2)
        {
            return new Dados(0,"");
        }

        public static bool operator == (Dados D1, bool D2)
        {
            if (D1 == D2)
            {
                return true;
            }
            return false;
        }

        public static bool operator != (Dados D1, bool D2)
        {
            if (D1 == D2)
            {
                return true;
            }
            return false;
        }
        
        public void Imprimir()
        {
            Console.WriteLine(Valor.ToString());
            Console.WriteLine(Color);
        }
    }
}