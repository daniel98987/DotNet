using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using study_this_framework.Dtos;
using study_this_framework.IBase;
using study_this_framework.interfaceRepositories;
using study_this_framework.IServices;
using study_this_framework.models;
using System.Data;

namespace study_this_framework.Services
{
    public class EspecialidadService : IEspecialidadService
    {
        private readonly IResponseService _responseService;
        private readonly IGenericRepository<Especialidad> _genericRepository;
        private  HospitalDbContext _context;
        private readonly string _connectionString;

        public EspecialidadService(IConfiguration configuration, IResponseService responseService, HospitalDbContext context,IGenericRepository<Especialidad> genericRepository)
        {
            _responseService = responseService;
            _context = context;
            _genericRepository = genericRepository;
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }
        public Task<IResponseService> CrearEspecialidad()
        {
               throw new NotImplementedException();
        }

        public async Task<IResponseService> ListaEspecialidades()
        {
            try
            {
                _responseService.EstablecerRespuestaLista(true, await _genericRepository.GetAllAsync(o => o.OrderBy(x => x.NombreEspecialidad)));
                return _responseService;
            }
            catch (Exception ex)
            {
                _responseService.Estado = false;
                _responseService.Errores.Add(ex.Message);
                return _responseService;
            }
        }

        public async Task<IResponseService> CreateSeveralEspecialtiesProcedure(IEnumerable<CrearEspecialidadDto> Especialties)
        {
            try {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    using (var command = new SqlCommand("SeveralEspecialtiesInsert", connection)
                    {
                        CommandType = CommandType.StoredProcedure
                    })
                    {
                        DataTable tvpEspecialidades = new DataTable();
                        tvpEspecialidades.Columns.Add(new DataColumn("Especialidad", typeof(string)));
                        foreach (var especialidad in Especialties)
                        {
                            tvpEspecialidades.Rows.Add(especialidad.NombreEspecialidad);
                        }
                        SqlParameter tvpParam = command.Parameters.AddWithValue("@ListEspecialties", tvpEspecialidades);
                        tvpParam.SqlDbType = SqlDbType.Structured;
                        tvpParam.TypeName = "dbo.EspecialidadTipoTabla"; // Nombre exacto del TVP en SQL Server

                        connection.Open();
                        await command.ExecuteNonQueryAsync();
                    }
                }
                _responseService.Estado = true;
                return _responseService;
            }
            catch(Exception ex)
            {
                _responseService.Estado = false;
                _responseService.Errores.Add(ex.Message);
                return _responseService;
            }


        }
    }
}
