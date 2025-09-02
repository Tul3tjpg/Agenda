namespace Agenda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCargarContactos_Click(object sender, EventArgs e)
        {
            try
            {
                string[] datos = File.ReadAllLines(@"Datos\Personas.csv");
                MessageBox.Show(datos[1]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
