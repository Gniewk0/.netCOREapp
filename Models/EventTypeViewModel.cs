using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace ProjektZaliczeniowyCore.Models
{
    public class EventTypeViewModel
    {
        public List<Event>? Events { get; set; }
        public SelectList? Types { get; set; }
        public string? EventType { get; set; }
        public string? SearchString { get; set; }
    }
}
