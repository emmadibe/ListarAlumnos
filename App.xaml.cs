using ListadoAlumnos.ViewMolders;
using AlumnosNameSpace = ListadoAlumnos.Views.ListadoAlumnos;
namespace ListadoAlumnos
{
    public partial class App : Application
    {

        public new static App Current => (App)Application.Current;
        public IServiceProvider Services { get; set; }

        public App()
        {
            var services = new ServiceCollection();
            Services = ConfigureServices(services);

            InitializeComponent();

            MainPage = new AppShell();
        }

        private static IServiceProvider ConfigureServices(ServiceCollection services)
        {
            //Servicios:
              
            //ViewModels:
            services.AddTransient<AlumnosViewModels>();
            services.AddTransient<AlumnoViewModels>();
            //Views:
            services.AddSingleton<AlumnosNameSpace>();
            services.AddSingleton<Alumnos>();

            return services.BuildServiceProvider();
        }

    }
}
