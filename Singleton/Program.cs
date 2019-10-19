// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Program.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kumar Shubham"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Threading.Tasks;
using DesignPattern.Singleton.BehavioralDesignPattern.Subject;
using DesignPattern.Singleton.BehavioralDesignPattern.Observer;
using DesignPattern.Singleton.BehavioralDesignPattern.VisitorPattern.Offers;
using DesignPattern.Singleton.BehavioralDesignPattern.VisitorPattern.CreditCard;
using DesignPattern.Singleton.StructuralDesignPattern.AdapterDesignPattern;
using DesignPattern.Singleton.StructuralDesignPattern.ProxyDesignPattern;
using DesignPattern.Singleton.StructuralDesignPattern.FacadeDesignPattern;
using DesignPattern.Singleton.BehavioralDesignPattern.MeadiatorDesignPattern;
using DesignPattern.Singleton.CreationalDesignPattern.FactoryDesignPattern;


namespace DesignPattern.Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //Facade Design Pattern
            //HotelFacade hotel = new HotelFacade();
            //hotel.FullStructureHotel();
            ChatClient client = new ChatClient();
            client.test();
            */
            //Factory Design Pattern
            VechileFactory vechile = new TotalFactory();
            IFactory scooter = vechile.GetVechile("Scooter");
            scooter.Drive(20);
            IFactory bike = vechile.GetVechile("Bike");
            bike.Drive(40);


            /*
            //Proxy Design Pattern
            ProxyClient proxyClient = new ProxyClient();
            Console.WriteLine("Data from the Proxy Client---> {0}", proxyClient.getdata());
            Console.ReadKey();
            */
            /*
            //Adapter Design Pattern
            //It will work as the main Computer i.e., Client
            USBAdaptor usb = new USBAdaptor();
            usb.connectA();
            Console.WriteLine("Got Signal from Adapter finally!");
            */





            //Factory Design Pattern
            /*
            FactoryDesign.Computerobject computerobject = new FactoryDesign.Computerobject();
            FactoryDesign.ComputerFactory factory = computerobject.CreateObject("PC", "2GB", "500GB", "Intel");
            Console.WriteLine(factory.toString());
            */
            // Prototype Design Pattern
            /*
            PatternTest.Start();
            */
             
            // Observer Design pattern
            /*
            BehavioralDesignPattern.Subject.YoutubeChannel youtube = new BehavioralDesignPattern.Subject.YoutubeChannel();


            YoutubeChannel yt = new YoutubeChannel();
            ISubscriber Shubh = new User();
            ISubscriber Sachin = new User();
            ISubscriber Devta = new Moderators();

            youtube.Subscribe(Shubh);
            youtube.Subscribe(Sachin);
            youtube.Subscribe(Devta);

            youtube.NotifySubscribers();

            Console.WriteLine("Devta Unsubsribed !!!");
            youtube.Unsubscribe(Devta);

            youtube.NotifySubscribers();

            Console.ReadKey();
            */

            //Visitor Pattern
            /*
            OfferVisitor visitor = new HotelOfferVisitor();
            OfferVisitor visitor1 = new GasOfferVisitor();
            CreditCard bronze = new BronzeCreditCard();
            CreditCard silver = new SilverCreditCard();
            CreditCard gold = new GoldCreditCard();
            bronze.accept(visitor);
            silver.accept(visitor);
            gold.accept(visitor);
            Console.WriteLine("\n");
            bronze.accept(visitor1);
            silver.accept(visitor1);
            gold.accept(visitor1);
            */
           
            //Parallel.Invoke(() => PrintEmployeeDetails(),
            //                   () => PrintStudentdetails());
            //Singleton single = Singleton.GetInstance;
            //single.PrintDetails("This is the First Message");
            //Singleton dou = Singleton.GetInstance;
            //dou.PrintDetails("This is the secound message");

            //Console.ReadLine();
           
        }
       
        //private static void PrintEmployeeDetails()
        //{
        //    /*
        //    *Assuming Singleton is created from employee class
        //     * we refer to the GetInstance property from the Singleton class
        //     */
        //    Singleton fromEmployee = Singleton.GetInstance;
        //    fromEmployee.PrintDetails("From Employee");
        //}
    

        
            
        //    private static void PrintStudentdetails()
        //        {
        //           /*
        //                         * Assuming Singleton is created from student class
        //                         * we refer to the GetInstance property from the Singleton class
        //                         */
        //    Singleton fromStudent = Singleton.GetInstance;
        //        fromStudent.PrintDetails("From Student");
        //    }
        

        }
    }


