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
    public partial class frmRegistrarNotaCmd : Form
    {
        private int _id;
        private Uow _uow;
        private Estudiante _estudiante;
        public frmRegistrarNotaCmd(int id)
        {
            InitializeComponent();
            _id = id;
            _uow = new Uow();
            _estudiante = _uow.Estudiantes.ObtenerPorId(_id);


        }

        private void frmRegistrarNotaCmd_Load(object sender, EventArgs e)
        {
            if (_estudiante != null)
            {
                // Cargar los datos del estudiante en los TextBox
                txtCodigo.Text = _estudiante.Codigo;
                txtNombre.Text = _estudiante.Nombre;
                txtLaboratorio.Text = _estudiante.Laboratorio.ToString();
                txtParcial.Text = _estudiante.Parcial.ToString();
                txtAsistencia.Text = _estudiante.Asistencia.ToString();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
                if (string.IsNullOrWhiteSpace(txtCodigo.Text) ||
                    string.IsNullOrWhiteSpace(txtNombre.Text) ||
                    string.IsNullOrWhiteSpace(txtLaboratorio.Text) ||
                    string.IsNullOrWhiteSpace(txtParcial.Text) ||
                    string.IsNullOrWhiteSpace(txtAsistencia.Text))
                {
                    MessageBox.Show("Debe completar todos los campos.", "Advertencia",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    _estudiante.Codigo = txtCodigo.Text;
                    _estudiante.Nombre = txtNombre.Text;
                    _estudiante.Laboratorio = decimal.Parse(txtLaboratorio.Text);
                    _estudiante.Parcial = decimal.Parse(txtParcial.Text);
                    _estudiante.Asistencia = decimal.Parse(txtAsistencia.Text);

                    if (_estudiante.Laboratorio < 0 || _estudiante.Parcial < 0 || _estudiante.Asistencia < 0 ||
                        _estudiante.Laboratorio > 10 || _estudiante.Parcial > 10 || _estudiante.Asistencia > 10)
                    {
                        MessageBox.Show("Las notas deben estar entre 0 y 10.", "Error de validación",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    _estudiante.CalcularNotaFinal();
                    _uow.Estudiantes.Actualizar(_estudiante);

                    MessageBox.Show("Registro actualizado correctamente.", "Éxito",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar: " + ex.Message);
                }
            
        }

        private void dgvRegistro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
