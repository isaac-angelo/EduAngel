namespace EduAngel.Domain.Entities
{
    public class TipoRede
    {
        public int Id { get; set; }

        public string Nome { get; set; } = string.Empty;

        public bool Ativo { get; set; } = true;
    }
}