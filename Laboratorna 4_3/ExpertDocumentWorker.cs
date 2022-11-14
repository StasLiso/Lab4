using System;

namespace Laboratorna_4_3
{
    class ExpertDocumentWorker : ProDocumentWorker
        {
            public override void SaveDocument()
            {
                Console.WriteLine("The document is saved in a new format");
            }
        }
    }