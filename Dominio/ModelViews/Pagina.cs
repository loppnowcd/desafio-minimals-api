// arquivo: Dominio/ModelViews/Pagina.cs
// asta classe encapsula a lista de itens e as informacoes de paginaçãoa

namespace MinimalApi.Dominio.ModelViews;

public class Pagina<T>
{
    // a lista de itens da página atual
    public List<T> Itens { get; set; } = new List<T>();

    // numero da página atual
    public int PaginaAtual { get; set; }

    // total de itens retornados por pagina
    public int ItensPorPagina { get; set; }

    // total de itens em todas as paginas
    public int TotalItens { get; set; }
    public int TotalPaginas { get; set; }
}
