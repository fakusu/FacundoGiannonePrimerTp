// See https://aka.ms/new-console-template for more information



using FacundoGiannone.Entidades;
using System.ComponentModel.DataAnnotations;
using UtilidadesFacundoGiannone;

int cantidadPiramides = 0;
bool continuar = true;

while (continuar)
{
    Console.WriteLine("PIRAMIDE CUADRADA");
    var ladoBase = ExtensionesConsola.PedirEntero("Ingresar Lado de la base: ");
    var altura = ExtensionesConsola.PedirEntero("Ingresar Altura: ");
    var piramideCuadrada = new PiramideCuadrada(ladoBase, altura);
    var context = new ValidationContext(piramideCuadrada);
    var errores = new List<ValidationResult>();
    bool esValido = Validator.TryValidateObject(piramideCuadrada, context, errores, true);
    if (!esValido)
    {
        foreach (var item in errores)
        {
            Console.WriteLine(item.ErrorMessage);
        }
    }
    else
    {
        Console.WriteLine(piramideCuadrada.InformarDatos());
        cantidadPiramides++;

    }
    string respuesta;
    do
    {
        Console.WriteLine("¿Deseas ingresar otra piramide? (S/N): ");
        respuesta = Console.ReadLine().ToUpper(); 

        if (respuesta != "S" && respuesta != "N") 
        {
            Console.WriteLine("Carácter erróneo. Ingresa 'S' para sí o 'N' para no.");
        }

    } while (respuesta != "S" && respuesta != "N"); 

    if (respuesta == "N") 
    {
        continuar = false;
    }
}



Console.WriteLine($"Se ingresaron {cantidadPiramides} Piramides");
