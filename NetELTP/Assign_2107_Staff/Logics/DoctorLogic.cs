using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assign_2107_Staff.Entities;
using Assign_2107_Staff.Database;

namespace Assign_2107_Staff.Logics
{
    public class DoctorLogic : StaffLogic
    {

        List<Doctor> doctors = new List<Doctor>();

        public override Dictionary<int,Staff> RegisterStaff(int id,Staff staff)
        {
            HospitalDbStore.GlobalStafflist.Add(id,staff);
            return HospitalDbStore.GlobalStafflist;
        }

        public override Dictionary<int, Staff> GetStaff()
        {
            return HospitalDbStore.GlobalStafflist;
        }

        public override Dictionary<int, Staff> DeleteStaff(int id)
        {
            foreach (var item in HospitalDbStore.GlobalStafflist.Values)
            {
                var p = (Doctor)item;int countObj = 0;
                
                if(p.StaffId == id)
                {
                    HospitalDbStore.GlobalStafflist.Remove(id);

                }
                return HospitalDbStore.GlobalStafflist;


            }

            return HospitalDbStore.GlobalStafflist; ;
        }


        public override Dictionary<int, Staff> UpdateStaff(int id, Staff dr)
        {
            foreach (var item in HospitalDbStore.GlobalStafflist)
            {

                var v = (Doctor)item.Value;
                if (item.Value.StaffId == id)
                {

                    String wish = "y";

                    do
                    {
                        Console.WriteLine("====================================================");

                        Console.WriteLine("Press 1 to update name");
                        //Console.WriteLine("Press 2 to update email");
                        Console.WriteLine("Press 2 specialization");
                        Console.WriteLine("Press 3 to update education");
                        int updatedChoice = Convert.ToInt32(Console.ReadLine());

                        switch (updatedChoice)
                        {
                            case 1:
                                Console.WriteLine("Enter updated name");
                                String newName = Console.ReadLine();

                                v.StaffName = newName;
                                break;

                            //case 2:
                            //    Console.WriteLine("Enter updated mail");
                            //    String newMail = Console.ReadLine();

                            //    item.Email = newMail;
                            //    break;

                            //case 3:
                            //    Console.WriteLine("Enter updated department");
                            //    String newDept = Console.ReadLine();

                            //    item.DeptName = newDept;
                            //    break;

                            case 2:
                                Console.WriteLine("Enter updated specialization");
                                String newSpecialization = Console.ReadLine();

                                v.Specialization = newSpecialization;
                                break;


                            case 3:
                                Console.WriteLine("Enter updated education");
                                String newEdu = Console.ReadLine();

                                v.Education = newEdu;
                                break;

                            //case 8:
                            //    Console.WriteLine("Enter updated contact");
                            //    int newContact = Convert.ToInt32(Console.ReadLine());

                            //    item.ContatNo = newContact;
                            //    break;
                        }

                        Console.WriteLine("Press \"y\" or \"Y\" to continue updating records");
                        wish = Console.ReadLine();
                    } while (wish == "y" || wish == "Y");

                }
                //else
                //{
                //    Console.WriteLine("Record not found!! Please enter valid ID.");
                //    break;

                //}
            }
            return HospitalDbStore.GlobalStafflist;
        }


        //==================================================================================================


    }
}
