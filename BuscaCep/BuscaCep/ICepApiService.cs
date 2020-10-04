using Refit;
using System.Threading.Tasks;

namespace BuscaCep
{
    public interface ICepApiService
    {
        [Get("/ws/{cep}/json/")]
        Task<CepResponse> GetAddressAsync(string cep);
    }
}
