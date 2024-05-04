namespace Fisco.Models
{
    public class Mensilita
    {
        public Guid Id { get; set; }
        public decimal Stipendio { get; set; }
        public decimal EntrateExtra { get; set; }
        public string Risparmio { get; set; }
        public string ContoComune { get; set; }
        public string ContoWeekend { get; set; }
        public decimal SpFisseMese { get; set; }
        public decimal SpFisseAnno { get; set; }
        public decimal UsciteExtra { get; set; }
        public decimal RimanenzaMese { get; set; }

        public string Mese { get; set; }
        public string Anno { get; set; }
    }
}
