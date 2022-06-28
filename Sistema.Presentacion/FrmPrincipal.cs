using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.Presentacion
{
    public partial class FrmPrincipal : Form
    {
        private int childFormNumber = 0;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void categoriasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!existeformulario("FrmCategoria"))
            {
                FrmCategoria frm = new FrmCategoria();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private bool existeformulario(string Nombre)
        {

            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == Nombre)
                {
                    return true;
                }

            }
            return false;


        }

        private void marcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!existeformulario("FrmMarca"))
            {
               FrmMarca frm = new FrmMarca();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void tallesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!existeformulario("FrmTalle"))
            {
                FrmTalle frm = new FrmTalle();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void articulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!existeformulario("FrmArticulo"))
            {
                FrmArticulo frm = new FrmArticulo();
                frm.MdiParent = this;
                frm.Show();
            }
        }
    }
}