﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringType
{
    class Program
    {
        static void Main(string[] args)
        {
            //بعض الاشارات المهمة في برنامج السي شارب واستخداماتها وهي 
            // \‘  \"  \\ \0  \a  \b  \n  \r  \t  \v  \f    @

            //لتعريف متغير من نوع سترنج ويعتبر نوع ريفرنس تايب وليس فاليو تايب بحيث لا يستقبل قيمة ولكن يمكن كتابة اي شي تريده بين "" بين هذه الاقواس
            // اذا اردت طباعة الاقواس "" أو \ أو ‘ واظهارها مع الجملة اثناء الطباعة يجب عليك وضع اشارة \ قبل كل اشارة 
            //جرب الاشارات الاخرى مع الجملة التالية
            // تستخدم اشارة 0\ للاعلان عن انتهاء الجملة اي انها تعتبر بدل النقطة بحيث يبدأ سطر جديد
            //تستخدم هذه الاشارة لاصدار صوت عند الكود \a
            //تستخدم هذه الاشارة لحذف الحرف الذي قبلها اي انها تعمل كمفتاح الباك سبيس بالكيبورد تحذف الحرف \b
            //تستخدم هذه الاشارة لاعطاء سطر جديد بحيث يمكن جعل اي عبارة مكتوبة في سطرين اثناء الطباعة كما ويمكن وضع اكثر من اشارة متتالية حسب عدد الاسطر المرادة \n
            //تستخدم هذه الاشارة لحذف الكلمات التى قبلها بحيث تكتب الكلمات التي بعدها من بداية السطر وليس في موقعها السابق \r
            //اكتشف استخداماتها بنفسك \t, \v, \f
            //تستخدم هذه الاشارة لتفادي مشكلة تقسيم الجملة الى سطربن عند الكتابة ومشكلة الاشارات الكثيرة كما هي في الجملة الثانية بدل وضع اشارة \ قبل كل اشارة   @
            // اذا اردنا  الجمع بين تو سترنج اعرف سترنج ثالث يجمع بينهم كما هو موضح بالسترنج الثالث 


            string myString = "Orwa said \"This is my string\b variable\", and I think\a\0";
            string myString2 = @"D:\Documents\Desktop\visual studio 
                                 codes\Local repository\CSharpCourseCodes";

            string myString3 = myString + myString2;


            Console.WriteLine("{0}", myString3);
            Console.ReadKey();


        }
    }
}
