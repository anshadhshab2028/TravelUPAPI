using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelUP.BLL.Service;
using TravelUP.DLL.Model;
using TravelUP.DLL.Service;

namespace TravelUP.BLL.Implementation
{
    public class DBManagerBL:IDBManagerBL
    {
        public readonly IDBManagerDL dbmanagerDAL;

        public DBManagerBL(IDBManagerDL _dbmanagerDAL)
        {
            this.dbmanagerDAL = _dbmanagerDAL;
        }


        public TravelPartner SavePartnerData(TravelPartner partner)
        {
            return dbmanagerDAL.SavePartnerData(partner);
        }

        public List<TravelPartner> GetTravelPartners()
        {
            return dbmanagerDAL.GetTravelPartners();
        }


    }
}
