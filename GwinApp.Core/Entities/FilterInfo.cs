using GApp.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GApp.Win.Entities
{
    public class FilterInfo : BaseEntity
    {
        public FilterInfo()
        {
            this.isDefaultFilter = false;
        }

        [Required]
        public string Title { set; get; }

        public bool isDefaultFilter { set; get; }

        public string Description { set; get; }

        public string FilterString { set; get; }

        public string SortString { set; get; }

        [Required]
        public virtual ManagerInfo ManagerInfo { set; get; }


    }
}
