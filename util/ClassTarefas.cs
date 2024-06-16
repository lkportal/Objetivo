using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetasObjetivos.util {
    internal class ClassTarefas {


     
        
        public string NomeTarefa { get; set; }
        public string Detalhes { get; set; }
        public string Categoria { get; set; }  

        public string DataCriacao { get; set; }

        public DateTime TempoPassado { get; set; } 

        public int Pontos { get;  private set; }    
        public string Mes {  get; set; }

        public ClassTarefas(string nomeTarefa, string detalhes, string categoria,string dataCriacao, int pontos, string mes) {
            NomeTarefa = nomeTarefa;
            Detalhes = detalhes;
            Categoria = categoria;
            DataCriacao = dataCriacao;
            Pontos = pontos;
            Mes = mes;
        }
        
    }
}
