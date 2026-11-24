namespace WinFormsApp1
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
            int opcion = int.Parse(cmdnumero.SelectedItem.ToString());

            switch (opcion)
            {
                case 1:
                    {
                        txtmes.Text = "ENERO";
                        break;
                    }
                case 2:
                    {
                        txtmes.Text = "FEBRERO";
                        break;
                    }
                case 3:
                    {
                        txtmes.Text = "MARZO";
                        break;
                    }
                case 4:
                    {
                        txtmes.Text = "ABRIL";
                        break;
                    }
                case 5:
                    {
                        txtmes.Text = "MAYO";
                        break;
                    }
                case 6:
                    {
                        txtmes.Text = "JUNIO";
                        break;
                    }
                case 7:
                    {
                        txtmes.Text = "JULIO";
                        break;
                    }
                case 8:
                    {
                        txtmes.Text = "AGOSTO";
                        break;
                    }
                case 9:
                    {
                        txtmes.Text = "SEPTIEMBRE";
                        break;
                    }
                case 10:
                    {
                        txtmes.Text = "OCTUBRE";
                        break;
                    }
                case 11:
                    {
                        txtmes.Text = "NOVIEMBRE";
                        break;
                    }
                case 12:
                    {
                        txtmes.Text = "DICIEMBRE";
                        break;
                    }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtmes.Enabled = false;
        }
    }
}

