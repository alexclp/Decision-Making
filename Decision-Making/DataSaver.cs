using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decision_Making
{
    class DataSaver
    {
        public static void SaveData(Product product)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

            System.Xml.Serialization.XmlSerializer writer =
            new System.Xml.Serialization.XmlSerializer(typeof(Product));

            System.IO.StreamWriter file = new System.IO.StreamWriter(@"Fabricare.xml");
            writer.Serialize(file, product);
            file.Close();
        }

        public static Product LoadData()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

            System.Xml.Serialization.XmlSerializer reader =
                new System.Xml.Serialization.XmlSerializer(typeof(Product));
            System.IO.StreamReader file = new System.IO.StreamReader(path);
            Product product = new Product();
            product = (Product)reader.Deserialize(file);

            return product;
        }
    }
}
