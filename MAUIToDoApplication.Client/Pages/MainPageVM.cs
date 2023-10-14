using MAUIToDoApplication.Client.DataServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIToDoApplication.Client.Pages
{
    internal class MainPageVM
    {
        private readonly IRestDataService _service;

        public MainPageVM(IRestDataService service)
        {
            _service = service;
        }
    }
}
