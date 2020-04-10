using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoDotNetCoreGraphQL.Infra
{
    public class UsuarioRepositorio
    {
        private readonly BlogContext _context;
        public UsuarioRepositorio(BlogContext context)
        {
            _context = context;
        }
        public async Task<List<Usuario>> ObterUsuarios(UsuarioFiltro filtro)
        {
            var query = _context.Usuarios.AsTracking();
            if (filtro.Id.HasValue && filtro.Id > 0)
                query = query.Where(w => w.Id == filtro.Id);
            if (!string.IsNullOrEmpty(filtro.Nome))
                query = query.Where(w => filtro.Nome.Contains(w.Nome));
            return await query.ToListAsync();
        }

        public Usuario Adicionar(Usuario usuario)
        {
            _context.Add(usuario);
            return usuario;
        }
    }
}
