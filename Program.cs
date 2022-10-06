using System;

namespace MeuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MeuMetodo();
            string nome = RetornaNome("Gabriel", "Campos");
            Console.WriteLine(nome);

            var mouse = new Product(01, "Mouse weibo gamer", 39.90, EProductType.Product);

            Console.WriteLine(mouse.Id);
            Console.WriteLine(mouse.Nome);
            Console.WriteLine(mouse.Price);
            Console.WriteLine(mouse.Type);
            Console.WriteLine((int)mouse.Type);
        }

        static void MeuMetodo()
        {
            Console.WriteLine("C# Sonds goods!");
        }

        static string RetornaNome(
            string nome,
            string sobrenome,
            //parametros opcionais são iniciados
            double idade = 23,
            string mes = " Junho"
        )
        {
            return nome + " " + sobrenome + " idade " + idade.ToString() + " Anos." + mes;
        }
    }

    struct Product
    {
        public Product(int id, string nome, double price, EProductType type)
        {
            Id = id;
            Nome = nome;
            Price = price;
            Type = type;

        }
        public int Id;
        public string Nome;

        public double Price;

        public EProductType Type;

        public double PriceInDolar(double dolar)
        {
            return Price * dolar;
        }
    }

    enum EProductType
    {
        Product = 1,
        Service = 2
    }
}

