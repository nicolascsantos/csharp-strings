using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Humanizer;
using System.Text.RegularExpressions;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, mundo.");
            Console.WriteLine(123);
            Console.WriteLine(10.5);
            Console.WriteLine(true);

            object conta = new ContaCorrente(456, 687876);
            object desenvolvedor = new Desenvolvedor("123.456.789-54");

            string contaToString = conta.ToString();

            Console.WriteLine("Resultado: " + contaToString);
            Console.WriteLine("Resultado: " + conta);

            Cliente carlos_1 = new Cliente();
            carlos_1.Nome = "Carlos";
            carlos_1.CPF = "123.123.123-12";
            carlos_1.Profissao = "Designer";

            Cliente carlos_2 = new Cliente();
            carlos_2.Nome = "Carlos";
            carlos_2.CPF = "123.123.123-12";
            carlos_2.Profissao = "Designer";

            ContaCorrente conta2 = new ContaCorrente(456, 894785);

            if (carlos_1.Equals(carlos_2))
            {
                Console.WriteLine("São iguais");
            }
            else
            {
                Console.WriteLine("Não são iguais.");
            }

            Console.ReadLine();
        }
        static void TestaString()
        {
            //string padrao = "[0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]";
            //string padrao = "[0-9]{4,5}[-][0-9]{4}";
            //string padrao = "[0-9]{4,5}[-]{0,1}[0-9]{4}";
            //string padrao = "[0-9]{4,5}-{0,1}[0-9]{4}";

            string padrao = "[0-9]{4,5}-?[0-9]{4}";


            string textoDeTeste = "iasfajsdfjsdhfjsdh 91234-1234";

            Match resultado = Regex.Match(textoDeTeste, padrao);

            Console.WriteLine(resultado.Value);
            Console.WriteLine(resultado.Success);

            Console.ReadLine();


            string urlTeste = "https://www.bytebank.com/cambio";
            int indiceByteBank = urlTeste.IndexOf("http://www.bytebank.com");

            Console.WriteLine(urlTeste.StartsWith("https://www.bytebank.com"));
            Console.WriteLine(urlTeste.EndsWith("cambio"));


            Console.WriteLine("Contém Bytebank no Url? " + urlTeste.Contains("bytebank"));



            Console.ReadLine();

            string termoBusca = "ra";

            Console.WriteLine(termoBusca.ToLower());

            //Console.ReadLine();


            string urlParametros = "http://www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar&valor=2500";
            ExtratorValorDeArgumentosURL extratorDeValores = new ExtratorValorDeArgumentosURL(urlParametros);

            string valor = extratorDeValores.GetValor("moedaDestino");
            Console.WriteLine("Valor da moedaDestino: " + valor);

            string valor2 = extratorDeValores.GetValor("moedaOrigem");
            Console.WriteLine("Valor da moedaOrigem: " + valor2);

            Console.WriteLine(extratorDeValores.GetValor("VALOR"));


            Console.ReadLine();


            // Testando o método Remove
            string testeRemocao = "primeiraParte&parteParRemover";
            int indiceEComercial = testeRemocao.IndexOf('&');
            Console.WriteLine(testeRemocao.Remove(indiceEComercial));

            Console.ReadLine();
        }
    }
}
