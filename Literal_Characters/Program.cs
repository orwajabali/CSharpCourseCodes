using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Literal_Characters
{
    class Program
    {
        static void Main(string[] args)
        {

            //بعض انواع المتغيرات لا يتعرف عليها البرنامج السي شارب الا اذا وضعنا الحرف الذي يدل على نوع المتغير بعد قيمة المتغير
            //التوضيح اكثر بالاسفل كلا حسب نوع المتغير

            //هذا النوع لا يعترض عليه البرنامح اذا وضعت اشارة السالب قبل القيمة
            int myVar = -100;

            //هذا النوع لا يمكن وضع القيمة السالبة معه, كما ويمكن وضع الحرف الدال عليه او تركه بدون حرف
            uint myUVar = 1000;

            //يمكن وضع الحرف الدال عليه او تركه بدون حرف
            long myLVar = 1000;

            //يعترض البرنامج على هذا النوع في حالة لم يتم وضع الحرف الدال على نوع المتغير كما هو موضح
            float myFlVar = 1.5F;

            //يمكن وضع الحرف الدال عليه او تركه بدون حرف
            double myDVar = 100.5;

            //يعترض البرنامج على هذا النوع في حالة لم يتم وضع الحرف الدال على نوع المتغير كما هو موضح
            decimal myDecVar = 100.5M;



            Console.WriteLine("{0} {1}", myVar, myUVar);

            // طريقة طباعة ثانية اسهل من الطريقة الاولى كما هو موضح كما يلي

            Console.WriteLine($"{myDecVar},{myDVar}");
            Console.ReadKey();

        }
    }
}
