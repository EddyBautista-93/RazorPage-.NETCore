using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models
{
    public class Movie
    {
        // id always required for primary key
        public int ID { get; set; }
        public string Title { get; set; }

        // specifies the datatype with the attribute
        //The user isn't required to enter time information in the date field.
        //Only the date is displayed, not time information.
        
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }
}
