using MetasObjetivos.bd;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetasObjetivos {
    public partial class Form1 : Form {
        SqlCommand command;
        int NIVEL;
        public Form1() {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e) {
            Close();
            Thread thread = new Thread(() => Application.Run(new Tarefas()));
            thread.Start();
        }

        private void btnCadastrar_Click(object sender, EventArgs e) {
            NIVEL = 0;
            string query = "INSERT INTO USUARIO (NOME,NICK,EMAIL,SENHA,NIVEL)" +
                "VALUES (@NOME,@NICK,@EMAIL,@SENHA,@NIVEL)";
            try {
                BDSQLServer.Connection();
                if (!string.IsNullOrEmpty(txtNome.Text) && !string.IsNullOrEmpty(txtNick.Text)
                   && !string.IsNullOrEmpty(txtEmail.Text) && !string.IsNullOrEmpty(txtSenha.Text)) {
                    command = new SqlCommand(query, BDSQLServer.Connection());
                    command.Parameters.AddWithValue("@NOME",txtNome.Text.ToLower());
                    command.Parameters.AddWithValue("@NICK",txtNick.Text.ToLower());
                    command.Parameters.AddWithValue("@EMAIL",txtEmail.Text.ToLower());
                    command.Parameters.AddWithValue("@SENHA",txtSenha.Text);
                    command.Parameters.AddWithValue("@NIVEL",NIVEL);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Usuario cadastrado!","Sucesso",MessageBoxButtons.OK);    

                }
                else {
                    MessageBox.Show("Preencha os campos Vazios","Campos Cadastro",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    command.Cancel();
                }
            } catch(Exception ex) {
                MessageBox.Show(ex.Message, "Inserindo Usuario");
                
            } finally {
                command.Dispose();
                BDSQLServer.Desconnection();
                txtNome.Text = "";
                txtEmail.Text = "";
                txtNick.Text = "";
                txtSenha.Text = "";


            }  

        }
    }
}
