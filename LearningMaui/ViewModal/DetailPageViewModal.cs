

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace LearningMaui.ViewModal
{
    [QueryProperty("Text","Text")]
    public partial class DetailPageViewModal : ObservableObject
    {
       
        [ObservableProperty]
        string text;

        [RelayCommand]
        async Task Goback()
        {
            await Shell.Current.GoToAsync("..");
        }

    }
}
