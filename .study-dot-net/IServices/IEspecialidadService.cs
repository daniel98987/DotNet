using study_this_framework.Dtos;
using study_this_framework.IBase;

namespace study_this_framework.IServices
{
    public interface IEspecialidadService
    {
        Task<IResponseService> ListaEspecialidades();
        Task<IResponseService> CrearEspecialidad();

        Task<IResponseService> CreateSeveralEspecialtiesProcedure(IEnumerable<CrearEspecialidadDto> Especialties);
 
    }
}
