using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetasObjetivos.util {
    internal class Tarefas {


        enum Estatus {
            Completo,
            Imcompleto
        }
        enum Prioridade {
            Facil = 10,
            Medio= 20,
            Dificil = 25
        }
        public string NomeTarefa { get; set; }
        public string Detalhes { get; set; }
        public string Categoria { get; set; }  

        public DateTime DataCriacao { get; set; }

        public DateTime DataConclusao { get; set; } 

        private int Pontos { get; set; }    
        public string Mes {  get; set; }

        public Tarefas(string nomeTarefa, string detalhes, string categoria, DateTime dataCriacao, int pontos, string mes) {
            NomeTarefa = nomeTarefa;
            Detalhes = detalhes;
            Categoria = categoria;
            DataCriacao = dataCriacao;
            Pontos = pontos;
            Mes = mes;
        }
        
    }
}
