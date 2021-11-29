using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using senai_Roman_webAPI.Domains;
using senai_Roman_webAPI.Interfaces;
using senai_Roman_webAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_Roman_webAPI.Controllers
{
    /// <summary>
    /// Controller responsável pelos endpoints (URLs) referentes aos Projetos
    /// </summary>

    // Define que o tipo de resposta da API será no formato JSON
    [Produces("application/json")]

    // Define que a rota de uma requisição será no formato dominio/api/nomeController
    // ex: http://localhost:5000/api/Projetos
    [Route("api/[controller]")]

    //Define que é um controlador de API
    [ApiController]
    public class ProjetosController : ControllerBase
    {
        /// <summary>
        /// Objeto _projetoRepository que irá receber todos os métodos definidos na interface IProjetoRepository
        /// </summary>
        private IProjetoRepository _projetoRepository { get; set; }

        /// <summary>
        /// Instancia o objeto _projetoRepository para que haja a referência aos métodos no repositório
        /// </summary>
        public ProjetosController()
        {
            _projetoRepository = new ProjetoRepository();
        }

        /// <summary>
        /// Lista todos os projetos
        /// </summary>
        /// <returns>Uma lista de Projetos e um status code 200 - Ok</returns>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                // Retorna a resposta da requisição fazendo a chamada para o método .ListarProjetos
                // Retorna um status code 200 - Ok
                return Ok(_projetoRepository.ListarProjetos());
            }
            catch (Exception error)
            {
                return BadRequest(error);
            }
        }

        /// <summary>
        /// Busca um projeto através do seu Id
        /// </summary>
        /// <param name="idProjeto">Id do projeto que será buscado</param>
        /// <returns>Um projeto buscado e um status code 200 - Ok</returns>
        [HttpGet("{idUsuario}")]
        public IActionResult GetById(int idProjeto)
        {
            try
            {
                // Retora a resposta da requisição fazendo a chamada para o método .BuscarProjetoPorId
                // Retorna um status code 200 - Ok
                return Ok(_projetoRepository.BuscarProjetoPorId(idProjeto));
            }
            catch (Exception error)
            {
                return BadRequest(error);
            }
        }

        /// <summary>
        /// Cadastra um novo projeto
        /// </summary>
        /// <param name="novoProjeto">Objeto novoProjeto que será cadastrado</param>
        /// <returns>Um status code 201 - Created</returns>
        [HttpPost]
        public IActionResult Post(Projeto novoProjeto)
        {
            try
            {
                // Faz a chamada para o método .CadastrarProjeto, enviando as informações para o banco de dados 
                _projetoRepository.CadastrarProjeto(novoProjeto);

                // Retorna um status code 201 - Created
                return StatusCode(201);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        /// <summary>
        /// Atualiza um projeto existente
        /// </summary>
        /// <param name="idProjeto">Id do projeto que será atualizado</param>
        /// <param name="projetoAtualizado">Objeto com as novas informações</param>
        /// <returns>Um status code 204 - No Content</returns>
        [HttpPut("{idUsuario}")]
        public IActionResult Put(int idProjeto, Projeto projetoAtualizado)
        {
            try
            {
                // Faz a chamada para o método .AtualizarProjeto, enviando as informações para o banco de dados
                _projetoRepository.AtualizarProjeto(idProjeto, projetoAtualizado);

                // Retorna um status code 204 - No Content
                return StatusCode(204);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        /// <summary>
        /// Deleta um projeto existente
        /// </summary>
        /// <param name="idProjeto">Id do projeto que será deletado</param>
        /// <returns>Um status code 204 - No Content</returns>
        [HttpDelete("{idUsuario}")]
        public IActionResult Delete(int idProjeto)
        {
            try
            {
                // Faz a chamada para o método .DeletarProjeto, enviando as informações para o banco de dados
                _projetoRepository.DeletarProjeto(idProjeto);

                // Retorna um status code 204 - No Content
                return StatusCode(204);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
