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

      
    }
}
