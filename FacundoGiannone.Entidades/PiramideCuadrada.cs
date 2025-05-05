using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FacundoGiannone.Entidades
{
    public class PiramideCuadrada:IValidatableObject
    {
        public PiramideCuadrada()
        {
            
        }
        public PiramideCuadrada(int ladoBase, int altura)
        {
            Altura = altura;
            LadoBase = ladoBase;
        }

        public int Altura { get;  }
        public int LadoBase { get; }
        private double Apotema { get; }
       

        public double CalcularApotema()
        {
            
            return Math.Sqrt(Math.Pow(LadoBase / 2.0, 2) + Math.Pow(Altura, 2));
        }

        public double CalcularArea()
        {
            return Math.Pow(LadoBase, 2)+ 2*LadoBase*CalcularApotema();
        }

        public double CalcularVolumen()
        {
            return (Math.Pow(LadoBase, 2) * Altura) / 3.0;
        }

        public string InformarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Apotema de piramide cuadrada: {CalcularApotema()}");
            sb.AppendLine($"Area de piramide cuadrada: {CalcularArea()}");
            sb.AppendLine($"Volumen de piramide cuadrada: {CalcularVolumen()}");
            return sb.ToString();
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {

            if (LadoBase <= 0 )
            {
                yield return new ValidationResult("El Lado no puede ser nulo o negativo");
            }
            if (Altura <= 0)
            {
                yield return new ValidationResult("La Altura no puede ser nulo o negativo");
            }
        }
        public override string ToString()
        {
            return $"Piramide de lado {LadoBase} y altura {Altura}";
        }
    }
}
