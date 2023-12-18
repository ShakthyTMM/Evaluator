﻿// ----------------------------------------------------------------------------------------
// Training 
// Copyright (c) Metamation India.
// ----------------------------------------------------------------------------------------
// Program.cs
// Expression evaluator
// Implementation of unary operator in the expression evaluator
// ----------------------------------------------------------------------------------------
namespace Eval;

class Program {
   static void Main (string[] args) {
      var eval = new Evaluator ();
      for (; ; ) {
         Console.Write ("> ");
         string text = Console.ReadLine () ?? "";
         if (text == "exit") break;
         try {
            double result = eval.Evaluate (text);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine (result);
         } catch (Exception e) {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine (e.Message);
         }
         Console.ResetColor ();
      }
   }
}
