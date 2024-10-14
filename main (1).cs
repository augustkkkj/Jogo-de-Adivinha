using System;
class HelloWorld {
  static void Main(string[] args) {
    Random random = new Random();
    
    int numeroSecreto = random.Next(1, 50);
    
    int tentativa;
    
    int tentativas = 0;
    
    bool acertou = false;
    
    while(!acertou){
        tentativas++;
        
        Console.WriteLine("adivinha o numero entre 1 a 50: ");
        tentativa = Convert.ToInt32(Console.ReadLine());
        
        
        if(tentativa < numeroSecreto){
            Console.WriteLine("muito baixo!");
        } 
        else if(tentativa > numeroSecreto){
            Console.WriteLine("mui alto!");
        } 
        else{
            Console.WriteLine("que merda... vc acertou em" + tentativas + "tentativas:/");
            acertou = true;
        }
    
    }
    Console.ReadKey();
  }
}