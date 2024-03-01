using LearningMaui.ViewModal;

namespace LearningMaui
{
    public partial class MainPage : ContentPage
    {
       

        public MainPage(MainPageViewModal vm)
        {
            InitializeComponent();
            BindingContext = vm;
        }

        
    }

}
