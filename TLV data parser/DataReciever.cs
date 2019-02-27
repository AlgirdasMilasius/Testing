using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TLV_data_parser
{

    /// <summary>
    /// Checks if the client exists
    /// </summary>
    public class ClientExisting
    {

        public bool Existing(EndClient endClient)
        {
            if (endClient.EndpointClient)
                return true;

            return false;

        }
        


    }

    /// <summary>
    /// Information about client if there is a client, client name, and prefered connection type
    /// </summary>
    public class EndClient
    {
        public bool EndpointClient { get; set; }
        public string EndpointClientName { get; set; }
        public int PreferedContentFormat { get; set; }
    }


}
