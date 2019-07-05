using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Data.Entity;
using System.Security.Cryptography;
using libRegEntity;
using crud;

namespace libRegEntity
{
    public class Crud
    {
        public static int Insert_PhysicalPerson(string name, string email, decimal salary, DateTime dateBirth, char genre)
        {

            #region With explicit Transaction
            dbRegistrationContext context1 = new dbRegistrationContext();
            dbRegistrationContext context2 = new dbRegistrationContext();

            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    int id = 0;

                    try
                    {
                        id = context1.PERSON.Max(p => p.ID + 1);
                    }
                    catch (Exception)
                    {
                        id = 1;
                    } 

                    PERSON pes = new PERSON()
                    {
                        ID = id,
                        NAME = name,
                        EMAIL = email
                    };

                    context1.PERSON.Add(pes);

                    PHYSICALPERSON pp = new PHYSICALPERSON()
                    {
                        ID = pes.ID,
                        PERSON_ID = pes.ID,
                        SALARY = salary,
                        DATEBIRTH = dateBirth,
                        GENRE = genre.ToString()
                    };

                    context2.PHYSICALPERSON.Add(pp);

                    try
                    {
                        context1.SaveChanges();
                        context2.SaveChanges();
                        scope.Complete();
                        return 1;
                    }
                    catch (Exception)
                    {
                        return -1;
                    }
                }
            }
            catch (Exception)
            {
                return -1;
            }
            #endregion

            #region Without explicit Transaction
            /*
            using (dbRegistrationContext context = new dbRegistrationContext())
            {
                int id = context.PERSON.Max(p => p.ID + 1);

                PERSON pes = new PERSON()
                {
                    ID = id,
                    NAME = name,
                    EMAIL = email
                };

                PHYSICALPERSON pp = new PHYSICALPERSON()
                {
                    ID = pes.ID,
                    PERSON_ID = pes.ID,
                    SALARY = salary,
                    DATEBIRTH = dateBirth,
                    GENRE = genre.ToString()
                };

                context.PERSON.Add(pes);
                context.PHYSICALPERSON.Add(pp);
                context.SaveChanges();
                return 1;
            }
            */
            #endregion
            
        }

        public static int Edit_PhysicalPerson(int id, string name, string email, decimal salary, DateTime dateBirth, char genre)
        {
            dbRegistrationContext context1 = new dbRegistrationContext();
            dbRegistrationContext context2 = new dbRegistrationContext();

            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    PERSON pes = new PERSON()
                    {
                        ID = id,
                        NAME = name,
                        EMAIL = email
                    };

                    PHYSICALPERSON pp = new PHYSICALPERSON()
                    {
                        ID = pes.ID,
                        PERSON_ID = pes.ID,
                        SALARY = salary,
                        DATEBIRTH = dateBirth,
                        GENRE = genre.ToString()
                    };

                    context1.PERSON.Attach(pes);
                    context1.Entry(pes).State = EntityState.Modified;
                    context2.PHYSICALPERSON.Attach(pp);
                    context2.Entry(pp).State = EntityState.Modified;

                    try
                    {
                        context2.SaveChanges();
                        context1.SaveChanges();
                        scope.Complete();
                        return 1;
                    }
                    catch (Exception)
                    {
                        return -1;
                    }
                }
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public static int Delete_PhysicalPerson(int id)
        {
            dbRegistrationContext context1 = new dbRegistrationContext();
            dbRegistrationContext context2 = new dbRegistrationContext();

            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    PERSON pes = new PERSON()
                    {
                        ID = id
                    };


                    PHYSICALPERSON pp = new PHYSICALPERSON()
                    {
                        ID = pes.ID
                    };

                    context2.PHYSICALPERSON.Attach(pp);
                    context2.PHYSICALPERSON.Remove(pp);
                    context1.PERSON.Attach(pes);
                    context1.PERSON.Remove(pes);

                    try
                    {
                        context2.SaveChanges();
                        context1.SaveChanges();
                        scope.Complete();
                        return 1;
                    }
                    catch (Exception)
                    {
                        return -1;
                    }
                }
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public static List<PhysicalPerson> GetPhysicalPerson_ByName(string name)
        {
            try
            {
                using (dbRegistrationContext context = new dbRegistrationContext())
                {
                    var query = from p in context.PERSON
                                join pp in context.PHYSICALPERSON
                                on p.ID equals pp.PERSON_ID
                                where p.NAME.StartsWith(name)
                                select p;

                    List<PhysicalPerson> list = new List<PhysicalPerson>();

                    foreach (var item_p in query)
                    {
                        PhysicalPerson ppr = new PhysicalPerson();

                        ppr.Id = item_p.ID;
                        ppr.Name = item_p.NAME;
                        ppr.Email = item_p.EMAIL;

                        foreach (var item_pp in item_p.PHYSICALPERSON)
                        {
                            ppr.Salary = item_pp.SALARY;
                            ppr.DateBirth = item_pp.DATEBIRTH;
                            ppr.Genre = item_pp.GENRE[0];
                        }

                        list.Add(ppr);
                    }
                    return list;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static PhysicalPerson GetPhysicalPerson_ByID(int id)
        {
            try
            {
                using (dbRegistrationContext context = new dbRegistrationContext())
                {
                    var query = from p in context.PERSON
                                join pp in context.PHYSICALPERSON
                                on p.ID equals pp.PERSON_ID
                                where p.ID == id
                                select p;

                    PhysicalPerson ppr = new PhysicalPerson();

                    foreach (var item_p in query)
                    {
                        ppr.Id = item_p.ID;
                        ppr.Name = item_p.NAME;
                        ppr.Email = item_p.EMAIL;

                        foreach (var item_pp in item_p.PHYSICALPERSON)
                        {
                            ppr.Salary = item_pp.SALARY;
                            ppr.DateBirth = item_pp.DATEBIRTH;
                            ppr.Genre = item_pp.GENRE[0];
                        }
                    }
                    return ppr;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<PhysicalPerson> GetPhysicalPerson_SalaryAboveAVG()
        {
            try
            {
                using (dbRegistrationContext context = new dbRegistrationContext())
                {
                    decimal avg_sal = context.PHYSICALPERSON.Average(p => p.SALARY);

                    var query = from p in context.PERSON
                                join pp in context.PHYSICALPERSON
                                on p.ID equals pp.PERSON_ID
                                where pp.SALARY > avg_sal
                                select p;

                    List<PhysicalPerson> list = new List<PhysicalPerson>();

                    foreach (var item_p in query)
                    {
                        PhysicalPerson ppr = new PhysicalPerson();

                        ppr.Id = item_p.ID;
                        ppr.Name = item_p.NAME;
                        ppr.Email = item_p.EMAIL;

                        foreach (var item_pp in item_p.PHYSICALPERSON)
                        {
                            ppr.Salary = item_pp.SALARY;
                            ppr.DateBirth = item_pp.DATEBIRTH;
                            ppr.Genre = item_pp.GENRE[0];
                        }

                        list.Add(ppr);
                    }
                    return list;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<PhysicalPerson> GetPhysicalPerson_SalaryEqualAVG()
        {
            try
            {
                using (dbRegistrationContext context = new dbRegistrationContext())
                {
                    decimal avg_sal = context.PHYSICALPERSON.Average(p => p.SALARY);

                    var query = from p in context.PERSON
                                join pp in context.PHYSICALPERSON
                                on p.ID equals pp.PERSON_ID
                                where pp.SALARY == avg_sal
                                select p;

                    List<PhysicalPerson> list = new List<PhysicalPerson>();

                    foreach (var item_p in query)
                    {
                        PhysicalPerson ppr = new PhysicalPerson();

                        ppr.Id = item_p.ID;
                        ppr.Name = item_p.NAME;
                        ppr.Email = item_p.EMAIL;

                        foreach (var item_pp in item_p.PHYSICALPERSON)
                        {
                            ppr.Salary = item_pp.SALARY;
                            ppr.DateBirth = item_pp.DATEBIRTH;
                            ppr.Genre = item_pp.GENRE[0];
                        }

                        list.Add(ppr);
                    }
                    return list;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<PhysicalPerson> GetPhysicalPerson_SalaryUnderAVG()
        {
            {
                try
                {
                    using (dbRegistrationContext context = new dbRegistrationContext())
                    {
                        decimal avg_sal = context.PHYSICALPERSON.Average(p => p.SALARY);

                        var query = from p in context.PERSON
                                    join pp in context.PHYSICALPERSON
                                    on p.ID equals pp.PERSON_ID
                                    where pp.SALARY < avg_sal
                                    select p;

                        List<PhysicalPerson> list = new List<PhysicalPerson>();

                        foreach (var item_p in query)
                        {
                            PhysicalPerson ppr = new PhysicalPerson();

                            ppr.Id = item_p.ID;
                            ppr.Name = item_p.NAME;
                            ppr.Email = item_p.EMAIL;

                            foreach (var item_pp in item_p.PHYSICALPERSON)
                            {
                                ppr.Salary = item_pp.SALARY;
                                ppr.DateBirth = item_pp.DATEBIRTH;
                                ppr.Genre = item_pp.GENRE[0];
                            }

                            list.Add(ppr);
                        }
                        return list;
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public static List<PhysicalPerson> GetPhysicalPerson_ByBirthMonth(int month)
        {
            try
            {
                using (dbRegistrationContext context = new dbRegistrationContext())
                {
                    decimal avg_sal = context.PHYSICALPERSON.Average(p => p.SALARY);

                    var query = from p in context.PERSON
                                join pp in context.PHYSICALPERSON
                                on p.ID equals pp.PERSON_ID
                                where pp.DATEBIRTH.Month == month
                                select p;

                    List<PhysicalPerson> list = new List<PhysicalPerson>();

                    foreach (var item_p in query)
                    {
                        PhysicalPerson ppr = new PhysicalPerson();

                        ppr.Id = item_p.ID;
                        ppr.Name = item_p.NAME;
                        ppr.Email = item_p.EMAIL;

                        foreach (var item_pp in item_p.PHYSICALPERSON)
                        {
                            ppr.Salary = item_pp.SALARY;
                            ppr.DateBirth = item_pp.DATEBIRTH;
                            ppr.Genre = item_pp.GENRE[0];
                        }

                        list.Add(ppr);
                    }
                    return list;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<PhysicalPerson> GetPhysicalPerson_BySalaryRange(decimal sal1, decimal sal2)
        {
            try
            {
                using (dbRegistrationContext context = new dbRegistrationContext())
                {
                    decimal avg_sal = context.PHYSICALPERSON.Average(p => p.SALARY);

                    var query = from p in context.PERSON
                                join pp in context.PHYSICALPERSON
                                on p.ID equals pp.PERSON_ID
                                where pp.SALARY >= sal1 && pp.SALARY <= sal2 
                                select p;

                    List<PhysicalPerson> list = new List<PhysicalPerson>();

                    foreach (var item_p in query)
                    {
                        PhysicalPerson ppr = new PhysicalPerson();

                        ppr.Id = item_p.ID;
                        ppr.Name = item_p.NAME;
                        ppr.Email = item_p.EMAIL;

                        foreach (var item_pp in item_p.PHYSICALPERSON)
                        {
                            ppr.Salary = item_pp.SALARY;
                            ppr.DateBirth = item_pp.DATEBIRTH;
                            ppr.Genre = item_pp.GENRE[0];
                        }

                        list.Add(ppr);
                    }
                    return list;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static PhysicalPerson GetPhysicalPerson_HigherSalary()
        {
            try
            {
                using (dbRegistrationContext context = new dbRegistrationContext())
                {
                    decimal highSal = context.PHYSICALPERSON.Max(p => p.SALARY);

                    var query = from p in context.PERSON
                                join pp in context.PHYSICALPERSON
                                on p.ID equals pp.PERSON_ID
                                where pp.SALARY == highSal
                                select p;

                    PhysicalPerson ppr = new PhysicalPerson();

                    foreach (var item_p in query)
                    {
                        ppr.Id = item_p.ID;
                        ppr.Name = item_p.NAME;
                        ppr.Email = item_p.EMAIL;

                        foreach (var item_pp in item_p.PHYSICALPERSON)
                        {
                            ppr.Salary = item_pp.SALARY;
                            ppr.DateBirth = item_pp.DATEBIRTH;
                            ppr.Genre = item_pp.GENRE[0];
                        }
                    }
                    return ppr;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        
        public static PhysicalPerson GetPhysicalPerson_LowerSalary()
        {
            try
            {
                using (dbRegistrationContext context = new dbRegistrationContext())
                {
                    decimal lowSal = context.PHYSICALPERSON.Min(p => p.SALARY);

                    var query = from p in context.PERSON
                                join pp in context.PHYSICALPERSON
                                on p.ID equals pp.PERSON_ID
                                where pp.SALARY == lowSal
                                select p;

                    PhysicalPerson ppr = new PhysicalPerson();

                    foreach (var item_p in query)
                    {
                        ppr.Id = item_p.ID;
                        ppr.Name = item_p.NAME;
                        ppr.Email = item_p.EMAIL;

                        foreach (var item_pp in item_p.PHYSICALPERSON)
                        {
                            ppr.Salary = item_pp.SALARY;
                            ppr.DateBirth = item_pp.DATEBIRTH;
                            ppr.Genre = item_pp.GENRE[0];
                        }
                    }
                    return ppr;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        
        public static int Delete_UserSys(int id)
        {
            dbRegistrationContext context1 = new dbRegistrationContext();
            
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    USERSYS us = new USERSYS()
                    {
                        ID = id
                    };

                    context1.USERSYS.Attach(us);
                    context1.USERSYS.Remove(us);
              
                    try
                    {
                        context1.SaveChanges();
                        scope.Complete();
                        return 1;
                    }
                    catch (Exception)
                    {
                        return -1;
                    }
                }
            }
            catch (Exception)
            {
                return -1;
            }
        }
        
        public static Dictionary<string, int> GetCountPhysicalPerson_ByGenre()
        {
            try
            {
                Dictionary<string, int> data = new Dictionary<string, int>();
                    
                using (dbRegistrationContext context = new dbRegistrationContext())
                {
                    var countM = context.PHYSICALPERSON.Count(p => p.GENRE == "M");
                    var countF = context.PHYSICALPERSON.Count(p => p.GENRE == "F");
                    data.Add("M", countM);
                    data.Add("F", countF);
                }
                return data;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static int Insert_UserSys(string username, string userpass)
        {
            dbRegistrationContext context1 = new dbRegistrationContext();
            
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    int id = 0;

                    try
                    {
                        id = context1.USERSYS.Max(p => p.ID + 1);
                    }
                    catch (Exception)
                    {
                        id = 1;
                    }

                    var sha512 = new SHA512Managed();
                    var bytes = UTF8Encoding.UTF8.GetBytes(userpass);
                    var hash = sha512.ComputeHash(bytes);
                    var pass = Encoding.UTF8.GetString(hash);

                    USERSYS usu = new USERSYS()
                    {
                        ID = id,
                        USERNAME = username,
                        USERPASS = pass
                    };

                    context1.USERSYS.Add(usu);

                    try
                    {
                        context1.SaveChanges();
                        scope.Complete();
                        return 1;
                    }
                    catch (Exception)
                    {
                        return -1;
                    }
                }
            }
            catch (Exception)
            {
                return -1;
            }
        }
                
        public static int ToLog_UserSys(string username, string userpass)
        {
            try
            {
                using (dbRegistrationContext context = new dbRegistrationContext())
                {
                    var sha512 = new SHA512Managed();
                    var bytes = UTF8Encoding.UTF8.GetBytes(userpass);
                    var hash = sha512.ComputeHash(bytes);
                    var pass = Encoding.UTF8.GetString(hash);

                    var query = from usu in context.USERSYS
                                where usu.USERNAME == username  &&
                                usu.USERPASS == pass
                                select usu;
                                
                    if (query.Count() == 1)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}


