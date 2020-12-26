using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TruckPlanApiClient.Model;
using TruckPlanWebApp.DAL;
using System.Configuration;
using TruckPlanApiClient.Api;
using TruckPlanApiClient.Client;

namespace ContosoUniversity.Controllers
{
    public class GPSTruckRecordsController : Controller
    {
        private TruckPlanContext db = new TruckPlanContext();

        // GET: GPSTruckRecords
        public  ActionResult Index()
        {
            TruckPlanApiClient.Client.Configuration.Default.AccessToken = "eyJhbGciOiJBMTI4S1ciLCJlbmMiOiJBMTI4Q0JDLUhTMjU2IiwidHlwIjoiSldUIn0.Z5ZSueSwRPD11j5i7vp75dx62RiBj6bhRDwSv0GBXiHZ8ROnzUmX3A.SvdvlCiuwg_r7MDF8UF4Kg.UvITOXPINbS3cIKWG9Q1R_KyGseesj6fBaA2MRTr6IqcpVhl6-Zi4RP7Km72Juc9iq7kiZk0jgoVkFL5mV6mcA6pbHYAMiMIqYIxoiHRV9DroGQRwV-iHF2n7C5zKjxc7fqhYv746SxtIWXPq-iFuiTpZMY_DtUYirqkvV3PVOeo3KQsmc--Ysx2BsE0jTlp-NxeXk7Sw4T-hm-so_ZzHyy0FHrwsTlHwrkGMrORjEWU6BAfWXWSDWpudpB6uG3VPKKuqc2oUFonVvmVbRSyAwReDogcy55LX7TxPxZymCENPtPLDrEy8-e_KZb24T8n6-nXiyrICVfleSXpoAt5-nAPTD9aTa1xEQWeh3ZyNtC-lPsqYaahxZGhTXpaJMUvkoqOqwUFsVtqy2sA3LkfkRJIxztD1GWZZiHreMDt8fLv-o4S8meCufDdsPgjzdUfiCegvKNh6lG_e7hIwbZxwkgyAiRT3jO3qdkzAkhk23HPi9rhoTWiYx571VKTJXY9b-B0Lq4m42bt9qvmhMF5wdm2psh45ZK0jfTHXe2I5f50dsbSQ5dRn_IK2k8bEIHAPJJEIjGt3jzIetPteM9rDlEtWyU7KtyB_ue3nkoa3bK2NbeZ7acu77Q8if_X6zLfQsGqBKppzryXE0wIZ7aC3WwO5ztggHUhSRL0nklPUOE.PfzYxHG4Um4Zj-7oi0cdxQ";

            var apiInstance = new GPSTruckRecordsApi();

            try
            {
                // Returns all GPSTruckRecords
                List<GPSTruckRecordSelectDto> result = apiInstance.ApiV2GPSTruckRecordsGet();
                return View(  result);
            }
            catch (Exception e)
            {
                return View(new List<GPSTruckRecordSelectDto>());
            }

          
        }
         
       
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
