using datosApi.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace datosApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DatosController : Controller
    {
        [HttpGet()]
        public async Task<List<datosClass>> GetDatos()
        {
            throw new NotImplementedException();
        }

        [HttpGet("{id}")]
        public async Task<datosClass> GetDatos(long id)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("{id}")]
        public async Task<bool> DeleteDatos(long id)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public async Task<datosClass> CreateDatos(createClass datos)
        {
            throw new NotImplementedException();
        }

        [HttpPut]
        public async Task<datosClass> updateDatos(datosClass datos)
        {
            throw new NotImplementedException();
        }
    }
}
