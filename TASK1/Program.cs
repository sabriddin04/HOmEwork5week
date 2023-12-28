var mag=new Shop();
var prod1=new Products();

var phone1=new Phone();
phone1.Id=1;
phone1.Name="iphone";
phone1.Price=2000;
phone1.KuvaiBatare=80;
mag.AddProduct(phone1);
var phone2=new Phone();
phone2.Id=2;
phone2.Name="samsung";
phone2.Price=200;
phone2.KuvaiBatare=70;
mag.AddProduct(phone2);
var car1=new Car();
car1.Id=3;
car1.Name="Mers";
car1.Price=300000;
car1.Motor=3;
var car2=new Car();
car2.Id=4;
car2.Name="bmv";
car2.Price=300000;
car2.Motor=5;
mag.AddProduct(car1);
mag.AddProduct(car2);

foreach (var item in mag.PrintProductList())
{
    if(item==phone1){
    System.Console.WriteLine(item.Id);
    System.Console.WriteLine(item.Name);
    System.Console.WriteLine(item.Price);
    System.Console.WriteLine(phone1.KuvaiBatare);
    System.Console.WriteLine("----------------------------------");
    }
      if(item==phone2){
    System.Console.WriteLine(item.Id);
    System.Console.WriteLine(item.Name);
    System.Console.WriteLine(item.Price);
    System.Console.WriteLine(phone2.KuvaiBatare);
    System.Console.WriteLine("----------------------------------");
    }
      if(item==car1){
    System.Console.WriteLine(item.Id);
    System.Console.WriteLine(item.Name);
    System.Console.WriteLine(item.Price);
    System.Console.WriteLine(car1.Motor);
    System.Console.WriteLine("----------------------------------");
    }
       if(item==car2){
    System.Console.WriteLine(item.Id);
    System.Console.WriteLine(item.Name);
    System.Console.WriteLine(item.Price);
    System.Console.WriteLine(car2.Motor);
    System.Console.WriteLine("----------------------------------");
    }

    
}
System.Console.WriteLine("************************************************");
mag.RemoveProduct(1);
foreach (var item in mag.PrintProductList())
{
    if(item==phone1){
    System.Console.WriteLine(item.Id);
    System.Console.WriteLine(item.Name);
    System.Console.WriteLine(item.Price);
    System.Console.WriteLine(phone1.KuvaiBatare);
    System.Console.WriteLine("----------------------------------");
    }
      if(item==phone2){
    System.Console.WriteLine(item.Id);
    System.Console.WriteLine(item.Name);
    System.Console.WriteLine(item.Price);
    System.Console.WriteLine(phone2.KuvaiBatare);
    System.Console.WriteLine("----------------------------------");
    }
      if(item==car1){
    System.Console.WriteLine(item.Id);
    System.Console.WriteLine(item.Name);
    System.Console.WriteLine(item.Price);
    System.Console.WriteLine(car1.Motor);
    System.Console.WriteLine("----------------------------------");
    }
       if(item==car2){
    System.Console.WriteLine(item.Id);
    System.Console.WriteLine(item.Name);
    System.Console.WriteLine(item.Price);
    System.Console.WriteLine(car2.Motor);
    System.Console.WriteLine("----------------------------------");
    }
}
