using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wintellect.PowerCollections;

namespace Problem02OnlineMarket
{
    class Program
    {
      
            static StringBuilder resultBuilder;
            static OrderedSet<Product> res;

            static void Main(string[] args)
            {
                res = new OrderedSet<Product>();
                resultBuilder = new StringBuilder();
                Dictionary<string, Product> shop = new Dictionary<string, Product>();
                Dictionary<string, OrderedSet<Product>> typeProduct = new Dictionary<string, OrderedSet<Product>>();
                string input = Console.ReadLine();
                while (input != "end")
                {
                    string[] cmd = input.Split();
                    switch (cmd[0])
                    {
                        case "add":
                            //string name = cmd[1];
                            //decimal price = decimal.Parse(cmd[2]);
                            //string type = cmd[3];
                            var currProduct = new Product(cmd[1], decimal.Parse(cmd[2]), cmd[3]);
                            if (!shop.ContainsKey(cmd[1]))
                            {
                                shop.Add(cmd[1], currProduct);
                                resultBuilder.AppendLine($"Ok: Product {cmd[1]} added successfully");
                            }
                            else
                            {
                                resultBuilder.AppendLine($"Error: Product {cmd[1]} already exists");
                            }
                            if (!typeProduct.ContainsKey(cmd[3]))
                            {
                                typeProduct.Add(cmd[3], new OrderedSet<Product>());

                                typeProduct[cmd[3]].Add(currProduct);
                            }
                            else
                            {
                                if (!(typeProduct[cmd[3]].Any(x => x.Name == currProduct.Name)))
                                {
                                    typeProduct[cmd[3]].Add(currProduct);
                                }
                            }


                            break;
                        case "filter":

                            switch (cmd[2])
                            {
                                case "type":
                                    //var pType = cmd[3];
                                    if (typeProduct.ContainsKey(cmd[3]))
                                    {
                                        resultBuilder.AppendLine($"Ok: {string.Join(", ", typeProduct[cmd[3]].Take(10))}");

                                    }
                                    else
                                    {
                                        resultBuilder.AppendLine($"Error: Type {cmd[3]} does not exists");
                                    }
                                    break;
                                case "price":

                                    if (cmd[3] == "from" && cmd.Length == 7)
                                    {
                                        foreach (var product in shop.Where(x => x.Value.Price >= decimal.Parse(cmd[4]) && x.Value.Price <= decimal.Parse(cmd[6])))
                                        {
                                            res.Add(product.Value);
                                        }

                                        resultBuilder.AppendLine($"Ok: {string.Join(", ", res.Take(10))}");
                                        res.Clear();
                                    }
                                    else if (cmd[3] == "from" /*&& cmd.Length == 5*/)
                                    {
                                        foreach (var product in shop.Where(x => x.Value.Price >= decimal.Parse(cmd[4])))
                                        {
                                            res.Add(product.Value);
                                        }

                                        resultBuilder.AppendLine($"Ok: {string.Join(", ", res.Take(10))}");
                                        res.Clear();
                                    }
                                    else if (cmd[3] == "to" && cmd.Length == 5)
                                    {
                                        foreach (var product in shop.Where(x => x.Value.Price <= decimal.Parse(cmd[4])))
                                        {

                                            res.Add(product.Value);



                                        }
                                        resultBuilder.AppendLine($"Ok: {string.Join(", ", res.Take(10))}");
                                        res.Clear();
                                    }
                                    break;
                                default:
                                    break;
                            }
                            break;
                        default:
                            break;
                    }
                    input = Console.ReadLine();
                }


                Console.WriteLine(resultBuilder.ToString());
            }
        }
    }
    internal struct Product : IComparable<Product>
    {
        public Product(string name, decimal price, string type)
        {
            this.Name = name;
            this.Price = price;
            this.Type = type;
        }
        public decimal Price { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }



        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append($"{this.Name}({this.Price.ToString("G29")})");

            return str.ToString();
        }
        public int CompareTo(Product other)
        {
            int result = this.Price.CompareTo(other.Price);
            if (result == 0)
            {
                result = this.Name.CompareTo(other.Name);

                if (result == 0)
                {
                    result = this.Type.CompareTo(other.Type);
                }
            }


            return result;
        }
    }

