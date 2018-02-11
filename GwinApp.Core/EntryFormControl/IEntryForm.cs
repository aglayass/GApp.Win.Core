using GApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GApp.Win.EntryFormControl
{
    /// <summary>
    /// Generic winform Form
    /// </summary>
    public interface IEntryForm
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
        object Value { set; get; }

        bool isValidate();
    }
}
