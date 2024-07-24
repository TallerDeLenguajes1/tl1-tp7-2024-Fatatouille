// See https://aka.ms/new-console-template for more information
using EspacioCalculadora;

Calculadora calculadora = new Calculadora();
int opcion;
Console.WriteLine("Ingrese un numero: ");
double valor = Convert.ToDouble(Console.ReadLine());
calculadora.Sumar(valor);
bool opera=true;

while(opera){
    if(calculadora.resultado == 0){
        Console.WriteLine("Ingrese un numero: ");
        valor = Convert.ToDouble(Console.ReadLine());
    }else{
        Console.WriteLine("Que operacion quieres hacer?");
        Console.WriteLine("1: Sumar");
        Console.WriteLine("2: Restar");
        Console.WriteLine("3: Multiplicar");
        Console.WriteLine("4: Dividir");
        Console.WriteLine("5: Limpiar");
        Console.WriteLine("6: Salir");

        opcion= Convert.ToInt32(Console.ReadLine());

        if(opcion==6){
            break;
        }else{
            Console.WriteLine("Ingrese un numero: ");
            valor = Convert.ToDouble(Console.ReadLine());
            
            switch (opcion)
            {
                case 1:
                    calculadora.Sumar(valor);
                    break;
                case 2:
                    calculadora.Restar(valor);
                    break;
                case 3:
                    calculadora.Multiplicar(valor);
                    break;
                case 4:
                    calculadora.Dividir(valor);
                    break;
                case 5:
                    calculadora.Limpiar();
                    break;
                default:
                    Console.WriteLine("Ingrese una opcion.");
                    break;
            }
            Console.WriteLine($"El resultado es {calculadora.resultado}");
        }
    }
}    