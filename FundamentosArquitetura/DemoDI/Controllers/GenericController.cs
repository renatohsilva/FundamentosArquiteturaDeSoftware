using DemoDI.Models;
using DemoDI.Repository.Interface;
using Microsoft.AspNetCore.Mvc;

namespace DemoDI.Controllers
{
    public class GenericController : Controller
    {
        private readonly IGenericRepository<Cliente> _clienteRepository;

        public GenericController(IGenericRepository<Cliente> clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public string? Index()
        {
            return _clienteRepository.Adicionar(new Cliente("Renato"));
        }
    }
}
