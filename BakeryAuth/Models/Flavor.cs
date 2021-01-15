using System.Collections.Generic; //parent class

namespace BakeryAuth.Models
{
  public class Flavor
    {
        public Flavor()
        {
            this.Treats = new HashSet<FlavorTreat>();
        }

        public int FlavorId { get; set; }
        public string FlavorName { get; set; }
        public virtual ICollection<FlavorTreat> Treats { get; set; }
    }
}