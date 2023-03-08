using InsuranceProgram.Layers.DAL;
using InsuranceProgram.Layers.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceProgram.Layers.BLL
{
    public class BLLClient
    {
        /// <summary>
        /// CRUD - Rewad
        /// </summary>
        /// <returns></returns>
        public static DataTable Read()
        {
            DALClient Data = new DALClient();
            return Data.Read();
        }

        /// <summary>
        /// Method to search a client in the Windows Form
        /// </summary>
        /// <param name="Value"></param>
        /// <returns></returns>
        public static DataTable Search(string Value)
        {
            DALClient Data = new DALClient();
            return Data.Search(Value);
        }

        /// <summary>
        /// CRUD - Create
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="FirstName"></param>
        /// <param name="LastName"></param>
        /// <param name="Nationality"></param>
        /// <param name="Gender"></param>
        /// <param name="DateOfBirth"></param>
        /// <param name="PhoneNumber"></param>
        /// <param name="Photo"></param>
        /// <param name="Address"></param>
        /// <param name="Email"></param>
        /// <returns></returns>
        public static string Insert(string Id, string FirstName, string LastName, int Nationality, string Gender,
                                    DateTime DateOfBirth, string PhoneNumber, byte[] Photo, string Address, string Email)
        {
            DALClient Data = new DALClient();

            string Exist = Data.Exist(Id);

            if (Exist.Equals("1"))
            {
                return "The Client already exists";
            }
            else
            {
                Client Obj = new Client();
                Obj.Identification = Id;
                Obj.FistName = FirstName;
                Obj.LastName = LastName;
                Obj.Nationality = Nationality;
                Obj.Gender = Gender;
                Obj.DateOfBirth = DateOfBirth;
                Obj.PhoneNumber = PhoneNumber;
                Obj.Photo = Photo;
                Obj.Address = Address;
                Obj.Email = Email;
                return Data.Insert(Obj);
            }
        }


        /// <summary>
        /// CRUD - Update
        /// </summary>
        /// <param name="PreviousId"></param>
        /// <param name="Id"></param>
        /// <param name="FirstName"></param>
        /// <param name="LastName"></param>
        /// <param name="Nationality"></param>
        /// <param name="Gender"></param>
        /// <param name="DateOfBirth"></param>
        /// <param name="PhoneNumber"></param>
        /// <param name="Photo"></param>
        /// <param name="Address"></param>
        /// <param name="Email"></param>
        /// <returns>string with the confirmation</returns>
        public static string Update(string PreviousId, string Id, string FirstName, string LastName, int Nationality, string Gender,
                                    DateTime DateOfBirth, string PhoneNumber, byte[] Photo, string Address, string Email)
        {
            DALClient Data = new DALClient();
            Client Obj = new Client();

            if (PreviousId.Equals(Id))
            {
                Obj.Identification = Id;
                Obj.FistName = FirstName;
                Obj.LastName = LastName;
                Obj.Nationality = Nationality;
                Obj.Gender = Gender;
                Obj.DateOfBirth = DateOfBirth;
                Obj.PhoneNumber = PhoneNumber;
                Obj.Photo = Photo;
                Obj.Address = Address;
                Obj.Email = Email;
                return Data.Update(Obj);
            }
            else
            {
                string Exist = Data.Exist(Id);
                if (Exist.Equals("1"))
                {
                    return "The client already exists";
                }
                else
                {
                    Obj.Identification = Id;
                    Obj.FistName = FirstName;
                    Obj.LastName = LastName;
                    Obj.Nationality = Nationality;
                    Obj.Gender = Gender;
                    Obj.DateOfBirth = DateOfBirth;
                    Obj.PhoneNumber = PhoneNumber;
                    Obj.Photo = Photo;
                    Obj.Address = Address;
                    return Data.Update(Obj);
                }
            }
        }

        /// <summary>
        /// CRUD - Delete
        /// Table Client
        /// </summary>
        /// <param name="Id"></param>
        /// <returns>string with the confirmation</returns>
        public static string Delete(string Id)
        {
            DALClient Data = new DALClient();
            return Data.Delete(Id);
        }

        public static string Activate(string Id)
        {
            DALClient Data = new DALClient();
            return Data.Activate(Id);
        }

        public static string Deactivate(string Id)
        {
            DALClient Data = new DALClient();
            return Data.Deactivate(Id);
        }
    }
}
