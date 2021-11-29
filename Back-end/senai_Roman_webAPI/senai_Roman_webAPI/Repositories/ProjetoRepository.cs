using senai_Roman_webAPI.Contexts;
using senai_Roman_webAPI.Domains;
using senai_Roman_webAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_Roman_webAPI.Repositories
{
    /// <summary>
    /// Classe responsável por declarar a implementação dos métodos para ProjetoController
    /// </summary>
    public class ProjetoRepository : IProjetoRepository
    {
        /// <summary>
        /// Objeto contexto por onde serão chamados os métodos do Entity Framework Core
        /// </summary>
        RomanContext ctx = new RomanContext();

        /// <summary>
        /// Atualiza um projeto existente
        /// </summary>
        /// <param name="id">Id do projeto que será atualizado</param>
        /// <param name="projetoAtualizado">Objeto com as novas informações</param>
        public void AtualizarProjeto(int id, Projeto projetoAtualizado)
        {
            //Busca uma consulta através de seu ID
            Projeto projetoBuscado = ctx.Projetos.Find(id);

            //Verifica se o Id do situação foi informada
            if (projetoAtualizado.IdSituacao != null)
            {
                //Atribui os novos valores aos campos existentes
                projetoBuscado.IdSituacao = projetoAtualizado.IdSituacao;
            }

            //Verifica se o Id do paciente na consulta foi informado
            if (projetoAtualizado.IdTema != null)
            {
                //Atribui os novos valores aos campos existentes
                projetoBuscado.IdTema = projetoAtualizado.IdTema;
            }
                        
            //Verifica se nome do projeto foi informado
            if (projetoAtualizado.NomeProjeto != null)
            {
                //Atribui os novos valores aos campos existentes
                projetoBuscado.NomeProjeto = projetoAtualizado.NomeProjeto;
            }

            //Verifica se a descrição do projeto foi informada
            if (projetoAtualizado.DescricaoProjeto != null)
            {
                //Atribui os novos valores aos campos existentes
                projetoBuscado.DescricaoProjeto = projetoAtualizado.DescricaoProjeto;
            }

            //Atualiza o projeto que foi buscado
            ctx.Projetos.Update(projetoBuscado);

            //Salva as informações no banco de dados
            ctx.SaveChanges();
        }

        public Projeto BuscarProjetoPorId(int id)
        {
            //Retorna o primeiro projeto encontrado, para o ID informado
            return ctx.Projetos.FirstOrDefault(c => c.IdProjeto == id);
        }

        /// <summary>
        /// Cadastra uma novo projeto
        /// </summary>
        /// <param name="novoProjeto">Objeto novoProjeto que será cadastrada</param>
        public void CadastrarProjeto(Projeto novoProjeto)
        {
            //Adiciona ao objeto novoProjeto as informações cadastradas
            ctx.Projetos.Add(novoProjeto);

            //Salva as informações no banco de dados
            ctx.SaveChanges();
        }

        /// <summary>
        /// Deleta um projeto existente
        /// </summary>
        /// <param name="id">Id da projeto que será deletado</param>
        public void DeletarProjeto(int id)
        {
            //Busca um projeto através de seu id
            Projeto pacienteBuscado = ctx.Projetos.Find(id);

            //Remove um projeto através de seu id
            ctx.Projetos.Remove(pacienteBuscado);

            //Salva as informações no banco de dados
            ctx.SaveChanges();
        }

        /// <summary>
        /// Lista as Consultas de projetos
        /// </summary>
        /// <returns>Uma lista de projetos</returns>
        public List<Projeto> ListarProjetos()
        {
            //Retorna uma lista com todos os projetos
            return ctx.Projetos.ToList();
        }
    }
}
