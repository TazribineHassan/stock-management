using stock_management.Pages;

namespace stock_management
{
    public partial class Menu : Form
    {
        private Form? currentForm = null;

        public Menu()
        {
            InitializeComponent();
        }

        // Swich to the new page
        private void moveToNewForm(Form form)
        {
            if(currentForm != null)
            {
                currentForm.Close();
            }
            currentForm = form;
            form.TopLevel = false;
            form.FormBorderStyle=FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(form);
            mainPanel.Tag = form;
            form.BringToFront();
            form.Show();
        }

        private void stock_btn_Click(object sender, EventArgs e)
        {
            moveToNewForm(new Stock());
        }

        private void vente_btn_Click(object sender, EventArgs e)
        {
            moveToNewForm(new vente());
        }

        private void suivi_btn_Click(object sender, EventArgs e)
        {
            moveToNewForm(new Suivi());
        }
    }
}