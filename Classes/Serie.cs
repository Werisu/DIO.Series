using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIO.Series
{
    public class Serie : EntidadeBase
    {
        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
            Id = id;
            Genero = genero;
            Titulo = titulo;
            Descricao = descricao;
            Ano = ano;
            isDelete = false;
        }

        public Serie(int id)
        {
        }

        public Genero Genero { get; private set; }
        public string Titulo { get; private set; }
        public string Descricao { get; private set; }
        public int Ano { get; private set; }
        public bool isDelete { get; private set; }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero:" + Genero + Environment.NewLine;
            retorno += "Título:" + Titulo + Environment.NewLine;
            retorno += "Descrição:" + Descricao + Environment.NewLine;
            retorno += "Ano:" + Ano + Environment.NewLine;
            retorno += "Excluido:" + isDelete;

            return retorno;
        }

        public string retornTitle()
        {
            return Titulo;
        }

        public int retornId()
        {
            return Id;
        }

        public void Delete()
        {
            isDelete = true;
        }

        public bool retornDelete()
        {
            return isDelete;
        }
    }
}
