using Calculator;

Console.WriteLine("==== 電卓アプリケーション ====");

while (true)
{
    Console.WriteLine("\n1つ目の数値を入力してください:");
    string input1 = Console.ReadLine() ?? "";
    
    Console.WriteLine("2つ目の数値を入力してください:");
    string input2 = Console.ReadLine() ?? "";

    // Try to parse inputs to integers
    if (!int.TryParse(input1, out int num1) || !int.TryParse(input2, out int num2))
    {
        Console.WriteLine("🙅 数字以外の文字が入力されました");
        continue;
    }

    // Perform calculations
    var calc = new Calculator.Calculator();
    
    Console.WriteLine("\n=== 計算結果 ===");
    Console.WriteLine($"{num1} + {num2} = {calc.Add(num1, num2)}");
    Console.WriteLine($"{num1} - {num2} = {calc.Subtract(num1, num2)}");
    Console.WriteLine($"{num1} × {num2} = {calc.Multiply(num1, num2)}");
    
    try
    {
        Console.WriteLine($"{num1} ÷ {num2} = {calc.Divide(num1, num2)}");
    }
    catch (DivideByZeroException)
    {
        Console.WriteLine($"{num1} ÷ {num2} = 0で割ることはできません");
    }

    Console.WriteLine("\n続けるには Enter キーを押してください。終了するには「exit」と入力してください:");
    string continueInput = Console.ReadLine() ?? "";
    
    if (continueInput.ToLower() == "exit")
        break;
}
