
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Globalization;
using System.Linq; 
class Program
{
   static async Task<List<double>> GetBinancePrices(string symbol = "BTCUSDT")
   {
      using var client = new HttpClient();
      //free public endpoint - no API key needed for price
      var url = $"https://data-api.binance.vision/api/v3/klines?symbol=BTCUSDT&interval=1m&limit=100";
      var response = await client.GetStringAsync(url);
      var data =JsonDocument.Parse(response);
      var prices = new List<double>();

      foreach (var candle in data.RootElement.EnumerateArray())
      {
         double closePrice = double.Parse(candle[4].GetString() ?? "0", CultureInfo.InvariantCulture);
         prices.Add(closePrice);
      }
      return prices;
   }

   static double CalculateRSI(List<double>prices, int period = 14)
   {
      if (prices.Count < period + 1) return 50;

      var gains =new List<double>();
      var losses = new List<double>();

      for (int i = 1; i <prices.Count; i++)
      {
         double diff = prices[i] - prices[i-1];
         if (diff > 0) {gains.Add(diff); losses.Add(0); }
         else { gains.Add(0); losses.Add(Math.Abs(diff)); }
      }

      double avgGain = gains.TakeLast(period).Average();
      double avgLoss = losses.TakeLast(period).Average();

      if (avgLoss == 0) return 100;
      double rs = avgGain / avgLoss;
      return 100 - (100 / (1 + rs));
   }

   static async Task Main()
   {
      System.Console.WriteLine("===Masroor Technical College - Crypto RSI Bot (Educational) ===");
      System.Console.WriteLine("WARNING: For demo/paper trading only. No guarantee profit.");
   
      while (true)
      {

         try
         {
            var prices = await GetBinancePrices("BTCUSDT");
            double rsi = CalculateRSI(prices);
            double currentPrice = prices.Last();

            Console.WriteLine($"\n[{DateTime.Now}] BTC Price: ${currentPrice:F2} | RSI: {rsi:F2}");

            if (rsi < 35)
               System.Console.WriteLine(">>> SIGNAL: BUY (Oversold) - Demo only");
            else if (rsi > 70)
            System.Console.WriteLine(">>> SIGNAL: SELL (Overbought) - Demo only");
            else
               System.Console.WriteLine(">>> SIGNAL: HOLD");

            //Wait 60 seconds before next check
            await Task.Delay(5000);
         }
         catch (Exception ex)
         {
            System.Console.WriteLine($"Error: {ex.Message}");
            await Task.Delay(600000);
         }
      }
   }
}