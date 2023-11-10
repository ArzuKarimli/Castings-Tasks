
using Castings_practice;
using Castings_practice.Controllers;
using Castings_practice.Exceptions;
using Castings_practice.Models;

#region Homework
Generics<Product> products = new Generics<Product>();
products.Add(new Product { Id = 1, Name = "Iphone", Price = 3000 });
products.Add(new Product { Id = 2, Name = "Samsung", Price = 2000 });
products.Add(new Product { Id = 3, Name = "Nokia", Price = 500 });

//var result=products.GetAll();
//foreach(var item in result)
//{
//    Console.WriteLine(item.Name);
//}

//var res = products.GetById(2);
//Console.WriteLine(res.Name);
//var result = products.Delete(2);
//foreach (var item in result)
//{
//    Console.WriteLine(item.Name);
//}

//try
//{
//    int number = 5;
//    int factorial = 1;
//    if (number <0)
//    {
//        throw new LessThanZeroException();
//    };
//    for (int i = 1; i <=number; i++)
//    {
//        factorial *= i;
//    }
//    Console.WriteLine(factorial);
//}
//catch (Exception ex)
//{

//    Console.WriteLine(ex.Message);
//}
#endregion



//Animal animal = new Animal();
//Fish fish1 = new Fish();
//Bird bird = new Bird();
//Animal animal2 = fish1;
////animal2.Sound();
////fish1.Sound();
//Animal animal3 = bird;
//Bird bird2 = (Bird)animal;


//Animal[] datas = {animal,fish1,bird,animal2,animal3, bird2 };
//foreach (var item in datas)
//{
//    item.Name = "XXX";
//    Console.WriteLine(item.Name);
//}

//int num1 = 5;
//object obj = num1;
//int num2 =(int) obj;
//bool isMarried = false;
//object data = isMarried;
//bool test = (bool)data;

//string name = "test";
//object data2 = name;
//string name2=data2.ToString();

//byte num1 = 5;
//int num2 = num1;
//int a1 = 3;
//byte a2 =(byte) a1;
//Console.WriteLine(a2);


Bird bird = new Bird();
Fish fish = new Fish();
Animal animal1 = new Bird();
Animal animal2 = new Bird();
object[] datas = {1,2,bird,"salam",fish,animal1,100,animal2};
//foreach (var data in datas)
//{ 
//    if(data is Animal t) 
//    {
//        t.Name = "XXX";
//        Console.WriteLine(t.Name);
//    }
//    else
//    {
//        Console.WriteLine($"{data} cant convert");
//    }

//}

//foreach (var data in datas)
//{
//    Animal animal = data as Animal;
//    if(animal != null)
//    {
//        animal.Name = "test";
//        Console.WriteLine(animal.Name);
//    }
//}

//List<int>nums=new List<int>();
//List<int>nums2=new List<int>();
//nums2.Add(100);
//nums2.Add(200);
//nums.Add(5);
//nums.Add(2);
//nums.Add(3);
//nums.AddRange(nums2);
//Console.WriteLine(nums.Count);
//foreach (var item in nums)
//{
//    Console.WriteLine(item);
//}

//List<string> names = new() { "Tunzale", "Arzu", "Ilham" };

//for (int i = 0; i < names.Count; i++)
//{
//    Console.WriteLine(names[i]);
//}

//List<string> emails = new() { "t@gmail.com", "n@code.edu.az", "c@gmail.com" };
//static void CheckEmail(string email,List<string>emails)
//{
//    if (emails.Contains(email))
//    {
//        Console.WriteLine("yes");
//    }
//    else
//    {
//        Console.WriteLine("no");
//    }
//}
//CheckEmail("c@gmail.com", emails);

//List<Product>products1 = new List<Product>();

//products1.Add(new Product { Id = 1, Name = "Iphone", Price = 3000 });
//products1.Add(new Product { Id = 2, Name = "Nokia", Price = 500 });
//products1.Add(new Product { Id = 3, Name = "Samsung", Price = 2000 });
//foreach (var item in products1)
//{
//    Console.WriteLine(item.Name);
//}


//static List<Product> Search(string str,List<Product>products1)
//{
//    //var datas=products1.FindAll(x => x.Name.Contains(str));
//    var datas=products1.Where(m=>m.Name.Contains(str)).ToList();
//    return datas;
//}


List<int>nums= new() { 1,2,3,4,5,6,9,100};

//for (int i = 0; i <nums.Count; i++)
//{
//    if (i<=4)
//    {
//        Console.WriteLine(nums[i]);
//    }
//}

//for (int i = 0; i < nums.Count; i++)
//{
//    if (nums[i] == 5)
//    {
//        break;
//    }
//    else
//    {
//        Console.WriteLine(nums[i]);
//    }
//}


//for (int i = 0; i < nums.Count; i++)
//{
//  int index=nums.IndexOf(5);
//    if(i<= index)
//    {
//        Console.WriteLine(nums[i]);
//    }
//}



//ProductController controller = new ProductController();
//controller.GetAll();
//controller.GetById();

