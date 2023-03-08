using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceProgram.Layers.Interfaces
{
    interface IDAL_IVA
    {
        DataTable Read();
        string Update(float Value);
    }
}
