using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using CommunityToolkit.Mvvm.Input;

namespace ListadoAlumnos.ViewMolders
{
    public partial class AlumnoViewModels : ObservableValidator
    {
        private string apellido;

        [Required(ErrorMessage = "El campo apellido es obligatorio, pal")] //DataAnnotation. Validacion. Campo requerido
        [MaxLength(100)]

        public string textApellido { get => apellido; set => SetProperty(ref apellido, value, true); }

        private string nombre;

        [Required(ErrorMessage = "El campo nombre es obligatorio, pal")] //DataAnnotation. Validacion. Campo requerido
        [MaxLength(100)]

        public string textNombre { get => nombre; set => SetProperty(ref nombre, value, true); }

        [RelayCommand]
        public async Task guardarAlumno()
        {
            ValidateAllProperties(); //Valida todas las Data Annotations. 
            var erroresNombre = GetErrors(nameof(textNombre)).ToList(); //Traeme los errores del campo nombre. Como pueden ser más de uno, me los convierte a una lista.
            var erroresApellido = GetErrors(nameof(textApellido)).ToList();

        }

    }
}
