using Microsoft.AspNetCore.Authorization;
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
    /// Controller responsável pelos endpoints (URLs) referentes aos Especialidades
    /// </summary>

    // Define que o tipo de resposta da API será no formato JSON
    [Produces("application/json")]

    // Define que a rota de uma requisição será no formato dominio/api/nomeController
    // ex: http://localhost:5000/api/Especialidades
    [Route("api/[controller]")]

    //Define que é um controlador de API
    [ApiController]
    public class TemasController : ControllerBase
    {
        /// <summary>
        /// Objeto _temaRepository que irá receber todos os métodos definidos na interface ITemaRepository
        /// </summary>
        private ITemaRepository _temaRepository { get; set; }

        /// <summary>
        /// Instancia o objeto _temaRepository para que haja a referência aos métodos no repositório
        /// </summary>
        public TemasController()
        {
            _temaRepository = new TemaRepository();
        }

        /// <summary>
        /// Lista todas os temas
        /// </summary>
        /// <returns>Uma lista de temas e um status code 200 - Ok</returns>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                // Retorna a resposta da requisição fazendo a chamada para o método .ListarTemas
                // Retorna um status code 200 - Ok
                return Ok(_temaRepository.ListarTemas());
            }
            catch (Exception error)
            {
                return BadRequest(error);
            }
        }

        /// <summary>
        /// Busca um tema através do seu Id
        /// </summary>
        /// <param name="idtema">Id do tema que será buscado</param>
        /// <returns>Um tema buscado e um status code 200 - Ok</returns>
        [HttpGet("{idTema}")]
        public IActionResult GetById(int idtema)
        {
            try
            {
                // Retora a resposta da requisição fazendo a chamada para o método .BuscarEspecialidadePorId
                // Retorna um status code 200 - Ok
                return Ok(_temaRepository.BuscarTemaPorId(idtema));
            }
            catch (Exception error)
            {
                return BadRequest(error);
            }
        }

        /// <summary>
        /// Cadastra um novo tema
        /// </summary>
        /// <param name="novoTema">Objeto novoTema que será cadastrado</param>
        /// <returns>Um status code 201 - Created</returns>
        [HttpPost]
        [Authorize(Roles = "1")]
        public IActionResult Post(Tema novoTema)
        {
            try
            {
                // Faz a chamada para o método .CadastrarTema, enviando as informações para o banco de dados 
                _temaRepository.CadastrarTema(novoTema);

                // Retorna um status code 201 - Created
                return StatusCode(201);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        /// <summary>
        /// Atualiza um tema existente
        /// </summary>
        /// <param name="idTema">Id do tema que será atualizado</param>
        /// <param name="temaAtualizado">Objeto com as novas informações</param>
        /// <returns>Um status code 204 - No Content</returns>
        [HttpPut("{idTema}")]
        [Authorize(Roles = "1")]
        public IActionResult Put(int idTema, Tema temaAtualizado)
        {
            try
            {
                // Faz a chamada para o método .AtualizarTema, enviando as informações para o banco de dados
                _temaRepository.AtualizarTema(idTema, temaAtualizado);

                // Retorna um status code 204 - No Content
                return StatusCode(204);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        /// <summary>
        /// Deleta um tema existente
        /// </summary>
        /// <param name="idTema">Id do tema que será deletado</param>
        /// <returns>Um status code 204 - No Content</returns>
        [HttpDelete("{idTema}")]
        [Authorize(Roles = "1")]
        public IActionResult Delete(int idTema)
        {
            try
            {
                // Faz a chamada para o método .DeletarTema, enviando as informações para o banco de dados
                _temaRepository.DeletarTema(idTema);

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
