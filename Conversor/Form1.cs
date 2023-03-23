namespace Conversor
{
    public partial class Form1 : Form
    {
        public Form1()

        {
            InitializeComponent();
        }
        class Convertir
        {
            public Convertir()
            {
                dolar = 54.79;
                euro = 59.65;
            }
            double dolar;
            double euro;

            public double getPesosToDolar(double Pesos)
            {
                return Pesos / dolar;
            }

            public double getPesosToEuro(double Pesos)
            {
                return Pesos / euro;
            }
        }
        Convertir miConvertidor = new Convertir();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            int pesos = Convert.ToInt32(txtPesos.Text);
            double Dolar = miConvertidor.getPesosToDolar(pesos);
            double Euro = miConvertidor.getPesosToEuro(pesos);

            txtDolar.Text = Dolar.ToString("0.00");
            txtEuro.Text = Euro.ToString("0.00");

            
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtDolar.Clear();
            txtEuro.Clear();
            txtPesos.Clear();
        }
    }
}