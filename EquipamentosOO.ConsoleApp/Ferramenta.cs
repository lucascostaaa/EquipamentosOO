using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipamentosOO.ConsoleApp
{
    class Ferramenta
    {

        private string nome = "";
        private double preco = 0;
        private int numeroSerie = 0;
        private string nomeFabricante = "";
        private int idEquipamento;
        private DateTime dataFabricacao;

        //private Ferramenta[] arrayFerramentas = new Ferramenta[100];
        private static int id;

        private static void GerarId()
        {
            id++;
        }

        public int Id_equipamento
        {
            get
            {
                return idEquipamento;
            }

        }
        public DateTime DataFabricacao
        {
            get
            {
                return dataFabricacao;
            }
        }
        // TENTEI ARRUMAR OS (FOR DE CADASTRO,EDITAR E EXCLUIR MAIS ACABOU DANDO ERRO)
        //public void cadastrar(int contador, Ferramenta ferramenta)
        //{
        //    arrayFerramentas[contador] = ferramenta;
        //}
        //public void editar(int contador,Ferramenta ferramenta)
        //{ 
        //    for (int i = 0; i < contador; i++);
        //}
        //public void vizualisar(int contador, Ferramenta ferramenta)
        //{
        //    arrayFerramentas[contador].monstrarFerramentas();
        //}

      
        public Ferramenta()
        {

        }
        // CADASTRO 
        public Ferramenta(string nome, double preco, int numeroSerie, string nomeFabricante, DateTime dataFabricacao)
        {
            this.Preco = preco;
            this.Nome = nome;
            this.NumeroSerie = numeroSerie;
            this.NomeFabricante = nomeFabricante;
            this.dataFabricacao = dataFabricacao;
            idEquipamento = id;
            GerarId();
        }
        //EDITAR
        public void editarFerramentas()
        {
            Preco = double.Parse(Console.ReadLine());
            Nome = Console.ReadLine();
            NomeFabricante = Console.ReadLine();
            NumeroSerie = int.Parse(Console.ReadLine());
        }
        public override string ToString()
        {
            return $"Nome: {nome}\n Serie: {numeroSerie}\n Fabricante: {nomeFabricante}\n Preço: {preco}\n Data Fabricação: {dataFabricacao}\n Id Equipamento: {Id_equipamento}\n";
        }
        //VIZUALIZA
        //public String monstrarFerramentas()
        //{
        //    return "===================FERRAMENTA=======================" + "\n" +

        //             " ID da Ferramenta:...................... " + idEquipamento + "\n"+  
        //             " NUMERO DE SERIE:....................... " + numeroSerie + "\n" +
        //             " NOME DA FERRAMENTA:.................... " + nome + "\n" +
        //             " PREÇO DA FERRAMENTA:................... " + preco + "\n" +
        //             " NOME DO FABRICANTE:.................... " + nomeFabricante + "\n" +
        //             " DATA DE FABRICAÇÃO:.................... " + dataFabricacao + "\n" +

        //            "===================================================" + "\n";

        //}

        public double Preco { get => preco; set => preco = value; }
        public string Nome { get => nome; set => nome = value; }
        public int NumeroSerie { get => numeroSerie; set => numeroSerie = value; }
        public string NomeFabricante { get => nomeFabricante; set => nomeFabricante = value; }

    }
}



