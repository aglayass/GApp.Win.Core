using GApp.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GApp.Win.Entities
{
    public class ManagerInfo : BaseEntity
    {
        [Required]
        public string Title { set; get; }

        public string Description { set; get; }

        public bool isSystem { set; get; }

        public string FilterString { set; get; }

        public string SortString { set; get; }


    }
}
