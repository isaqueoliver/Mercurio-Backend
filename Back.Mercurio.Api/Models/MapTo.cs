using Back.Mercurio.Domain.Models;

namespace Back.Mercurio.Api.Models
{
    public static class MapTo
    {
        #region Assunto
        public static AssuntoViewModel AssuntoMapToAssuntoViewModel(this Assunto assunto)
        {
            return new AssuntoViewModel { Id = assunto.Id, Descricao = assunto.Descricao };
        }

        public static IEnumerable<AssuntoViewModel> AssuntoMapToAssuntoViewModel(this IEnumerable<Assunto> assuntos)
        {
            foreach (var assunto in assuntos)
            {
                yield return new AssuntoViewModel { Id = assunto.Id, Descricao = assunto.Descricao };
            }
        }
        #endregion

        #region Cidade
        public static IEnumerable<CidadeViewModel> CidadeMapToCidadeViewModel(this IEnumerable<Cidade> cidades)
        {
            return cidades.Select(x => new CidadeViewModel(x.Id, x.Nome));
        }
        public static CidadeViewModel CidadeMapToCidadeViewModel(this Cidade cidade)
        {
            return new CidadeViewModel(cidade.Id, cidade.Nome);
        }
        #endregion

        #region Estado
        public static EstadoViewModel EstadoMapToEstadoViewModel(this Estado estado)
        {
            return new EstadoViewModel(estado.Sigla);
        }
        #endregion

        #region Mercado
        public static IEnumerable<MercadoViewModel> MercadoMapToMercadoViewModel(this IEnumerable<Mercado> mercados)
        {
            return mercados.Select(x => new MercadoViewModel(x.Id, x.Nome, x.Estado.Sigla, x.Cidade.Nome, x.Endereco, x.Imagem));
        }
        #endregion

        #region Produto
        public static IEnumerable<ProdutoViewModel> ProdutoMapToProdutoViewModel(this IEnumerable<Produto> produtos)
        {
            return produtos.Select(x => new ProdutoViewModel(x.Id, x.Nome, x.Imagem));
        }
        #endregion

        #region ProdutoUsuario
        public static IEnumerable<ProdutoUsuarioModelView> ProdutoUsuarioMapToProdutoUsuarioModelView(this IEnumerable<ProdutoUsuario> produtos)
        {
            return produtos.Select(x => new ProdutoUsuarioModelView(x.ProdutoId, x.Produto.Nome, x.MercadoId, x.Mercado.Nome, x.Produto.Imagem, x.Valor));
        }
        #endregion

        #region ProdutValorMedio
        public static IEnumerable<ProdutoValorMedioModelView> ProdutoValorMedioMapToProdutoValorMedioModelView(this IEnumerable<ProdutoValorMedio> produtos)
        {
            return produtos.Select(x => new ProdutoValorMedioModelView(x.ProdutoId, x.Produto.Nome, x.MercadoId, x.Mercado.Nome, x.Produto.Imagem, x.Valor));
        }
        #endregion

        #region Reporte
        public static IEnumerable<ReporteModelView> ReporteMapToReporteModelView(this IEnumerable<Reporte> reportes)
        {
            return reportes.Select(x => new ReporteModelView(x.Id, x.Assunto.Descricao, x.Descricao, x.ConverterStatusEnumParaStatus(), x.Resposta, x.DataCriacao));
        }
        #endregion
    }
}
