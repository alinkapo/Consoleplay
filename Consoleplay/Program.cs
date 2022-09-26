Console.WriteLine("Приветствую тебя в игре 'Виселица!'");
string[] words = { "вилка", "кепка", "математика", "кошка", "муравей", "туфли" };
Random rand = new Random();
string enter = (words[rand.Next(words.Length - 1)]);

if (enter == "вилка")
{
Console.WriteLine("Компьютер загадал слово.Твоя задача угадать загаданное слово за несколько попыток! Это будет столовый прибор.");
}
if (enter == "кепка")
{
Console.WriteLine("Компьютер загадал слово.Твоя задача угадать загаданное слово за несколько попыток! Это будет головной убор.");
}
if (enter == "математика")
{
Console.WriteLine("Компьютер загадал слово.Твоя задача угадать загаданное слово за несколько попыток! Это будет школьный предмет.");
}
if (enter == "кошка")
{
Console.WriteLine("Компьютер загадал слово.Твоя задача угадать загаданное слово за несколько попыток! Это будет домашнее животное.");
}
if (enter == "муравей")
{
Console.WriteLine("Компьютер загадал слово.Твоя задача угадать загаданное слово за несколько попыток! Это будет насекомое.");
}
if (enter == "туфли")
{
Console.WriteLine("Компьютер загадал слово.Твоя задача угадать загаданное слово за несколько попыток! Это будет обувь.");
}
int attempts = 6;
List<char> letters = new List<char>();
while (attempts -- > 0)
{ 
    Console.WriteLine(Environment.NewLine);
    string user_word = null;
    foreach (char _char in enter.ToCharArray())
    {
        if (letters.Contains(_char)) user_word += _char;
        else user_word += ".";
    }
    if (user_word.Contains("."))
    {
        Console.WriteLine($"Осталось попыток: {attempts} {Environment.NewLine}{user_word}");
        try
        {
            Console.WriteLine("Введите букву: ");
            var user_char = Console.ReadLine();
            letters.Add(char.Parse(user_char));
            if (enter.Contains(user_char))
            {
                attempts++;
                Console.WriteLine($"Буква '{user_char}' правильная. Молодец!");
            }

            else Console.WriteLine($"Буква '{user_char}' неправильная.");
        }
        catch
        {
            Console.ReadLine();
        }
    }
    else
    {
        Console.WriteLine($"Круто! Вы угадали слово! {Environment.NewLine}{user_word}");
        return;
    }
}
Console.WriteLine($"К сожалению, вы проиграли! {Environment.NewLine}{enter}");