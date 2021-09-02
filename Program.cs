using System;
using System.Collections.Generic;
namespace HW1
{
    
    class Program
    {
        static void Main(string[] args)
        {
            User jame = new User("jame watson","jane@gmail.com");
            Tshirt red = new Tshirt("red","L", "koi",500);
            Tshirt black1 = new Tshirt("black", "M", "sheep", 750);
            Tshirt black2 = new Tshirt("black", "s", "Wolf", 625);
            Address Ajame = new Address("Thanon Phutthamonthon", "Nakon Prathom", "10180");

            jame.Sent();
            jame.shirt(red);
            jame.shirt(black1);
            jame.shirt(black2);
            red.opTshirt();
            black1.opTshirt();
            black2.opTshirt();
            jame.AddRess(Ajame);
            Ajame.opAddress();
            Console.WriteLine("total cost : {0} bath", red.price + black1.price + black2.price);
            Console.ReadLine();

        }

    }
    class User
    {
        public string name, email;
        public List<Tshirt> ShirstOrder;
        public List<Address> Location;
        public User (string Vname,string Vemail)
        {
            name = Vname;
            email = Vemail;
            ShirstOrder = new List<Tshirt>();
            Location = new List<Address>();
        }
        public void shirt(Tshirt tshirt)
        {
            ShirstOrder.Add(tshirt);
        }
        public void AddRess(Address AddresS)
        {
            Location.Add(AddresS);
        }
        public void Sent()
        {
            Console.WriteLine("Username : {0}", this.name);
            Console.WriteLine("Email : {0}", this.email);
        }
    }
    class Tshirt
    {
        public string color, size, image;
        public float price;

        public Tshirt (string Vcolor,string Vsize,string Vimage,float Vpriec)
        {
            color = Vcolor;
            size = Vsize;
            image = Vimage;
            price = Vpriec;
        }
        public void opTshirt()
        {
            Console.WriteLine("Size : {0}", this.size);
            Console.WriteLine("Color : {0}", this.color);
            Console.WriteLine("Image : {0}", this.image);
            Console.WriteLine("Priec : {0}", this.price);
        }

        
    }
    class Address
    {
        public string street, city, zipcode;

        public Address(string Vstreet, string Vcity, string Vzipcode)
        {
            street = Vstreet;
            city = Vcity;
            zipcode = Vzipcode;

        }
        public void opAddress()
        {
            Console.WriteLine("131/75 street : {0},city : {1},zipcode : {2}", this.street, this.city, this.zipcode);
        }

    }
    class ShoppingCart
    {
        public List<Tshirt> tshirt;
        public List<Address> addresses;

        public ShoppingCart()
        {
            tshirt = new List<Tshirt>();
            addresses = new List<Address>();
        }
        
        
    }
 
}
