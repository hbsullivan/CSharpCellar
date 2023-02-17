using System.Collections.Generic;

namespace Cellar.Models
{
  public class Status
  {
    public int StatusId { get; set; }
    public bool Consumed { get; set; }
    public Wine Wine { get; set; } 
  }
}