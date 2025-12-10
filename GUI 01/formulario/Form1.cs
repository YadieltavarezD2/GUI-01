namespace formulario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       /*inicializacion del formulario , inicia con el textbox de las horas extras inivisible y
        * el groupbox con 2 valores*/
        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxExtras.Visible = false;

            groupBoxTodo.Text = $"sueldo:\nTotal General: ";
        }

        /* este es el boton click donde se realiza la operacion tiene un if para q incluso si solo se ingresan
         * 2 valores y no las horas extras , igual funcione*/
        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            double sueldo, horas, extras, sueldot, horasx, TotalGeneral;

            sueldo = double.Parse(textBoxSueldo.Text);
            horas = double.Parse(textBoxHoras.Text);

            if (checkBoxExtras.Checked)
            {
                extras = double.Parse(textBoxExtras.Text);
                sueldot = sueldo * horas;
                horasx = (sueldo * 1.35) * extras;
                TotalGeneral = sueldot + horasx;
                groupBoxTodo.Text = $"sueldo:{sueldot}\nhoras extras: {horasx}\nTotal General: {TotalGeneral}";
            }
            else
            {
                sueldot = sueldo * horas;
                groupBoxTodo.Text = $"sueldo:{sueldot}\nTotal General: {sueldot}";
            
        }
               
            
        }

        //GUI 01nombre carpeta
        /*esta es la validacion del checkbox en el cual se pone un if para q aparezca el textbox y una para
         q el groupbox cambie*/
        private void checkBoxExtras_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxExtras.Checked)
            {
                groupBoxTodo.Text = $"sueldo:\nhoras extras:\nTotal General:";
            }
            else
            {
                groupBoxTodo.Text = $"sueldo:\nTotal General: ";
            }

            if (checkBoxExtras.Checked)
            {
                textBoxExtras.Visible = true;
            }
            else
            {
                textBoxExtras.Visible = false;
            }
        }

        /*esto hace q todos los valores vuelvan a 0*/
        private void buttonLimpiar_Click_1(object sender, EventArgs e)
        {
            textBoxSueldo.Text = "";
            textBoxHoras.Text = "";
            textBoxExtras.Text = "";
            groupBoxTodo.Text = "";
        }

        /*Esto tuliza el metodo exit de la clase Application para salir del programa*/
        private void buttonSalir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

