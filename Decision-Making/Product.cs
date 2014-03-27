using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decision_Making
{
    class Product
    {
        public string annualCost { get; set; }
        public string variableCost { get; set; }
        public string annualVolume { get; set; }

        public static void SaveData(Product product)
        {
            System.Xml.Serialization.XmlSerializer writer =
            new System.Xml.Serialization.XmlSerializer(typeof(Product));

            System.IO.StreamWriter file = new System.IO.StreamWriter(
                @"c:\temp\SerializationOverview.xml");
            writer.Serialize(file, product);
            file.Close();
        }

        public static Product LoadData()
        {
            System.Xml.Serialization.XmlSerializer reader =
                new System.Xml.Serialization.XmlSerializer(typeof(Product));
            System.IO.StreamReader file = new System.IO.StreamReader(
                @"c:\temp\SerializationOverview.xml");
            Product product = new Product();
            product = (Product)reader.Deserialize(file);

            return product;
        }
    }
}
