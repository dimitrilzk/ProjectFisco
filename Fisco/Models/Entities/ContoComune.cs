namespace Fisco.Models.Entities
{
    public class ContoComune
    {
        public Guid Id { get; set; }
        public Dictionary<string, decimal>? ListaContoComune { get; set; }
        public decimal ContoComuneValue { get; set; }

        public Guid MensilitaId { get; set; }
    }
}
