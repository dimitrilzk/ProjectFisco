namespace Fisco.Models.Entities
{
    public class Risparmio
    {
        public Guid Id { get; set; }
        public decimal Cassa { get; set; }
        public decimal Emergenze { get; set; }
        public decimal AcqProgrammato { get; set; }
        public decimal Varie { get; set; }

        public Guid MensilitaId { get; set; }
    }
}
