namespace Struct;

public struct equipeEsportes {
    public string nome;
    public int campeonatosVencidos;
    public int valorTotalPremiacoes;
    public int dataDeEstreiaEquipe;

    public equipeEsportes(string nome, int campeonatosVencidos, int valorTotalPremiacoes, int dataDeEstreiaEquipe) {
        this.nome = nome;
        this.campeonatosVencidos = campeonatosVencidos;
        this.valorTotalPremiacoes = valorTotalPremiacoes;
        this.dataDeEstreiaEquipe = dataDeEstreiaEquipe;
    }


    public void registrarCampeonatoVencido(){
        this.campeonatosVencidos++;
        Console.WriteLine ("\nQual o valor que a equipe recebeu pelo vencimento do campeonato? ");
        int valorPremiacao = Convert.ToInt32(Console.ReadLine());
        this.valorTotalPremiacoes += valorPremiacao;
    }

    public void atualizarValorTotalPremiacoes(){
        Console.WriteLine("\nO valor atualizado das premiações totais desta equipe é: " + valorTotalPremiacoes);
    }

    public string verificarAnoEstreia(){
        DateTime dataAgora = DateTime.Now;
        int ano = dataAgora.Year;

        if (this.dataDeEstreiaEquipe == ano ){
            return("Equipe Novata"); 
        }
        else {
            return("Equipe Veterana");
        }
    }
    
    public string imprimir() {
        return "\nNome: " + this.nome + "\nCampeonatos Vencidos: " + this.campeonatosVencidos + "\nValor total de premiações da equipe: " + this.valorTotalPremiacoes + "\nData de estreia da equipe: " + this.dataDeEstreiaEquipe;
    }
}