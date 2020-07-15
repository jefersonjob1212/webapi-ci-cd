using Webapi.ViewModel;

namespace Webapi.Services.Interfaces
{
    public interface IPessoaService
    {
        int CalcularIdade(PessoaViewModel viewModel);
    }
}