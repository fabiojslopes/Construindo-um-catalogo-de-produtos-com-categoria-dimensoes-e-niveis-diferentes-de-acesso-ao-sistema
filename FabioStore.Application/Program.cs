using FabioStore.Application;
using FabioStore.Domain;
using System;

namespace FabioStore.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Perfil perfil = new Perfil
            {
                ID = 1,
                Descricao = "Administrador",
                Regra = "Pode acessar tudo",
                DataCadastro = DateTime.Now,
                Ativo = true
            };

            Usuario usuario = new Usuario(1, "Fabio", "fabiojslopes@hotmail.com", "123456", 1);

            usuario.Perfil = perfil;
            var usuarioPerfil = usuario.Perfil;
            string descricaoPrefil = usuarioPerfil.Descricao;

            var verificaAtivo = usuario.RetornarAtivo();

            usuario.Desativar();
            usuario.Desativar(0);
            var verificaAtivo2 = usuario.RetornarAtivo();

            usuario.Ativar();
            var verificaAtivo3 = usuario.RetornarAtivo();

            Produto produto = new Produto(1, "Mesa", "Mesa Escritorio MDF", 200.00M, 5);

            produto.ReporEstoque(15);

            var possuiestoque = produto.PossuiEstoque(10);
            if(possuiestoque)
            produto.DebitarEstoque(10);

            var possuiestoque2 = produto.PossuiEstoque(15);
            if(possuiestoque2)
            produto.DebitarEstoque(10);

            Console.WriteLine("Hello World!");

        }
    }
}
 