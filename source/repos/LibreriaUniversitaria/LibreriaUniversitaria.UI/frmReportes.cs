using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibreriaUniversitaria.UI
{
    public partial class frmReportes : Form
    {

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmReportes
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "frmReportes";
            this.Load += new System.EventHandler(this.frmReportes_Load);
            this.ResumeLayout(false);

        }

        private void frmReportes_Load(object sender, EventArgs e)
        {

        }
    }
}
