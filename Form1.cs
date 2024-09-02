using System;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace RemoteCommandSender
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSendCommand_Click(object sender, EventArgs e)
        {
            {
                string ipAddress = txtIPAddress.Text;
                string command = txtcommand.Text;

                if (string.IsNullOrWhiteSpace(ipAddress) || string.IsNullOrWhiteSpace(command))
                {
                    MessageBox.Show("Please enter both IP Address and Command.");
                    return;
                }

                try
                {
                    using (TcpClient client = new TcpClient(ipAddress, 8080)) // Ensure port 8080 is open on the target machine
                    {
                        NetworkStream stream = client.GetStream();

                        byte[] data = Encoding.ASCII.GetBytes(command);
                        stream.Write(data, 0, data.Length);

                        // Receiving the output from the remote machine
                        byte[] buffer = new byte[1024];
                        int bytesRead = stream.Read(buffer, 0, buffer.Length);
                        string response = Encoding.ASCII.GetString(buffer, 0, bytesRead);

                        txtoutput.Text = response;

                        stream.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        } 

       

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
