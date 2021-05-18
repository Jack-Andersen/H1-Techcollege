//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace BankV2.Shop.OldProducts
//{
    
//    public interface IProduct
//    {

//        public string Name { get; set; }
//        public int? Amount { get; set; }

//        public class Apple : IProduct
//        {
//            public string Name { get; set; }
//            public int? Amount { get; set; }          
            
//            public override string ToString()
//            {
//                if (Amount == 0)
//                    return "";
//                else
//                {
//                    return ((Amount > 0 || Amount == 0 ? Amount : null) + " " + ( Name == "Apple" || Name == "" ? Name : string.Empty) + ( Amount > 1 || Amount == 0 ? "s" : string.Empty)).ToString();
//                }
//            }
//        }

//        public class Bread : IProduct
//        {
//            public string Name { get; set; }
//            public int? Amount { get; set; }

//            public override string ToString()
//            {
//                if (Amount == 0)
//                    return "";
//                else
//                {
//                    return ((Amount > 0 || Amount == 0 ? Amount : null) + " " + (Name == "Bread" || Name == "" ? Name : string.Empty) + (Amount > 1 || Amount == 0 ? "s" : string.Empty)).ToString();
//                }
//            }
//        }

//        public class Dount : IProduct
//        {
//            public string Name { get; set; }
//            public int? Amount { get; set; }

//            public override string ToString()
//            {
//                if (Amount == 0)
//                    return "";
//                else
//                {
//                    return ((Amount > 0 || Amount == 0 ? Amount : null) + " " + (Name == "Dount" || Name == "" ? Name : string.Empty) + (Amount > 1 || Amount == 0 ? "s" : string.Empty)).ToString();
//                }
//            }
//        }
//    }
//}
