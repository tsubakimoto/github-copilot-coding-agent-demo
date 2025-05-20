using System;

// トップレベルステートメントを使用した実装
Console.WriteLine("電卓アプリへようこそ！");
Console.WriteLine("２つの数値を入力すると四則演算を行います。");

// 1つ目の数値を入力
Console.Write("1つ目の数値を入力してください: ");
string input1 = Console.ReadLine() ?? "";

// 1つ目の入力値が数値かチェック
if (!double.TryParse(input1, out double num1))
{
    Console.WriteLine("🙅");
    return;
}

// 2つ目の数値を入力
Console.Write("2つ目の数値を入力してください: ");
string input2 = Console.ReadLine() ?? "";

// 2つ目の入力値が数値かチェック
if (!double.TryParse(input2, out double num2))
{
    Console.WriteLine("🙅");
    return;
}

// 四則演算の結果を表示
Console.WriteLine($"足し算の結果: {num1} + {num2} = {num1 + num2}");
Console.WriteLine($"引き算の結果: {num1} - {num2} = {num1 - num2}");
Console.WriteLine($"掛け算の結果: {num1} × {num2} = {num1 * num2}");

// 割り算（ゼロ除算の回避）
if (num2 != 0)
{
    Console.WriteLine($"割り算の結果: {num1} ÷ {num2} = {num1 / num2}");
}
else
{
    Console.WriteLine("割り算の結果: ゼロによる除算はできません。");
}