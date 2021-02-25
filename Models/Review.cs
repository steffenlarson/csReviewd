using System.ComponentModel.DataAnnotations;

namespace csReviewd.Models
{
  public class Review
  {
    public string Title { get; set; }
    public string Body { get; set; }
    public string Owner { get; set; }
    [Range(1, 6)]
    public int Rating { get; set; }
  }
}