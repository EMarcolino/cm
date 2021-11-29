using senai_Roman_webAPI.Contexts;
using senai_Roman_webAPI.Domains;
using senai_Roman_webAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_Roman_webAPI.Repositories
{
    public class TemaRepository : ITemaRepository
    {
        /// <summary>
        /// Objeto contexto por onde serão chamados os métodos do Entity Framework Core
        /// </summary>
        RomanContext ctx = new RomanContext();

        /// <summary>
        /// Atualiza um tema existente
        /// </summary>
        /// <param name="id">Id do tema que será atualizado</param>
        /// <param name="temaAtualizado">Objeto com as novas informações</param>
        public void AtualizarTema(int id, Tema temaAtualizado)
        {
            //Busca um tema através de seu ID
            Tema temaBuscado = ctx.Temas.Find(id);

            //Verifica se o nome do tema foi informada
            if (temaAtualizado.NomeTema != null)
            {
                //Atribui os novos valores aos campos existentes
                temaBuscado.NomeTema = temaAtualizado.NomeTema;
            }

            //Atualiza o nome da especialidade que foi buscado
            ctx.Temas.Update(temaBuscado);

            //Salva as informações no banco de dados
            ctx.SaveChanges();
        }

        /// <summary>
        /// Busca um tema por seu id
        /// </summary>
        /// <param name="id">Id do tema que está sendo buscado</param>
        /// <returns>Um tema buscado</returns>
        public Tema BuscarTemaPorId(int id)
        {
            //Retorna o primeiro tema encontrado, para o ID informado
            return ctx.Temas.FirstOrDefault(e => e.IdTema == id);
        }

        /// <summary>
        /// Cadastra um novo tema
        /// </summary>
        /// <param name="novoTema">Objeto novoTema que será cadastrado</param>
        public void CadastrarTema(Tema novoTema)
        {
            //Adiciona ao objeto novoTema as informações cadastradas
            ctx.Temas.Add(novoTema);

            //Salva as informações no banco de dados
            ctx.SaveChanges();
        }

        /// <summary>
        /// Deleta um tema existente
        /// </summary>
        /// <param name="id">Id do tema que será deletado</param>
        public void DeletarTema(int id)
        {
            //Busca um tema através de seu id
            Tema especialidadeBuscada = ctx.Temas.Find(id);

            //Remove um tema através de seu id
            ctx.Temas.Remove(especialidadeBuscada);

            //Salva as informações no banco de dados
            ctx.SaveChanges();
        }

        /// <summary>
        /// Lista todos os temas
        /// </summary>
        /// <returns>Uma lista de temas</returns>
        public List<Tema> ListarTemas()
        {
        //Retorna uma lista com todos os temas
        return ctx.Temas.ToList();
        }
    }
}
