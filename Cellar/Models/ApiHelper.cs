using System.Threading.Tasks;
using RestSharp;

namespace CellarClient.Models
{
  public class ApiHelper
  {
    public static async Task<string> GetAll()
    {
      RestClient client = new RestClient("http://localhost:5173/");
      RestRequest request = new RestRequest($"api/regions", Method.Get);
      RestResponse response = await client.GetAsync(request);
      return response.Content;
    }

    public static async Task<string> Get(int id)
    {
      RestClient client = new RestClient("http://localhost:5173/");
      RestRequest request = new RestRequest($"api/regions/{id}", Method.Get);
      RestResponse response = await client.GetAsync(request);
      return response.Content;
    }
  }
}