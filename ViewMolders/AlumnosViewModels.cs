using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListadoAlumnos.ViewMolders
{
    public partial class AlumnosViewModels : ObservableObject
    {
        public ObservableCollection<AlumnosModels> Alumnos { get; set; } = new();

        [RelayCommand]
        public async Task ListarAlumnos()
        {
            Alumnos.Clear(); //Limpio, por las dudas, para que no queden alumnos anteriores. 
            Alumnos.Add(new AlumnosModels() { apellido = "test", nombre = "emma" });
            Alumnos.Add(new AlumnosModels() { apellido = "jaj", nombre = "olivia" });


        }
    }

}

