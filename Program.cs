using System;

namespace dz_2020_04_04
{
    class Program
    {        
        static void Main(string[] args)
        {
            /*
             *  • Задание 2
             *      A. Создайте проект по шаблону Console Application.
             *      B. Cоздать класс Converter.
             *          1. В теле класса создать пользовательский конструктор, который принимает три
             *          вещественных аргумента, и инициализирует поля соответствующие курсу 3-х
             *          основных валют, по отношению к сомони – public Converter(double
             *          usd(доллар), double eur(евро), double rub(рубль)).
             *
             *          Написать программу, которая будет выполнять конвертацию из сомони в
             *          одну из указанных валют, также программа должна производить
             *          конвертацию из указанных валют в сомони.
             */
            
            Console.ReadKey();
        }
    }
    class Converter
    {
        private decimal USD;
        private decimal EUR;
        private decimal RUB;
        public Converter(decimal usd, decimal eur, decimal rub)
        {
            this.USD = usd;
            this.EUR = eur;
            this.RUB = rub;
        }
        public decimal UniversalConverter(string from, string to, decimal cash)
        {
            if(from == "USD")
            {
                if(to == "SMN")
                {
                    return cash * this.USD;
                }
                if(to == "EUR")
                {
                    return (cash * this.USD) / this.EUR;
                }
                if(to == "RUB")
                {
                    return (cash * this.USD) / this.RUB; 
                }
                return 0;
            }
            if(from == "EUR")
            {
                if(to == "SMN")
                {
                    return cash * this.EUR;
                }
                if(to == "USD")
                {
                    return (cash * this.EUR) / this.USD;
                }
                if(to == "RUB")
                {
                    return (cash * this.EUR) / this.RUB; 
                }
            }
            if(from == "RUB")
            {
                if(to == "SMN")
                {
                    return cash * this.RUB;
                }
                if(to == "EUR")
                {
                    return (cash * this.RUB) / this.EUR;
                }
                if(to == "USD")
                {
                    return (cash * this.RUB) / this.USD; 
                }
                return 0;
            }
            if(from == "SMN")
            {
                if(to == "USD")
                {
                    return cash / this.USD;
                }
                if(to == "EUR")
                {
                    return cash / this.EUR;
                }
                if(to == "RUB")
                {
                    return cash / this.RUB; 
                }
                return 0;
            }
            return 0;
        }
    }
}
