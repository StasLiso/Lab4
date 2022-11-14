using System;

namespace Laboratorna_4_3
{
    class Program
        {
            private const string PRO_LICENSE = "2011";
            private const string EXP_LICENSE = "1997";

            static void Main(string[] args)
            {

                Console.WriteLine("Ввести ключ:");
                var license = Console.ReadLine();


                DocumentWorker worker;
                switch (license)
                {
                    case PRO_LICENSE: worker = new ProDocumentWorker(); break;
                    case EXP_LICENSE: worker = new ExpertDocumentWorker(); break;
                    default: worker = new DocumentWorker(); break;
                }


                while (true)
                {
                    Console.WriteLine("Ввести комманду (Открыть/Редактировать/Сохранить/Выйти): ");
                    switch (Console.ReadLine())
                    {
                        case "Открыть": worker.OpenDocument(); break;
                        case "Редактировать": worker.EditDocument(); break;
                        case "Сохранить": worker.SaveDocument(); break;
                        case "Выйти": return;
                    }
                }
            }
        }
    }