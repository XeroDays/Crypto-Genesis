using BinanceExchange.API.Client;
using BinanceExchange.API.Client.Interfaces;
using BinanceExchange.API.Models.Request;
using BinanceExchange.API.Models.Response;
using BinanceExchange.API.Websockets;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crypto_Genesis.Controllers
{
    public class binanceApiController
    {
        IBinanceClient ss;
        IBinanceWebSocketClient binanceWebSocketClient;
        public binanceApiController()
        {
            ss = new BinanceClient(new ClientConfiguration()
            {
                ApiKey = "ROWSc3wMIV3Ip63m3S1144MXiizjbGbyrI7JpwlMZcRP3tO6JINQ7kU24wbdbpq8",
                SecretKey = "zIo3212KiiR7kUei13WnUxSROakOkCvSOGsnURL5dedIPPvNz7Hwwf62YXMUUbLL",
            });


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

        public async Task<OrderBookResponse> getOrderBook(string symbol)
        {
            var item = await ss.GetOrderBook(symbol, false, 100);
            return item;
        }

        public async Task<SymbolPriceResponse> getCurrentPrice(string symbol)
        {
            var item = await ss.GetPrice(symbol);
            return item;
        }

    }
}
