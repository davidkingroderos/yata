using Yata.ViewModels;

namespace Yata.Views;

public partial class AddTodoGroupPage : ContentPage
{
	private readonly AddTodoGroupViewModel addTodoGroupViewModel;

	public AddTodoGroupPage(AddTodoGroupViewModel addTodoGroupViewModel)
	{
		InitializeComponent();

		this.addTodoGroupViewModel = addTodoGroupViewModel;
		BindingContext = this.addTodoGroupViewModel;
	}

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
    }
}