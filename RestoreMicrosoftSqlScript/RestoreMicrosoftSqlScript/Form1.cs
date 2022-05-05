using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using System.Threading;

namespace RestoreMicrosoftSQLScript
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        Thread workerThread;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheckConnection_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(txtConnectionString.Text);
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                MessageBox.Show("Connection successful");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        void CleanDatabase()
        {
            /// Clean the database
            lblLoading.Text = "Deleting objects...";
            var path = Path.Combine(Directory.GetCurrentDirectory(), "DropScript.Sql");
            string script = File.ReadAllText(path);
            
            ExecuteScript(script);

            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                var lines = File.ReadLines(file.FileName).ToList();

                // remove USE DatabaseName text to avoid mistakes
                if (lines.First().Contains("USE ["))
                {
                    lines.RemoveAt(0);
                }

                //Generate script again without USE Database text
                StringBuilder builder = new StringBuilder();
                foreach (var line in lines)
                {
                    builder.Append(Environment.NewLine);
                    builder.Append(line);
                }

                lblLoading.Text = "Please wait! Script is installing...";
                workerThread = new Thread(() => InstallScript(builder.ToString()));
                workerThread.Start();
            }
        }

        void InstallScript(string script)
        {
            ExecuteScript(script);
            lblLoading.Text = "Installation of script completed!";
            MessageBox.Show("Installation completed.");
        }

        void ExecuteScript(string script)
        {
            using (conn = new SqlConnection(txtConnectionString.Text))
            {
                ServerConnection svrConnection = new ServerConnection(conn);
                Server server = new Server(svrConnection);
                server.ConnectionContext.ExecuteNonQuery(script);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // To enable workerThread to interact with UI
            CheckForIllegalCrossThreadCalls = false;
        }

        private void btnInstallScript_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure to drop all databases objects?", "Confirmation!", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                CleanDatabase();
            }
        }
    }
}