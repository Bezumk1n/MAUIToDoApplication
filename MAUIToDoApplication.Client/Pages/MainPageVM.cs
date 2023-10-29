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
    public class MainPageVM : VM
    {
        #region Properties
        private readonly IRestDataService _service;
        /// <summary>
        /// Collection of ToDos
        /// </summary>
        public List<ToDo> Collection { get; set; }
        /// <summary>
        /// Current selected ToDo
        /// </summary>
        public ToDo SelectedItem { get; set; }
        #endregion
        /// <summary>
        /// Command - add a new ToDo item
        /// </summary>
        public ICommand CommandAddNewToDo { get; }
        /// <summary>
        /// Command - edit selected ToDo item
        /// </summary>
        public ICommand CommandEditToDo { get; }
        #region Constructor
        public MainPageVM(IRestDataService service)
        {
            _service = service;
            CommandAddNewToDo = new DelegateCommand(async _ => await AddNewToDo());
            CommandEditToDo = new DelegateCommand(async _ => await EditToDo());
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
            var navigationParameter = new Dictionary<string, object>()
            {
                { nameof(ToDo), new ToDo() }
            };
            await Shell.Current.GoToAsync(nameof(ManageToDoPageV), navigationParameter);
        }
        /// <summary>
        /// Edit currently selected ToDo item
        /// </summary>
        /// <returns></returns>
        private async Task EditToDo()
        {
            var navigationParameter = new Dictionary<string, object>()
            {
                { nameof(ToDo), SelectedItem }
            };
            await Shell.Current.GoToAsync(nameof(ManageToDoPageV), navigationParameter);
        }
        #endregion
    }
}
