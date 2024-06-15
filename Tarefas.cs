using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetasObjetivos {
    public partial class Tarefas : Form {
        private int IDUsuario;
        private string Nick;
        private int Nivel;
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
    }
}
