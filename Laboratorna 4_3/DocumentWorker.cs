using System;

namespace Laboratorna_4_3
{
    class DocumentWorker
        {
            public virtual void OpenDocument()
            {
                Console.WriteLine("The document is open");
            }

            public virtual void EditDocument()
            {
                Console.WriteLine("Editing on the Pro version");
            }

            public virtual void SaveDocument()
            {
                Console.WriteLine("Saving on the Pro version");
            }
        }
    }