using System;

namespace nibbifycsharp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			Console.Write("Type something to nibbify: ");
			string textToNibbify = Console.ReadLine();
			string nibbifiedtext = textToNibbify.Replace('g', 'B');
			nibbifiedtext = nibbifiedtext.Replace('G', 'B');
			Console.WriteLine("Nibbafied text:\n" + nibbifiedtext);
			Console.Write("Press Any key to Continue... ");
			Console.ReadKey();
		}
    }
}
