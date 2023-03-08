using InsuranceProgram.Layers.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceProgram.Layers.Interfaces
{
    interface IDALPolicy
    {
        string Activate(int Id);
        string Deactivate(int Id);
        string Delete(int Id);
        string Exist(int Value);
        string Insert(Policy Obj);
        DataTable Read();
        DataTable Read(int Code);
        string Update(Policy Obj);
    }
}
