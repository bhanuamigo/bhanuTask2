using Program.Model.modl;
using PROGRAM.DOMINE.domine;
namespace PROGRAM.UI.ui
{


class ui 
{
   public void viewing(){
   
        Console.WriteLine("\n PROLIFICS PROJECT MANAGEMENT");
        Console.WriteLine("");
        Console.Write("Enter 1 for add project");
        Console.WriteLine("        Enter 2 to view all projects");
        Console.WriteLine("");
        Console.Write("Enter 3 for addEmployee");
        Console.WriteLine("        Enter 4 for view all Employees");
        Console.WriteLine("");
        Console.Write("Enter 5 for add Role");
        Console.WriteLine("             Enter 6 for view all Roles");
        Console.WriteLine("");
        Console.Write("Enter 7 for search project");
        Console.WriteLine("       Enter 8 for search project through id");
        Console.WriteLine("");
        Console.Write("Enter 9 to view all projects");
        Console.WriteLine("        Enter 10 add project to employee ");
        Console.WriteLine("");
        Console.WriteLine("           Enter x to exit application           ");
        Projectdata obj = new Projectdata();
        Employee employee = new Employee();
        Project project = new Project();
        EmpManagement obj1 = new EmpManagement();
        RoleManagement objmain = new RoleManagement();
        // AddingEmpProject obj3 = new AddingEmpProject();
        objmain.RoleList.Add(new Role(1,"Manager"));
        objmain.RoleList.Add(new Role(2,"Asst.Manger"));
        objmain.RoleList.Add(new Role(3,"Software Engineer" ));
        objmain.RoleList.Add(new Role(4,"Associate Software Engineer" ));
        objmain.RoleList.Add(new Role(5,"Trainee Software Engineer" ));


        Console.WriteLine("");
        var read = Console.ReadLine();
        while (true)
        {
            switch (read)
            {
                case "1":
                    Console.WriteLine("");
                    Console.WriteLine("");
                    try
                    {
                        Console.WriteLine("Enter Project Id");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the name of project");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter start date of project");
                        string start = Console.ReadLine();
                        Console.WriteLine("Enter start date of project");
                        string end = Console.ReadLine();
                        Project project1 = new Project(name, start, end, id);
                        project = project1;
                        obj.Addproject(project);
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine(" PROJECT Added Successfully!");
                        Console.WriteLine("");
                        Console.WriteLine("Enter any key for main menu");
                        Console.ReadLine();
                    }
                    catch (Exception )
                    {
                        Console.WriteLine("\nError : Only use number for id");

                    }

                    break;
                case "2":
                    obj.viewAllProjects();
                     Console.WriteLine("Enter any key to get back  to main menu");
                    Console.ReadLine();
                    break;



                case "3":
                    Console.WriteLine("");
                    Console.WriteLine("Enter the Id of employee");
                    int empId = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter employee first name");
                    string fname = Console.ReadLine();
                    Console.WriteLine("Enter employee last name");
                    string lname = Console.ReadLine();
                    Console.WriteLine("Enter employee email id");
                    string EMAIL = Console.ReadLine();
                    Console.WriteLine("Enter employee mobile number");
                    string m_number = Console.ReadLine();
                    Console.WriteLine("Enter address of the employee");
                    string address = Console.ReadLine();
                    Console.WriteLine("Select 1 add role ID to employe");
                    Console.WriteLine("Select 2 for new  role to the employee");
                    int selecting = Convert.ToInt32(Console.ReadLine());
                    if (selecting == 1)
                    {
                        try
                        {
                           objmain.displayRole();
                            Console.WriteLine("Select Role id from above list to assign role to employee");
                            int r1 = Convert.ToInt32(Console.ReadLine());
                            string? rN1 = null;
                            switch (r1)
                            {
                                case 1:
                                    rN1 = "Manager";
                                    break;
                                case 2:
                                    rN1 = " Asst.Manager";
                                    break;
                                case 3:
                                    rN1 = " Software Engineer";
                                    break;
                                case 4:
                                    rN1 = " Associate Software Engineer";
                                    break;
                                case 5:
                                    rN1 = "Trainee Software Engineer";
                                    break;
                                default:
                                    Console.WriteLine("Invalid Entry");
                                    break;
                            }
                            Employee eadd = new Employee(empId, fname, lname, EMAIL, m_number, address, r1, rN1);
                            obj1.AddEmp(eadd);
                            employee = eadd;
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("Added Successfully!");
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Emp ID in formate eg: 1234 ");
                        }
                    }
                    else if (selecting == 2)
                    {
                        try
                        {
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("Enter  Role Id");
                            int roleID = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter  name of the  Role");
                            string role_name = Console.ReadLine();
                            Console.WriteLine(role_name);
                            Role newRole = new Role(roleID, role_name);
                            objmain.RoleAdd(newRole);
                            Employee eadd = new Employee(empId, fname, lname, EMAIL, m_number, address, roleID, role_name);
                            obj1.AddEmp(eadd);
                            employee = eadd;
                            Console.WriteLine("");
                            Console.WriteLine("...Added Successfully...");
                        }
                        catch (Exception)
                        {

                            Console.WriteLine("Role Id should be  numbers");
                        }
                    }
                            Console.WriteLine("");
                            Console.WriteLine("Enter any key to get back to main menu");
                            Console.ReadLine();
                            break;
                case "4":
                    obj1.ShowEmp();
                    Console.WriteLine("Enter any key to get back  to main menu");
                    Console.ReadLine();
                    break;
                case "5":
                    try
                    {
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("Enter  Role Id");
                        int roleID = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter name of the  Role");
                        string role_name = Console.ReadLine();
                        Console.WriteLine(role_name);
                        Role newRole = new Role(roleID, role_name);
                        objmain.RoleAdd(newRole);
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("...Added Successfully...");
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Role Id should only be in number formate ");
                    }
                    Console.WriteLine("");
                    Console.WriteLine("Enter any key to get  back to main menu");
                    Console.ReadLine();
                    break;

                case "6":
                    objmain.displayRole();
                    Console.WriteLine("Enter any key to get back  to main menu");
                    Console.ReadLine();
                    break;

                case "7":
                    Console.WriteLine("search for project");
                    read = Console.ReadLine();
                    obj.SearchProject(read);
                    Console.WriteLine("Enter any key to get to main menu");
                    Console.ReadLine();
                    break;

                case "8":
                    try
                    {
                        Console.WriteLine("Search via project id");
                        Console.WriteLine("Enter  id of project");
                        int eid = Convert.ToInt32(Console.ReadLine());
                        obj.ShowProject(eid);
                        Console.WriteLine();
                        Console.WriteLine("Enter any key to get back to main menu");
                    }
                    catch (Exception ) { Console.WriteLine("Id should be in numbers formate"); }
                    break;

                case "9":
                    obj.viewAllProjects();
                    Console.WriteLine("Enter any key to get back  to main menu");
                    Console.ReadLine();
                    break;
                /*case "10":

                    Console.WriteLine("");
                    obj.viewAllProjects();
                    Console.WriteLine("PROJECT LIST");
                    Console.WriteLine();
                    obj1.ShowEmp();
                    Console.WriteLine(" EMPLOYEE LIST");
                    Console.WriteLine("Enter PROJECT NAME from above list exactly");
                    var PROJname = Console.ReadLine();
                    Console.WriteLine("Enter EMPLOYEE ID to merge with PROJECT");
                    int EMPID = Convert.ToInt32(Console.ReadLine());
                    if(PROJname == project.ProjectName && EMPID == employee.EmployeeID)
                    {
                        AddEmpProject Merging = new AddEmpProject(PROJname, EMPID);
                        AddingEmpProject merge = new AddingEmpProject();
                        merge.addingemp(Merging);
                        Console.WriteLine("Added success");
                    }
                    else
                    {
                        Console.WriteLine("Invalid Entry bro");
                    }
                    var Read = Console.ReadLine();
                    break;*/
                case "x":
                    return;
                default:
                    Console.WriteLine("Invalid entry");
                    break;
            }
        Console.WriteLine("\n PROLIFICS PROJECT MANAGEMENT");
        Console.WriteLine("");
        Console.Write("Enter 1 for add project");
        Console.WriteLine("        Enter 2 to view all projects");
        Console.WriteLine("");
        Console.Write("Enter 3 for addEmployee");
        Console.WriteLine("        Enter 4 for view all Employees");
        Console.WriteLine("");
        Console.Write("Enter 5 for add Role");
        Console.WriteLine("             Enter 6 for view all Roles");
        Console.WriteLine("");
        Console.Write("Enter 7 for search project");
        Console.WriteLine("       Enter 8 for search project through id");
        Console.WriteLine("");
        Console.Write("Enter 9 to view all projects");
        Console.WriteLine("        Enter 10 add project to employee ");
        Console.WriteLine("");
        Console.WriteLine("           Enter x to exit application           "); 
        Console.WriteLine("Select operation from above list");
        read = Console.ReadLine();
        }
    }
   }

}
