using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOC.GSP.V2.WF.DAL.Models
{
    public class Application
    {

        public int Id { get; set; }
        public string EnName { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string Description { get; set; }
        public System.DateTime CreateTime { get; set; }
        public bool Enabled { get; set; }
        public string Secret { get; set; }
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
        public string Ticket { get; set; }
        public string APIAddress { get; set; }
        public Nullable<int> IdentityAppId { get; set; }
    }
}
