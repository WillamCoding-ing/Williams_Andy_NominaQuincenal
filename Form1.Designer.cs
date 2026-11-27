namespace Nomina_Quincenal
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
            groupBox1 = new GroupBox();
            btnSalir = new Button();
            btnLimpiar = new Button();
            btnResumen = new Button();
            groupBox5 = new GroupBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            lblNeto = new Label();
            lblDeducciones = new Label();
            lblBruto = new Label();
            lblEmpleados = new Label();
            label8 = new Label();
            groupBox4 = new GroupBox();
            label7 = new Label();
            lstNomina = new ListBox();
            groupBox3 = new GroupBox();
            btnRegistrar = new Button();
            chkTransporte = new CheckBox();
            txtHoras = new TextBox();
            label6 = new Label();
            cmbCargo = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            groupBox2 = new GroupBox();
            label3 = new Label();
            rdbTemporal = new RadioButton();
            rdbFijo = new RadioButton();
            txtEmpleado = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSalir);
            groupBox1.Controls.Add(btnLimpiar);
            groupBox1.Controls.Add(btnResumen);
            groupBox1.Controls.Add(groupBox5);
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 426);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(429, 398);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(132, 23);
            btnSalir.TabIndex = 11;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(266, 398);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(132, 23);
            btnLimpiar.TabIndex = 10;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnResumen
            // 
            btnResumen.Location = new Point(111, 398);
            btnResumen.Name = "btnResumen";
            btnResumen.Size = new Size(132, 23);
            btnResumen.TabIndex = 9;
            btnResumen.Text = "Mostrar resumen";
            btnResumen.UseVisualStyleBackColor = true;
            btnResumen.Click += btnResumen_Click;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(label12);
            groupBox5.Controls.Add(label11);
            groupBox5.Controls.Add(label10);
            groupBox5.Controls.Add(label9);
            groupBox5.Controls.Add(lblNeto);
            groupBox5.Controls.Add(lblDeducciones);
            groupBox5.Controls.Add(lblBruto);
            groupBox5.Controls.Add(lblEmpleados);
            groupBox5.Controls.Add(label8);
            groupBox5.Location = new Point(310, 210);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(463, 172);
            groupBox5.TabIndex = 8;
            groupBox5.TabStop = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(82, 144);
            label12.Name = "label12";
            label12.Size = new Size(63, 15);
            label12.TabIndex = 10;
            label12.Text = "Total neto:";
            label12.Click += label12_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(44, 114);
            label11.Name = "label11";
            label11.Size = new Size(106, 15);
            label11.TabIndex = 9;
            label11.Text = "Total deducciones:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(82, 85);
            label10.Name = "label10";
            label10.Size = new Size(68, 15);
            label10.TabIndex = 8;
            label10.Text = "Total bruto:";
            label10.Click += label10_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(24, 52);
            label9.Name = "label9";
            label9.Size = new Size(126, 15);
            label9.TabIndex = 7;
            label9.Text = "Empleados registrados";
            // 
            // lblNeto
            // 
            lblNeto.BorderStyle = BorderStyle.FixedSingle;
            lblNeto.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNeto.Location = new Point(156, 144);
            lblNeto.Name = "lblNeto";
            lblNeto.Size = new Size(126, 15);
            lblNeto.TabIndex = 6;
            // 
            // lblDeducciones
            // 
            lblDeducciones.BorderStyle = BorderStyle.FixedSingle;
            lblDeducciones.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDeducciones.Location = new Point(156, 114);
            lblDeducciones.Name = "lblDeducciones";
            lblDeducciones.Size = new Size(126, 15);
            lblDeducciones.TabIndex = 5;
            // 
            // lblBruto
            // 
            lblBruto.BorderStyle = BorderStyle.FixedSingle;
            lblBruto.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBruto.Location = new Point(156, 85);
            lblBruto.Name = "lblBruto";
            lblBruto.Size = new Size(126, 15);
            lblBruto.TabIndex = 4;
            // 
            // lblEmpleados
            // 
            lblEmpleados.BorderStyle = BorderStyle.FixedSingle;
            lblEmpleados.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmpleados.Location = new Point(156, 52);
            lblEmpleados.Name = "lblEmpleados";
            lblEmpleados.Size = new Size(126, 15);
            lblEmpleados.TabIndex = 3;
            lblEmpleados.TextAlign = ContentAlignment.TopRight;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(24, 20);
            label8.Name = "label8";
            label8.Size = new Size(64, 17);
            label8.TabIndex = 2;
            label8.Text = "Resumen";
            // 
            // groupBox4
            // 
            groupBox4.BackColor = SystemColors.Control;
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(lstNomina);
            groupBox4.Location = new Point(310, 19);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(460, 182);
            groupBox4.TabIndex = 7;
            groupBox4.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(57, 19);
            label7.Name = "label7";
            label7.Size = new Size(123, 17);
            label7.TabIndex = 1;
            label7.Text = "Nomina registrada";
            label7.Click += label7_Click;
            // 
            // lstNomina
            // 
            lstNomina.FormattingEnabled = true;
            lstNomina.Location = new Point(57, 40);
            lstNomina.Name = "lstNomina";
            lstNomina.Size = new Size(354, 124);
            lstNomina.TabIndex = 0;
            lstNomina.SelectedIndexChanged += lstNomina_SelectedIndexChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnRegistrar);
            groupBox3.Controls.Add(chkTransporte);
            groupBox3.Controls.Add(txtHoras);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(cmbCargo);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label4);
            groupBox3.Location = new Point(6, 150);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(286, 232);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrar.Location = new Point(6, 194);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(273, 32);
            btnRegistrar.TabIndex = 16;
            btnRegistrar.Text = "Registrar empleado";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // chkTransporte
            // 
            chkTransporte.AutoSize = true;
            chkTransporte.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkTransporte.Location = new Point(38, 145);
            chkTransporte.Name = "chkTransporte";
            chkTransporte.Size = new Size(186, 19);
            chkTransporte.TabIndex = 15;
            chkTransporte.Text = "Recibe incentivo de transporte";
            chkTransporte.UseVisualStyleBackColor = true;
            chkTransporte.CheckedChanged += chkTransporte_CheckedChanged;
            // 
            // txtHoras
            // 
            txtHoras.Location = new Point(38, 98);
            txtHoras.Name = "txtHoras";
            txtHoras.Size = new Size(159, 23);
            txtHoras.TabIndex = 14;
            txtHoras.TextChanged += txtHoras_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(37, 80);
            label6.Name = "label6";
            label6.Size = new Size(178, 15);
            label6.TabIndex = 13;
            label6.Text = "Horas trabajadas en la quincena:";
            // 
            // cmbCargo
            // 
            cmbCargo.FormattingEnabled = true;
            cmbCargo.Items.AddRange(new object[] { "Auxiliar", "Técnico", "Supervisor", "Gerente" });
            cmbCargo.Location = new Point(76, 42);
            cmbCargo.Name = "cmbCargo";
            cmbCargo.Size = new Size(121, 23);
            cmbCargo.TabIndex = 12;
            cmbCargo.SelectedIndexChanged += cmbCargo_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(37, 45);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 11;
            label5.Text = "Cargo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(30, 16);
            label4.Name = "label4";
            label4.Size = new Size(113, 17);
            label4.TabIndex = 10;
            label4.Text = "Registro de pago";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(rdbTemporal);
            groupBox2.Controls.Add(rdbFijo);
            groupBox2.Controls.Add(txtEmpleado);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(12, 19);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(280, 125);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(24, 19);
            label3.Name = "label3";
            label3.Size = new Size(148, 20);
            label3.TabIndex = 9;
            label3.Text = "Datos del empleado";
            // 
            // rdbTemporal
            // 
            rdbTemporal.AutoSize = true;
            rdbTemporal.Location = new Point(162, 90);
            rdbTemporal.Name = "rdbTemporal";
            rdbTemporal.Size = new Size(75, 19);
            rdbTemporal.TabIndex = 4;
            rdbTemporal.TabStop = true;
            rdbTemporal.Text = "Temporal";
            rdbTemporal.UseVisualStyleBackColor = true;
            rdbTemporal.CheckedChanged += rdbTemporal_CheckedChanged;
            // 
            // rdbFijo
            // 
            rdbFijo.AutoSize = true;
            rdbFijo.Location = new Point(99, 90);
            rdbFijo.Name = "rdbFijo";
            rdbFijo.Size = new Size(44, 19);
            rdbFijo.TabIndex = 3;
            rdbFijo.TabStop = true;
            rdbFijo.Text = "Fijo";
            rdbFijo.UseVisualStyleBackColor = true;
            rdbFijo.CheckedChanged += rdbFijo_CheckedChanged;
            // 
            // txtEmpleado
            // 
            txtEmpleado.Location = new Point(92, 47);
            txtEmpleado.Name = "txtEmpleado";
            txtEmpleado.Size = new Size(135, 23);
            txtEmpleado.TabIndex = 2;
            txtEmpleado.TextChanged += txtEmpleado_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 90);
            label2.Name = "label2";
            label2.Size = new Size(62, 17);
            label2.TabIndex = 1;
            label2.Text = "Contrato:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 47);
            label1.Name = "label1";
            label1.Size = new Size(60, 17);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Nomina Quincenal";
            groupBox1.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton rdbTemporal;
        private RadioButton rdbFijo;
        private TextBox txtEmpleado;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private GroupBox groupBox5;
        private GroupBox groupBox4;
        private GroupBox groupBox3;
        private Label label3;
        private Label label5;
        private Label label4;
        private TextBox txtHoras;
        private Label label6;
        private ComboBox cmbCargo;
        private ListBox lstNomina;
        private Button btnRegistrar;
        private CheckBox chkTransporte;
        private Label label7;
        private Label lblBruto;
        private Label lblEmpleados;
        private Label label8;
        private Button btnSalir;
        private Button btnLimpiar;
        private Button btnResumen;
        private Label lblNeto;
        private Label lblDeducciones;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
    }
}
