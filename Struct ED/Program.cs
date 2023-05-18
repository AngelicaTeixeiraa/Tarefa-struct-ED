using Struct;

namespace TAD {

    class Program {
        static  void Main(string[] args)
        {
            Clientes cliente1 = new ();
            cliente1.nome = "Angélica";
            cliente1.cpf = "111111111";
            cliente1.dataNascimento = "03/03/2005";
            cliente1.email = "angelica.teixeira@fatec.com";
            
            Console.WriteLine("\nCLIENTES:");
            Console.WriteLine(cliente1.imprimir());
            

            Console.WriteLine("\n JOGADORES DE FUTEBOL:");
            jogadorFutebol JogadorFutebol1 = new ();

            JogadorFutebol1.nome = "Neymar";
            JogadorFutebol1.cpf = "12345678";
            JogadorFutebol1.dataNascimento = "05/02/1992";
            JogadorFutebol1.VinculoClube = "Brasil";
            JogadorFutebol1.registrarNumeroCartoesAmarelos();
            JogadorFutebol1.registrarNumeroCartoesVermelhos ();
            Console.WriteLine(JogadorFutebol1.imprimir());
            Console.WriteLine(JogadorFutebol1.verificarVinculoClube());
           
           
            Console.WriteLine("\n--> EQUIPES DE FUTEBOL");
            equipeEsportes equipeEsports1 = new ();
            equipeEsports1.nome = "chuteiras FC oficial";
            equipeEsports1.campeonatosVencidos = 80;
            equipeEsports1.valorTotalPremiacoes = 500;
            equipeEsports1.dataDeEstreiaEquipe = 1999;
            Console.WriteLine(equipeEsports1.imprimir());
            equipeEsports1.registrarCampeonatoVencido();
            equipeEsports1.atualizarValorTotalPremiacoes();
            Console.WriteLine(equipeEsports1.verificarAnoEstreia());
            

            Console.WriteLine("\n PRODUTOS:");
            Produto produto1 = new ();

            produto1.nome = "Coca cola 3L";
            produto1.valor = R$12,00;
            produto1.quantidadeEstoque = 500;
            System.Console.WriteLine(produto1.imprimir());
            System.Console.WriteLine("Deseja aplicar um cupom de desconto ao valor deste produto?");
            string decisaoAplicarCupom = Console.ReadLine();
            if (decisaoAplicarCupom == "sim"){
                System.Console.WriteLine("Deseja aplicar um desconto em Valor pré-definido ou em porcentagem?");
                string decisaoCupom = Console.ReadLine();
                if (decisaoCupom == "valor"){
                    Console.WriteLine(produto1.aplicarCupomDescontoValor());
                }
                else if (decisaoCupom == "porcentagem"){
                    Console.WriteLine(produto1.aplicarCupomDescontoPorcentagem());
                }
                else {
                    System.Console.WriteLine("Cupom não identificado!");
                }
            }


            Console.WriteLine("\n PROFESSOR:");
            Professor professor1 = new ();

            professor1.nome = "Angélica da Silva";
            professor1.cpf = "142.123.111-22";
            professor1.dataNascimento = "03/03/2005";
            professor1.email = "angelica.teixeira@fatec.com";
            professor1.salario = 2000;
            professor1.CargaHoraria = 60;
            System.Console.WriteLine(professor1.imprimir());
            System.Console.WriteLine("Aplicar um reajuste ao salário desse professor?");
            string decisaoAplicarReajuste = Console.ReadLine();
            if (decisaoAplicarReajuste == "sim"){
                System.Console.WriteLine("Deseja aplicar um desconto em Valor pré-definido ou em porcentagem?");
                string decisaoReajuste = Console.ReadLine();
                if (decisaoReajuste == "valor"){
                    Console.WriteLine(professor1.reajusteSalarialEmValor());
                }
                else if (decisaoReajuste == "porcentagem"){
                    Console.WriteLine(professor1.reajusteSalarialEmPorcentagem());
                }
                else {
                    System.Console.WriteLine("Operação não identificada!");
                }
            System.Console.WriteLine("O professor possui alguma falta?");
            string decisaoFalta = Console.ReadLine();
            if (decisaoFalta == "sim"){
                System.Console.WriteLine("Digite a quantidade de faltas: ");
                professor1.faltas = Convert.ToInt32(Console.ReadLine());
                if (professor1.faltas > 0){
                System.Console.WriteLine("Deseja aplicar um desconto em Valor pré-definido ou em porcentagem?");
                decisaoReajuste = Console.ReadLine();
                if (decisaoReajuste == "valor"){
                    Console.WriteLine(professor1.descontoSalarialPorFaltaEmValor());
                }
                else if (decisaoReajuste == "porcentagem"){
                    Console.WriteLine(professor1.descontoSalarialPorFaltaEmPorcentagem());
                }
                else {
                    System.Console.WriteLine("Operação não identificada!");
                }
                }
                else {
                    System.Console.WriteLine("Nenhuma falta registrada!");
                }
            }
            System.Console.WriteLine("Deseja aumentar a carga horária do professor?");
            string decisaoAumentarCargaHoraria = Console.ReadLine();
            if (decisaoAumentarCargaHoraria == "sim"){
                Console.WriteLine(professor1.aumentarCargaHorariaDeTrabalho());
            }
        }

        


    }
}
}