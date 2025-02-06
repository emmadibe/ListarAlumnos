using ListadoAlumnos.ViewMolders;

namespace ListadoAlumnos.Views;

public partial class Alumnos : ContentView
{
	public Alumnos()
	{
		BindingContext = App.Current.Services.GetRequiredService<AlumnoViewModels>();
		InitializeComponent();
	}
}