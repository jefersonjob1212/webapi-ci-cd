using System;

namespace Webapi.ViewModel
{
    public class PessoaViewModel
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }

        public int CalcularIdade() {
            return DateTime.Now.Year - DataNascimento.Year - 
                (DateTime.Today.DayOfYear < DataNascimento.DayOfYear ? 1 : 0);
        }
    }
}