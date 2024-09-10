using MaterialSkin;
using MaterialSkin.Controls;
using System.Net.Mail;

namespace municipalServices
{
    public partial class home : MaterialForm
    {
        public home()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            string location = materialTextBox1.Text;
            string description = materialTextBox2.Text;
            if (string.IsNullOrEmpty(location) || string.IsNullOrWhiteSpace(description))
            {
                MessageBox.Show("Please fill out all fields before submitting.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Issue reported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}