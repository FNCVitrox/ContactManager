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
    public partial class mainmenu : UserControl
    {
        public mainmenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 mainForm = this.FindForm() as Form1;
            if (mainForm != null)
            {
                mainForm.LoadView(new Hinzufügen()); // Wechsel zum Hinzufügen-View
            }
        }
    }
}
