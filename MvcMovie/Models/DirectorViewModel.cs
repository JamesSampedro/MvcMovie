using Microsoft.AspNetCore.Mvc.Rendering;

namespace MvcMovie.Models
{
    public class DirectorViewModel
    {
        public int? MovieID { get; set; }
        public int DirectorID { get; set; }
        public SelectList Movies { get; set; }
        public Director Director { get; set; }
    }
}