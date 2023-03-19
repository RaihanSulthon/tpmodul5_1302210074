// See https://aka.ms/new-console-template for more information
namespace TP_MOD5_KPL_1302210074
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            HaloGeneric<String> sapa= new HaloGeneric<String>();

            String X = "Raihan Sulthon";

            sapa.SapaUSer(X);

            DataGeneric<String> data_saved = new DataGeneric<string>("1302210074");

            data_saved.PrintData();
        }
    }
}
