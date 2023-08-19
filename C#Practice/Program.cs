// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

class Program{

    static void Main(){
        BinaryTest();
        FibonacciTest();
    }

    static string BinaryTest(){
        int decimalNumber = 30;
        string binary = DecimalToBinary(decimalNumber);
        Console.WriteLine($"Decimal: {decimalNumber} => Binary: {binary}");
        return binary;
    }

    static long FibonacciTest(){
        int n = 20;
        long fib = Fibonacci(n);
        Console.WriteLine($"n: {n} => Fib: {fib}");
        return fib;
    }
    static string DecimalToBinary(int decimalNumber){
        return Convert.ToString(decimalNumber, 2);
    }

    static long Fibonacci(int n){
        if(n <= 0) throw new ArgumentException("n must be a positive number");

        else if (n == 1 || n == 2) return 1;

        else return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
}
