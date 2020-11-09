using System;
using System.Xml.XPath;

namespace Lab1
{
    class Document
    {
        protected string text;

        public void setText(string newText)
        {
            this.text = newText;
        }

        public string ToString()
        {
            return text;
        }
    }

    class Email : Document
    {
        private string sender;
        private string recipient;
        private string title;

        public Email (string sender, string recipient, string title, string text)
        {
            this.sender = sender;
            this.recipient = recipient;
            this.title = title;
            this.text = text;
        }
        
        public string ToString()
        {
            return sender + recipient + title + text;
        }
    }

    class Fileobjects : Document
    {
        private string pathname;

        public Fileobjects (string pathname, string text)
        {
            this.pathname = pathname;
            this.text = text;
        }

        public string ToString()
        {
            return pathname + text;
        }
    }
    class Lab1
    {
        static void Main(string[] args)
        {
            Email email1 = new Email("jim", "barbara", "Need Potato", "Plz bring potato");
            Email email2 = new Email("barbara", "jim", "No Potate", "There is no potate");
            Fileobjects file1 = new Fileobjects("C://jim", "tomato");
            Fileobjects file2 = new Fileobjects("D://Barbara", "Cheetos");

            Console.WriteLine("Should be true. " + ContainsKeyword(email1, "potato"));
            Console.WriteLine("Should be true. " + ContainsKeyword(email2, "potate"));
            Console.WriteLine("Should be true. " + ContainsKeyword(file1, "tomato"));
            Console.WriteLine("Should be true. " + ContainsKeyword(file2, "Cheetos"));
            Console.WriteLine("Should be false. " + ContainsKeyword(email2, "Potato"));


        }

        public static bool ContainsKeyword(Document docObject, string keyword)

        {

            if (docObject.ToString().IndexOf(keyword, 0) >= 0)

            {

                return true;

            }

            return false;

        }
    }
}
