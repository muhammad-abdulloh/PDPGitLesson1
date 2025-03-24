using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.InhertanceLesson
{
    internal class Father
    {
        // access modifiers
        // private bo'sa manashu funksiya yoki property faqat shu classni
        // ichida ishlidi
        // shu class va inherit qilingan classni ichida ishlidi
        // olingan objectda foydalana olmimiz
        protected void GetName()
        {
            Console.WriteLine("Sherzod");
        }
    }
}
