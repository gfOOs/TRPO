using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        List<Edition> library = new List<Edition>();
        OnlineResource onlBook = new OnlineResource(1, "Право", "Иванов", "Важно", "http://library.ru");
        Article magasin = new Article(2, "Народные песни", "Театр", "Носик", 2015, 12);
        Book bookvar = new Book(3, "Иду по пещере", "Титов-Задунайский", 1954, "Знание");
        OnlineResource onlineBook = new OnlineResource(4, "Жизнь Пушкина", "Никоненко", "Научное", "http://library.ru");
        Article news = new Article(5, "Кин-дза-дза", "Фильмы Гайдара", "Ручкин", 1966, 1);
        Book book = new Book(6, "Незнаика и его друзья", "Носов", 1984, "Литература");
        library.Add(onlBook);
        library.Add(magasin);
        library.Add(bookvar);
        library.Add(onlineBook);
        library.Add(news);
        library.Add(book);
        for (int i = 0; i < library.Count; i++)
            Console.WriteLine(library[i].CompareTo("Носов"));
    }
}
abstract class Edition
{
    public virtual int Id { get; set; }
    public virtual string Name { get; set; }
    public virtual string Autor { get; set; }
    public virtual int Year { get; set; }
    public virtual string EditorGroup { get; set; }
    public List<Edition> list;
    public Edition(int id, string name, string autor)
    {
        Id = id;
        Name = name;
        Autor = autor;
        list = new List<Edition>();
    }
    public abstract string CompareTo(string souname);
}
class Article : Edition
{
    public override int Id { get; set; }
    public override string Name { get; set; }
    public string ArticleName { get; set; }
    public override string Autor { get; set; }
    public override int Year { get; set; }
    public int Number { get; set; }
    public Article(int id, string name, string autor, string articName, int year, int num) : base(id, name, autor)
    {
        Id = id;
        Name = name;
        ArticleName = articName;
        Autor = autor;
        Year = year;
        Number = num;
        list.Add(this);
    }
    public override string CompareTo(string souname)
    {
        if (souname != Autor)
        {
            return default(string);
        }
        return "Название :" + Name + "\nНазвание журнала :" + ArticleName + "\nФамилия афтора :" + Autor + "\nГод :" + Year + "\nНомер :" + Number + "\n";
    }
}
class Book : Edition
{
    public override int Id { get; set; }
    public override string Name { get; set; }
    public override string Autor { get; set; }
    public override int Year { get; set; }
    public override string EditorGroup { get; set; }
    public Book(int id, string name, string autor, int year, string eGroup) : base(id, name, autor)
    {
        Id = id;
        Name = name;
        Autor = autor;
        Year = year;
        EditorGroup = eGroup;
        list.Add(this);
    }
    public override string CompareTo(string souname)
    {
        if (souname != Autor)
        {
            return default(string);
        }
        return "Название :" + Name + "\nФамилия афтора :" + Autor + "\nГод :" + Year + "\nИздательство :" + EditorGroup + "\n";
    }
}
class OnlineResource : Edition
{
    public override int Id { get; set; }
    public override string Name { get; set; }
    public override string Autor { get; set; }
    public string Abstract { get; set; }
    public string Link { get; set; }
    public OnlineResource(int id, string name, string autor, string abstr, string lin) : base(id, name, autor)
    {
        Id = id;
        Name = name;
        Autor = autor;
        Abstract = abstr;
        Link = lin;
        list.Add(this);
    }
    public override string CompareTo(string souname)
    {
        if (souname != Autor)
        {
            return default(string);
        }
        return "Название :" + Name + "\nФамилия афтора :" + Autor + "\nСсылка :" + Link + "\nАннатация :" + Abstract + "\n";
    }
}