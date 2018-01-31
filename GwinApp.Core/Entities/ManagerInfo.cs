using GApp.Entities;
using GApp.Exceptions;
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
        public ManagerInfo()
        {
            this.FilterInfos = new List<FilterInfo>();

            //// Insert Default filter
            //FilterInfo filterInfo = new FilterInfo();
            //filterInfo.isDefaultFilter = true;
            //this.FilterInfos.Add(filterInfo);
           
        }

        [Required]
        public string Title { set; get; }

        public string Description { set; get; }

        public bool isSystem { set; get; }

 
        public virtual List<FilterInfo> FilterInfos { set; get; }

        public FilterInfo getDefaultFilter()
        {
            FilterInfo filterInfo = this.FilterInfos.Where(f => f.isDefaultFilter).FirstOrDefault();
            if (filterInfo == null) throw new GAppException(string.Format("The ManagerInfo {0} is without default filter",this));
            return filterInfo;
        }


    }
}
