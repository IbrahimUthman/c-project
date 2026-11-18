// Console.Write("Enter value for N: ");
// int N = int.Parse(Console.ReadLine()!);

// int i = 1;
// while(i <= N)
// {
//     Console.WriteLine(i);
//     i++;
// }

// question 2

// Console.WriteLine("Enter value for N: ");
// int N = int.Parse(Console.ReadLine()!);

// int i = 1;
// while (i <= N)
// {
//     if (i % 3 == 0 && i % 7 == 0 )
//     {
//          
//     }
//     else
//     {
//         Console.WriteLine(i);
//     }
//         i++;
// }
// question 3
//  Console.Write("how many numbers: ");
// int count = int.Parse(Console.ReadLine()!);

//  Console.Write("Enter numnber 1: ");
//  int number = int.Parse(Console.ReadLine()!);

//  int smallest = number;
//  int largest = number;

// int i = 2;
// while (i <= count)
// {
//      System.Console.WriteLine($"Enter number {i}: ");
//      number = int.Parse(Console.ReadLine()!);
//      i++;
//      if(number < smallest) smallest = number;
//     if (number > largest) largest = number;
//  }
//     System.Console.WriteLine($"Smallest: {smallest}");
//    System.Console.WriteLine($"Largest: {largest}"); 
// // question 6
// Console.Write("Enter N: ");
// int N = int.Parse(Console.ReadLine()!);

// Console.Write("Enter K: ");
//  int K = int.Parse(Console.ReadLine()!);

// long result = 1;
// int i = K + 1;
// while (i <= N)
// {
// //     result *= i;
// //     i++;
// // }
// // System.Console.WriteLine($"N!/K! = {result");
// question 7
// Console.Write("Enter N: ");
// int N = int.Parse(Console.ReadLine()!);

// Console.Write("Enter K: ");
// int K = int.Parse(Console.ReadLine()!);

// long part1 = 1;
// int j = 0;
// while (j < K)
// {
// part1 *= (N - j);
//     j++;
// }
// // now K!
// long factK = 1;
// int i = 1;
// while (i <= K)
// {
//     factK *= i;
//     i++;
// }

// long result = part1 * factK;
// System.Console.WriteLine($"N!K!/(N-K)! = {result}");
