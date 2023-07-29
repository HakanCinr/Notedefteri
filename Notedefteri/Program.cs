namespace Notedefteri
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

            static void metindosyas�()
            {
                string fileName = "notepad.txt";
                string textToAdd = "Bu notepad �zerine yaz�lan bir metindir.";

                using (StreamWriter sw = File.AppendText(fileName))
                {
                    sw.WriteLine(textToAdd);
                }

                Console.WriteLine("Notepad'a yaz�lan metin: " + textToAdd);
                Console.ReadLine();
            }

        }
    }
}