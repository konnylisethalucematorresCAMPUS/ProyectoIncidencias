using System.ComponentModel.DataAnnotations;

namespace Dominio;

public class UsuariosRoles : BaseEntityA
{
   
    public Usuario ? Usuario { get; set; }
    public int RolId { get; set; }
    public Rol ? Rol { get; set; }
}
