using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using BerTlv;


/// <summary>
/// Determine the mapping first, contact the creator of the TLV and get the map.
///Get a byte stream of the protocol
///Start parsing in bytes
///Determine the first byte which decodes the type
///Detemine the length which follows next
///Grab the length to decode the payload.
///Decode the payload (note you have to know something about the payload)
///Determine how the client will receive the bytes...HTTP, TCP/IP, UDP etc.
/// </summary>

namespace TLV_data_parser
{

        

    class Program
    {
        static void Main(string[] args)
        {

            #region Dont even bother looking, just testing out how json works
            string json = @"{
                  'Email': 'james@example.com',
                  'Active': true,
                  'CreatedDate': '2013-01-20T00:00:00Z',
                  'Roles': [
                    'User',
                    'Admin'
                  ]
                }";

           ClientExisting dataReciever = JsonConvert.DeserializeObject<ClientExisting>(json);
           // Console.WriteLine(dataReciever.EndpointClientName);


            ICollection<Tlv> tlvs = Tlv.ParseTlv("6F1A840E315041592E5359532E4444463031A5088801025F2D02656E");
            Console.WriteLine(tlvs);


            #endregion
        }
    }
}


