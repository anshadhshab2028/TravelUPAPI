using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelUP.DLL.Model
{
    public class TravelPartner
    {
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public int PartnerType { get; set; }=0;
        public int LiNo { get; set; } = 0;
        public string? Partner { get; set; }
        public int Count { get; set; } = 0;
    }
}
