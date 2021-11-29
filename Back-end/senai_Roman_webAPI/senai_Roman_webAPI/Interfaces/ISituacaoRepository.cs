using senai_Roman_webAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_Roman_webAPI.Interfaces
{
    /// <summary>
    /// Interface responsável por informar os métodos ao repositório SituacaoRepository
    /// </summary>
    interface ISituacaoRepository
    {
        /// <summary>
        /// Cadastra uma nova situação
        /// </summary>
        /// <param name="novoProjeto">Objeto novaSituacao que será cadastrado</param>
        void CadastrarSituacao(Situacao novoProjeto);

        /// <summary>
        /// Lista todas as situações
        /// </summary>
        /// <returns>Uma lista com as situações cadastradas</returns>
        List<Situacao> ListarSituacaos();

        /// <summary>
        /// Busca uma situação específica por seu id
        /// </summary>
        /// <param name="id">Id da situação que está sendo buscada</param>
        /// <returns>Um Projeto buscado</returns>
        Situacao BuscarSituacaoPorId(int id);

        /// <summary>
        /// Atualiza uma situação 
        /// </summary>
        /// <param name="id">Id da situação que será atualizada</param>
        /// <param name="situacaoAtualizada">Objeto situacaoAtualizada que contém as atualizações</param>
        void AtualizarSituacao(int id, Situacao situacaoAtualizada);

        /// <summary>
        /// Deleta uma situação
        /// </summary>
        /// <param name="id">Id da situação que será deletada</param>
        void DeletarSituacao(int id);
    }
}
