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
     static  Contacto contacto = new Contacto();
        static void Main()
        {
            botClient = new TelegramBotClient("821600759:AAHI2fu51znnt5vFPz7SKoBO3nIgNNPKfg4");

            var me = botClient.GetMeAsync().Result;
           

            botClient.OnMessage += Bot_OnMessage;
            botClient.StartReceiving();
            Thread.Sleep(int.MaxValue);
        }

        static async void Bot_OnMessage(object sender, MessageEventArgs e)
        {
            ContactoMagament contantoMagament = new ContactoMagament();

            var opcion = e.Message.Text;
          


            switch (opcion)
            {
                
                case "1":
                    leerDatos(e);
                    opcion = null;
                    break;


                default:
                    await botClient.SendTextMessageAsync(e.Message.Chat.Id, @"Usage:
                        1.Registrar un Contacto

                        ");
                    break;
               




            }
                       
              
            }
       
         static async void leerDatos(MessageEventArgs e)
        {
            await botClient.SendTextMessageAsync(
        chatId: e.Message.Chat,
        text: "You said:\n" + e.Message.Text
      );
        }

        }
    }

