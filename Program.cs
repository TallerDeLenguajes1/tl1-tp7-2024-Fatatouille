// See https://aka.ms/new-console-template for more information
using System.Globalization;
using Empleados;

Empleado[] empleados = new Empleado[3];
Empleado mayor= new Empleado();
string nacimiento;
int cargo, year=2023;
DateTime actual;

for (int i=0; i<3; i++){
    empleados[i] = new Empleado();

    Console.WriteLine("Apellido: ");
    empleados[i].Apellido = Console.ReadLine();

    Console.WriteLine("Nombre: ");
    empleados[i].Nombre = Console.ReadLine();

    Console.WriteLine("Fecha de nacimiento: ");
    nacimiento = Console.ReadLine();
    empleados[i].Nacimiento= DateTime.ParseExact(nacimiento, "ddMMyy", CultureInfo.InvariantCulture);
    actual = DateTime.ParseExact(nacimiento, "ddMMyy", CultureInfo.InvariantCulture);

    Console.WriteLine("Estado civil: ");
    empleados[i].EstadoC = Convert.ToChar(Console.ReadLine());

    Console.WriteLine("Sueldo Básico: ");
    empleados[i].Sueldo = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Cargo del 0 al 5: ");
    cargo = Convert.ToInt32(Console.ReadLine());

    switch (cargo)
        {
            case 0:
                empleados[i].CargoE = Empleado.Cargo.Auxiliar;
                break;
            case 1:
                empleados[i].CargoE = Empleado.Cargo.Administrativo;
                break;
            case 2:
                empleados[i].CargoE = Empleado.Cargo.Ingeniero;
                break;
            case 3:
                empleados[i].CargoE = Empleado.Cargo.Especialista;
                break;
            case 4:
                empleados[i].CargoE = Empleado.Cargo.Investigador;
                break;
            default:
                Console.WriteLine("No se ingresó un cargo válido.");
                break;
        }
    if (actual.Year < year){
        year= actual.Year;
        mayor = empleados[i];
    }
}

mayor.MostrarDatos(mayor);