using AlumnosNamespace = ListadoAlumnos.Views.ListadoAlumnos;

namespace ListadoAlumnos
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(ListadoAlumnos), typeof(AlumnosNamespace));  //así me funcionó.

        }


    }
}
