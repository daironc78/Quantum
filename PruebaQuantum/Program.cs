using PruebaQuantum.BusinessLogic.FlatFile;
using PruebaQuantum.BusinessLogic.Multiple;
using PruebaQuantum.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace PruebaQuantum
{
    public class Program
    {
        static void Main(string[] args)
        {
            IFlatFile IFlatFile = new FlatFile();
            IMultiple IMultiple = new Multiple();
            IList<ModelFlatFile> modelFlatFile;
            string fullPath = @"D:\numbers.txt";
            try
            {
                if (File.Exists(fullPath))
                {
                    modelFlatFile = IFlatFile.ReadFlatFile(fullPath);
                    if (modelFlatFile != null)
                    {
                        modelFlatFile = IMultiple.MultipleThree(modelFlatFile);
                        IFlatFile.WriteFlatFile(fullPath,modelFlatFile);

                        Console.WriteLine("Para visualizar la salida del documento dirijase a la siguiente ruta: " + fullPath);
                    }
                    else
                    {
                        Console.WriteLine("Error leyendo el archivo");
                    }
                }
                else
                {
                    Console.WriteLine("No se ha encontrado el archivo por favor validar" + fullPath.Replace("bin", "Documents\\numbers.csv"));
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Ha ocurrido un error");
            }
            Console.ReadKey();
        }
    }
}
