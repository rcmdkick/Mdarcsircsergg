
using System;

namespace Mdarcsircsergg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            String str = "æ Ç ç É é È è Ê ê Í í Ì ì Î î Ñ ñ Ó ó Ò ò Ô ô Ö ö Ø ø Ú ú Ù ù Ü ü Ž ž ₳ ฿ ￠ € ₡ ¢ ₢ ₵ ₫ ￡ £ ₤ ₣ ƒ ₲ ₭ ₥ ₦ ₱ ＄ $ ₮ ₩ ￦ ¥ ￥ ₴ ₰ ¤ ៛ ₪ ₯ ₠ ₧ ₨ ௹ ﷼ ㍐ ৲ ৳ ~ ƻ Ƽ ƽ ¹ ¸ ¬ ¨ ɂ ǁ ¯ Ɂ ǂ ¡ ´ ° ꟾ ¦ } { | . , · ] ) [ / _ \\ ¿ º § \" * - + ( ! & % $ ¼ ¾ ½ ¶ © ® @ ẟ Ɀ ` Ȿ ^ ꜠ ꜡ ỻ ' = : ; < ꞌ Ꞌ ꞊ ꞁ ꞈ ꞉ > ? ÷ ℾ ℿ ℔ ℩ ℉ ⅀ ℈ þ ð Þ µ ª ꝋ ꜿ Ꜿ ⱽ ⱺ ⱹ ⱷ ⱶ Ⱶ ⱴ ⱱ Ɒ ⱦ ȶ ȴ ȣ Ȣ ȡ ȝ Ȝ ț ȋ Ȋ ȉ Ȉ ǯ Ǯ ǃ ǀ ƿ ƾ ƺ ƹ Ƹ Ʒ Ʋ ư ƪ ƣ Ƣ Ɵ ƛ Ɩ ƕ ƍ ſ ỽ";
            int size = 25;
                while (true)
            {
                string ran = "";
                for (int j = 0; j < size; j++)
                {
                    int x = rand.Next(26);
                    ran = ran + str[x];
                }
                
                int i = rand.Next(632, 13000);
                Console.WriteLine(i);
                Console.Beep(i, 200);
                Console.Clear();
                Console.Title = ran;
            }
        }
    }
}
