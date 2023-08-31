using Dominio;
using Dominio.Interfaces;
using Persistencia;

namespace Aplicacion.Repository;

public class RolRepository : GenericRepositoryB<Rol>, IRolRepository
{
    private readonly ApiContext _context;

    public RolRepository(ApiContext context) : base(context)
    {
        _context = context;
    }
}
