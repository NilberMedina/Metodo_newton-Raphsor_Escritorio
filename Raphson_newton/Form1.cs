using NCalc;
namespace Raphson_newton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double EvaluarFuncion(string expresion, double x)
        {
            try
            {
                Expression e = new Expression(expresion);
                e.Parameters["x"] = x;
                var result = e.Evaluate();
                return Convert.ToDouble(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al evaluar la funci�n: {ex.Message}");
                throw;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string funcion = txtFuncion.Text;
            string derivada = txtDerivada.Text;

            lstResultados.Items.Clear();

            if (!double.TryParse(txtValorInicial.Text, out double x))
            {
                MessageBox.Show("Ingrese un valor inicial v�lido.");
                return;
            }

            if (!int.TryParse(txtIteraciones.Text, out int maxIteraciones) || maxIteraciones <= 0)
            {
                MessageBox.Show("Ingrese un n�mero v�lido de iteraciones.");
                return;
            }

            double tolerancia = 1e-6;
            bool convergencia = false;

            for (int i = 1; i <= maxIteraciones; i++)
            {
                double fx, fpx;
                try
                {
                    fx = EvaluarFuncion(funcion, x);
                    fpx = EvaluarFuncion(derivada, x);
                }
                catch
                {
                    lstResultados.Items.Add($"Error al evaluar funci�n o derivada en la iteraci�n {i}.");
                    return;
                }

                if (fpx == 0)
                {
                    MessageBox.Show($"Derivada igual a cero en la iteraci�n {i}. El m�todo falla.");
                    return;
                }

                double siguienteX = x - (fx / fpx);
                double error = Math.Abs(siguienteX - x);

                lstResultados.Items.Add($"Iteraci�n {i}:");
                lstResultados.Items.Add($"   x = {x:F6}");
                lstResultados.Items.Add($"   f(x) = {fx:F6}");
                lstResultados.Items.Add($"   f'(x) = {fpx:F6}");
                lstResultados.Items.Add($"   Nueva x = {siguienteX:F6}");
                lstResultados.Items.Add($"   Error = {error:E6}");
                lstResultados.Items.Add("--------------------------");

                if (error < tolerancia)
                {
                    lstResultados.Items.Add($"Convergencia alcanzada en la iteraci�n {i}.");
                    convergencia = true;
                    x = siguienteX;
                    break;
                }

                x = siguienteX;
            }

            txtRaiz.Text = convergencia ? x.ToString("F6") : "No convergi�";

            if (!convergencia)
            {
                lstResultados.Items.Add("No se alcanz� la tolerancia deseada en las iteraciones dadas.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
