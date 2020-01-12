﻿using System;
using System.Collections.Generic;

namespace inheritance
{
    internal class AdvertisingAgency
    {
        protected static string _name;
        private double _rating;
        private string agencyname;

        public AdvertisingAgency(string name, double rating)
        {
            Name = name;
            Rating = rating;
        }

        

        public string Name
        {
            get => _name;
            set => _name = value;
        } // свойство (инкапсулирует _name)

        public double Rating
        {
            get => _rating;
            set => _rating = value;
        }

        public List<Employee> Employers = new List<Employee>() { };
        public List<Client> Clients = new List<Client>() { };
        public List<Advertising> Adverts = new List<Advertising>() { };

        public void DisplayNameAndAd()
        {
            Console.WriteLine("Имя рекламного агентства: " + Name);
            Console.WriteLine("Рейтинг рекламного агентства: " + Rating);
            /*
            Console.WriteLine("Вид добавленной рекламы: " + Ads[0].Type);
            Console.WriteLine("Цена: " + Ads[0].Price);
            Console.WriteLine("Кол-во заказов: " + Ads[0].OrdersCount);
            */
        }
    }

    internal class Advertising
    {
        public Advertising(string name, string type, double price)
            
        {
            Type = type;
            Price = price;
            Name = name;
        }

        public string Type { get; set; }

        public double Price { get; set; }

        public string Name { get; set; }
    }

    internal class Person
    {
        public Person(string name, string surname, string patronymic)
        {
            this.name = name;
            this.surname = surname;
            this.patronymic = patronymic;
        }

        public string name { get; set; }

        public string surname { get; set; }

        public string patronymic { get; set; }

        public void DisplayPerson()
        {
            Console.WriteLine("ФИО: " + name + " " + surname + " " + patronymic);
        }
    }

    internal class Client : Person
    {
        public Client(string name, string surname, string patronymic, int haveMoney)
            : base(name, surname, patronymic)
        {
            HaveMoney = haveMoney;
        }

        public int HaveMoney { get; set; }

        public void DisplayMoney()
        {
            Console.WriteLine("Столько денег он имеет: " + HaveMoney);
        }

        public void DisplayCLient()
        {
            Console.WriteLine("ФИО: " + name + " " + surname + " " + patronymic);
        }
    }

    internal class Employee : Person
    {
        private string Empname;

        public Employee(string name, string surname, string patronymic, string position, string department) : base(name,
            surname, patronymic)
        {
            Position = position;
            Department = department;
        }
        
        public string Position { get; set; }

        public string Department { get; set; }

        public void DisplayPosition()
        {
            Console.WriteLine("Должность: " + Position);
        }

        public void DisplayDepartment()
        {
            Console.WriteLine("Отдел: " + Department);
        }
    }

    internal class Program
    {
        static List<AdvertisingAgency> Agencies = new List<AdvertisingAgency>() { };
        static List<Employee> Employers = new List<Employee>() { };
        static List<Client> Clients = new List<Client>() { };

        static int Menu()
        {
            int choose = 5;
            Console.Clear();
            Console.WriteLine("1. Добавить агенство");
            Console.WriteLine("2. Добавить сотрудника");
            Console.WriteLine("3. Добавить клиента");
            Console.WriteLine("4. Посмотреть информацию об агенствах");
            Console.WriteLine("5. Выйти через окно");
            choose = Int32.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            switch (choose)
            {
                case 1:
                {
                    AddAgency();
                    Console.WriteLine("Агенство успешно добавлено");
                    Console.ReadKey();
                    Menu();
                    break;
                }
                case 2:
                {
                    AddEmployer();
                    Console.WriteLine("Сотрудник успешно добавлен");
                    Console.ReadKey();
                    Menu();
                    break;
                }
                case 3:
                {
                    AddClient();
                    Console.WriteLine("Клиент успешно добавлен");
                    Console.ReadKey();
                    Menu();
                    break;
                }
                case 4:
                {
                    ShowAgencies();
                    Console.ReadKey();
                    Menu();
                    break;
                }
                case 5:
                {
                    return 0;
                }
            }
            return 0;
        }
        
        static int Main()
        {

            Menu();
            /*for (;;)
            {
                
                Console.Write("ФИО сотрудника: ");
                empname = Console.ReadLine();
                
                
                
                //Console.Write("Имя: ");
                //empname = Console.ReadLine();

                //Console.Write("Отчество: ");
                //emppatronymic = Console.ReadLine();

                Console.Write("Отдел: ");
                empdep = Console.ReadLine();

                Console.Write("Должность: ");
                emppos = Console.ReadLine();

                Console.Write("Номер телефона: ");
                empnumber = Console.ReadLine();

                Console.Write("Фамилия клиента: ");
                clientlastname = Console.ReadLine();

                Console.Write("Имя: ");
                clientname = Console.ReadLine();

                Console.Write("Отчество: ");
                clientpatronymic = Console.ReadLine();

                Console.Write("Номер телефона: ");
                clientnumber = Console.ReadLine();

                Console.Write("Место проживания: ");
                clienthouse = Console.ReadLine();

                /#1#/ Создаём экземпляр объекта AdvertisingAgency с именем, введённым в переменную agencyname
                var agency = new AdvertisingAgency(agencyname);

                // Создаём массив с рекламами и присваиваем его полю Orders
                agency.Ads = new Advertising[1];

                // Создаём экземпляр объекта Advertising с видом, введённым в переменную adtype
                var ad = new Advertising(adtype);
                ad.Price = 500;
                ad.OrdersCount = 25;

                // Добавляем этот экземпляр в массив с рекламами
                agency.Ads[0] = ad;

                // Создаём массив с сотрудниками и присваиваем его полю Employeers
                agency.Employeers = new Employee[3];

                // Создаём экземпляр объекта Employee
                var emp = new Employee(empname);

                // Добавляем этот экземпляр в массив с сотрудниками
                agency.Employeers[0] = emp;

                // Повторяем то, что мы делали с сотрудниками, но для клиентов
                agency.Clients = new Client[2];
                var client = new Client(clientname, clientlastname, clientpatronymic, 300);
                agency.Clients[0] = client;
                Console.WriteLine("\n== Результат ==");
                agency.DisplayNameAndAd();

                Console.WriteLine("\n== Добавленные сотрудники ==");
                agency.Employeers[0].DisplayPerson();
                agency.Employeers[0].DisplayPosition();

                Console.WriteLine("\n== Добавленные клиенты ==");
                agency.Clients[0].DisplayPerson();
                agency.Clients[0].DisplayMoney();#1#
                Console.ReadLine();
            }*/
            return 0;
        }

        static void AddAgency()
        {
            string agencyname;
            
            double rating;
                
            Console.Write("Название агентства: ");
            agencyname = Console.ReadLine();

            Console.Write("Введите рейтинг: ");
            var buf = Console.ReadLine();
            rating = Convert.ToDouble(buf.Trim());
                
            var agency = new AdvertisingAgency(agencyname, rating);
            Agencies.Add(agency);

            }

        static void ShowAgencies()
        {
            foreach (var item in Agencies)
            {
                item.DisplayNameAndAd();
            }
        }

        static void AddEmployer()
        {
            string name;
            string surname;
            string patronymic;
            string position;
            string department;

            Console.Write("Имя: ");
            name = Console.ReadLine();

            Console.Write("Фамилия: ");
            surname = Console.ReadLine();
            
            Console.Write("Отчество: ");
            patronymic = Console.ReadLine();

            Console.Write("Отдел: ");
            department = Console.ReadLine();

            Console.Write("Должность: ");
            position = Console.ReadLine();
            
            var emp = new Employee(name, surname, patronymic, position, department);
            Employers.Add(emp);
            
            Console.WriteLine("Агенства");
            ShowAgencies();
            
            Console.Write("Введите название агенства в котором этот человек работает");
            var agency = Console.ReadLine();
            foreach (var item in Agencies)
            {
                if (item.Name.Equals(agency))
                {
                    item.Employers.Add(emp);
                }
            }
        }
        
        static void AddClient()
        {
            string name;
            string surname;
            string patronymic;
            int haveMoney;
            

            Console.Write("Имя: ");
            name = Console.ReadLine();

            Console.Write("Фамилия: ");
            surname = Console.ReadLine();
            
            Console.Write("Отчество: ");
            patronymic = Console.ReadLine();

            Console.Write("Бюджет: ");
            haveMoney = Convert.ToInt32(Console.ReadLine());
            
            var cli = new Client(name, surname, patronymic, haveMoney);
            Clients.Add(cli);
            
            Console.WriteLine("Агенства");
            ShowAgencies();
            
            Console.WriteLine("Введите название агенства в котором хотите обслуживаться");
            var agency = Console.ReadLine();
            foreach (var item in Agencies)
            {
                if (item.Name.Equals(agency))
                {
                    item.Clients.Add(cli);
                }
            }
        }
    }
}