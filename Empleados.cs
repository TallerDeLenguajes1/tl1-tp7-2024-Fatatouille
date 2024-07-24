namespace Empleados{
    class Empleado{
        private string nombre;
        private string apellido;
        private DateTime nacimiento;
        private char EC; //C: Casado, S: Soltero
        private DateTime ingreso;
        private double sueldo;
        private enum Cargo
        {
            Auxiliar,
            Administrativo,
            Ingeniero,
            Especialista,
            Investigador
        };

        private int Antiguedad(){
            int antiguedad =  DateTime.Today.Year - ingreso.Year;
            return antiguedad;
        }
        private int Edad(){
            int edad =  DateTime.Today.Year - nacimiento.Year;
            return edad;
        }

        public int Jubilacion(){
            int jubila = 65 - Edad();
            return jubila;
        }

        private float Salario(){
            float salario=0;
            return salario;
        }

    }
}