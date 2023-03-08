using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace InsuranceProgram.Layers.Persistence
{
    public class BCCR
    {
        public float compra { get; set; }
        public float venta { get; set; }
        public DateTime fecha { get; set; }

        public static BCCR GetTypeOfChange()
        {
            string json = "";
            BCCR TypeOfChange = null;
            string urlJSON = "https://tipodecambio.paginasweb.cr/api";
            try
            {
                // Creates a GET request to fetch  
                WebRequest request = WebRequest.Create(urlJSON);
                // Verb GET
                request.Method = "GET";

                using (WebResponse response = request.GetResponse())
                {
                    // GetResponse returns a web response containing the response to the request
                    using (WebResponse webResponse = request.GetResponse())
                    {
                        // Reading data
                        StreamReader reader = new StreamReader(webResponse.GetResponseStream());
                        json = reader.ReadToEnd();
                    }
                }

                TypeOfChange = JsonConvert.DeserializeObject<BCCR>(json);

            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error {ex.Message}");
            }

            return TypeOfChange;
        }




    }
}
