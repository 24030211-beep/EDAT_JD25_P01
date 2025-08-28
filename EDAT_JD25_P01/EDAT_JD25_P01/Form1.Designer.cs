namespace EDAT_JD25_P01
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Numero = new TextBox();
            Nombre = new TextBox();
            BGenerarDatos = new Button();
            label4 = new Label();
            Sueldo = new TextBox();
            Grupo = new ComboBox();
            label5 = new Label();
            SeguroMedico = new CheckBox();
            Sexo = new RadioButton();
            Sexo2 = new RadioButton();
            FechaNacimiento = new DateTimePicker();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 40);
            label1.Name = "label1";
            label1.Size = new Size(173, 25);
            label1.TabIndex = 0;
            label1.Text = "Datos del empleado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 82);
            label2.Name = "label2";
            label2.Size = new Size(77, 25);
            label2.TabIndex = 1;
            label2.Text = "Número";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 128);
            label3.Name = "label3";
            label3.Size = new Size(78, 25);
            label3.TabIndex = 2;
            label3.Text = "Nombre";
            // 
            // Numero
            // 
            Numero.Location = new Point(134, 88);
            Numero.Name = "Numero";
            Numero.Size = new Size(225, 31);
            Numero.TabIndex = 3;
            Numero.TextChanged += textBox1_TextChanged;
            // 
            // Nombre
            // 
            Nombre.Location = new Point(133, 125);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(225, 31);
            Nombre.TabIndex = 4;
            Nombre.TextChanged += textBox2_TextChanged;
            // 
            // BGenerarDatos
            // 
            BGenerarDatos.Location = new Point(224, 463);
            BGenerarDatos.Name = "BGenerarDatos";
            BGenerarDatos.Size = new Size(218, 36);
            BGenerarDatos.TabIndex = 5;
            BGenerarDatos.Text = "Generar Datos";
            BGenerarDatos.UseVisualStyleBackColor = true;
            BGenerarDatos.Click += BGenerarDatos_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(77, 389);
            label4.Name = "label4";
            label4.Size = new Size(67, 25);
            label4.TabIndex = 6;
            label4.Text = "Sueldo";
            // 
            // Sueldo
            // 
            Sueldo.Location = new Point(156, 383);
            Sueldo.Name = "Sueldo";
            Sueldo.Size = new Size(225, 31);
            Sueldo.TabIndex = 7;
            Sueldo.TextChanged += Sueldo_TextChanged;
            // 
            // Grupo
            // 
            Grupo.FormattingEnabled = true;
            Grupo.Location = new Point(162, 336);
            Grupo.Name = "Grupo";
            Grupo.Size = new Size(169, 33);
            Grupo.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(77, 344);
            label5.Name = "label5";
            label5.Size = new Size(62, 25);
            label5.TabIndex = 9;
            label5.Text = "Grupo";
            // 
            // SeguroMedico
            // 
            SeguroMedico.AutoSize = true;
            SeguroMedico.Location = new Point(260, 428);
            SeguroMedico.Name = "SeguroMedico";
            SeguroMedico.Size = new Size(159, 29);
            SeguroMedico.TabIndex = 10;
            SeguroMedico.Text = "Seguro médico";
            SeguroMedico.UseVisualStyleBackColor = true;
            SeguroMedico.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Sexo
            // 
            Sexo.AutoSize = true;
            Sexo.Location = new Point(144, 237);
            Sexo.Name = "Sexo";
            Sexo.Size = new Size(117, 29);
            Sexo.TabIndex = 11;
            Sexo.TabStop = true;
            Sexo.Text = "Masculino";
            Sexo.UseVisualStyleBackColor = true;
            Sexo.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // Sexo2
            // 
            Sexo2.AutoSize = true;
            Sexo2.Location = new Point(144, 284);
            Sexo2.Name = "Sexo2";
            Sexo2.Size = new Size(115, 29);
            Sexo2.TabIndex = 12;
            Sexo2.TabStop = true;
            Sexo2.Text = "Femenino";
            Sexo2.UseVisualStyleBackColor = true;
            Sexo2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // FechaNacimiento
            // 
            FechaNacimiento.Location = new Point(243, 200);
            FechaNacimiento.Name = "FechaNacimiento";
            FechaNacimiento.Size = new Size(300, 31);
            FechaNacimiento.TabIndex = 13;
            FechaNacimiento.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(45, 206);
            label6.Name = "label6";
            label6.Size = new Size(174, 25);
            label6.TabIndex = 14;
            label6.Text = "Fecha de nacimiento";
            label6.Click += label6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 522);
            Controls.Add(label6);
            Controls.Add(FechaNacimiento);
            Controls.Add(Sexo2);
            Controls.Add(Sexo);
            Controls.Add(SeguroMedico);
            Controls.Add(label5);
            Controls.Add(Grupo);
            Controls.Add(Sueldo);
            Controls.Add(label4);
            Controls.Add(BGenerarDatos);
            Controls.Add(Nombre);
            Controls.Add(Numero);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox Numero;
        private TextBox Nombre;
        private Button BGenerarDatos;
        private Label label4;
        private TextBox Sueldo;
        private ComboBox Grupo;
        private Label label5;
        private CheckBox SeguroMedico;
        private RadioButton Sexo;
        private RadioButton Sexo2;
        private DateTimePicker FechaNacimiento;
        private Label label6;
    }
}
