using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjektMVCCV.Models
{
    public class ShuffleModels
    {
        //[System.ComponentModel.DataAnnotations.Key]
        //public int Id { get; set; }
        public string Default { get; set; }
        public string Shuffled { get; set; }
        public string Sorted { get; set; }

        //public IList<string> ResultList { get; set; }
    }
}