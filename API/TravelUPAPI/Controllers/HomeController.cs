using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using TravelUP.BLL.Service;
using TravelUP.DLL.Model;

namespace TravelUPAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IDBManagerBL _dbmanager;

        public HomeController(IDBManagerBL IDBManagerBL)
        {
            this._dbmanager = IDBManagerBL;
        }

        [HttpPost("CreateTravelpartner")]
        public TravelPartner SavePartnerData(TravelPartner partner)
        {
            try
            {
                var result =  _dbmanager.SavePartnerData(partner);
                return result;
            }

            catch (Exception ex)
            {
                return new TravelPartner();
            }
        }


        [HttpGet("GetTravelpartner")]
        public List<TravelPartner>  GetTravelPartners()
        {
            try
            {
                var result =  _dbmanager.GetTravelPartners();
                return result;
            }

            catch (Exception ex)
            {
                return new List<TravelPartner>(); ;
            }
        }
    }
}
