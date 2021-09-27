using PruebaQuantum.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaQuantum.BusinessLogic.Multiple
{
    public interface IMultiple
    {
        public IList<ModelFlatFile> MultipleThree(IList<ModelFlatFile> modelArchivo);
    }
}
