using InsuranceProgram.Layers.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceProgram.Layers.Interfaces
{
    interface IDALBill
    {
        DataTable Read();
        DataTable Search(string Value);
        string Insert(Bill Obj);
        string Cancel(int Id);
    }
}
