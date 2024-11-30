using CommunityToolkit.Mvvm.Input;
using SAM.Models;

namespace SAM.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}