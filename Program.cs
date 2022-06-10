namespace caeser
{
    class Program
    {
        static char[] alphavit = { 'a', 'b', 'c', 'd', 'e','f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o',
            'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        static void Main(string[] args)
        {
            bool isWorking = true;
            while (isWorking)
            {
                Console.WriteLine("1. зашифровать сообщение 2. расшифровать сообщение 3. выход");
                string temp = Console.ReadLine();
                switch (temp)
                {
                    case "1":
                        Shifr();
                        break;
                    case "2":
                        Deshifr();
                        break;
                    case "3":
                        isWorking = false;
                        break;
                    default:
                        break;
                }
            }
        }

        static void Shifr()
        {
            var isOkay = true;
            var key = 0;
            Console.Write("Введите сообщение: ");
            var message = Console.ReadLine();
            Console.Write("Введите сдвиг: ");
            try
            {
                key = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("неправильный ключ");
                isOkay = false;
            }

            if (isOkay)
            {
                var encoded = new char[message.Length];

                for (var i = 0; i < message.Length; i++)
                {
                    if (message[i] != ' ')
                    {
                        var index = Array.IndexOf(alphavit, message[i]) + key;
                        while (index >= alphavit.Length)
                        {
                            index -= alphavit.Length;
                        }
                        encoded[i] = alphavit[index];
                    }
                    else
                    {
                        encoded[i] = ' ';
                    }
                }
                Console.Write("Зашифрованное сообщение: ");
                foreach (var letter in encoded)
                {
                    Console.Write(letter);
                }
                Console.WriteLine();
            }
        }

        static void Deshifr()
        {
            var isOkay = true;
            var key = 0;
            Console.Write("Введите сообщение: ");
            var message = Console.ReadLine();
            Console.Write("Введите сдвиг: ");
            try
            {
                key = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("неправильный ключ");
                isOkay = false;
            }

            if (isOkay)
            {
                var decoded = new char[message.Length];

                for (var i = 0; i < message.Length; i++)
                {
                    if (message[i] != ' ')
                    {
                        var index = Array.IndexOf(alphavit, message[i]) - key;
                        while (index < 0)
                        {
                            index += alphavit.Length;
                        }
                        decoded[i] = alphavit[index];
                    }
                    else
                    {
                        decoded[i] = ' ';
                    }
                }
                Console.Write("Расшифрованное сообщение: ");
                foreach (var letter in decoded)
                {
                    Console.Write(letter);
                }
                Console.WriteLine();
            }
        }
    }
}