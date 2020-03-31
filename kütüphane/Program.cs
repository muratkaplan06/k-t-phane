using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kütüphane
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = 3;
            
            int k = 0;
            int c = 0;
            int m=0;
            string[] kitaplar = new string[10];
            string[] isimler = new string[10];
            string[] yenikitap = new string[10];

            string[,] kayıt = new string[10,2];
            while(true)
            {
                Console.Clear();
                Console.Write(" 1-kitap Kayıt \n 2-kitap ödünç verme \n 3-kitap ekleme\n 4-iade alma Seçiminiz\n 5-kitap listesi\n ( 1 - 5 )\n = ");
                string secim = Console.ReadLine();
                switch(secim)
                {
                    case "1":
                        for (int i=0; i < 3; i++)
                        {
                            Console.WriteLine(i+1 +"kitap ismi:");
                            kitaplar[i] = Console.ReadLine();
                        }
                        break;
                    case "2":
                        for (int j = 0; j < s; j++)
                        {
                            Console.WriteLine("ödünç verilecek ismi giriniz:");
                            isimler[j] = Console.ReadLine();
                            Console.WriteLine("hangi kitap verilecek");
                            string odunc = Convert.ToString(Console.ReadLine());
                            
                            bool b = true;
                            while (b == true)
                            {
                                if (odunc == kitaplar[k])
                                {
                                    yenikitap[m] = kitaplar[k];
                                    m++;
                                    k = -1;
                                    b = false;

                                }
                                else
                                    b = true;

                                k++;
                            }
                        }
                       
                        for (int i = 0; i < s; i++)
                        {
                            for (int j = 0; j < 2; j++)
                            {
                                if (j == 0)
                                    kayıt[i, j] = isimler[i];
                                else if (j == 1)
                                    kayıt[i, j] = yenikitap[i];
                            }
                        }
                        
                       
                          
                           break;
                    case "3":
                        string cevap = "e";
                        while(cevap == "e")
                        {
                            Console.WriteLine("kitap eklemek istiyor musun(E/H)");
                             cevap = Console.ReadLine();
                            if (cevap == "h")
                                break;
                            s++;
                                Array.Resize(ref kitaplar,s);
                                Console.WriteLine("kitap ismi:");
                                kitaplar[s-1] = Console.ReadLine();
                            Console.WriteLine(kitaplar[s - 1] + "eklendi");
                        }
                       
                             break;
                    case "4":
                        Console.WriteLine("iade alınacak kitap ismi");
                        string iade = Console.ReadLine();
                        for(int i=0;i<s;i++)
                        {
                            for(int j=0;j<2;j++)
                            {
                                if (j == 1)
                                {
                                    if (iade == kayıt[i, j])
                                    {
                                        if (i == 0)
                                            c = 1;
                                        else if (i == 1)
                                            c = 3;
                                        else if (i == 2)
                                            c = 5;
                                        else if (i == 3)
                                            c = 7;
                                        else if (i == 4)
                                            c = 9;
                                        else if (i == 5)
                                            c = 11;

                                        Array.Clear(kayıt, c, 1);
                                    }
                                }

                            }
                        }
                        break;
                    case "5":
                        Console.WriteLine("kitapların listesi");
                        Console.WriteLine(".............................");
                        Console.WriteLine("enter'a basarak devam ediniz");
                        for (int i = 0; i < s; i++)
                        {
                            for (int j = 0; j < 2; j++)
                            {


                                Console.SetCursorPosition(5 * j + 5, 10 + i);
                                Console.WriteLine("-{0}", kayıt[i, j]);
                                Console.ReadKey();
                            }
                        }
                        break;
                }
            }
            
        }
    }
}
