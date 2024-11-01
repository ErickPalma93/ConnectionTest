using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace TesteConexao
{
    public partial class PostRequestForm : Form
    {
        public PostRequestForm()
        {
            InitializeComponent();
        }

        private void postRequestMenuItem_Click(object sender, EventArgs e)
        {
            var form = new Form1();
            form.Show();
            Hide();
        }

        private async void buttonBuscar_Click(object sender, EventArgs e)
        {
            string url = TextUrl.Text;
            string jsonBody = RequestBodyBox.Text;

            Communication comm = new Communication();
            try
            {
                string response = await comm.PostResponseAsync(url, jsonBody);
                ResponseBox.Text = response;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro de Comunicação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            TextUrl.Clear();
            RequestBodyBox.Clear();
            ResponseBox.Clear();
        }
    }
}
