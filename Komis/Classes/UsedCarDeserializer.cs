using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Komis
{
    public static class UsedCarDeserializer
    {
        public static List<UsedCar> Cars { set; get; }

        static UsedCarDeserializer()
        {
            Cars = new List<UsedCar>();
            
            var serializer = new XmlSerializer(Cars.GetType(), "Cars");

            object obj;
            try
            {
                using (var reader = new StreamReader("Cars.xml"))
                {
                    obj = serializer.Deserialize(reader.BaseStream);
                }

                Cars = (List<UsedCar>) obj;
            }
            catch (FileNotFoundException)
            {
            }
        }
    }
}