using System;

namespace Laboratorna_4_2
{
    class ExcelentPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("ExcelentPupil: Study-exceletn");
        }
        public override void Read()
        {
            Console.WriteLine("ExcelentPupil: Read-exceletn");
        }
        public override void Write()
        {
            Console.WriteLine("ExcelentPupil: Write-exceletn");
        }
        public override void Relax()
        {
            Console.WriteLine("ExcelentPupil: Relax-exceletn");
        }

    }
}