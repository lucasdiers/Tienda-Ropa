using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema.Negocio;
using System.Data.SqlClient;

namespace Sistema.Presentacion
{
    public partial class FrmCategoria : Form
    {
       // SqlConnection conex = new SqlConnection("Data Source=DESKTOP-5Q753GK\\SQLEXPRESS;Initial Catalog=dbsistema;Integrated Security=True");

        public FrmCategoria()
        {
            InitializeComponent();

        }
        
        private void Listar()
        {
            try
            {
                DgvListado.DataSource = NCategoria.listar();
                this.formato();
                Limpiar();
                lblTotal.Text = "Total registros: " + Convert.ToString(DgvListado.Rows.Count);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void formato()
        {
            DgvListado.Columns[0].Visible = false;
            DgvListado.Columns[1].Visible = false;
            DgvListado.Columns[2].Width = 400;

        }
        private void Limpiar()
        {
          
            TxtNombre.Clear();
            Txtid.Clear();
            BtInsertar.Visible = true;
            BtActualizar.Visible = false;
            errorIcono.Clear();

            DgvListado.Columns[0].Visible = false;
            btEliminar.Visible = false;
            ChkSeleccionar.Checked = false;

        }
        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeOK(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
       
        private void BtInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if (TxtNombre.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos, seran remarcaos");
                    errorIcono.SetError(TxtNombre, "Ingrese un nombre");

                }
                else
                {
                    Rpta = NCategoria.Insertar(TxtNombre.Text.Trim());
                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeOK("Se inserto correctamente");
                        this.Listar();
                    }
                    else
                    {
                        this.MensajeError(Rpta);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);

            }

        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            this.Limpiar();

        }

        private void DgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                this.Limpiar();
                BtActualizar.Visible = true;
                BtInsertar.Visible = false;

                Txtid.Text = Convert.ToString(DgvListado.CurrentRow.Cells["ID"].Value);
                TxtNombre.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Nombre"].Value);

            }
            catch (Exception)
            {

                MessageBox.Show("Selecione en la celda Nombre");
            }


        }
        private void DgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DgvListado.Columns["Seleccionar"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)DgvListado.Rows[e.RowIndex].Cells["Seleccionar"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }
        }

        private void BtActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if (TxtNombre.Text == string.Empty || Txtid.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos, seran remarcaos");
                    errorIcono.SetError(TxtNombre, "Ingrese un nombre");

                }
                else
                {
                    Rpta = NCategoria.Actualizar(Convert.ToInt32(Txtid.Text.Trim()), TxtNombre.Text.Trim());
                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeOK("Se modifico correctamente");
                        this.Listar();
                    }
                    else
                    {
                        this.MensajeError(Rpta);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);

            }
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcion;
                opcion = MessageBox.Show("Realmente quieres eliminar el/los registro", "sistema de ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (opcion == DialogResult.OK)
                {
                    int codigo;//
                    string Rpa = "";//

                    foreach (DataGridViewRow row in DgvListado.Rows) // recorre todas las filas del datagriwd mediante el objeto row
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value)) // si esta seleccionado
                        {
                            codigo = Convert.ToInt32(row.Cells[1].Value);
                            Rpa = NCategoria.Eliminar(codigo);


                        }


                    }
                    this.MensajeOK("Se eliminaron correctamente los registros");
                    this.Listar();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void ChkSeleccionar_CheckedChanged_1(object sender, EventArgs e)
        {
            if (ChkSeleccionar.Checked)
            {
                DgvListado.Columns[0].Visible = true;
                btEliminar.Visible = true;
            }
            else
            {
                DgvListado.Columns[0].Visible = false;
                btEliminar.Visible = false;
            }
        }

        

        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        
        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}