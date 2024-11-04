namespace Actividad1.Models
{
    public class Empleado
    {
        private string _nombreCompleto;

        public int Id { get; set; }

        // Propiedad de solo lectura para obtener el nombre completo del empleado
        public string NombreCompleto
        {
            get { return _nombreCompleto.ToUpper(); } // Accesor: devuelve el nombre en mayúsculas
            set { _nombreCompleto = value; } // Mutador: establece el valor sin modificarlo
        }

        // Propiedad con mutador para formatear la fecha de contratación
        private DateTime _fechaContratacion;
        public string FechaContratacion
        {
            get { return _fechaContratacion.ToString("dd/MM/yyyy"); } // Accesor: devuelve la fecha en formato dd/MM/yyyy
            set
            {
                if (DateTime.TryParse(value, out DateTime fecha))
                {
                    _fechaContratacion = fecha;
                }
                else
                {
                    _fechaContratacion = DateTime.Now; // Establece fecha actual si no es válida
                }
            }
        }

        // Propiedad con mutador que convierte el salario de string a decimal
        private decimal _salario;
        public string Salario
        {
            get { return $"${_salario:F2}"; } // Accesor: devuelve el salario con formato de moneda
            set
            {
                if (decimal.TryParse(value, out decimal salario))
                {
                    _salario = salario; // Mutador: convierte y guarda el salario como decimal
                }
                else
                {
                    _salario = 0; // Establece 0 si el valor no es un número válido
                }
            }
        }

        // Otra propiedad para demostrar casting explícito
        public int Edad { get; set; }

        // Método de conversión de tipo (casting explícito)
        public static explicit operator int(Empleado empleado)
        {
            return empleado.Edad; // Convierte el objeto Empleado a su edad en entero
        }
    }
}
