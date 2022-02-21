using System;
using System.IO;
using System.Globalization;
using CsvHelper;
using CsvHelper.Configuration;
using System.Text;

namespace MoreumProje
{
    class Program
    {
        static void Main(string[] args)
        {
            //referanslarım
            //https://zetcode.com/csharp/csv/ csv formatındaki dosyayı okumak için kodları bu siteden aldım.

            var csvConfig = new CsvConfiguration(CultureInfo.CurrentCulture)
            {
                HasHeaderRecord = false,
                Comment = '#',
                AllowComments = true,
                Delimiter = ";",
            };

           using var streamReader = File.OpenText(@"C:\Users\sunay\Desktop\Data.csv");
           using var csvReader = new CsvReader(streamReader, csvConfig);

            var Bills = csvReader.GetRecords<BillProperty>();

            foreach (var b in Bills)
            {

               
                //Fatura Formatı
                StringBuilder billFormat = new StringBuilder();
                billFormat.Append($"Konu: {DateTime.Now.ToString("dd.MM.yyyy")} tarihli faturanız.");
                billFormat.Append(Environment.NewLine);
                billFormat.Append(Environment.NewLine);
                billFormat.Append(Environment.NewLine);
                billFormat.Append($"Sayın {b.Name} {b.SurName},");
                billFormat.Append(Environment.NewLine);
                billFormat.Append($"{b.BillNo} numaralı hizmet faturanız ekte gönderilmiştir. ");
                billFormat.Append(Environment.NewLine);
                billFormat.Append($"Bu dönem için fatura tutarınız: {b.Price} TL.");
                billFormat.Append(Environment.NewLine);
                billFormat.Append(Environment.NewLine);
                billFormat.Append(Environment.NewLine);
                billFormat.Append($"Saygılarımızla,");
                billFormat.Append(Environment.NewLine);
                billFormat.Append($"Moreum A.Ş.");

                //Faturaların Dosyaya yazılması
                StringBuilder billWayandName = new StringBuilder();
                billWayandName.Append($@"C:\Users\sunay\Desktop\Bills\{b.BillNo}.txt");
                FileStream fs = new FileStream(billWayandName.ToString(), FileMode.OpenOrCreate, FileAccess.Write);
                fs.Close();
                File.AppendAllText(fs.Name, billFormat.ToString());

                Console.WriteLine($"{b.BillNo}.txt");
            }



         
        }

      
    }
 }

   
