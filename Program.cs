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
        private double Unusd { get; set; }
        private double Eueur { get; set; }
        private double Rurub { get; set; }
        public Converter(double usd, double eur, double rub)
        {
               
        }
    }
}
