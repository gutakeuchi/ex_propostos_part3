// See https://aka.ms/new-console-template for more information


//Ex 01
Console.WriteLine("Digite a senha: ");
int senha = int.Parse(Console.ReadLine());

while(senha !=  2002){
    Console.WriteLine("Senha inválida");
    senha = int.Parse(Console.ReadLine());

}
Console.WriteLine("Acesso permitido");

//Ex02
int x, y;
string[] vet = Console.ReadLine().Split(' ');
x = int.Parse(vet[0]);
y = int.Parse(vet[1]);

while(x != 0 && y != 0){
    if(x > 0 && y > 0){
        Console.WriteLine("primeiro");
    }
    else if(x < 0 && y > 0){
        Console.WriteLine("segundo");
    }
    else if(x < 0 && y <  0){
        Console.WriteLine("terceiro");
    }
    else{
        Console.WriteLine("quarto");
    }

    vet = Console.ReadLine().Split(' ');
    x = int.Parse(vet[0]);
    y = int.Parse(vet[1]);

//Ex03

 int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            int tipo = int.Parse(Console.ReadLine());

            while (tipo != 4) {
                if (tipo == 1) {
                    alcool = alcool + 1;
                }
                else if (tipo == 2) {
                    gasolina = gasolina + 1;
                }
                else if (tipo == 3) {
                    diesel = diesel + 1;
                }

                tipo = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);}
