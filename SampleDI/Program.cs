using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            MailOperations mailOperations = new MailOperations();
            Console.WriteLine("Hangisiyle yollamak istersiniz ?");
            Console.Write("1.Gmail\n2.Hotmail\n");
            int s1 = Convert.ToInt16(Console.ReadLine());
            if (s1 == 1)
            {
                GmailService gmailService = new GmailService();
                mailOperations.SendMail(gmailService);
            }
            else if (s1 == 2)
            {
                HotmailService hotmailService = new HotmailService();
                mailOperations.SendMail(hotmailService);
            }
            else
            {
                Console.WriteLine("yanlış değer tekrar giriniz");
            }



        }
    }
}
