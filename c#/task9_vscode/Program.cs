using System;
using System.Windows.Forms;
using System.Drawing;

namespace First
{
    public class MyForm : Form
    {
        private TextBox textBox1;

        public MyForm()
        {
            InitComponents();
        }

        private void InitComponents()
        {
            // Initialize and add TextBox
            textBox1 = new TextBox();
            textBox1.Location = new Point(50, 50);
            textBox1.Size = new Size(200, 30);
            Controls.Add(textBox1);

            // Show color dialog
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                // Set the selected color as TextBox background
                textBox1.BackColor = dlg.Color;
            }
        }

        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.Run(new MyForm());
        }
    }
}
