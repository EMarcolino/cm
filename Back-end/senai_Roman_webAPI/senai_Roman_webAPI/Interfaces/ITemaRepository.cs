using senai_Roman_webAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_Roman_webAPI.Interfaces
{
    /// <summary>
    /// Interface responsável por informar os métodos ao repositório TemaRepository
    /// </summary>
    interface ITemaRepository
    {
        /// <summary>
        /// Cadastra um novo tema
        /// </summary>
        /// <param name="novoTema">Objeto novaTema que será cadastrado</param>
        void CadastrarTema(Tema novoTema);

        /// <summary>
        /// Lista todos os temas
        /// </summary>
        /// <returns>Uma lista com os temas cadastrados</returns>
        List<Tema> ListarTemas();

        /// <summary>
        /// Busca um tema específica por seu id
        /// </summary>
        /// <param name="id">Id do tema que está sendo buscado</param>
        /// <returns>Um tema buscado</returns>
        Tema BuscarTemaPorId(int id);

        /// <summary>
        /// Atualiza um tema 
        /// </summary>
        /// <param name="id">Id do tema que será atualizado</param>
        /// <param name="temaAtualizado">Objeto temaAtualizado que contém as atualizações</param>
        void AtualizarTema(int id, Tema temaAtualizado);

        /// <summary>
        /// Deleta um tema
        /// </summary>
        /// <param name="id">Id do tema que será deletado</param>
        void DeletarTema(int id);
    }
}
