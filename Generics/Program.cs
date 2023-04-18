using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Generics.Program;

namespace Generics
{
    // Tasarlanan metot class parametreler degiskenler belirli tip olarak degil bir sablon yapisi dahilinde calismasini saglayan bir yapi.
    internal class Program
    {
        static void Main(string[] args)
        {
            //Generic yontemini kullanarak ...

            //Generic olarak tanimlandigi class Int olarak nesnelendiriliyor.

            //Int
            Example<int> examp_1 = new Example<int>();  //Generic yapia tanimlanmis class int olarak kullanabilmesi 
            examp_1.example_1 = 1;//example type int 
            examp_1.example_2(200); //example type int 
             
            //String
            Example<string> examp_2 = new Example<string>();
            examp_2.example_1 = "Ozcan Kara";
            examp_2.example_2("C#");

            //Double
            Example<double> examp_3 = new Example<double>();
            examp_3.example_1=10.5;
            examp_3.example_2(100.4);


            Console.ReadKey();

        }


        //Normal olarak
       

        //Generic yapisini kullanildiginda degiskenler ,parametreler ve metotlar geri donus tipleri gibi durumlari o siniftan bir nesne olustururken belirlenmesidir.

        public class Example //T --Type T tipi  
        {
            public int  example_1;
            
            }//Metot

            public void example_2(int parameter)
            {

            }

            
        }

         public class Example<T> //T Type
        {
            public T example_1; //Degisken
           
            public void example_2(T parameter)  //Metot
            {

                Console.WriteLine("Parametre degeri : " + parameter + "\n");
            }
        }


}

//        foreach (int i in ProduceEvenNumbers(9))
//{
//    Console.Write(i);
//    Console.Write(" ");
//}
//// Output: 0 2 4 6 8

//IEnumerable<int> ProduceEvenNumbers(int upto)
//{
//    for (int i = 0; i <= upto; i += 2)
//    {
//        yield return i;
//    }
//}
//    }




