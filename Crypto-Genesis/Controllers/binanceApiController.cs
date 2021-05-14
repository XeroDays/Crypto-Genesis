using BinanceExchange.API.Client;
using BinanceExchange.API.Client.Interfaces;
using BinanceExchange.API.Models.Request;
using BinanceExchange.API.Models.Response;
using BinanceExchange.API.Websockets;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Crypto_Genesis.Controllers
{
    public class binanceApiController
    {
        IBinanceClient ss;
        IBinanceWebSocketClient binanceWebSocketClient;
        DateTime lastRequest = new DateTime();
        public binanceApiController()
        {
            ss = new BinanceClient(new ClientConfiguration()
            {
                ApiKey = "ROWSc3wMIV3Ip63m3S1144MXiizjbGbyrI7JpwlMZcRP3tO6JINQ7kU24wbdbpq8",
                SecretKey = "zIo3212KiiR7kUei13WnUxSROakOkCvSOGsnURL5dedIPPvNz7Hwwf62YXMUUbLL",
            });

            lastRequest = DateTime.Now;
            // binanceWebSocketClient = new InstanceBinanceWebSocketClient(ss);
            // websocketData();


        }


        public async void websocketData(string TargetSymbol)
        {

            // Manual management

            var socketId = binanceWebSocketClient.ConnectToDepthWebSocket(TargetSymbol, async data =>
            {

                System.Console.WriteLine($"DepthCall: {JsonConvert.SerializeObject(data)}");
                var sss = await ss.GetOrderBook("DOGEUSDT", false, 100);

            });

            // Disposable and managed
            //using (var binanceWebSocketClient = new DisposableBinanceWebSocketClient(ss))
            //{
            //    binanceWebSocketClient.ConnectToDepthWebSocket("ETHBTC", data =>
            //    {
            //        System.Console.WriteLine($"DepthCall: {JsonConvert.SerializeObject(data)}");
            //    });

            //    Thread.Sleep(1000);
            //}
        }

        public async Task<SymbolPriceResponse> getCurrentPrice(string symbol)
        {
            var item = await ss.GetPrice(symbol);
            return item;
        }


       

        /// <summary>
        /// This send request to binance api requesting ORder boook
        /// </summary>
        /// <param name="symbol">The symbol of requesting coin pair. e.g BTCUSDT</param>
        /// <param name="limit">Limit is the total number of orderbook, this should be : 5,100,1000,5000</param>
        /// <returns></returns>
        public async Task<OrderBookResponse> getOrderBook(string symbol, int limit = 100)
        {

            if (limit <= 100)
            {
               return await ss.GetOrderBook(symbol);
            }
            else
            { 
                OrderBookResponse item = new OrderBookResponse();
                if (lastRequest < DateTime.Now.AddMilliseconds(100))
                {
                    System.Threading.Thread.Sleep(80);
                }
                string html;
                string url = "https://api.binance.com/api/v3/depth?symbol=" + symbol + "&limit=" + limit;
                try
                {
                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                    lastRequest = DateTime.Now;
                    request.AutomaticDecompression = DecompressionMethods.GZip;
                    using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                    using (Stream stream = response.GetResponseStream())
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        html = reader.ReadToEnd();
                    }

                    item = JsonConvert.DeserializeObject<OrderBookResponse>(html);

                }
                catch (Exception ex)
                {

                }
                return item;
            }
        }

        public async void CreateOrder()
        {

            var cressateOrder = await ss.CreateOrder(new CreateOrderRequest()
            {
                IcebergQuantity = 00,
                Price = 8.5m,
                Quantity = 1.5m,
                Side = BinanceExchange.API.Enums.OrderSide.Sell,
                Symbol = "AXSUSDT",
                Type = BinanceExchange.API.Enums.OrderType.StopLossLimit,
                NewOrderResponseType = BinanceExchange.API.Enums.NewOrderResponseType.Full,
                TimeInForce = BinanceExchange.API.Enums.TimeInForce.GTC,
                StopPrice = 7.5m
            });
            var createOrder = await ss.CreateOrder(new CreateOrderRequest()
            {
                IcebergQuantity = 00,
                Price = 8.5m,
                Quantity = 1.5m,
                Side = BinanceExchange.API.Enums.OrderSide.Sell,
                Symbol = "AXSUSDT",
                Type = BinanceExchange.API.Enums.OrderType.Limit,
                NewOrderResponseType = BinanceExchange.API.Enums.NewOrderResponseType.Full,
                TimeInForce = BinanceExchange.API.Enums.TimeInForce.GTC,
            });


        }

        public async void CheckOrders()
        {
            string ssss = "AXSUSDT";
            CurrentOpenOrdersRequest request = new CurrentOpenOrdersRequest();
            // request.Symbol = ssss;

            var orderss = await ss.GetCurrentOpenOrders(request);
        }
    }
}
