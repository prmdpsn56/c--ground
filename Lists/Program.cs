

namespace Lists
{

   public  class Product {
    public  required string Name { get; set; }
    public  double? Price { get; set; }
    
    }
    internal class Program
    {
        static void Main(string[] args)
        {


 //syntaxes           
            // List<string> newList = new List<string>{"1","1","2","3","4","5","6"};
            List<string> newList = ["1","1","2","3","4","5","6"];

            newList.Add("10");
            foreach (var item in newList)
            {
                System.Console.WriteLine(item);
            }

            System.Console.WriteLine("-------------");
            bool checkIfRemoved = newList.Remove("1");
            while(checkIfRemoved){
                checkIfRemoved = newList.Remove("1");
            }


            foreach (var item in newList)
                {
                    System.Console.WriteLine(item);
                }


//sort
             List<int> newList2 = [11,2,30,1,56];
             newList2.Sort();
             foreach (var item in newList2)
             {
                System.Console.WriteLine(item);
             }
             
//find and find all

            System.Console.WriteLine("----------------");

            List<int> numbers =  [1,2,3,4,5,6,7,8,9];
            var filteredList = numbers.FindAll(item => item>=5);
            var filteredItem = numbers.Find(item => item>=5);
            System.Console.WriteLine(filteredItem);
            foreach (var item in filteredList)
            {
                System.Console.WriteLine(item);   
            }


            System.Console.WriteLine("----------------");

//lambda and predicates 
        Predicate<int> isGreaterthan = x => x > 4;
        List<int> numbers2 =  [1,2,3,4,5,6,7,8,9];
        var result = numbers2.FindAll(isGreaterthan);
        foreach (var item in result)
            {
                System.Console.WriteLine(item);
            }



//another example with if keyword

            System.Console.WriteLine("------large than 20----------");
            Func<int,bool> anyGreaterThanTwenty = x => x > 20;
            List<int> numbers3 = [1,2,3,4,5,6,21];
            var result3 = numbers3.Any(anyGreaterThanTwenty);
            System.Console.WriteLine(result3);


//using a custom class for product

        List<Product> products = new List<Product>{
            new Product{Name = "berries"},
            new Product { Name= "Apple", Price = 12},
            new Product { Name= "Oranges", Price = 1},
            new Product { Name = "cherries",Price = 0.1},
            new Product { Name= "guava", Price = 0.9},
            new Product { Name= "Oranges", Price = 10}
        };


        foreach (var item in products){
            System.Console.Write(item.Name);
            System.Console.Write(" : ");
            System.Console.Write(item.Price);
            System.Console.WriteLine("");
        }



        System.Console.WriteLine("------Less than 1----------");

        List<Product> cheapProducts = products.Where(x => x.Price <= 1).ToList();
        foreach (var product in cheapProducts)
        {
             System.Console.Write(product.Name);
            System.Console.Write(" : ");
            System.Console.Write(product.Price);
            System.Console.WriteLine("");
        }
    }

 




//method definition sytanxes apart from predicates and func
       static int square(int x) =>x *x;

        int Square2(int x){
            return x*x;
        }
    }
}