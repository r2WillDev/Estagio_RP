static bool Fibonacci(int num){
    int a = 0, b = 1;
    
    while(b < num){
        int tempo = a;
        a = b;
        b = tempo + b;
    }
    
    return b == num;
}

Console.WriteLine("Informe um numero para verificação");
int num = int.Parse(Console.ReadLine());

if (Fibonacci(num)){
    Console.WriteLine($"o numero {num} pertence a sequencia de fibonacci");
} else {
    Console.WriteLine($"O numero {num} não pertence a sequencia de fibonacci");
}

