namespace Empleados{
    class Empleado{
        private string nombre;
        private string apellido;
        private DateTime nacimiento;
        private char EC; //C: Casado, S: Soltero
        private DateTime ingreso;
        private double sueldo;
        public enum Cargo
        {
            Auxiliar,
            Administrativo,
            Ingeniero,
            Especialista,
            Investigador
        };
        private Cargo cargoE;

        public string Nombre { get => nombre; set => nombre=value; }
        public string Apellido { get => apellido; set => apellido=value; }
        public DateTime Nacimiento { get => nacimiento; set => nacimiento=value; }
        public char EstadoC { get => EC; set => EC=value; } //C: Casado, S: Soltero
        public DateTime Ingreso { get => ingreso; set => ingreso=value; }
        public double Sueldo { get => sueldo; set => sueldo=value; }
        public Cargo CargoE { get => cargoE; set => cargoE=value; }

        private int Antiguedad(){
            int antiguedad =  DateTime.Today.Year - this.ingreso.Year;
            if (DateTime.Today.DayOfYear < this.ingreso.DayOfYear)
            {
                antiguedad--;
            }
            return antiguedad;
        }
        public int Edad(){
            int edad =  DateTime.Today.Year - nacimiento.Year;
            return edad;
        }

        public int Jubilacion(){
            int jubila = 65 - Edad();
            return jubila;
        }

        private double Salario(){
            double adicional=0;
            if (this.Antiguedad() <20){
                adicional+= (this.sueldo*this.Antiguedad())/100;
            }else{
                adicional+= this.sueldo*0.25;
            }

            switch (this.cargoE)
            {
                case Cargo.Especialista:
                    adicional+=this.sueldo*0.5;
                    break;
                case Cargo.Ingeniero:
                    adicional+=this.sueldo*0.5;
                    break;
                default:
                    adicional=adicional;
                    break;
            }

            if(this.EC == 'C'){
                adicional+=150000;
            }

            return this.sueldo+adicional;
        }

        public void MostrarDatos(Empleado empleado){
            Console.WriteLine($"El empleado mas proximo a jubilarse es: {empleado.apellido}, {empleado.nombre}.");
            Console.WriteLine($"Lleva {empleado.Antiguedad()} anos en la empresa, tiene {empleado.Edad()} y se jubila en {empleado.Jubilacion()}.");
            Console.WriteLine($"Su salario es de {empleado.Salario()}.");
        }
    }
}