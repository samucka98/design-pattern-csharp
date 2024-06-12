interface IStrategy
{
    void execute(Int32 A, Int32 B);
}

class CreateStrategyAdd : IStrategy
{
    public void execute(int A, int B)
    {
        Console.WriteLine(A + B);
    }
}

class CreateStrategySubtract : IStrategy
{
    public void execute(int A, int B)
    {
        Console.WriteLine(A - B);
    }
}

class CreateStrategyMultiply : IStrategy
{
    public void execute(int A, int B)
    {
        Console.WriteLine(A * B);
    }
}

class Context
{
    public IStrategy ?Strategy { get; set; }

    public void setStrategy(IStrategy strategy) {
        Strategy = strategy;
    }

    public void executeStrategy(int A, int B) {
        if (Strategy != null) {
            Strategy.execute(A, B);
        }
    }
}

class Program
{
    public static void Main()
    {
        Context context = new Context();

        Console.WriteLine("[1] Soma");
        Console.WriteLine("[2] Subtracao");
        Console.WriteLine("[3] Multiplicacao");
        Console.WriteLine("Selecione uma das opcoes acima pelo numero:");
        var option = short.Parse(Console.ReadLine());

        switch (option) {
            case 1: context.setStrategy(new CreateStrategyAdd()); break;
            case 2: context.setStrategy(new CreateStrategySubtract()); break;
            case 3: context.setStrategy(new CreateStrategyMultiply()); break;
        }

        context.executeStrategy(1, 2);
    }
}
