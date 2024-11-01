namespace TesteConexao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void postRequestMenuItem_Click(object sender, EventArgs e)
        {
            var postRequestForm = new PostRequestForm();
            postRequestForm.Show();
            Hide();
        }

        private async void buttonBuscar_Click(object sender, EventArgs e)
        {
            string user = TextUser.Text;
            string password = TextPass.Text;
            string url = TextUrl.Text;

            Communication comm = new Communication();
            try
            {
                if (radioButtonGet.Checked)
                {
                    string response = await comm.GetResponseAsync(user, password, url);
                    ResponseBox.Text = response;
                }
                else
                {
                    string response = await comm.PostResponseWithCredentialsAsync(user, password, url);
                    ResponseBox.Text = response;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro de Comunicação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            TextUser.Clear();
            TextPass.Clear();
            TextUrl.Clear();
            ResponseBox.Clear();
        }
    }
}
