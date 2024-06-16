using MetasObjetivos.bd;
using MetasObjetivos.util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetasObjetivos {
    public partial class Tarefas : Form {

        enum Prioridade {
            Facil = 10,
            Medio = 20,
            Dificil = 25
        }
        private int IDUsuario;
        private string Nick;
        private int Nivel;
        private int Pontos;
        ClassTarefas tarefas;
        SqlCommand command;


        public Tarefas(int iDUsuario,string Nome,int Nivel) {
            InitializeComponent();
            IDUsuario = iDUsuario;
            this.Nick = Nome;
            this.Nivel = Nivel;
        }

        private void Tarefas_Load(object sender, EventArgs e) {
            labelNick.Text = Nick;
            labelNivel.Text = Nivel.ToString();
           
           
        }

        private void btnAdicionaCategoria_Click(object sender, EventArgs e) {
            if (!string.IsNullOrEmpty(txtAdicionaCategoria.Text)) {
                if (categoria.Items.Contains(txtAdicionaCategoria.Text)) {
                    MessageBox.Show("Item já existe!");
                    txtAdicionaCategoria.Text = "";
                }
                else {
                    categoria.Items.Add(txtAdicionaCategoria.Text.ToLower());
                    MessageBox.Show("Item adicionado", "Categoria");
                    txtAdicionaCategoria.Text = "";
                }
            }
            else {
                MessageBox.Show("Para adiciona preencha o campo:Adiciona categoria");
            }           
        }

        private void btnRemoveCategoria_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(txtAdicionaCategoria.Text)) {
                MessageBox.Show("Escreva a categoria que queira remover!");
                          }
            else {                    
                categoria.Items.Remove(txtAdicionaCategoria.Text);
                MessageBox.Show("Categoria removida", txtAdicionaCategoria.Text);
            }
        }

        private void categoria_SelectedIndexChanged(object sender, EventArgs e) {
            txtAdicionaCategoria.Text = categoria.SelectedItem.ToString();     
        }

        private void btnInserirTarefa_Click(object sender, EventArgs e) {

            if(!string.IsNullOrEmpty(txtTitulo.Text) && !string.IsNullOrEmpty(txtDescricao.Text) && !string.IsNullOrEmpty(dataPrazo.Text) && !string.IsNullOrEmpty(categoria.Text) && !string.IsNullOrEmpty(comboDificuldade.Text)) {
                CultureInfo info = new CultureInfo("PT-Br");
                string mes = info.DateTimeFormat.GetMonthName(DateTime.Now.Month);
                tarefas = new ClassTarefas(txtTitulo.Text,txtDescricao.Text,categoria.Text,DateTime.Now.ToShortDateString(),Pontos,mes);
                try {
                    BDSQLServer.Connection();
                    string query = "INSERT INTO TAREFAS (NOME_TAREFA,DETALHES,CATEGORIA,DATA_CRIACAO,DATA_CONCLUSAO,ESTATUS,PRIORIDADE,FK_USUARIO,PONTOS,MES) " +
                        "VALUES(@NOME,@DETALHES,@CATEGORIA,@DT_CRIACAO,@DT_CONCLUSAO,@STATUS,@PRIORIDADE,@FK,@PTS,@MES)";
                    command = new SqlCommand(query, BDSQLServer.Connection());
                    command.Parameters.AddWithValue("@NOME",tarefas.NomeTarefa);
                    command.Parameters.AddWithValue("@DETALHES",tarefas.Detalhes);
                    command.Parameters.AddWithValue("@CATEGORIA",categoria.Text);
                    command.Parameters.AddWithValue("@DT_CRIACAO",tarefas.DataCriacao);
                    command.Parameters.AddWithValue("@DT_CONCLUSAO",dataPrazo.Text);
                    command.Parameters.AddWithValue("@STATUS","IMCOMPLETO");
                    command.Parameters.AddWithValue("@PRIORIDADE",comboDificuldade.Text);
                    command.Parameters.AddWithValue("@FK",IDUsuario);
                    command.Parameters.AddWithValue("@PTS",tarefas.Pontos);
                    command.Parameters.AddWithValue("@MES",tarefas.Mes);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Tarefa Adiciionada", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                } catch(Exception ex) {
                    MessageBox.Show(ex.Message);
                } finally {
                    BDSQLServer.Desconnection();
                    command.Dispose();
                }
            }
            else {
                     MessageBox.Show("Preencha os campos vazios");
            }
        }

        private void comboDificuldade_SelectedIndexChanged(object sender, EventArgs e) {
            if (comboDificuldade.SelectedItem.Equals("Fácil")) {
                Pontos = (int)Prioridade.Facil;     
            }else if (comboDificuldade.SelectedItem.Equals("Médio")) {
                Pontos = (int)Prioridade.Medio;
            }
            else {
                Pontos = (int)Prioridade.Dificil;
            }    
        }

        private void dataPrazo_Enter(object sender, EventArgs e) {
            dataPrazo.MinDate = DateTime.Now;
        }
    }
}
