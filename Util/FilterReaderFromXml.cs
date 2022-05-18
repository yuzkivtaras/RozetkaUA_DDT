using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RozetkaUA_DDT.Util
{
    public class FilterReadaderFromXml
    {
        public Filters ReadFilterFromXml()
        {
            Filters readFilterfromXml = new Filters();
            XmlSerializer xmlserializer = new XmlSerializer(readFilterfromXml.GetType());
            using (StreamReader streamReader = new StreamReader("d:/AQA/C#/.NetProjects AQA/RozetkaUA_DDT/RozetkaUA_DDT/resources/dataBrand.xml"))
            {
                return (Filters)xmlserializer.Deserialize(streamReader);
            }
        }
    }
}
