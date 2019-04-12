using Eventos.IO.Domain.Core.Entities;

namespace Eventos.IO.Domain.Entities
{
    public class Eventos : Entity<Eventos>
    {
        public Eventos(string nome, string descricaoCurta)
        {
            this.Nome = nome;
            this.DescricaoCurta = descricaoCurta;

        }
        public string Nome { get; private set; }
        public string DescricaoCurta { get; private set; }

        public override bool EhValido()
        {
            return false;
        }
    }
}