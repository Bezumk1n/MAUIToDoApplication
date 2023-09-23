using MAUIToDoApplication.Client.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIToDoApplication.Client.Models
{
    public class ToDo : NotifyObject
    {
        public Guid Id
        {
            get => _id;
            set 
            { 
                _id = value;
                OnPropertyChanged();
            }
        }
        private Guid _id;
        public string ToDoName
        {
            get => _todoname;
            set 
            { 
                _todoname = value;
                OnPropertyChanged();
            }
        }
        private string _todoname;
    }
}
