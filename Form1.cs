namespace Nomina_Quincenal
{
    public partial class Form1 : Form
    {
        const int horas_max = 88;
        const decimal horas_extra = 1.35m;

        const decimal incentivo_transporte = 1500;


        const decimal AFP = 0.0287m;
        const decimal SFS = 0.0304m;
        const decimal auxiliar = 180m;
        const decimal tecnico = 250m;
        const decimal supervisor = 350m;
        const decimal gerente = 500m;
        int totalempleados = 0;
        decimal totalbruto = 0m;
        decimal totalDeducciones = 0m;
        decimal totalNeto = 0m;

        public Form1()

        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtEmpleado_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdbFijo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbTemporal_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cmbCargo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtHoras_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkTransporte_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string nombre = txtEmpleado.Text.Trim();
            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Por favor, ingrese el nombre del empleado.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmpleado.Focus();
                return;
            }

            if (!rdbFijo.Checked && !rdbTemporal.Checked)
            {
                MessageBox.Show("Por favor, seleccione el tipo de contrato (Fijo o Temporal).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbCargo.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione un cargo.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbCargo.Focus();
                return;
            }

            if (!int.TryParse(txtHoras.Text.Trim(), out int horasTrabajadas) || horasTrabajadas < 1 || horasTrabajadas > 120)
            {
                MessageBox.Show("Ingrese una cantidad de horas válida (número entero entre 1 y 120).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoras.Focus();
                return;
            }

            string cargo = cmbCargo.SelectedItem.ToString();
            decimal tarifaHora = 0m;

            if (cargo == "Auxiliar")
            {
                tarifaHora = auxiliar;
            }
            else if (cargo == "Técnico")
            {
                tarifaHora = tecnico;
            }
            else if (cargo == "Supervisor")
            {
                tarifaHora = supervisor;
            }
            else if (cargo == "Gerente")
            {
                tarifaHora = gerente;
            }

            decimal salarioRegular = 0m;
            decimal pagoExtra = 0m;

            if (horasTrabajadas <= horas_max)
            {
                salarioRegular = horasTrabajadas * tarifaHora;
            }
            else
            {
                salarioRegular = horas_max * tarifaHora;
                int horasExtra = horasTrabajadas - horas_max;
                pagoExtra = horasExtra * tarifaHora * horas_extra;
            }
            decimal incentivo = chkTransporte.Checked ? incentivo_transporte : 0m;
            decimal salarioBruto = salarioRegular + pagoExtra + incentivo;

            decimal deducciones = 0m;
            if (rdbFijo.Checked)
            {
                decimal baseDeduccion = salarioRegular + pagoExtra;
                deducciones = baseDeduccion * (AFP + SFS);
            }

            decimal salarioNeto = salarioBruto - deducciones;

            string registro = $"{nombre} · {cargo} · RD$ {salarioNeto:N2}";
            lstNomina.Items.Add(registro);

            totalempleados++;
            totalbruto += salarioBruto;
            totalDeducciones += deducciones;
            totalNeto += salarioNeto;

            txtEmpleado.Clear();
            rdbFijo.Checked = false;
            rdbTemporal.Checked = false;
            cmbCargo.SelectedIndex = -1;
            txtHoras.Clear();
            chkTransporte.Checked = false;

            txtEmpleado.Focus();
        }

        private void lstNomina_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnResumen_Click(object sender, EventArgs e)
        {
            if (lstNomina.Items.Count == 0)
            {
                MessageBox.Show("No hay empleados registrados para mostrar el resumen.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            lblEmpleados.Text = totalempleados.ToString();
            lblBruto.Text = $"RD$ {totalbruto:N2}";
            lblDeducciones.Text = $"RD$ {totalDeducciones:N2}";
            lblNeto.Text = $"RD$ {totalNeto:N2}";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtEmpleado.Clear();
            rdbFijo.Checked = false;
            rdbTemporal.Checked = false;
            cmbCargo.SelectedIndex = -1;
            txtHoras.Clear();
            chkTransporte.Checked = false;

            lstNomina.Items.Clear();

            totalempleados = 0;
            totalbruto = 0m;
            totalDeducciones = 0m;
            totalNeto = 0m;

            lblEmpleados.Text = "0";
            lblBruto.Text = "RD$ 0.00";
            lblDeducciones.Text = "RD$ 0.00";
            lblNeto.Text = "RD$ 0.00";

            txtEmpleado.Focus();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
