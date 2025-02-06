using ListadoAlumnos.ViewMolders;

namespace ListadoAlumnos.Views;

public partial class ListadoAlumnos : ContentPage
{
	public ListadoAlumnos()
	{
		BindingContext = App.Current.Services.GetRequiredService<AlumnosViewModels>();

        InitializeComponent();
	}
}