using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace fileIODemoLive
{
    public class BlogSites
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Description { get; set; }
    }
}
