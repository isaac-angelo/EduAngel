namespace EduAngel.Domain.Entities
{
    public class Redes
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public bool Ativo { get; set; } = true;
        public int TipoRedeId { get; set; }
        public TiposRedes? TipoRede { get; set; }
    }
}
