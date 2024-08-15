using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALL_E.Models
{
    public class GeneratedImages
    {
        public string ImagePath { get; set; }
        public string MainKeyword { get; set; }
        public List<string> Keywords { get; set; }
    }
}
