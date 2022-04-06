using System;
using ClassLibrary;

namespace EnumException
{
    class Program
    {
        static void Main(string[] args)
        {
            int answer;
            Store store = new Store();

            do
            {
                Console.WriteLine("1.Product elave et\n2.Filterle\n 0. programi bitir");
                string answerStr = Console.ReadLine();
                while (!int.TryParse(answerStr, out answer))
                {
                    Console.WriteLine("duzgun deyer daxil edin: ");
                    answerStr = Console.ReadLine();
                }

                switch (answer)
                {
                    case 1:
                        Console.WriteLine("nece mehsul elave etmek isteyirsiniz?");
                        string sizeStr = Console.ReadLine();
                        int size;

                        while (!int.TryParse(sizeStr, out size))
                        {
                            Console.WriteLine("duzgun deyer daxil edin: ");
                            sizeStr = Console.ReadLine();
                        }


                        for (int i = 0; i < size; i++)
                        {
                            Console.WriteLine($"{i + 1}. mehsulun adini daxil edin: ");
                            string name = Console.ReadLine();
                            Console.WriteLine($"{i + 1}. mehsulun qiymetini daxil edin: ");
                            string priceStr = Console.ReadLine();
                            double price;
                            while (!double.TryParse(priceStr, out price))
                            {
                                Console.WriteLine("duzgun deyer daxil edin: ");
                                priceStr = Console.ReadLine();
                            }

                            Console.WriteLine($"{i + 1}. mehsulun tipini daxil edin: ");
                            string typeStr = Console.ReadLine();
                            int typeInt;
                            ProductType type;
                            while (!int.TryParse(typeStr, out typeInt))
                            {
                                Console.WriteLine("eded daxil edin: ");
                                typeStr = Console.ReadLine();
                                typeInt = Convert.ToByte(typeStr);
                            }

                            while (!Enum.IsDefined(typeof(ProductType), typeInt))
                            {
                                Console.WriteLine("duzgun secim edin!");
                                typeStr = Console.ReadLine();
                                while (!int.TryParse(typeStr, out typeInt))
                                {
                                    Console.WriteLine("eded daxil edin: ");
                                    typeStr = Console.ReadLine();
                                }
                                typeInt = Convert.ToInt32(typeStr);
                            }
                            type = (ProductType)typeInt;

                            Product product = new Product();
                            product.Name = name;
                            product.Price = price;
                            product.Type = type;

                            store.AddProduct(product);
                        }
                        foreach (var item in store.Products)
                        {
                            Console.WriteLine(item.Name + " " + item.No);
                        }
                        break;

                    case 2:
                        Console.WriteLine("1.ada gore \n 2.tipe gore");
                        string answer2Str = Console.ReadLine();
                        int answer2;
                        while (!int.TryParse(answer2Str, out answer2))
                        {
                            Console.WriteLine("duzgun deyer daxil edin: ");
                            answer2Str = Console.ReadLine();
                        }
                        if (answer2 == 1)
                        {
                            Console.WriteLine("adi daxil edin: ");
                            string filterName = Console.ReadLine();
                            foreach (var item in store.FilterProductsByName(filterName))
                            {
                                Console.WriteLine(item.ToString());
                            }
                        }
                        if (answer2 == 2)
                        {
                            Console.WriteLine("adi daxil edin: ");
                            string filterTypeStr = Console.ReadLine();
                            int filterTypeInt;
                            while (!int.TryParse(filterTypeStr, out filterTypeInt))
                            {
                                Console.WriteLine("eded daxil edin: ");
                                filterTypeStr = Console.ReadLine();
                            }
                            ProductType filterType = (ProductType)filterTypeInt;

                            foreach (var item in store.FilterProductsByType(filterType))
                            {
                                Console.WriteLine(item.ToString());
                            }
                        }
                        break;
                    default:
                        break;
                }
            } while (answer != 0);
           


            
            


            

      



        }
    }
}
