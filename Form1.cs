using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurante
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void kryptonPanel_Menu_Paint(object sender, PaintEventArgs e)
        {

        }
        //BOTON DESAYUNOS
        private void kryptonCheckButton1_Click(object sender, EventArgs e)
        {
            AbrirDesayunos(new Desayunos());
        }

        //FUNCION OBJECT DESAYUNOS
        private void AbrirDesayunos(object desayunos)
        {
            if(this.kryptonPanel_Menu.Controls.Count > 0)
                this.kryptonPanel_Menu.Controls.RemoveAt(0);
            Form des = desayunos as Form;
            des.TopLevel = false;
            des.Dock = DockStyle.Fill;
            this.kryptonPanel_Menu.Controls.Add(des);
            this.kryptonPanel_Menu.Tag = des;
            des.Show();
        }

        //FUNCION OBJECT ALMUERZO
        private void AbrirAlmuerzos(object almuerzo)
        {
            if (this.kryptonPanel_Menu.Controls.Count > 0)
                this.kryptonPanel_Menu.Controls.RemoveAt(0);
            Form alm = almuerzo as Form;
            alm.TopLevel = false;
            alm.Dock = DockStyle.Fill;
            this.kryptonPanel_Menu.Controls.Add(alm);
            this.kryptonPanel_Menu.Tag = alm;
            alm.Show();
        }

        //FUNCION OBJECT CENAS
        private void AbrirCenas(object cena)
        {
            if (this.kryptonPanel_Menu.Controls.Count > 0)
                this.kryptonPanel_Menu.Controls.RemoveAt(0);
            Form cen = cena as Form;
            cen.TopLevel = false;
            cen.Dock = DockStyle.Fill;
            this.kryptonPanel_Menu.Controls.Add(cen);
            this.kryptonPanel_Menu.Tag = cen;
            cen.Show();
        }

        private void kryptonCheckButton1_Click_1(object sender, EventArgs e)
        {
           
        }
        //BOTON ALMUERZO
        private void kryptonCheckButton2_Click(object sender, EventArgs e)
        {
            AbrirAlmuerzos(new Almuerzo());
        }

        //BOTON CENA
        private void kryptonCheckButton3_Click(object sender, EventArgs e)
        {
          AbrirCenas(new Cena());
        }

        private void kryptonLabel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
