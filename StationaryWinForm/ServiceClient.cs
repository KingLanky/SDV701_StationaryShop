using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace StationaryWinForm
{
    public static class ServiceClient
    {
        //Getting Orders List
        internal async static Task<List<string>> GetOrdersAsync()
        {
            using (HttpClient lcHttpClient = new HttpClient())
                return JsonConvert.DeserializeObject<List<string>>
                    (await lcHttpClient.GetStringAsync("http://localhost:60064/api/stationary/GetOrders/"));
        }

        internal async static Task<clsOrder> GetOrderDetailsAsync(string prOrderID)
        {
            using (HttpClient lcHttpClient = new HttpClient())
                return JsonConvert.DeserializeObject<clsOrder>
                    (await lcHttpClient.GetStringAsync("http://localhost:60064/api/stationary/GetOrderDetails?OrderID=" + prOrderID));
        }

        internal async static Task<List<string>> GetBrandNamesAsync()
        {
            using (HttpClient lcHttpClient = new HttpClient())
                return JsonConvert.DeserializeObject<List<string>>
                    (await lcHttpClient.GetStringAsync("http://localhost:60064/api/stationary/GetBrandNames/"));
        }

        internal async static Task<clsBrand> GetBrandAsync(string prBrandName)
        {
            using (HttpClient lcHttpClient = new HttpClient())
                return JsonConvert.DeserializeObject<clsBrand>
                    (await lcHttpClient.GetStringAsync("http://localhost:60064/api/stationary/GetBrand?BrandName=" + prBrandName));
        }
        // BRAND
        internal async static Task<string> InsertBrandAsync(clsBrand prBrand)
        {
            return await InsertOrUpdateAsync(prBrand, "http://localhost:60064/api/stationary/PostBrand", "POST");
        }

        internal async static Task<string> UpdateBrandAsync(clsBrand prBrand)
        {
            return await InsertOrUpdateAsync(prBrand, "http://localhost:60064/api/stationary/PutBrand", "PUT");
        }


        // STATIONARY 
        internal async static Task<string> InsertStationaryAsync(clsAllStationary prStationary)
        {
            return await InsertOrUpdateAsync(prStationary, "http://localhost:60064/api/stationary/PostStationary", "POST");
        }
        internal async static Task<string> UpdateStationaryAsync(clsAllStationary prStationary)
        {
            return await InsertOrUpdateAsync(prStationary, "http://localhost:60064/api/stationary/PutStationary", "PUT");
        }


        internal async static Task<string> DeleteStationaryAsync(clsAllStationary prStationary)
        {
            using (HttpClient lcHttpClient = new HttpClient())
            {
                HttpResponseMessage lcRespMessage = await lcHttpClient.DeleteAsync
                    ($"http://localhost:60064/api/stationary/DeleteStationary?prStationaryID={prStationary.StationaryID}");
                return await lcRespMessage.Content.ReadAsStringAsync();
            }
        }

        // INSERT OR UPDATE ASYNC
        private async static Task<string> InsertOrUpdateAsync<TItem>(TItem prItem, string prUrl, string prRequest)
        {
            using (HttpRequestMessage lcReqMessage = new HttpRequestMessage(new HttpMethod(prRequest), prUrl))
            using (lcReqMessage.Content =
                new StringContent(JsonConvert.SerializeObject(prItem), Encoding.Default, "application/json"))
            using (HttpClient lcHttpClient = new HttpClient())
            {
                HttpResponseMessage lcRespMessage = await lcHttpClient.SendAsync(lcReqMessage);
                return await lcRespMessage.Content.ReadAsStringAsync();
            }
        }
    }
}


