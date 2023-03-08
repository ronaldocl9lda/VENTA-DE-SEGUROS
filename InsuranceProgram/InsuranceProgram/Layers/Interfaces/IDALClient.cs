using InsuranceProgram.Layers.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceProgram.Layers.Interfaces
{
    interface IDALClient
    {
        DataTable Read();
        DataTable Search(string Value);
        string Exist(string Value);
        string Insert(Client Obj);
        string Update(Client Obj);
        string Delete(string Id);
        string Activate(string Id);
        string Deactivate(string Id);
    }
}
