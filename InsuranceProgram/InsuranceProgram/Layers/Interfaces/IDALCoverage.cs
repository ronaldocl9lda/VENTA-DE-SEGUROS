using InsuranceProgram.Layers.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceProgram.Layers.Interfaces
{
    interface IDALCoverage
    {
        string Update(Coverage Obj);
        string Read(int PlanId);
        string Insert(Coverage Obj);
        string Delete(int Id);
        string Exist(int Value);
        string Deactivate(int Id);
        string Activate(int Id);
    }
}
