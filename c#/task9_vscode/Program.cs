using System.Windows.Forms; using System.Drawing; namespace First
{
public class MyForm : Form
{
public MyForm()
{
InitComponents();
}
private void InitComponents()
{
ColorDialog dlg = new ColorDialog(); dlg.ShowDialog();
if(dlg.ShowDialog() == DialogResult.Ok)
this.backColor = dlg.Color;
dlg.ShowDialog();
}
[STAThread]
static void Main() {
Application.SetHighDpiMode(HighDpiMode.SystemAware); Application.EnableVisualStyles();
Application.Run(new MyForm());
}
}
}
