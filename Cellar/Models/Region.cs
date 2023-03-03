using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CellarClient.Models
{
  public class Region
  {
    public int RegionId { get; set; }
    public string Appellation { get; set; }
    public string Country { get; set; }
    public string Climate { get; set; }
    public string Soil { get; set; }

    public static List<Region> GetRegions()
    {
      var apiCallTask = ApiHelper.GetAll();
      var result = apiCallTask.Result;

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<Region> regionList = JsonConvert.DeserializeObject<List<Region>>(jsonResponse.ToString());

      return regionList;
    }

    public static Region GetDetails(int id)
    {
      var apiCallTask = ApiHelper.Get(id);
      var result = apiCallTask.Result;

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      Region region = JsonConvert.DeserializeObject<Region>(jsonResponse.ToString());

      return region;
    }
  }
}