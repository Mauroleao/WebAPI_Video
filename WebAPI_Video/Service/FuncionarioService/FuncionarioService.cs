using WebAPI_Video.DataContext;
using WebAPI_Video.Models;

namespace WebAPI_Video.Service.FuncionarioService
{
    public class FuncionarioService : IFuncionarioInterface
    {
        private readonly ApplicationDbContext _context;
        public FuncionarioService(ApplicationDbContext context)
        {
            _context = context;
        }

        private readonly IFuncionarioInterface _funcionarioInterface;

        public FuncionarioService(IFuncionarioInterface funcionarioInterface)
        {
            _funcionarioInterface = funcionarioInterface;
        }

        public Task<ServiceResponse<List<FuncionarioModel>>> GetFuncionarios()
        {
            return _funcionarioInterface.GetFuncionarios();
        }

        public Task<ServiceResponse<List<FuncionarioModel>>> CreateFuncionarios(FuncionarioModel novoFuncionario)
        {
            return _funcionarioInterface.CreateFuncionarios(novoFuncionario);
        }

        public Task<ServiceResponse<FuncionarioModel>> GetFuncionarioById(int id)
        {
            return _funcionarioInterface.GetFuncionarioById(id);
        }

        public Task<ServiceResponse<FuncionarioModel>> UpdateFuncionario(FuncionarioModel editadoFuncionario)
        {
            return _funcionarioInterface.UpdateFuncionario(editadoFuncionario);
        }

        public Task<ServiceResponse<List<FuncionarioModel>>> DeleteFuncionario(int id)
        {
            return _funcionarioInterface.DeleteFuncionario(id);
        }

        public Task<ServiceResponse<List<FuncionarioModel>>> InativaFuncionario(int id)
        {
            return _funcionarioInterface.InativaFuncionario(id);
        }
    }
}
