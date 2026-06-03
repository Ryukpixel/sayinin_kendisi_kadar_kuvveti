using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sayinin_kendisi_kadar_kuvveti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double sonuc = 1;

                Console.Write("Kendisi kadar kuvveti alınacak sayıyı giriniz : ");
                int sayi = Convert.ToInt32(Console.ReadLine());

                if ( sayi == 0 )
                {
                    Console.WriteLine(" 0 sayısının kendisi kadar kuvveti belirsizdir ");
                    
                }
                else if ( sayi < 0)
                {
                    for ( int  i = 1; i <= -sayi; i++)
                    {
                        sonuc *= sayi;
                    }
                    
                    Console.WriteLine("{0} sayısının kendisi kadar kuvveti alınmış hali : 1/{1}",sayi,sonuc);
                }
                else
                {
                    for (int i = 1; i<=sayi; i++)
                    {
                        sonuc *= sayi;
                    }
                    Console.WriteLine("{0} sayısının kendisi kadar kuvveti alınmış hali : {1} ",sayi,sonuc);
                }

                
                

            }
            catch (Exception ex)
            {
                Console.WriteLine("HATA : {0}", ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
