
namespace CaixaEletronico.Usuarios
{
    public class Cliente
    {
        public string Nome { get; private set; }

        public Cliente(string nome)
        {
            Nome = nome;
        }
        public override string ToString()
        {
            return Nome;
        }
    }
}
