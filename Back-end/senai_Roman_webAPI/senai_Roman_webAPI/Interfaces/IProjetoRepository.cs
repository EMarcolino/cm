using senai_Roman_webAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_Roman_webAPI.Interfaces
{
    /// <summary>
    /// Interface responsável por informar os métodos ao repositório ProjetoRepository
    /// </summary>
    interface IProjetoRepository
    {
        /// <summary>
        /// Cadastra um novo projeto
        /// </summary>
        /// <param name="novoProjeto">Objeto novoProjeto que será cadastrado</param>
        void CadastrarProjeto(Projeto novoProjeto);

        /// <summary>
        /// Lista todos os projetos
        /// </summary>
        /// <returns>Uma lista com os projetos cadastrados</returns>
        List<Projeto> ListarProjetos();

        /// <summary>
        /// Busca um projeto específico por seu id
        /// </summary>
        /// <param name="id">Id do Projeto que está sendo buscado</param>
        /// <returns>Um projeto buscado</returns>
        Projeto BuscarProjetoPorId(int id);

        /// <summary>
        /// Atualiza uma projeto 
        /// </summary>
        /// <param name="id">Id do projeto que será atualizado</param>
        /// <param name="projetoAtualizado">Objeto projetoAtualizada que contém as atualizações</param>
        void AtualizarProjeto(int id, Projeto projetoAtualizado);

        /// <summary>
        /// Deleta um Ppojeto
        /// </summary>
        /// <param name="id">Id do projeto que será deletado</param>
        void DeletarProjeto(int id);
    }
}
