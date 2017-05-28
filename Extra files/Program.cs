using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Google.Cloud.Translation.V2;

namespace translateApp
{
    public class QuickStart
    {
        public static String translate(string text)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            TranslationClient client = TranslationClient.Create();
            var response = client.TranslateText(text, "en");
            return response.TranslatedText;
        }
    }
}
