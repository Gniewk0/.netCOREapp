using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProjektZaliczeniowyCore.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
    }
}
