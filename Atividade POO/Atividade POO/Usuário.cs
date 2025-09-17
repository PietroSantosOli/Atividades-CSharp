namespace Atividade_POO
{
    public class Usuario : IAutenticavel
    {
        public string usuario;
        public string senha;
        public Usuario(string usuario, string senha)
        {
            this.usuario = usuario;
            this.senha = senha;
        }
        public bool Autenticar(string senha)
        {
            return this.senha == senha.ToLower();
        }
    }
    public class Admin : IAutenticavel
    {
        public string admin;
        public string senha;
        public Admin(string admin, string senha)
        {
            this.admin = admin;
            this.senha = senha;
        }
        public bool Autenticar(string senha)
        {
            return this.senha == senha.ToLower();
        }
    }
}
