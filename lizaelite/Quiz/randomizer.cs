
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Randomizer
{
    public class Program
    {
        static void Main(string[] args)
        {
            int asciiCharacterStart = 65; // from which ascii character code the generation should start
            int asciiCharacterEnd = 122; // to which ascii character code the generation should end
            int characterCount = 10000; // count of characters to generate
            
            Random random = new Random(DateTime.Now.Millisecond);
            StringBuilder builder = new StringBuilder();
            
            // iterate, get random int between 'asciiCharacterStart' and 'asciiCharacterEnd', then convert it to (char), append to StringBuilder
            for (int i = 0; i < characterCount; i++)
                builder.Append((char)(random.Next(asciiCharacterStart, asciiCharacterEnd + 1) % 255));

            // voila!
            String text = builder.ToString();
        }
    }
}