using InsuranceProgram.Layers.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceProgram.Layers.Interfaces
{
    interface IDALUser
    {
        DataTable Read();
        DataTable Search(string Value);
        DataTable Login(string UserId, string Password);
        string Exist(string Value);
        string Insert(User Obj);
        string Update(User Obj);
        string Delete(int Id);
        string Activate(int Id);
        string Deactivate(int Id);
    }
}
