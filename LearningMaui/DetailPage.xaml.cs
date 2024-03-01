using LearningMaui.ViewModal;

namespace LearningMaui;

public partial class DetailPage : ContentPage
{
	public DetailPage(DetailPageViewModal vm)
	{
        InitializeComponent();
        BindingContext = vm;
    }
}