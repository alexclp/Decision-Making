using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decision_Making
{
    class DataSaver
    {
        public static void SaveData(Product product, string fileName)
        {
            System.Xml.Serialization.XmlSerializer writer =
            new System.Xml.Serialization.XmlSerializer(typeof(Product));

            string path = fileName + ".xml";

            System.IO.StreamWriter file = new System.IO.StreamWriter(path);
            writer.Serialize(file, product);
            file.Close();
        }

        public static Product LoadData(string fileName)
        {
            string path = fileName + ".xml";

            System.Xml.Serialization.XmlSerializer reader =
                new System.Xml.Serialization.XmlSerializer(typeof(Product));
            System.IO.StreamReader file = new System.IO.StreamReader(path);
            Product product = new Product();
            product = (Product)reader.Deserialize(file);
            file.Close();

            return product;
        }
    }
}
