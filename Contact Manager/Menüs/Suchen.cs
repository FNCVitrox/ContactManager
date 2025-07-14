using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_Manager
{
    public partial class Suchen : UserControl
    {
        public Suchen()
        {
            InitializeComponent();
        }

        private void btnZurueck_Click(object sender, EventArgs e)
        {
            Form1 mainForm = this.FindForm() as Form1;//sucht Form1
            if (mainForm != null)//wenn Form1 gfunden wurde wird das if statement ausgeführt
            {
                mainForm.LoadView(new mainmenu()); // Wechsel zum Hinzufügen-View

            }
        }
    }
}
