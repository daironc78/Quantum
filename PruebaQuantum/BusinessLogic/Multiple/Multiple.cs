using PruebaQuantum.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaQuantum.BusinessLogic.Multiple
{
    public class Multiple : IMultiple
    {
        public IList<ModelFlatFile> MultipleThree(IList<ModelFlatFile> modelArchivo)
        {
            IList<ModelFlatFile> ListFlatFile = new List<ModelFlatFile>();
            
            try
            {
                foreach (var item in modelArchivo)
                {
                    long Result = 0;
                    string NumberString = item.Number;

                    while (Result == 0 || Result >= 10)
                    {
                        List<char> datalist = new List<char>();
                        datalist.AddRange(NumberString);

                        foreach (var numero in datalist)
                            Result = Result + Convert.ToInt32(numero.ToString());

                        if (Result >= 10)
                        {
                            NumberString = Result.ToString();
                            Result = 0;
                        }
                    }

                    if (Result == 3 || Result == 6 || Result == 9)
                        ListFlatFile.Add(new ModelFlatFile { Number = item.Number, IsMultipleThree = "Si" });
                    else if ((long)Convert.ToDouble(item.Number.Trim())% 3 == 0)
                        ListFlatFile.Add(new ModelFlatFile { Number = item.Number, IsMultipleThree = "Si" });
                    else
                        ListFlatFile.Add(new ModelFlatFile { Number = item.Number, IsMultipleThree = "No" });
                }

                foreach (var item in modelArchivo)
                {
                    
                }
            }
            catch (Exception)
            {

                throw;
            }

            return ListFlatFile;
        }
    }
}
