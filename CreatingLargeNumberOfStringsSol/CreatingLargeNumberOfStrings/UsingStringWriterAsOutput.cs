using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CreatingLargeNumberOfStrings
{
    internal class UsingStringWriterAsOutput
    {
        static void Main(string[] args)
        {
            var stringWriter = new StringWriter();
            using (XmlWriter writer = XmlWriter.Create(stringWriter))
            {
                writer.WriteStartElement("book");
                writer.WriteElementString("price", "19.95");
                writer.WriteEndElement();
                writer.Flush();
            }
            string xml = stringWriter.ToString();
            Console.WriteLine(xml);
            Console.ReadKey();

            //Leer xml
            var stringReader = new StringReader(xml);
            using (XmlReader reader = XmlReader.Create(stringReader))
            {
                reader.ReadToFollowing("price");
                decimal price = decimal.Parse(reader.ReadInnerXml(), new CultureInfo("ex-MX"));
                Console.WriteLine($"price = {price}");
            }
            Console.ReadKey();
        }
    }
}
