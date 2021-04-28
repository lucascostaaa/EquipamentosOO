using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipamentosOO.ConsoleApp
{
    class Chamados
    {

        private int idChamados;
        private string tituloChamado;
        private string descricao;
        private Ferramenta equipamento;
        private DateTime dataAbertura;
        private DateTime dataNova;


        private static int id;

        private static void GerarId()
        {
            id++;
        }
        public int Id_chamados
        {
            get
            {
                return idChamados;
            }
        }

        public string Titulo
        {
            get
            {
                return tituloChamado;
            }
        }
        public Ferramenta Ferramenta
        {
            get
            {
                return equipamento;
            }
        }
        public DateTime DataAbertura
        {
            get
            {
                return dataAbertura;
            }
        }
        public Chamados()
        { 
        }

        public Chamados(string titulo, string descricao, DateTime dataAbertura, Ferramenta teste)
        {
            this.tituloChamado = titulo;
            this.descricao = descricao;
            this.dataAbertura = dataAbertura;
            this.dataNova = dataAbertura;
            this.equipamento = teste;
            idChamados = id;
            GerarId();
        }
        public override string ToString()
        {
            return $"Titulo: {tituloChamado}\n Descrição: {descricao}\n Data Abertura: {dataAbertura}\n Numero de Dias em aberto: {DiasEmAberto()}\n ID chamado: {Id_chamados}\n";
        }
        //public String monstrarChamdos()
        //{

        //    return "===================FERRAMENTA=======================" + "\n" +

        //             " ID da Ferramenta:...................... " + idChamados + "\n" +
        //             " TITULO CHAMADO:........................ " + tituloChamado + "\n" +
        //             " DESCRICAO:............................. " + descricao + "\n" +
        //             " DATA ABERTURA:......................... " + dataAbertura + "\n" +
        //             " DIAS ABERTO:........................... " + DiasEmAberto() + " Dias em aberto" + "\n"+ 
        //            "===================================================" + "\n";

        //}

        public int DiasEmAberto()
        {
            DateTime dataAtual = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day);
            return (int)dataAtual.Subtract(dataAbertura).TotalDays;
        }
        public string Descricao { get => descricao; set => descricao = value; }
        public DateTime DataAtualizacao { get => dataNova; set => dataNova = value; }
    }

}

