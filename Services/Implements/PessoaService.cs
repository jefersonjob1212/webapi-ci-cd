using Webapi.Services.Interfaces;
using Webapi.ViewModel;

namespace Webapi.Services.Implements
{
    public class PessoaService : IPessoaService
    {
        public int CalcularIdade(PessoaViewModel viewModel)
        {
            return viewModel.CalcularIdade();
        }
    }
}