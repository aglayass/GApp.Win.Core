using GApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GApp.Win.EntryForm
{
    /// <summary>
    /// Generic winform Form
    /// </summary>
    public interface IEntryFormControl 
    {
        /// <summary>
        /// Set or get Title value
        /// </summary>
        string Title { set; get; }

        /// <summary>
        /// Set or get the type of Entity
        /// </summary>
        Type TypeOfEntity { get; }

        /// <summary>
        /// Set or get the entity value
        /// </summary>
        BaseEntity Value { set; get; }
    }
}
