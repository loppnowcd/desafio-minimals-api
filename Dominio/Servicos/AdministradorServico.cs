using BCrypt.Net;
using MinimalApi.Dominio.Entidades;
using MinimalApi.Dominio.Interfaces;
using MinimalApi.Dominio.ModelViews;
using MinimalApi.DTOs;
using MinimalApi.Infraestrutura.Db;

namespace MinimalApi.Dominio.Servicos;

public class AdministradorServico : IAdministradorServico
{
    private readonly DbContexto _contexto;
    public AdministradorServico(DbContexto contexto)
    {
        _contexto = contexto;
    }

    public Administrador? BuscaPorId(int id)
    {
        return _contexto.Administradores.Where(v => v.Id == id).FirstOrDefault();
    }

    public Administrador Incluir(Administrador administrador)
    {
        administrador.Senha = BCrypt.Net.BCrypt.HashPassword(administrador.Senha);

        _contexto.Administradores.Add(administrador);
        _contexto.SaveChanges();

        return administrador;
    }

    public Administrador? Login(LoginDTO loginDTO)
    {
        var adm = _contexto.Administradores.Where(a => a.Email == loginDTO.Email && a.Senha == loginDTO.Senha).FirstOrDefault();
        return adm;
    }

    public Pagina<Administrador> Todos(int? pagina)
    {
        var query = _contexto.Administradores.AsQueryable();
        var totalItens = query.Count();
        int itensPorPagina = 10;

        if (pagina == null || pagina <= 0) pagina = 1;

        query = query.Skip(((int)pagina - 1) * itensPorPagina).Take(itensPorPagina);

        var totalPaginas = (int)Math.Ceiling(totalItens / (double)itensPorPagina);

        return new Pagina<Administrador>
        {
            Itens = query.ToList(),
            PaginaAtual = (int)pagina,
            ItensPorPagina = itensPorPagina,
            TotalItens = totalItens,
            TotalPaginas = totalPaginas
        };
    }
}