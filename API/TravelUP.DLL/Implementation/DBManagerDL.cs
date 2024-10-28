using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelUP.DLL.Model;
using TravelUP.DLL.Service;

namespace TravelUP.DLL.Implementation
{
    public class DBManagerDL:IDBManagerDL
    {
        private readonly IDapperHelper dapperHelper;


        public DBManagerDL(IDapperHelper dapperHelper)
        {
            this.dapperHelper = dapperHelper;
        }


        public TravelPartner SavePartnerData(TravelPartner partner)
        {
            var parameters = new DynamicParameters();
            try
            {
                parameters.Add("PartnerType", partner.PartnerType, DbType.Int16);
                parameters.Add("Name", partner.Name, DbType.String);
                parameters.Add("Address1", partner.Address1, DbType.String);
                parameters.Add("Address2", partner.Address2, DbType.String);
                parameters.Add("City", partner.City, DbType.String);
                parameters.Add("Country", partner.Country, DbType.String);
                parameters.Add("Phone", partner.Phone, DbType.String);
                parameters.Add("Email", partner.Email, DbType.String);
                parameters.Add("Website", partner.Website, DbType.String);
                parameters.Add("PartnerID", partner.LiNo, DbType.Int16);
                using var dbConnection = dapperHelper.CreateConnection();
                var proc = "SP_Set_TravelPartner";
                var data = dbConnection.Query<TravelPartner>(proc, parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
                if (data != null)
                {
                    return data;
                }

            }
            catch (Exception ex)
            {
            }

            return new TravelPartner();

        }

        public List<TravelPartner> GetTravelPartners()
        {
            try
            {
                using var dbConnection = dapperHelper.CreateConnection();
                var proc = "SP_Get_TravelPartner";
                var data = dbConnection.Query<TravelPartner>(proc, commandType: CommandType.StoredProcedure).ToList();
                if (data != null && data.Count() > 0)
                {
                    return data;
                }

            }
            catch (Exception ex)
            {
            }

            return new List<TravelPartner>();

        }
    }
}
