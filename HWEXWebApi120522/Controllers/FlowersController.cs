
using Microsoft.AspNetCore.Mvc;


namespace HWEXWebApi120522.Controllers
{
    [ApiController]
    [Route("test/[action]")]
    public class FlowersController
    {
        public string Calanit()
        {
            return "Hello from Calanit Method";
        }
        public string Rakefet()
        {
            return "Hello from Rakefet Method";
        }
        public string Narkis()
        {
            return "Hello from Narkis Method";
        }
        public string Shoshan()
        {
            return "Hello from Shoshan Method";
        }
    }
}
