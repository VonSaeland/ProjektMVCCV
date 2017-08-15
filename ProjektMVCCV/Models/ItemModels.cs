using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektMVCCV.Models
{
    class ItemModel
    {
        public string Id        { get; }
        public string ItemNamne { get; set; }
        public string Attribute { get; set; }
    }
}
