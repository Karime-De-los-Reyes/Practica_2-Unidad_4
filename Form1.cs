namespace Practica_2_Unidad_4
{
    public partial class Form1 : Form
    {
        //´Declaracion de variables de cantidad
        int CantidadHamburguesas;
        int CantidadHotDog;
        int CantidadSandwich;
        int CantidadTe;
        int CantidadRefresco;
        int CantidadPapas;

        double TotalVta;
        double CostoHamburguesa;
        double CostoHotDog;
        double CostoSandwich;
        double CostoTe;
        double CostoRefresco;
        double CostoPapas;

        //´Inicializar las variables con los precios de los productos 
        double Hamburguesa = 20.5;
        double HotDog = 19.25;
        double Sandwich = 17.5;
        double PapasFritas = 4.5;
        double Refresco = 4;
        double Te = 5;

        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //Paquete No.1 de comida
            textTotal.Text = " ";
            if (radioButton1.Checked == true)
            {
                CantidadHamburguesas = 1;
                CantidadRefresco = 1;
                CantidadPapas = 1;
                CantidadHotDog = 0;
                CantidadSandwich = 0;
                CantidadTe = 0;
                //Inicializar valores
                textHamburguesa.Text = CantidadHamburguesas.ToString();
                textRefresco.Text = CantidadRefresco.ToString();
                textPapas.Text = CantidadPapas.ToString();

                //Activar las cajas de texto del paquete
                textHamburguesa.Enabled = true;
                textRefresco.Enabled = true;
                textPapas.Enabled = true;

                //Desactivar las otras cajas 
                textHotDog.Enabled = false;
                textSandwich.Enabled = false;
                textTe.Enabled = false;

                //Limpiar las cajas de texto
                textHotDog.Text = "";
                textTe.Text = "";
                textSandwich.Text = "";
            }
        }

        private void BotonSalida_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void BotonCalcular_Click(object sender, EventArgs e)
        {
            //Multiplicando la cantidad por el precio y sumando el total
            CostoHamburguesa = (CantidadHamburguesas * Hamburguesa);
            CostoHotDog = (CantidadHotDog * HotDog);
            CostoPapas = (CantidadPapas * PapasFritas);
            CostoSandwich = (CantidadSandwich * Sandwich);
            CostoRefresco = (CantidadRefresco * Refresco);
            CostoTe = (CantidadTe * Te);
            TotalVta = CostoHamburguesa + CostoHotDog + CostoPapas + CostoRefresco + CostoSandwich + CostoTe;
            textTotal.Text = TotalVta.ToString();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //Paquete No.2 de comida
            textTotal.Text = "";
            if (radioButton2.Checked == true)
            {
                CantidadRefresco = 1;
                CantidadPapas = 1;
                CantidadHotDog = 1;
                CantidadSandwich = 0;

                //Inicializar valores
                textHotDog.Text = CantidadHotDog.ToString();
                textRefresco.Text = CantidadRefresco.ToString();
                textPapas.Text = CantidadPapas.ToString();

                //Activar las cajas de texto del paquete
                textHotDog.Enabled = true;
                textRefresco.Enabled = true;
                textPapas.Enabled = true;

                //Desactivar las otras cajas 
                textHamburguesa.Enabled = false;
                textTe.Enabled = false;
                textSandwich.Enabled = false;

                //Limpiar las cajas de texto
                //textHotDog.Text = "";
                textHamburguesa.Text = "";
                textSandwich.Text = "";
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            //Paquete No.3 de comida 
            textTotal.Text = "";
            if (radioButton3.Checked == true)
            {
                CantidadHamburguesas = 0;
                CantidadRefresco = 1;
                CantidadPapas = 1;
                CantidadHotDog = 0;
                CantidadSandwich = 1;
                CantidadTe = 0;

                //Inicializar valores
                textSandwich.Text = CantidadSandwich.ToString();
                textRefresco.Text = CantidadRefresco.ToString();
                textPapas.Text = CantidadPapas.ToString();

                //Activar las cajas de texto del paquete
                textSandwich.Enabled = true;
                textRefresco.Enabled = true;
                textPapas.Enabled = true;

                //Desactivar las otras cajas
                textHotDog.Enabled = false;
                textHamburguesa.Enabled = false;
                textTe.Enabled = false;

                //Limpiar las cajas de texto
                textHamburguesa.Text = "";
                textTe.Text = "";
                textHotDog.Text = "";
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            //Opcion otro pedido
            textTotal.Text = "";
            if (radioButton4.Checked == true)
            {
                //Habilitar todas las entradas
                textHamburguesa.Enabled = true;
                textHotDog.Enabled = true;
                textSandwich.Enabled = true;
                textTe.Enabled = true;
                textRefresco.Enabled = true;
                textPapas.Enabled = true;

                /*
                textHamburguesa.Text = "";
                textHotDog.Text = "";
                textPapas.Text = "";
                textRefresco.Text = "";
                textSandwich.Text = "";
                textTe.Text = "";*/

                double CantidadHamburguesas = int.Parse(textHamburguesa.Text);
                double CantidadHotDog = int.Parse(textHotDog.Text);
                double CantidadPapas = int.Parse(textPapas.Text);
                double CantidadRefresco = int.Parse(textRefresco.Text);
                double CantidadSandwich = int.Parse(textSandwich.Text);
                double CantidadTe = int.Parse(textTe.Text);
            }
        }
    }
}