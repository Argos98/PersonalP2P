using Entities_POJO;
using System;
using System.Threading;
using Telegram.Bot;
using Telegram.Bot.Args;
using Test;

namespace Awesome
{
    class Program
    {
        static ITelegramBotClient botClient;

        static void Main()
        {
            botClient = new TelegramBotClient("821600759:AAHI2fu51znnt5vFPz7SKoBO3nIgNNPKfg4");

            var me = botClient.GetMeAsync().Result;
            Console.WriteLine(
              $"Hello, World! I am user {me.Id} and my name is {me.FirstName}."
            );

            botClient.OnMessage += Bot_OnMessage;
            botClient.StartReceiving();
            Thread.Sleep(int.MaxValue);
        }

        static async void Bot_OnMessage(object sender, MessageEventArgs e)
        {
            ClienteMagament clienteMagament = new ClienteMagament();

            Cliente cliente = new Cliente();
            if (e.Message.Text != null)
            {
                Console.WriteLine($"Received a text message in chat {e.Message.Chat.Id}.");

                await botClient.SendTextMessageAsync(
                  chatId: e.Message.Chat,
                  text: "You said:\n" + e.Message.Text
                 
                );
                var x = e.Message.Text;
                Console.WriteLine(x);


                cliente.Nombre = x;
                Console.WriteLine(x);

            }

            clienteMagament.Create(cliente);

        }
    }
}
