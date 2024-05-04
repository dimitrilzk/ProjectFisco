using Fisco.Models.Enums;

namespace Fisco.Models.Entities
{
    public class Mensilita
    {
        public Guid Id { get; set; }
        public decimal Stipendio { get; set; }
        public decimal EntrateExtra { get; set; }
        public Risparmio? Risparmio { get; set; }
        public ContoComune? ContoComune { get; set; }
        public ContoWeekend? ContoWeekend { get; set; }
        public decimal SpFisseMese { get; set; }
        public decimal SpFisseAnno { get; set; }
        public decimal UsciteExtra { get; set; }
        public decimal RimanenzaMese { get; set; }

        public Mesi Mese { get; set; }
        public Anni Anno { get; set; }
    }
}
