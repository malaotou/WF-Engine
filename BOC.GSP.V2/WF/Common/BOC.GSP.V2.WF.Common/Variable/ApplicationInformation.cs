using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOC.GSP.V2.WF.Common.Variable
{
    public class ApplicationInformation
    {

        public int Id
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public string ShorName
        {
            get;
            set;
        }
        public string DisplayName
        {
            get;
            set;
        }
        public DateTime CreateTime
        {
            get;
            set;
        }
        public bool Enabled
        {
            get;
            set;
        }
        public string APIAddress
        {
            get;
            set;
        }
    }
}
