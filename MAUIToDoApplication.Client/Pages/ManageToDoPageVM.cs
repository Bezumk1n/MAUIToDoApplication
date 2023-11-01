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
    [QueryProperty(nameof(ToDo), "ToDo")]
    public class ManageToDoPageVM : VM
    {
        #region Properties
        private readonly IRestDataService _dataService;
        public ToDo ToDo
        {
            get => _toDo;
            set => _toDo = value;

        }
        private ToDo _toDo;
        #endregion
        #region Commands
        public ICommand CommandCancel { get; }
        public ICommand CommandSave { get; }
        public ICommand CommandDelete { get; }
        #endregion
        #region Constructor
        public ManageToDoPageVM(IRestDataService dataService)
        {
            _dataService = dataService;
            CommandCancel = new DelegateCommand(async _ => await Cancel());
            CommandSave = new DelegateCommand(async _ => await Save());
            CommandDelete = new DelegateCommand(async _ => await Delete());
        }


        #endregion
        #region Methods
        private bool IsNew(ToDo toDo) => toDo.Id == Guid.Empty;
        private async Task Delete()
        {
            await _dataService.DeleteToDoAsync(_toDo.Id);
        }
        private async Task Save()
        {
            if (IsNew(_toDo))
                await _dataService.AddToDoAsync(_toDo);
            else
                await _dataService.UpdateToDoAsync(_toDo);
            await Shell.Current.GoToAsync("..");
        }

        private async Task Cancel()
        {
            await Shell.Current.GoToAsync("..");
        }
        #endregion
    }
}
