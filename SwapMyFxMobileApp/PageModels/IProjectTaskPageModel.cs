using CommunityToolkit.Mvvm.Input;
using SwapMyFxMobileApp.Models;

namespace SwapMyFxMobileApp.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}