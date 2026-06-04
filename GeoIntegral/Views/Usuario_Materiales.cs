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
            dgvMateriales.AllowUserToAddRows = false;
            dgvMateriales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMateriales.ReadOnly = true;
            dgvMateriales.Columns["ID"].Visible = false;

            lblMensaje_Nombre.Visible = false;
            lblMensaje_Costo.Visible = false;
            lblMensaje_Nombre.ForeColor = System.Drawing.Color.Red;
            lblMensaje_Costo.ForeColor = System.Drawing.Color.Red;

            btnGuardarMaterial.Click += new EventHandler(btnGuardarMaterial_Click);
            btnLimpiarCampos.Click += new EventHandler(btnLimpiarCampos_Click);
            btnEliminarMaterial.Click += new EventHandler(btnEliminarMaterial_Click);

            CargarMateriales();
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
            txtCostoUnidad.Text = "";
            lblMensaje_Nombre.Visible = false;
            lblMensaje_Costo.Visible = false;
        }

        private void btnGuardarMaterial_Click(object sender, EventArgs e)
        {
            lblMensaje_Nombre.Visible = false;
            lblMensaje_Costo.Visible = false;

            bool validar = true;

            if (txtNombreMaterial.Text.Trim() == "")
            {
                lblMensaje_Nombre.Text = "Campo obligatorio*";
                lblMensaje_Nombre.Visible = true;
                validar = false;
            }
            if (txtCostoUnidad.Text.Trim() == "")
            {
                lblMensaje_Costo.Text = "Campo obligatorio*";
                lblMensaje_Costo.Visible = true;
                validar = false;
            }

            if (!validar) return;

            if (!double.TryParse(txtCostoUnidad.Text, out double costo) || costo <= 0)
            {
                lblMensaje_Costo.Text = "Ingrese un valor numérico válido*";
                lblMensaje_Costo.Visible = true;
                return;
            }

            if (materialController.MaterialExiste(txtNombreMaterial.Text.Trim()))
            {
                lblMensaje_Nombre.Text = "Ese material ya existe*";
                lblMensaje_Nombre.Visible = true;
                return;
            }

            Material nuevoMaterial = new Material(
                materialController.GenerarNuevoId(),
                txtNombreMaterial.Text.Trim(),
                costo
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

            string nombre = dgvMateriales.SelectedRows[0].Cells["Nombre"].Value.ToString();
            int id = int.Parse(dgvMateriales.SelectedRows[0].Cells["ID"].Value.ToString());

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
    }
}