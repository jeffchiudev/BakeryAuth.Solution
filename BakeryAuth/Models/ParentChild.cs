namespace BakeryAuth.Models
{
  public class FlavorTreat
    {       
        public int FlavorTreatId { get; set; }
        public int TreatId { get; set; }
        public int FlavorId { get; set; }
        public Treat Treat { get; set; }
        public Flavor Flavor { get; set; }
    }
}