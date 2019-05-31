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
        static Contacto contacto = new Contacto();
        static ContactoMagament contantoMagament = new ContactoMagament();
        static string opcion;
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


            opcion = e.Message.Text;

            if (opcion == "1")
            {

                switch (opcion)
                {

                    case "1":
                        await botClient.SendTextMessageAsync(
                                chatId: e.Message.Chat,
                                text: "Escriba los siguientes datos Tipo Contacto, Valor, Descripcion, Publicidad, Cedula Cliente "
                             );


                        break;

                    case "Que puedes hacer":
                        await botClient.SendTextMessageAsync(
                                chatId: e.Message.Chat,
                                text: "Puedo ayudarte a registra, modificar y eleminar contactos de un cliente"
                        );
                        opcion = null;

                        break;

                    case "Que haces?":
                        await botClient.SendTextMessageAsync(
                                chatId: e.Message.Chat,
                                text: "Puedo ayudarte a registra, modificar y eleminar contactos de un cliente"
                        );
                        opcion = null;

                        break;

                    case "Hola":
                        await botClient.SendTextMessageAsync(
                                chatId: e.Message.Chat,
                                text: "Hola " + e.Message.Chat.Username + ", como estas?"
                        );
                        opcion = null;

                        break;




                    default:
                        await botClient.SendTextMessageAsync(e.Message.Chat.Id, @"Usage:
                                  1.Registrar un Contacto
                                  2.Modificar un Contacto
                                  3.Eleminar  un Contacto

                                ");
                        break;

                }
            }
            //else
            //{

            //    var info = e.Message.Text;
            //    var infoArray = info.Split(',');


            //    contacto = new Contacto(infoArray);
            //    contantoMagament.Create(contacto);

            //}




        }




    }
}

