using projeto;
using System;
using System.Globalization;
/*A dona de umm pensionato possui dez quartos para alugar para estudantes, sendo esses quartos identificados pelos númmeros 0 a 9. 
Fazer umm programa que inicie com todos os dez quartos vazios, 
 e depois leia uma quantidade N representando o número de estudantes que vão alugar quartos (N pode ser de 1 a 10). 
 Em seguida, registre o aluguel dos N estudantes. 
 Para cada registro de aluguel, informar o nome e email do estudante, bem como qual dos quartos ele escolheu( de 0 a 9).  
 Suponha que seja escolhido um quarto vago.  
 Ao final, seu programa deve imprimir um relatório de todas ocupações do pensionato, por ordem de quarto, conforme exemplo.*/

namespace projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true){
                Pensionato[] pensionato = new Pensionato[10];

                for(int i = 0; i < 10; i++){
                    pensionato[i] = new Pensionato{Nome=null,Email=null};
                }

                Console.Write("\nQuantos quartos serão alugados? ");
                int n = int.Parse(Console.ReadLine());
                
                for(int i = 1; i <= n; i++){
                    Console.WriteLine("\nAluguel #" + i);
                    Console.Write("Nome: ");
                    string name = Console.ReadLine();
                    Console.Write("Email: ");
                    string email = Console.ReadLine();
                    Console.Write("Quarto: ");
                    int quarto = int.Parse(Console.ReadLine());
                    if(quarto==0 || quarto==1 || quarto==2 || quarto==3 || quarto==4 || quarto==5 || quarto==6 || quarto==7 || quarto==8 || quarto==9 ){
                        if(pensionato[quarto].Nome == null){
                            pensionato[quarto] = new Pensionato{Nome=name,Email=email};
                        }
                        else{
                            Console.WriteLine("\nQuarto ocupado!");
                        }
                        
                    }
                    else{
                        Console.WriteLine("\nDígito inválido");
                    }
                }
                Console.WriteLine("\nQuartos ocupados: ");
                for(int i = 0; i < 10; i++){
                    if(pensionato[i].Email != null){
                       Console.WriteLine($"{i}: {pensionato[i]}"); 
                    }
                }
                Console.Write("\nDeseja alugar outros quartos ? (s/n)");
                string text = Console.ReadLine();
                if(text == "n"){
                    break;
                }
                
            }     
        }
    }
}  