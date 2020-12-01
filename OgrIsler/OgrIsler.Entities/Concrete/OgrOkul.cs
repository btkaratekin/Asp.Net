using System;
using System.Collections.Generic;
using System.Text;

namespace OgrIsler.Entities.Concrete
{
    public class OgrOkul
    {
        public virtual OgrBilgi OgrNo { get; set; }

        public int sinif { get; set; }
        public string pkodu { get; set; }
        public string ogrtur { get; set; }
        public int dkodu { get; set; }
    }
}
