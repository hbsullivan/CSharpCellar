using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Cellar.Models
{
  public class Wine
  {
    public int WineId { get; set; }
    public string Producer { get; set; }
    public string Origin { get; set; }
    public string Vintage { get; set; }
    public string Price { get; set; }
    public string Location { get; set; }
    public string Description { get; set; }
    public string TastingNote { get; set; }
    public string Rating { get; set; }
    public ApplicationUser User { get; set; }
    public int StatusId { get; set; }
    public Status Status { get; set; }
  }
}