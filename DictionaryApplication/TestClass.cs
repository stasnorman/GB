using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryApplication
{
    /// <summary>
    /// 
    /// </summary>
    public class TestClass
    {
        /// <summary>
        /// 
        /// </summary>
        private string Text { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        public TestClass(string text)
        {
            Text = text;
        }

        public void ViewMessage()
        {
            if (Text != null) Console.WriteLine(Text);
        }
        
        ~TestClass()
        {
            Console.WriteLine($"Очистили память: {Text}");
        }
    }
}
