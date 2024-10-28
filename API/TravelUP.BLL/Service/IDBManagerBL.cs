using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelUP.DLL.Model;

namespace TravelUP.BLL.Service
{
    public interface IDBManagerBL
    {
        TravelPartner SavePartnerData(TravelPartner partner);
        List<TravelPartner> GetTravelPartners();
    }
}
