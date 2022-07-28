using System;
using System.Collections.Generic;

namespace QuotesApi.Models
{
    public partial class Quote
    {
        public int Id { get; set; }
        public string? Quote1 { get; set; }
        public string? Author { get; set; }
        public DateTime? Time { get; set; }
    }
}
