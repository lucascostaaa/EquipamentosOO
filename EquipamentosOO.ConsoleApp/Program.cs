using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipamentosOO.ConsoleApp
{
    //FEITO
    #region
    //        Requisito 1.1: Como funcionário, Junior quer ter a possibilidade de registrar equipamentos  


    //         •  Deve ter um nome com no mínimo 6 caracteres;  
    //         •  Deve ter um preço de aquisição;  
    //         •  Deve ter um número de série;  
    //         •  Deve ter uma data de fabricação;  
    //         •  Deve ter uma fabricante;
    #endregion/

    //FEITO
    #region
    //    Requisito 1.2: Como funcionário, Junior quer ter a possibilidade de visualizar todos os equipamentos registrados em seu inventário.

    //         •  Deve mostrar o número;  
    //         •  Deve mostrar o nome;  
    //         •  Deve mostrar o preço; 
    //         •  Deve mostrar a fabricante;   
    //         •  Deve mostrar a data de fabricação;
    #endregion

    //FEITO
    #region
    //    Requisito 1.3:  Como funcionário, Junior quer ter a possibilidade de editar um equipamento, sendo que ele possa
    //    editar todos os campos.


    //         •  Deve ter os mesmos critérios que o Requisito 1.
    #endregion

    //FEITO
    #region
    // Requisito 1.4: Como funcionário, Junior quer ter a possibilidade de excluir um equipamento que esteja registrado.

    //         •  A lista de equipamentos deve ser atualizada
    #endregion

    // NAO FEITO
    #region
    //2. Controle de Chamados
    #endregion

    //FEITO
    #region
    //Requisito 2.1:  Como funcionário Junior quer ter a possibilidade de registrar os chamados de manutenções que são
    //efetuadas nos equipamentos registrados  


    //         •  Deve ter a título do chamado;  
    //         •  Deve ter a descrição do chamado;  
    //         •  Deve ter um equipamento;  
    //         •  Deve ter uma data de abertura;
    #endregion

    //FEITO
    #region
    //    Requisito 2.2: Como funcionário Junior quer ter a possibilidade de visualizar todos os chamados registrados para controle.


    //         •  Deve mostrar o título do chamado;  
    //         •  Deve mostrar o equipamento;  
    //         •  Deve mostrar a data de abertura;  
    //         •  Número de dias que o chamado está aberto
    #endregion

    //FEITO
    #region

    //Requisito 2.3: Como funcionário Junior quer ter a possibilidade de editar um chamado que esteja registrado, sendo que ele possa editar todos os campos.
    #endregion

    //FEITO
    #region
    //Requisito 2.4: Como funcionário Junior quer ter a possibilidade de excluir um chamado.
    #endregion

    //FEITO
    #region
    //NUMEROS DE DIAS DO CHAMDO ABERTO
    //OS IDS SAO GERADOS SOZINHOS
    #endregion


    class Program
    {
        // ERA PRA FAZER A CONSULTA DO ID DA FERRAMENTA PARA FAZER O CHAMADO MAIS NAO DEU CERTO


        //public Chamados PegarDadosChamados(Ferramenta ferramenta)
        //{
        //    return ComparandoChamado(ferramenta);
        //}

        //private static Chamados ComparandoChamado(Ferramenta ferramenta)
        //{
        //    while (true)
        //    {
        //        string tituloChamado;
        //        string descricao;
        //        DateTime dataAbertura;
        //        try
        //        {
        //            Console.WriteLine("Informe o Titulo do Chamado: ");
        //            tituloChamado = Console.ReadLine();
        //            Console.WriteLine("Informe a descrição do Chamado: ");
        //            descricao = Console.ReadLine();
        //            Console.WriteLine("Informe a data de Abertura do Chamado: ");
        //            dataAbertura = Convert.ToDateTime(Console.ReadLine());
        //            Chamados chamado = new Chamados(tituloChamado, descricao, dataAbertura, ferramenta);
        //            return chamado;
        //        }
        //        catch (Exception)
        //        {
        //            Console.WriteLine("Erro Valor Invalido.\nTente Novamente!");
        //            Console.ReadLine();
        //            Console.Clear();
        //            return null;
        //        }
        //    }
        //}
        //public void PegarNomeIdEquipamento(out string nome, out int id)
        //{
        //    Console.WriteLine("Informe o Nome do Equipamento: ");
        //    nome = Console.ReadLine();
        //    Console.WriteLine("Informe o Id do Equipamento: ");
        //    id = Console.ReadLine();
        //}


        static void Main(string[] args)
        {
            double preco = 0;
            string nome = "", tituloChamado = "", descricao ="";
            string nomeFabricante = "";
            int numeroSerie = 0;
            int contador = 0;
            DateTime dataFabricacao, dataAbertura;
            string opcao = "";
       

            Ferramenta equipamento = new Ferramenta();
            Ferramenta[] arrayFerramentas = new Ferramenta[100];

            Chamados chamados = new Chamados();
            Chamados[] arrayChamados = new Chamados[100];



            while (opcao != "s")
            {
                opcao = MenuPrincipal();

                if (opcao == "1")
                {
                    string cadastrar = MenuFeramenta();

                    switch (cadastrar)
                    {
                        case "1":
                            {
                                //CADASTRO

                                Console.WriteLine("Digite o preco da ferramenta");
                                preco = double.Parse(Console.ReadLine());

                                Console.WriteLine("Digite o nome da ferramenta");
                                nome = (Console.ReadLine());

                                Console.WriteLine("Digite o nome do fabricante");
                                nomeFabricante = (Console.ReadLine());

                                Console.WriteLine("Digite o numero de serie da ferramenta");
                                numeroSerie = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("Digite data de fabricação");
                                dataFabricacao = Convert.ToDateTime(Console.ReadLine());

                                //equipamento.cadastrar(contador, new Ferramenta(nome, preco, numeroSerie, nomeFabricante, dataFabricacao));

                                arrayFerramentas[contador] = new Ferramenta(nome, preco, numeroSerie, nomeFabricante, dataFabricacao);
                                contador++;

                                Console.ReadLine();
                                break;
                            }
                        case "2":
                            {
                                int idEditar = 0;
                                Console.WriteLine("Digite o id da ferramenta que deseja editar");
                                idEditar = Convert.ToInt32(Console.ReadLine());

                                for (int i = 0; i < contador; i++)
                                {
                                    if (arrayFerramentas[i].Id_equipamento == idEditar)
                                    {
                                        Console.WriteLine("Digite o preco da ferramenta");
                                        preco = double.Parse(Console.ReadLine());

                                        Console.WriteLine("Digite o nome da ferramenta");
                                        nome = (Console.ReadLine());

                                        Console.WriteLine("Digite o nome do fabricante");
                                        nomeFabricante = (Console.ReadLine());

                                        Console.WriteLine("Digite o numero de serie da ferramenta");
                                        numeroSerie = int.Parse(Console.ReadLine());

                                        Console.WriteLine("Digite data de fabricação");
                                        dataFabricacao = Convert.ToDateTime(Console.ReadLine());

                                        Console.ReadLine();

                                        arrayFerramentas[i] = new Ferramenta(nome, preco, numeroSerie, nomeFabricante, dataFabricacao);
                                    }
                                }

                                break;
                            }
                        case "3":
                            {
                                for (int i = 0; i < contador; i++)
                                {
                                    if (arrayFerramentas[i] != null)
                                    {
                                        Console.WriteLine(arrayFerramentas[i].ToString());
                                        //Console.WriteLine(arrayFerramentas[i].mostrarFerramenta());
                                    }
                                }
                                break;
                            }
                        case "4":
                            {
                                int idExcluir = 0;
                                Console.WriteLine("Digite o ID da ferramenta que ira ser deletada");
                                idExcluir = int.Parse(Console.ReadLine());

                                for (int i = 0; i < contador; i++)
                                {
                                    if (arrayFerramentas[i].Id_equipamento == idExcluir)
                                    {
                                        arrayFerramentas[i] = null;
                                    }
                                }
                                Console.WriteLine("Ferramenta Removida");
                                Console.ReadLine();
                                break;
                            }
                    }


                }
                else if (opcao == "2")
                {
                    string cadastrar = MenuChamados();

                    switch (cadastrar)
                    {
                        case "1":
                            {

                                Console.WriteLine("Digite o Titulo do chamado");
                                tituloChamado = (Console.ReadLine());
                                Console.WriteLine("Informe a Descrição do chamado");
                                descricao = (Console.ReadLine());
                                Console.WriteLine("Data de abertura");
                                dataAbertura = DateTime.Parse(Console.ReadLine());

                                Console.ReadLine();

                                arrayChamados[contador] = new Chamados(tituloChamado, descricao, dataAbertura, equipamento);

                                contador++;
                                break;
                            }
                        case "2":
                            {
                                int idEditar = 0;
                                Console.WriteLine("Informe o ID para editar");
                                idEditar = Convert.ToInt32(Console.ReadLine());

                                for (int i = 0; i < contador; i++)
                                {
                                    if (arrayChamados[i].Id_chamados == idEditar)
                                    {
                                        Console.WriteLine("Digite o titulo do chamado");
                                        tituloChamado = Console.ReadLine();

                                        Console.WriteLine("Digite a descrição do chamao");
                                        descricao = Console.ReadLine();

                                        Console.WriteLine("Digite a data do chamado");
                                        dataAbertura = DateTime.Parse(Console.ReadLine());

                                        Console.WriteLine();
                                        arrayChamados[i] = new Chamados(tituloChamado, descricao, dataAbertura, equipamento);
                                    }
                                }
                                break;
                            }
                        case "3":
                            {
                                for (int i = 0; i < contador; i++)
                                {
                                    if (arrayChamados[i] != null)
                                    {
                                        Console.WriteLine(arrayChamados[i].ToString());
                                    }
                                }
                                break;
                            }

                        case "4":
                            {
                                int idExcluir = 0;
                                Console.WriteLine("Digite o ID da Chamada que ser deletada");
                                idExcluir = int.Parse(Console.ReadLine());

                                for (int i = 0; i < contador; i++)
                                {
                                    if (arrayChamados[i].Id_chamados == idExcluir)
                                    {
                                        arrayChamados[i] = null;
                                    }
                                }
                                Console.WriteLine("Chamado Removida");
                                Console.ReadLine();
                                break;
                            }
                    }

                }



            }



        }

        private static string MenuChamados()
        {
            string cadastrar;
            Console.WriteLine("=============VER CHAMADOS=============");
            Console.WriteLine("Digite [1] para Inserir Chamados");
            Console.WriteLine("Digite [2] para Editar Chamados");
            Console.WriteLine("Digite [3] Para Mostrar Chamados");
            Console.WriteLine("Digite [4] Para Excluir Chamados");
            Console.WriteLine("======================================");
            cadastrar = Console.ReadLine();
            return cadastrar;
        }

        private static string MenuFeramenta()
        {
            string cadastrar;
            Console.WriteLine("==============FERRAMENTAS==============");
            Console.WriteLine("Digite [1] para inserir Ferramenta");
            Console.WriteLine("Digite [2] para Editar Ferramenta");
            Console.WriteLine("Digite [3] para Visualizar Ferramentas");
            Console.WriteLine("Digite [4] para Excluir uma Ferramenta");
            Console.WriteLine("=======================================");
            cadastrar = Console.ReadLine();
            return cadastrar;
        }

        private static string MenuPrincipal()
        {
            string opcao;
            Console.WriteLine("==============FERRAMENTAS==============");
            Console.WriteLine("Digite [1] para ver as opções de ferramentas");
            Console.WriteLine("Digite [2] para ver as opções de chamados");
            Console.WriteLine("Digite [3] para sair");
            Console.WriteLine("========================================");
            opcao = Console.ReadLine();
            return opcao;
        }
    }
}

