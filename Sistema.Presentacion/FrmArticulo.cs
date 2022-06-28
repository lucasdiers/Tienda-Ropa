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
using System.Drawing.Imaging;
using System.IO;

namespace Sistema.Presentacion
{
    public partial class FrmArticulo : Form
    {
        private string NombreAnterior;
        public FrmArticulo()
        {
            InitializeComponent();
        }

        private void Listar()
        {
            // me lista los articulos que se haya insertado y llamo el metdo listar de la capa negocio
            try
            {
                DgvListado.DataSource = NAarticulo.listar(); 
                this.formato();
                this.Limpiar();
                lblTotal.Text = "Total registros: " + Convert.ToString(DgvListado.Rows.Count);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void formato()
        {
            // le da formato al datagrid
            DgvListado.Columns[0].Visible = false;
            DgvListado.Columns[1].Visible = false;
            DgvListado.Columns[2].Visible = false;
            DgvListado.Columns[0].Width = 70;
            DgvListado.Columns[1].Width = 70;
            DgvListado.Columns[3].Width = 100;
            DgvListado.Columns[4].Visible=false;
            DgvListado.Columns[5].Width = 70;
            DgvListado.Columns[6].Visible=false;
            DgvListado.Columns[7].Width = 70;
            DgvListado.Columns[8].Width = 70;
            DgvListado.Columns[9].Width = 70;
            DgvListado.Columns[10].Width = 80;
            DgvListado.Columns[11].Width = 70;
            DgvListado.Columns[12].Width = 70;
            DgvListado.Columns[13].Width = 70;
        }
        private void Limpiar()
        {
            // limpia los textbox
            
            TxtNombre.Clear();
            Txtid.Clear();
            txtCodigo.Clear();
            TxtPrecioVenta.Clear();
            txtColor.Clear();
            txtPrecioCompra.Clear();    
            TxtStock.Clear();
            BtInsertar.Visible = true;
            BtActualizar.Visible = false;
            errorIcono.Clear();
            

            DgvListado.Columns[0].Visible = false;
            btEliminar.Visible = false;
            ChkSeleccionar.Checked = false;

        }
        private void CargarCategoria()
        {
            try
            {
                CboCategoria.DataSource = NCategoria.Seleccionar();
                CboCategoria.ValueMember = "idcategoria"; // obtengo el valor del items
                CboCategoria.DisplayMember = "nombre"; // obtengo el nombre de cada itmes
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }

        }
        private void CargarMarca()
        {
            try
            {
                cbomarca.DataSource = NMarca.Seleccionar();
                cbomarca.ValueMember = "idmarca"; // obtengo el valor del items
                cbomarca.DisplayMember = "nombre"; // obtengo el nombre de cada itmes
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void CargarTalle()
        {
            try
            {
                cbotalle.DataSource = NTalle.Seleccionar();
                cbotalle.ValueMember = "idtalle"; // obtengo el valor del items
                cbotalle.DisplayMember = "nombre"; // obtengo el nombre de cada itmes
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void MensajeError(string Mensaje)
        {
            // muestro un mensaje y un boton  de  ok  y muestra un icono de error
            MessageBox.Show(Mensaje, "Sistema de Ropa", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeOK(string Mensaje)
        {
            // muestro un mensaje y un boton  de  ok  y muestra un icono de informacion
            MessageBox.Show(Mensaje, "Sistema de Ropa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmArticulo_Load(object sender, EventArgs e)
        {
            
            this.CargarCategoria();
            this.CargarMarca();
            this.CargarTalle();
            this.Listar();
        }

        private void DgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // lo que esta en el datagridw lo pasa a los textbox
            try
            {
                this.Limpiar();
                BtActualizar.Visible = true;
                BtInsertar.Visible = false;
                Txtid.Text = Convert.ToString(DgvListado.CurrentRow.Cells["ID"].Value);
                CboCategoria.SelectedValue = Convert.ToString(DgvListado.CurrentRow.Cells["idcategoria"].Value);
                cbomarca.SelectedValue = Convert.ToString(DgvListado.CurrentRow.Cells["idmarca"].Value);
                cbotalle.SelectedValue = Convert.ToString(DgvListado.CurrentRow.Cells["idtalle"].Value);
                this.NombreAnterior = Convert.ToString(DgvListado.CurrentRow.Cells["Nombre"].Value);
                TxtNombre.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Nombre"].Value);
                txtCodigo.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Codigo"].Value);
                txtPrecioCompra.Text = Convert.ToString(DgvListado.CurrentRow.Cells["PrecioCompra"].Value);
                TxtPrecioVenta.Text = Convert.ToString(DgvListado.CurrentRow.Cells["PrecioVenta"].Value);
                TxtStock.Text = Convert.ToString(DgvListado.CurrentRow.Cells["stock"].Value);
                txtColor.Text = Convert.ToString(DgvListado.CurrentRow.Cells["color"].Value);
                
               

            } 
            catch (Exception ex)
            {

                MessageBox.Show("Selecione en la celda Nombre" + "| Error" + ex.Message );
            }
        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
           // llama al metodo limpiar 
        }

        private void DgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { // me permite selecionar 
            if (e.ColumnIndex == DgvListado.Columns["Seleccionar"].Index) // si el indice de la columna es igual a la columna selecionar
            {
                // indica que  la variable check eliminar es igual al a la celda seleccionar lo que hace identifica que celdas fueron
                //selcionadas
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)DgvListado.Rows[e.RowIndex].Cells["Seleccionar"]; 
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value); // convierto en falso o verdadero
            }
        }

        private void Chkseleccionar_CheckedChanged(object sender, EventArgs e)
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

        private void btEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcion;
                opcion = MessageBox.Show("Realmente quieres eliminar el/los registro", "sistema de ropa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (opcion == DialogResult.OK)
                {
                    int codigo;//
                    string Rpa = "";//

                    foreach (DataGridViewRow row in DgvListado.Rows) // recorre todas las filas del datagriwd mediante el objeto row
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value)) // si esta seleccionado
                        {
                            codigo = Convert.ToInt32(row.Cells[1].Value); // convierte a entero el id ya que es la columna 1
                            Rpa = NAarticulo.Eliminar(codigo); //


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

        private void BtActualizar_Click(object sender, EventArgs e)
        {
            try
            { // valido que si esten vacios los textbox
                string Rpta = "";
                if (Txtid.Text == string.Empty || CboCategoria.Text == string.Empty || cbomarca.Text == string.Empty || cbotalle.Text == string.Empty ||TxtNombre.Text == string.Empty
                    || txtCodigo.Text == string.Empty | txtPrecioCompra.Text == string.Empty || TxtPrecioVenta.Text == string.Empty || TxtStock.Text == string.Empty ||
                    txtColor.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos, seran remarcaos");
                    errorIcono.SetError(CboCategoria, "Ingrese una categoria");
                    errorIcono.SetError(cbomarca, "ingrese una marca");
                    errorIcono.SetError(cbotalle, "ingrese un talle");
                    errorIcono.SetError(TxtNombre, "ingrese un nombre");
                    errorIcono.SetError(txtCodigo, "ingrese un codigo");
                    errorIcono.SetError(txtPrecioCompra, "ingrese el precio compra");
                    errorIcono.SetError(TxtPrecioVenta, "ingrese el precio venta");
                    errorIcono.SetError(TxtStock, "ingrese el stock");
                    errorIcono.SetError(txtColor, "ingrese un color");

                }
                else
                {
                    // llamo el metodo insertar de la capa negocio y convierto a entero los campos que sean necesarios para poder actuaizar
                    Rpta = NAarticulo.Actualizar(Convert.ToInt32(Txtid.Text),Convert.ToInt32(CboCategoria.SelectedValue), Convert.ToInt32(cbomarca.SelectedValue),
                      Convert.ToInt32(cbotalle.SelectedValue),this.NombreAnterior ,TxtNombre.Text.Trim(), txtCodigo.Text.Trim(), Convert.ToDecimal(txtPrecioCompra.Text.Trim()),
                      Convert.ToDecimal(TxtPrecioVenta.Text.Trim()), Convert.ToInt32(TxtStock.Text.Trim()), txtColor.Text.Trim());

                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeOK("Se modifico correctamente");

                        Listar();
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

        private void BtInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                // valido que si esten vacios los textbox
                if (CboCategoria.Text== string.Empty||cbomarca.Text==string.Empty||cbotalle.Text==string.Empty ||TxtNombre.Text == string.Empty
                    ||txtCodigo.Text==string.Empty|txtPrecioCompra.Text==string.Empty||TxtPrecioVenta.Text ==string.Empty||TxtStock.Text==string.Empty||
                    txtColor.Text==string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos, seran remarcaos");
                    errorIcono.SetError(CboCategoria, "Ingrese una categoria");
                    errorIcono.SetError(cbomarca,"ingrese una marca");
                    errorIcono.SetError(cbotalle, "ingrese un talle");
                    errorIcono.SetError(TxtNombre, "ingrese un nombre");
                    errorIcono.SetError(txtCodigo, "ingrese un codigo");
                    errorIcono.SetError(txtPrecioCompra, "ingrese el precio compra");
                    errorIcono.SetError(TxtPrecioVenta, "ingrese el precio venta");
                    errorIcono.SetError(TxtStock, "ingrese el stock");
                    errorIcono.SetError(txtColor, "ingrese un color");
                    
                }
                else
                {   // llamo el metodo insertar de la capa negocio y convierto a entero los campos que sean necesarios para poder insertar
                    Rpta = NAarticulo.Insertar(Convert.ToInt32(CboCategoria.SelectedValue),Convert.ToInt32(cbomarca.SelectedValue),
                      Convert.ToInt32(cbotalle.SelectedValue), TxtNombre.Text.Trim(),txtCodigo.Text.Trim(),Convert.ToDecimal(txtPrecioCompra.Text.Trim()),
                      Convert.ToDecimal (TxtPrecioVenta.Text.Trim()),Convert.ToInt32(TxtStock.Text.Trim()),txtColor.Text.Trim());
                    
                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeOK("Se inserto correctamente");

                        Listar();
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
    }
    
}

