using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaNotas.Clases;
using SistemaNotas.UoW;

namespace SistemaNotas.Formularios
{
    public partial class frmRegistrarNota : Form

    {
        private Uow _uow;
        public frmRegistrarNota()
        {
            InitializeComponent();
            _uow = new Uow();
        }

        private void frmRegistrarNota_Load(object sender, EventArgs e)
        {
            CargarDatos();
            LimpiarCampos();
        }

        private void CargarDatos()
        {
            dgvRegistro.DataSource = _uow.Estudiantes.ObtenerTodos().ToList();
        }
        private void LimpiarCampos()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtLaboratorio.Clear();
            txtParcial.Clear();
            txtAsistencia.Clear();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text) || string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtLaboratorio.Text) || string.IsNullOrWhiteSpace(txtParcial.Text) ||
                string.IsNullOrWhiteSpace(txtAsistencia.Text))
            {
                MessageBox.Show("Debe completar todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var estudiante = new Estudiante
                {
                    Codigo = txtCodigo.Text,
                    Nombre = txtNombre.Text,
                    Laboratorio = decimal.Parse(txtLaboratorio.Text),
                    Parcial = decimal.Parse(txtParcial.Text),
                    Asistencia = decimal.Parse(txtAsistencia.Text)
                };

                if (estudiante.Laboratorio < 0 || estudiante.Parcial < 0 || estudiante.Asistencia < 0 ||
                    estudiante.Laboratorio > 10 || estudiante.Parcial > 10 || estudiante.Asistencia > 10)
                {
                    MessageBox.Show("Las notas deben estar entre 0 y 10.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                estudiante.CalcularNotaFinal();
                _uow.Estudiantes.Insertar(estudiante);

                CargarDatos();
                LimpiarCampos();
                MessageBox.Show("Estudiante agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        private void dgvRegistro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = (int)dgvRegistro.Rows[e.RowIndex].Cells["Id"].Value;
                var form = new frmRegistrarNotaCmd(id);
                form.ShowDialog();
                CargarDatos();
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; // Bloquea el carácter
                MessageBox.Show("Solo se permiten letras y espacios en el nombre.", "Entrada no válida",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten números en el código.", "Entrada no válida",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtLaboratorio_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten números o punto decimal en Laboratorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            TextBox txt = sender as TextBox;
            if (e.KeyChar == '.' && txt.Text.Contains("."))
                e.Handled = true;
        }

        private void txtParcial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten números o punto decimal en Parcial.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            TextBox txt = sender as TextBox;
            if (e.KeyChar == '.' && txt.Text.Contains("."))
                e.Handled = true;
        }

        private void txtAsistencia_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten números o punto decimal en Asistencia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            TextBox txt = sender as TextBox;
            if (e.KeyChar == '.' && txt.Text.Contains("."))
                e.Handled = true;
        }
        
            
        
    }
}

//Keiry Daniela Chávez Hernández
//Autoevaluación: 7.00