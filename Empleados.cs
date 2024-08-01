namespace Empleados{
    class Empleado{
        private string nombre;
        private string apellido;
        private DateTime nacimiento;
        private char EC; //C: Casado, S: Soltero
        private DateTime ingreso;
        private double sueldo;
        public enum cargo
        {
            Auxiliar,
            Administrativo,
            Ingeniero,
            Especialista,
            Investigador
        };
        private cargo cargoE;

        public string Nombre { get => nombre; set => nombre=value};
        public string Apellido { get => apellido; set => apellido=value};
        public DateTime Nacimiento { get => nombre; set => nombre=value};
        public char EstadoC { get => EC; set => EC=value}; //C: Casado, S: Soltero
        public DateTime Ingreso { get => ingreso; set => ingreso=value};
        public double Sueldo { get => sueldo; set => sueldo=value};
        public cargo CargoE { get => cargoE; set => cargoE=value};

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