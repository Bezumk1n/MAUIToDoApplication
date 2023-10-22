using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIToDoApplication.Client.Common
{
    public class VM : NotifyObject
    {
        /// <summary>
        /// Title of the ViewModel
        /// </summary>
        public virtual string Title { get; set; }
    }
}
