using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1(string name, string email, int age)
        {
            InitializeComponent();
            lblName.Text = $"NAME: {name}";
            labelControl2.Text = $"E-MAIL: {email}";
            labelControl3.Text = $"AGE: {age}";
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ALERTA");
            XtraMessageBox.Show("Gama");
        }
    }
    namespace EdgeJsMethods
    {
        using System.Threading.Tasks;

        class Methods
        {
            public async Task<object> ShowForm(dynamic input)
            {
                return await Task.Run(() => {
                    return new Form1(input.name, input.email, input.age).ShowDialog();
                });
            }
        }
    }
}
