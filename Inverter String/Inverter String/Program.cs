using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inverter_String {
    internal class Program {
        private static void Main(string[] args) {


            Console.Write("Digite um nome: ");
            string nome = Console.ReadLine();

            char[] caracteres = nome.ToCharArray();
            int tamanho = caracteres.Length;

            for (int i = 0; i < tamanho / 2; i++) {
                char temp = caracteres[i];
                caracteres[i] = caracteres[tamanho - 1 - i];
                caracteres[tamanho - 1 - i] = temp;
            }

            string nomeInvertido = new string(caracteres);
            Console.WriteLine("Nome invertido: " + nomeInvertido);

            Console.ReadLine();
        }



    }

    }

