using MAUIToDoApplication.Client.Common;
using MAUIToDoApplication.Client.DataServices;
using MAUIToDoApplication.Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MAUIToDoApplication.Client.Pages
{
    internal class MainPageVM : VM
    {
        #region Properties
        private readonly IRestDataService _service;
        /// <summary>
        /// Collection of ToDos
        /// </summary>
        public List<ToDo> Collection { get; set; }
        #endregion
        /// <summary>
        /// Command - add a new ToDo item
        /// </summary>
        public ICommand CommandAddNewToDo { get; }
        #region Constructor
        public MainPageVM(IRestDataService service)
        {
            _service = service;

            CommandAddNewToDo = new DelegateCommand(async _ => await AddNewToDo());

            Initialization();
        }
        #endregion
        #region Methods
        /// <summary>
        /// Initialization method that populates Collcetion
        /// </summary>
        /// <returns></returns>
        public async Task Initialization()
        {
            Collection = await _service.GetAllToDosAsync();
            OnPropertyChanged(() => Collection);
        }
        /// <summary>
        /// Add new ToDo item to the Collection
        /// </summary>
        /// <returns></returns>
        private async Task AddNewToDo()
        {

        }
        #endregion
    }
}
