namespace PRACTICA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnprocesar_Click(object sender, EventArgs e)
        {
            if (cmdcarnet.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un número de carnet");
                return;
            }

            string carnet = cmdcarnet.SelectedItem.ToString();

            switch (carnet)
            {
                case "1001":
                    txtnombre.Text = "JUAN PEREZ";
                    break;

                case "1002":
                    txtnombre.Text = "MARIA LOPEZ";
                    break;

                case "1003":
                    txtnombre.Text = "CARLOS FLORES";
                    break;

                case "1004":
                    txtnombre.Text = "ANA GUTIERREZ";
                    break;

                case "1005":
                    txtnombre.Text = "LUIS MAMANI";
                    break;

                default:
                    txtnombre.Text = "ESTUDIANTE NO ENCONTRADO";
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Cargar los números de carnet
            cmdcarnet.Items.Add("1001");
            cmdcarnet.Items.Add("1002");
            cmdcarnet.Items.Add("1003");
            cmdcarnet.Items.Add("1004");
            cmdcarnet.Items.Add("1005");

            // Deshabilitar la escritura en la caja de texto
            txtnombre.ReadOnly = true;
        }
    }
}
