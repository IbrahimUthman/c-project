// using System;
// using System.Collections.Generic;
// using System.Threading;

// class offlineTradebot
// {
//     static void Main()
//     {
//         // ---1. SETUP ---
//         double btcPrice = 60000;
//         double usdbalance = 10000; // fakemoney
//         double btcBalance = 0;
//         List<double> priceHistory = new List<double>();
//         Random rand = new Random();

//         Console.WriteLine("=== OFFLINE AUTO CRYPTO BOT STARTED ===");
//         System.Console.WriteLine($"Starting balance: ${usdbalance}");
//         System.Console.WriteLine("Bot is checking market...");

//         // bot loop
//         while (true)
//         {
//             // a. generate a new price (random walk)
//             double change = rand.Next(-150, 151);
//             btcPrice += change;
//             priceHistory.Add(btcPrice);
//             // Keep only last 20 price strategy
//             if (priceHistory.Count > 20)
//             priceHistory.RemoveAt(0);
//             // b. bot strategy
//             if (priceHistory.Count >= 10)
//             {
//                 double sum = 0;
//                 foreach (double p in priceHistory) sum += p;
//                 double avg = sum / priceHistory.Count;

//                 if (btcPrice < avg - 50 && usdbalance > 100)
//                 {
//                     double amountToBuy = 100 / btcPrice;
//                     btcBalance +=  amountToBuy;
//                     usdbalance -= 100;
//                     System.Console.WriteLine($"[BOT BUY] Price ${btcPrice:F2} | Sold {amountToBuy:F5} BTC | USD Now: ${usdbalance:F2}");
//                 }
//                 else if(btcPrice > avg + 50 && btcBalance > 0.001)
//                 {
//                     double amountToSell = btcBalance * 0.5;
//                     double usdGot = amountToSell * btcPrice;
//                     usdbalance += usdGot;
//                     btcBalance -= amountToSell;
//                     System.Console.WriteLine($"[BOT SELL] Price ${btcPrice:F2} | Solid {amountToSell} BTC | USD Now: ${usdbalance:F2}");
//                 }
//             }
//             // c. show current status
//             double totalValue = usdbalance + (btcBalance * btcPrice);
//             System.Console.WriteLine($"Price: ${btcPrice:F2} | USD: ${usdbalance:F2} | BTC: {btcBalance:F5} | Total: ${totalValue:F2}");

//             Thread.Sleep(2000);
//         }
//     }
// }
