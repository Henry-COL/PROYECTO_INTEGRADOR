using GeoIntegral.Controller;
using GeoIntegral.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GeoIntegral.Views
{
    public partial class Usuario_Materiales : Form, ICerrable
    {
        public event EventHandler VentanaCerrada;
        private MaterialController materialController = new MaterialController();

        public Usuario_Materiales(Size tamano)
        {
            InitializeComponent();
            this.Size = tamano;
            EstilarTabla();
            dgvMateriales.AllowUserToAddRows = false;
            dgvMateriales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMateriales.ReadOnly = true;
            if (dgvMateriales.Columns.Contains("ID"))
                dgvMateriales.Columns["ID"].Visible = false;

            lblMensaje_Nombre.Visible = false;
            lblMensaje_Nombre.ForeColor = System.Drawing.Color.Red;
            btnGuardarMaterial.Click += new EventHandler(btnGuardarMaterial_Click);
            btnLimpiarCampos.Click += new EventHandler(btnLimpiarCampos_Click);

            txtNombreMaterial.KeyPress += TxtNombreMaterial_KeyPress;

            CargarMateriales();
        }


        private void EstilarTabla()
        {
            dgvMateriales.BackgroundColor = System.Drawing.Color.FromArgb(15, 23, 33);
            dgvMateriales.GridColor = System.Drawing.Color.FromArgb(30, 45, 60);
            dgvMateriales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvMateriales.RowHeadersVisible = false;
            dgvMateriales.AllowUserToAddRows = false;
            dgvMateriales.AllowUserToResizeRows = false;
            dgvMateriales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvMateriales.ReadOnly = true;
            dgvMateriales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvMateriales.EnableHeadersVisualStyles = false;

            // Encabezado
            dgvMateriales.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(20, 32, 46);
            dgvMateriales.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(180, 210, 230);
            dgvMateriales.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10f, System.Drawing.FontStyle.Bold);
            dgvMateriales.ColumnHeadersDefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dgvMateriales.ColumnHeadersHeight = 38;
            dgvMateriales.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;

            // Filas normales
            dgvMateriales.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(22, 34, 48);
            dgvMateriales.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            dgvMateriales.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.5f);
            dgvMateriales.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;

            // Fila seleccionada
            dgvMateriales.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(7, 16, 30);
            dgvMateriales.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;

            // Filas alternadas
            dgvMateriales.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(18, 28, 40);
            dgvMateriales.AlternatingRowsDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(26, 95, 80);
            dgvMateriales.AlternatingRowsDefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;

            dgvMateriales.RowTemplate.Height = 32;
        }

        private void CargarMateriales()
        {
            dgvMateriales.Rows.Clear();
            var materiales = materialController.ObtenerTodosLosMateriales();
            foreach (var m in materiales)
            {
                dgvMateriales.Rows.Add(m.Id, m.Nombre, $"${m.CostoUnidad}");
            }
        }

        

        private void LimpiarCampos()
        {
            txtNombreMaterial.Text = "";
            numCostoUnidad.Value = 100000;
            lblMensaje_Nombre.Visible = false;
        }

        private void btnGuardarMaterial_Click(object sender, EventArgs e)
        {
            lblMensaje_Nombre.Visible = false;

            bool validar = true;

            if (txtNombreMaterial.Text.Trim() == "")
            {
                lblMensaje_Nombre.Text = "Campo obligatorio*";
                lblMensaje_Nombre.Visible = true;
                validar = false;
            }

            if (!validar) return;


            if (materialController.MaterialExiste(txtNombreMaterial.Text.Trim()))
            {
                lblMensaje_Nombre.Text = "Ese material ya existe*";
                lblMensaje_Nombre.Visible = true;
                return;
            }

            Material nuevoMaterial = new Material(
                materialController.GenerarNuevoId(),
                txtNombreMaterial.Text.Trim(), double.Parse(numCostoUnidad.Text.Trim())
            );

            if (materialController.RegistrarMaterial(nuevoMaterial))
            {
                MessageBox.Show("¡Material registrado con éxito!", "GeoIntegral",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                CargarMateriales();
            }
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnEliminarMaterial_Click(object sender, EventArgs e)
        {
            if (dgvMateriales.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un material de la tabla.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var row = dgvMateriales.SelectedRows[0];

                DataGridViewCell nombreCell = null;
                DataGridViewCell idCell = null;

                if (dgvMateriales.Columns.Contains("Nombre"))
                    nombreCell = row.Cells[dgvMateriales.Columns["Nombre"].Index];
                else if (row.Cells.Count > 1)
                    nombreCell = row.Cells[1];

                if (dgvMateriales.Columns.Contains("ID"))
                    idCell = row.Cells[dgvMateriales.Columns["ID"].Index];
                else if (row.Cells.Count > 0)
                    idCell = row.Cells[0];

                string nombre = nombreCell?.Value?.ToString() ?? string.Empty;
                if (!int.TryParse(idCell?.Value?.ToString(), out int id))
                {
                    MessageBox.Show("No se pudo obtener el identificador del material seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            var confirmacion = MessageBox.Show(
                $"¿Está seguro de eliminar el material '{nombre}'?",
                "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmacion == DialogResult.Yes)
                {
                    if (materialController.EliminarMaterial(id))
                    {
                        MessageBox.Show("Material eliminado con éxito.", "GeoIntegral",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarMateriales();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al procesar la fila seleccionada: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtNombreMaterial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) &&
                !char.IsWhiteSpace(e.KeyChar) &&
                !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnCerrar_App_Click(object sender, EventArgs e)
        {
            VentanaCerrada?.Invoke(this, EventArgs.Empty);
        }
    }
}