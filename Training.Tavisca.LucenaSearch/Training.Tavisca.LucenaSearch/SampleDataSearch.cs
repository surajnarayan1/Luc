using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Tavisca.LucenaSearch
{
    public class SampleDataSearch
    {
        public static SampleInformation Get(int id)
        {
            return GetAll().SingleOrDefault(x => x.id.Equals(id));
        }
        public static List<SampleInformation> GetAll()
        {
            return new List<SampleInformation> {
        new SampleInformation {id = 123,type="Hotel ", Description = "Oyo rooms  hotel present in viman nagar in pune"},
        new SampleInformation {id=345 ,type="Hotel", Description = "One of the most  reputed hotel  in pune"},
        new SampleInformation { id =678, type="Hotel" ,Description = "Five star Hotel in jamshedpur"},
        new SampleInformation {id=91011, type="Hotel" ,Description = "Hotel in Chicago" },
        new SampleInformation {id=123,  type="CabService" ,Description = "City in USA"}
    };
        }
    }
}   

