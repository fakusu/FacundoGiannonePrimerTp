using FacundoGiannone.Entidades;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FacundoGiannone.Windows
{
    public partial class FrmPiramides : Form
    {
        int cantidadPiramides = 0;
        public FrmPiramides()
        {
            InitializeComponent();
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            InicializarControles();
        }

        private void InicializarControles()
        {
            LadoBaseTxt.Clear();
            AlturaTxt.Clear();
            LadoBaseTxt.Focus();
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                int ladoBase = int.Parse(LadoBaseTxt.Text);
                int altura = int.Parse(AlturaTxt.Text);

                var piramideCuadrada = new PiramideCuadrada(ladoBase, altura);
                var context = new ValidationContext(piramideCuadrada);
                var errores = new List<ValidationResult>();
                bool esValido = Validator.TryValidateObject(piramideCuadrada, context, errores, true);
                if (esValido)
                {
                    MessageBox.Show(piramideCuadrada.InformarDatos(), "Información",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PiramidesList.Items.Add(piramideCuadrada);
                    InicializarControles();
                    DialogResult = DialogResult.OK;
                    cantidadPiramides++;
                    PiramidesIngresadasLbl.Text = $"Piramides ingresadas: {cantidadPiramides}";
                }
                else
                {
                    StringBuilder sbErrores = new StringBuilder();
                    foreach (var item in errores)
                    {
                        sbErrores.AppendLine(item.ErrorMessage);
                    }

                    MessageBox.Show(sbErrores.ToString(),
                        "Errores", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    LadoBaseTxt.SelectAll();
                    LadoBaseTxt.Focus();
                }
            }
          
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (!int.TryParse(LadoBaseTxt.Text,out _))
            {
                valido = false;
                errorProvider1.SetError(LadoBaseTxt, "Lado Mal ingresado");
            }
            if (!int.TryParse(AlturaTxt.Text, out _))
            {
                valido = false;
                errorProvider1.SetError(AlturaTxt, "Altura Mal ingresada");
            }
            return valido;


        }
    }
}
