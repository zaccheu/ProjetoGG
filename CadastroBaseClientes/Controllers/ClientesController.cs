using CadastroClientes.Models;
using CadastroClientes.Models.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace CadastroClientes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        [HttpPost("Salvar")]
        public object Salvar([FromBody] Clientes cliente)
        {
            try
            {
                ClientesRepository clientes = new ClientesRepository();
                clientes.Salvar(cliente);
            }
            catch (Exception ex)
            {

            }
            return null;
        }


        [HttpPost("Alterar")]
        public object Alterar([FromBody] Clientes cadastro)
        {
            try
            {

            }
            catch { Exception ex; }
            {

            }

            return null; // se fosse void no lugar do object, não precisaria de object
        }

        [HttpGet("Listar")]
        public object Listar()
        {
            List<Clientes> listaCli = null;
            try
            {
                ClientesRepository clientesRepo = new ClientesRepository();
                listaCli = clientesRepo.Listar();
            }
            catch { Exception ex; }
            {

            }

            return listaCli;
            //return null; // se fosse void no lugar do object, não precisaria de object
        }

        [HttpDelete("Deletar")]
        public object Deletar(int IdCliente)
        {
            try
            {

            }
            catch { Exception ex; }
            {

            }

            return null; // se fosse void no lugar do object, não precisaria de object
        }
    }
}
