using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _grupaV_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {

                Automobil automobil = new Automobil(
                    "AutomobilReg", "AutomobilProizv", "AutomobilModel");
                Automobil automobil1 = new Automobil(
                    "AutomobilReg1", "AutomobilProizv1", "AutomobilModel1");
                Autobus autobus = new Autobus(
                    "AutobusReg", "AutobusProizv", "AutobusModel", 50);

                Kamion.initBrMesta(3); // bez ove linije => exception
                Kamion kamion = new Kamion(
                    "KamionReg", "KamionProizv", "KamionModel", 1.5d);
                Kamion kamion1 = new Kamion(
                     "KamionReg1", "KamionProizv1", "KamionModel1", 1.5d);

                Parking parking1 = new Parking(5, 5);

                Kamion.initBrMesta(100);

                parking1.uparkirajVozilo(autobus);
                parking1.uparkirajVozilo(kamion);
                parking1.uparkirajVozilo(automobil);
                parking1.uparkirajVozilo(autobus);
                parking1.uparkirajVozilo(kamion1);
                parking1.uparkirajVozilo(kamion1);
                parking1.uparkirajVozilo(automobil1);
                // parking1.uparkirajVozilo(kamion1);

                Console.WriteLine("\t\tParking prvi pocetak[{0}]:\n\n{1}", parking1.BrojVozila, parking1);

                parking1.upisiBin(@"C:\Users\Mihajlo\Videos\_prog_jez\c#\vs\LaboratorijskeCTaraba\_grupaV_Parking\mojbinfajl.bin");

                Parking parking2 = new Parking(2, 2); // namerno dimenzija 2-2

                parking1.isparkirajVozilo(kamion);
                parking1.isparkirajVozilo(automobil);
                parking1.isparkirajVozilo(kamion1);

                parking1.uparkirajVozilo(automobil1);

                parking2.procitajBin(@"C:\Users\Mihajlo\Videos\_prog_jez\c#\vs\LaboratorijskeCTaraba\_grupaV_Parking\mojbinfajl.bin");

                Console.WriteLine("\t\tParking prvi konacno[{0}]:\n\n{1}", parking1.BrojVozila, parking1);
                Console.WriteLine("\t\tParking drugi konacno[{0}]:\n\n{1}", parking2.BrojVozila, parking2);

            }
            catch (NemaMesta ex)
            {
                Console.WriteLine(ex.Message + "\n" + ex.StackTrace);
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message + "\n" + ex.StackTrace);
            }

        }
    }
}
