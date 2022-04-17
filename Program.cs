//** Ödev1 C#**

    // Kullanıcıdan aldığımız pozitif tam sayı kadar sayıdan çift olanlarını yazdırın 

     Console.Write("Lütfen Gireceğiniz Sayıların Adetini Seçin:");
     int n = Convert.ToInt32(Console.ReadLine());
     int[] sayilar = new int[n];
     for (int i = 0; i <n; i++)
     {
         Console.WriteLine("Lütfen {0}. pozitif tam sayınızı giriniz", i+1);
         sayilar[i] = Convert.ToInt32(Console.ReadLine());
     }
         for (int i = 0; i <n ; i++)
         {
          if(sayilar[i]%2==0)
             Console.WriteLine("Çift Sayılarınız :" +sayilar[i]);
         }
        //*********************************************************************
         //kullanıcıdan aldığımız 2 adet pozitif tam sayıdan, ilk sayı kadar sayıyı kullanıcıdan alıp ikinciye tam bölünenlerini yazdırın 
                Console.WriteLine("Kaç adet sayı gireceksiniz ?");
            int deger1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Girdiğiniz Sayıları Bölmesini istediğiniz sayıyı giriniz :");
            int deger2 = Convert.ToInt32(Console.ReadLine());
            int[] sayilar2 = new int[deger1];
                for (int i = 0; i < deger1; i++)
            {
                Console.WriteLine("Lütfen {0}. sayıyı giriniz", i+1);
             sayilar2[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (var item in sayilar2)
            {
             if(item%deger2==0)
                 Console.WriteLine("Sonucunuz :" +item);
            }
         //*********************************************************************************
         //Kullanıcıdan alınan pozitif tam sayı kadar kelimenin sondan başa doğru yazdırımı 

                Console.WriteLine("Lütfen kaç kelime yazmak istediğinizi sayı ile belirtin");
            int kelimesayisi = Convert.ToInt32(Console.ReadLine());
            string[] kelimeler = new string[kelimesayisi];
            for (int i = 0; i < kelimesayisi; i++)
            {
                Console.Write("Lütfen {0}. kelimeyi giriniz:" + " " , i+1);
            kelimeler[i] = Console.ReadLine();
             }
            Array.Reverse(kelimeler);
            Console.Write("Cümlenizin tersten yazılışı :");
            foreach (var item in kelimeler)
            {
                Console.Write(item + " ");
            }
        //***********************************************************************************
        //Kullanıcıdan alınan bir cümlenin kelime ve harf sayısının yazdırımı 
                Console.WriteLine(" ");
                Console.WriteLine("Lütfen Cümlenizi giriniz");
            string cumle = Console.ReadLine();
            string sonuc = null;
            for(int i = 0; i < cumle.Length; i++)
            {
                if(cumle[i] != ' ')
                {
                    sonuc += cumle[i];
                }
            }
                
            int harfsayisi = sonuc.Length;
            Console.WriteLine("Cümleniz {0} harften oluşmakta.", harfsayisi);

            string[] kelime;
                kelime = cumle.Split(" ");
            int kelimesayisi1 = kelime.Length;
            Console.WriteLine ("Cümleniz {0} kelimeden oluşmakta.", kelimesayisi1);
