using System;

namespace Teste1
{
    class Program
    {
        //TODO
        /* 
         * Desenvolva um método que receba a string "abbcbbb". O retorno desse método deverá ser "abcb", 
         * logo o próximo caracter não deverá ser igual ao anterior, o método deve ser capaz de tratar qualquer string.
        */

        static void Main(string[] args)
        {
            String avaliacao = "abbcbbb";

            char[] teste = avaliacao.ToCharArray();
            string resultado = "";

            for (int i = 0; i < teste.Length; i++)
            {

                if (i != teste.Length - 1)
                {
                    if (teste[i] != teste[i + 1])
                    {
                        resultado = resultado + teste[i];
                    }
                }
                else
                {
                    if (teste[i] != teste[i - 1])
                    {
                        resultado = resultado + teste[i];
                    }
                }
            }
            Console.Write(resultado);
        }
    }
}
