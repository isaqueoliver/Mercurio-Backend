namespace Back.Mercurio.Api.Models
{
    public struct RespostaViewModel
    {
        public Guid ReporteId { get; set; }
        public string Resposta { get; set; }
    }
    public struct ReporteViewModel
    {
        public string Descricao { get; set; }
        public Guid AssuntoId { get; set; }
    }

    public struct ReporteModelView
    {
        public Guid Id { get; set; }
        public string Assunto { get; set; }
        public string Descricao { get; set; }
        public string Status { get; set; }
        public string? Resposta { get; set; }
        public DateTime DataCadastro { get; set; }

        public ReporteModelView(Guid id, string assunto, string descricao, string status, string? resposta, DateTime dataCadastro)
        {
            Id = id;
            Assunto = assunto;
            Descricao = descricao;
            Status = status;
            Resposta = resposta;
            DataCadastro = dataCadastro;
        }
    }
}
