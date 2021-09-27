using PruebaQuantum.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;

namespace PruebaQuantum.BusinessLogic.FlatFile
{
    public class FlatFile : IFlatFile
    {
        public IList<ModelFlatFile> ReadFlatFile(string Route)
        {
            IList<ModelFlatFile> ListFlatFile = new List<ModelFlatFile>();
            StreamReader FlatFile = new StreamReader(Route);
            try
            {
                var Line = FlatFile.ReadLine();
                while (!FlatFile.EndOfStream)
                {
                    ListFlatFile.Add(new ModelFlatFile { Number = Line });
                    Line = FlatFile.ReadLine();
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                FlatFile.Close();
            }
            
            return ListFlatFile;
        }

        public void WriteFlatFile(string route, IList<ModelFlatFile> modelFlatFiles)
        {
            StreamWriter FlatFile = new StreamWriter(route);
            try
            {
                foreach (var row in modelFlatFiles)
                {
                    FlatFile.WriteLine(row.Number + ";" + row.IsMultipleThree);
                    Console.WriteLine(row.Number + ": " + row.IsMultipleThree + " es multiplo de 3");
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                FlatFile.Flush();
                FlatFile.Close();
            }
        }
    }
}
