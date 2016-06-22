using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarketplaceWebServiceProducts;
using MarketplaceWebServiceProducts.Model;

namespace ABrain.AmazonMWS_Example
{
    class Program
    {
        static void Main(string[] args)
        {



            /*  Config */

            var sellerId = "<seller id>";
            var accessKey = "<access key";
            var marketPlaceId = "<marketplace id>";
            var secretKey = "<secret key>";

            var appName = "<application name>";
            var appVersion = "<application version>";

            /* Example Products API Client */

            var config = new MarketplaceWebServiceProductsConfig { ServiceURL = "https://mws.amazonservices.com" };
            var client = new MarketplaceWebServiceProductsClient(appName, appVersion, accessKey, secretKey, config);

            var request = new GetMatchingProductForIdRequest();

            request.IdList = new IdListType();
            request.IdType = "<id type>"; // UPC, ISBN, EAN, ASIN
            request.IdList.Id.Add("<id>");

            request.MarketplaceId = marketPlaceId;

            try
            {
                // try to get the response from the server
                var response = client.GetMatchingProductForId(request);

               

            }
            catch (MarketplaceWebServiceProductsException ex)
            {
               // something went wrong
               // check the value of ErrorCode 
            }





        }
    }
}
