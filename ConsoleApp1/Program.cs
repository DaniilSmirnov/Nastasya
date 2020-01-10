using System;
using System.Collections.Generic;

namespace inheritance
{
    internal class AdvertisingAgency
    {
        protected static string _name;
        private float _rating;
        private string agencyname;

        public AdvertisingAgency(string name, float rating)
        {
            Name = name;
            Rating = rating;
        }

        public AdvertisingAgency(string agencyname)
        {
            this.agencyname = agencyname;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        } // свойство (инкапсулирует _name)

        public float Rating
        {
            get => _rating;
            set => _rating = value;
        }

        public Employee[] Employeers { get; set; }

        public Client[] Clients { get; set; }

        public Advertising[] Ads { get; set; }

        public void DisplayNameAndAd()
        {
            Console.WriteLine("Имя рекламного агентства: " + Name);
            Console.WriteLine("Рейтинг рекламного агентства: " + Rating);
            Console.WriteLine("Вид добавленной рекламы: " + Ads[0].Type);
            Console.WriteLine("Цена: " + Ads[0].Price);
            Console.WriteLine("Кол-во заказов: " + Ads[0].OrdersCount);
        }
    }

    internal class Advertising : AdvertisingAgency
    {
        public Advertising(string type)
            : base(_name)
        {
            Type = type;
        }

        public string Type { get; set; }

        public int Price { get; set; }

        public int OrdersCount { get; set; }
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

        public Employee(string name, string surname, string patronymic, string position, string department, string empname) : base(name,
            surname, patronymic)
        {
            Position = position;
            Department = department;
            Empname = empname;
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

        static int Main()
        {

            int choose = 5;

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
                    break;
                }
                case 2:
                {
                    break;
                }
                case 3:
                {
                    break;
                }
                case 4:
                {
                    break;
                }
                case 5:
                {
                    return 0;
                }
            }

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
    

    static int AddAgency()
        {
            string agencyname,
                adtype,
                empname,
                emppos,
                empdep,
                empnumber,
                clientname,
                clientlastname,
                clientpatronymic,
                clientnumber,
                clienthouse;

            float rating;
            
            Console.Write("Название агентства: ");
            agencyname = Console.ReadLine();

            Console.Write("Введите рейтинг: ");
            rating = Int32.Parse(Console.ReadLine());
            
            AdvertisingAgency agency = new AdvertisingAgency(agencyname, rating);
            Agencies.Add(agency);
            
            return 0;
        }
        
    }
}