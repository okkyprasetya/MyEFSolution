using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEFSolution.Domain
{
    public class Samurai
    {
        public int SamuraiId { get; set; }
        public string? Name { get; set; }
        public IEnumerable<Quotes>? Quotes { get; set; }
    }
}
