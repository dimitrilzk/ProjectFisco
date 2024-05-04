namespace Fisco.Models.Entities
{
    public class ContoWeekend
    {
        public Guid Id { get; set; }
        public Dictionary<string, decimal>? ListaContoWeekend { get; set; }
        public decimal ContoWeekendValue { get; set; }

        public Guid MensilitaId { get; set; }
    }
}
