using System;

namespace Laboratorna_4_3
{
    class ProDocumentWorker : DocumentWorker
        {
            public override void EditDocument()
            {
                Console.WriteLine("The document has been edited");
            }

            public override void SaveDocument()
            {
                Console.WriteLine("The document is saved in the old format, saving in other formats is available in the Expert version");
            }
        }
    }