using PruebaQuantum.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaQuantum.BusinessLogic.FlatFile
{
    public interface IFlatFile
    {
        public IList<ModelFlatFile> ReadFlatFile(string Route);
        public void WriteFlatFile(string Route, IList<ModelFlatFile> modelFlatFiles);
    }
}
