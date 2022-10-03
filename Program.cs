using System.Numerics;
Kniga K = new Kniga();
char vvod;
do
{
    Console.Clear();
    Console.WriteLine("1 - Заполнение(добавление)");
    Console.WriteLine("2 - Удаление");
    Console.WriteLine("3 - Поиск");
    Console.WriteLine("4 - Вывод на экран");
    Console.WriteLine("Выходи тут ->>ESC<<-");
    
    vvod = Console.ReadKey().KeyChar;
    switch (vvod)
    {
        case '1':
        {
                Console.Clear();
                K.Vvod();
                K.print();
                Console.ReadLine();
            break;
        }
        case '2':
        {
                Console.Clear();
                K.Del(K.Search());
                Console.ReadLine();
                break;
        }
        case '3':
        {
                Console.Clear();
                K.Search();
                Console.ReadLine();
                break;
        }
        case '4':
            {
                Console.Clear();
                K.print();
                Console.ReadLine();
                break;
            }
    }   
    
} while (vvod != 27);
class Kniga
{
    public struct Info
    {
        public string name;
        public string autor;
        public string year;
    }

    private Info info;
    Info[] mas = new Info[0];
    public void Vvod()
    {
        Array.Resize(ref mas, mas.Length + 1);
        Console.WriteLine("Введите название книги");
        //info = new Info();
        info.name = Console.ReadLine();
        Console.WriteLine("Введите автора");
        info.autor = Console.ReadLine();
        Console.WriteLine("Введите год издания");
        info.year = Console.ReadLine();
        mas[mas.Length - 1] = info;
    }
    public void print()
    {
        for (int i = 0; i < mas.Length; i++)
        {
            Console.WriteLine("Номер книги [" + (i + 1) + "] ");
            Console.WriteLine("Книга ->> " + mas[i].name + "\nАвтор->> " + mas[i].autor + "\nГод издания->> " + mas[i].year);
        }
    }

    public string Search()
    {
        bool b = true;
        Console.WriteLine("Введите название книги");
        string? sr = Console.ReadLine();
        for (int i = 0; i < mas.Length; i++)
        {
            if (sr == mas[i].name)
            {
                Console.WriteLine((i + 1) + "\nКнига ->> " + mas[i].name + "\nАвтор->> " + mas[i].autor + "\nГод издания->> " + mas[i].year);
                b = false;
            }
        }
        if (b == true)
        {
            Console.WriteLine("Нетю.");
        }
        return sr;
    }

    public void Del(string sr)
    {
        int p = 0;
        for (int i = 0; i < mas.Length; i++)
        {
            if (sr != mas[i].name)
            {
                mas[p] = mas[i];
                p++;
            }
        }
        Array.Resize(ref mas,p);
        
    }
}

