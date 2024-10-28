using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelUP.DLL.Model;

namespace TravelUP.DLL.Service
{
    public interface IDBManagerDL
    {
        TravelPartner SavePartnerData(TravelPartner partner);
        List<TravelPartner> GetTravelPartners();
    }
}
