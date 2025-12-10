namespace formulario
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelInicio = new Label();
            textBoxSueldo = new TextBox();
            labelSueldo = new Label();
            labelExtras = new Label();
            textBoxHoras = new TextBox();
            labelHoras = new Label();
            textBoxExtras = new TextBox();
            buttonCalcular = new Button();
            buttonLimpiar = new Button();
            buttonSalir = new Button();
            groupBoxTodo = new GroupBox();
            checkBoxExtras = new CheckBox();
            SuspendLayout();
            // 
            // labelInicio
            // 
            labelInicio.AutoSize = true;
            labelInicio.Font = new Font("Segoe UI", 30F);
            labelInicio.Location = new Point(64, 20);
            labelInicio.Name = "labelInicio";
            labelInicio.Size = new Size(603, 81);
            labelInicio.TabIndex = 0;
            labelInicio.Text = "Formulario Empleado";
            // 
            // textBoxSueldo
            // 
            textBoxSueldo.Location = new Point(12, 164);
            textBoxSueldo.Name = "textBoxSueldo";
            textBoxSueldo.PlaceholderText = "Ingresa el sueldo";
            textBoxSueldo.Size = new Size(150, 31);
            textBoxSueldo.TabIndex = 1;
            // 
            // labelSueldo
            // 
            labelSueldo.AutoSize = true;
            labelSueldo.ForeColor = SystemColors.InfoText;
            labelSueldo.Location = new Point(12, 136);
            labelSueldo.Name = "labelSueldo";
            labelSueldo.Size = new Size(145, 25);
            labelSueldo.TabIndex = 2;
            labelSueldo.Text = "Sueldo por hora:";
            // 
            // labelExtras
            // 
            labelExtras.AutoSize = true;
            labelExtras.Location = new Point(8, 214);
            labelExtras.Name = "labelExtras";
            labelExtras.Size = new Size(0, 25);
            labelExtras.TabIndex = 5;
           
            // 
            // textBoxHoras
            // 
            textBoxHoras.Location = new Point(194, 164);
            textBoxHoras.Name = "textBoxHoras";
            textBoxHoras.PlaceholderText = "Ingresa el sueldo";
            textBoxHoras.Size = new Size(150, 31);
            textBoxHoras.TabIndex = 6;
            // 
            // labelHoras
            // 
            labelHoras.AutoSize = true;
            labelHoras.Location = new Point(194, 136);
            labelHoras.Name = "labelHoras";
            labelHoras.Size = new Size(150, 25);
            labelHoras.TabIndex = 7;
            labelHoras.Text = "Horas trabajadas:";
            // 
            // textBoxExtras
            // 
            textBoxExtras.Location = new Point(12, 277);
            textBoxExtras.Name = "textBoxExtras";
            textBoxExtras.PlaceholderText = "Horas extras";
            textBoxExtras.Size = new Size(150, 31);
            textBoxExtras.TabIndex = 8;
            // 
            // buttonCalcular
            // 
            buttonCalcular.Location = new Point(307, 384);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(112, 34);
            buttonCalcular.TabIndex = 9;
            buttonCalcular.Text = "Calcular";
            buttonCalcular.UseVisualStyleBackColor = true;
            buttonCalcular.Click += buttonCalcular_Click;
            // 
            // buttonLimpiar
            // 
            buttonLimpiar.Location = new Point(589, 384);
            buttonLimpiar.Name = "buttonLimpiar";
            buttonLimpiar.Size = new Size(112, 34);
            buttonLimpiar.TabIndex = 10;
            buttonLimpiar.Text = "Limpiar";
            buttonLimpiar.UseVisualStyleBackColor = true;
            buttonLimpiar.Click += buttonLimpiar_Click_1;
            // 
            // buttonSalir
            // 
            buttonSalir.Location = new Point(26, 384);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(112, 34);
            buttonSalir.TabIndex = 11;
            buttonSalir.Text = "Salir";
            buttonSalir.UseVisualStyleBackColor = true;
            buttonSalir.Click += buttonSalir_Click_1;
            // 
            // groupBoxTodo
            // 
            groupBoxTodo.Location = new Point(422, 137);
            groupBoxTodo.Name = "groupBoxTodo";
            groupBoxTodo.Size = new Size(222, 134);
            groupBoxTodo.TabIndex = 12;
            groupBoxTodo.TabStop = false;
            // 
            // checkBoxExtras
            // 
            checkBoxExtras.AutoSize = true;
            checkBoxExtras.Location = new Point(8, 242);
            checkBoxExtras.Name = "checkBoxExtras";
            checkBoxExtras.Size = new Size(140, 29);
            checkBoxExtras.TabIndex = 13;
            checkBoxExtras.Text = "Horas Extras:";
            checkBoxExtras.UseVisualStyleBackColor = true;
            checkBoxExtras.CheckedChanged += checkBoxExtras_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(713, 450);
            Controls.Add(checkBoxExtras);
            Controls.Add(groupBoxTodo);
            Controls.Add(buttonSalir);
            Controls.Add(buttonLimpiar);
            Controls.Add(buttonCalcular);
            Controls.Add(textBoxExtras);
            Controls.Add(labelHoras);
            Controls.Add(textBoxHoras);
            Controls.Add(labelExtras);
            Controls.Add(labelSueldo);
            Controls.Add(textBoxSueldo);
            Controls.Add(labelInicio);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelInicio;
        private TextBox textBoxSueldo;
        private Label labelSueldo;
        private Label labelExtras;
        private TextBox textBoxHoras;
        private Label labelHoras;
        private TextBox textBoxExtras;
        private Button buttonCalcular;
        private Button buttonLimpiar;
        private Button buttonSalir;
        private GroupBox groupBoxTodo;
        private CheckBox checkBoxExtras;
    }
}
