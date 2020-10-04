using Refit;
using System;
using System.Threading.Tasks;

namespace BuscaCep
{
    public class Programa
    {
        static async Task Main(string[] args)
        {
            try
            {
                var cepClient = RestService.For<ICepApiService>("http://viacep.com.br/");
                Console.WriteLine("Informe seu CEP: ");

                String cepInformado = Console.ReadLine().ToString();
                Console.WriteLine("Consultando informacoes do CEP: " + cepInformado);

                var address = await cepClient.GetAddressAsync(cepInformado);

                Console.Write($"\nLogradouro:{address.Logradouro},\nBairro:{address.Bairro},\nCidade:{address.Localidade}");
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("Erro na consulta de cep");
            }
        }
    }
}