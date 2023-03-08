using InsuranceProgram.Layers.Entities;
using InsuranceProgram.Layers.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceProgram.Layers.BLL
{
    public class BLLUser
    {
        /// <summary>
        /// Method that is used to read the Table User
        /// </summary>
        /// <returns></returns>
        public static DataTable Read()
        {
            DALUser Data = new DALUser();
            return Data.Read();
        }

        /// <summary>
        /// Method that is used to search an User by its name or Identification
        /// </summary>
        /// <param name="Value"></param>
        /// <returns></returns>
        public static DataTable Search(string Value)
        {
            DALUser Data = new DALUser();
            return Data.Search(Value);
        }
        /// <summary>
        /// Method to login with the account
        /// </summary>
        /// <param name="UserId"></param>
        /// <param name="Password"></param>
        /// <returns></returns>
        public static DataTable Login(string UserId, string Password)
        {
            DALUser Data = new DALUser();
            return Data.Login(UserId, Password);
        }
        /// <summary>
        /// Method Insert so that the information can be saved on database.
        /// The Password is protected by security in database
        /// </summary>
        /// <param name="UserId"></param>
        /// <param name="RoleId"></param>
        /// <param name="Name"></param>
        /// <param name="Password"></param>
        /// <param name="Photo"></param>
        /// <returns></returns>
        public static string Insert(string UserId, int RoleId, string Name, string Password, byte[] Photo)
        {
            DALUser Data = new DALUser();

            string Exist = Data.Exist(UserId);

            if (Exist.Equals("1"))
            {
                return "The User already exists";
            }
            else
            {
                User Obj = new User();
                Obj.ID = UserId;
                Obj.RoleId = RoleId;
                Obj.Name = Name;
                Obj.Password = Password;
                Obj.Photo = Photo;
                return Data.Insert(Obj);
            }
        }

        /// <summary>
        /// Method Insert so that the information can be saved on database.
        /// The Password is protected by security in database
        /// </summary>
        /// <param name="UserId"></param>
        /// <param name="RoleId"></param>
        /// <param name="Name"></param>
        /// <param name="Password"></param>
        /// <param name="Photo"></param>
        /// <returns></returns>
        public static string Update(string PreviousUserId, string UserId, int RoleId, string Name, string Password, byte[] Photo)
        {
            DALUser Data = new DALUser();
            User Obj = new User();

            if (PreviousUserId.Equals(UserId))
            {
                Obj.ID = UserId;
                Obj.RoleId = RoleId;
                Obj.Name = Name;
                Obj.Password = Password;
                Obj.Photo = Photo;
                return Data.Update(Obj);
            }
            else
            {
                string Exist = Data.Exist(UserId);
                if (Exist.Equals("1"))
                {
                    return "The user already exists";
                }
                else
                {
                    Obj.ID = UserId;
                    Obj.RoleId = RoleId;
                    Obj.Name = Name;
                    Obj.Password = Password;
                    Obj.Photo = Photo;
                    return Data.Update(Obj);
                }
            }
        }

        /// <summary>
        /// Method that can be used to delete an User
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public static string Delete(int Id)
        {
            DALUser Data = new DALUser();
            return Data.Delete(Id);
        }

        /// <summary>
        /// Method that can be used to active an User
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public static string Activate(int Id)
        {
            DALUser Data = new DALUser();
            return Data.Activate(Id);
        }

        /// <summary>
        /// Method that can be used to desactivate an User
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public static string Deactivate(int Id)
        {
            DALUser Data = new DALUser();
            return Data.Deactivate(Id);
        }
    }
}
