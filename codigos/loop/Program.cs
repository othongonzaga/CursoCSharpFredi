class Program{
    static void Main(){
        string[] nomes = {"Fredi", "Mariana", "Iaabella"};

        for (int i = 0; i < 3; i++){
            Console.WriteLine(nomes[i]);
        }

        // Ou

        foreach (string nome in nomes){
            Console.WriteLine(nome);
        }
    }
}