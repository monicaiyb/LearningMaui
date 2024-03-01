using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace LearningMaui.ViewModal
{
    public partial class MainPageViewModal: ObservableObject
    {
      
        public MainPageViewModal()
        {
            Items = new ObservableCollection<string>();
        }
        [ObservableProperty]
        ObservableCollection<string> items;

        [ObservableProperty]
        string text;
        
        [RelayCommand]
        void Add()
        {
            if(string.IsNullOrWhiteSpace(Text))
                return;
            Items.Add(Text);
            Text=string.Empty;
        }

        [RelayCommand]
        void Delete(string text)
        {
            if (items.Contains(text))
            {
                Items.Remove(Text);
            }
        }

        [RelayCommand]
        async Task Tap(string text)
        {
            await Shell.Current.GoToAsync($"{nameof(DetailPage)}?Text={text}");
        }

    }
}
