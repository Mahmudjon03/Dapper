using Domain.Models;
using Infracstructure.Servises;
var ct = new StudentServise();
var tch = new TeacherServise();
var Emp = new EmployeeServise();
while (true)
{
    int d;
    System.Console.WriteLine("1: Teachers");
    System.Console.WriteLine("2: Student");
    System.Console.WriteLine("3: Employee");
    d = Convert.ToInt32(Console.ReadLine());
    if (d == 1)
    {
        while (true)
        {
            int n;
            System.Console.WriteLine();
            System.Console.WriteLine("1 for get teacher");
            System.Console.WriteLine("2 for add teacher");
            System.Console.WriteLine("3 for delete teacher");
            System.Console.WriteLine("4 for update teacher");
            System.Console.WriteLine("5 for exet program");
            System.Console.WriteLine();
            n = Convert.ToInt32(Console.ReadLine());
            if (n == 1)
            {
                string name;
                name = Console.ReadLine();
                var lis = tch.GetTeacher(name);
                System.Console.WriteLine("id----------firstname---------lastname----------specialty-----------age------------salary");
                foreach (var i in lis)
                {
                    System.Console.WriteLine();
                    System.Console.WriteLine($"{i.id}    |   {i.first_name}     |     {i.last_name}     |     {i.specialty}    |    {i.age}     |     {i.salary}");

                }
            }
            else if (n == 2)
            {
                var tc = new Teacher();
                System.Console.Write("firstname:");
                tc.first_name = Console.ReadLine();
                System.Console.Write("lastname:");
                tc.last_name = Console.ReadLine();
                System.Console.Write("specialty:");
                tc.specialty = Console.ReadLine();
                System.Console.Write("age:");
                tc.age = Convert.ToInt16(Console.ReadLine());
                System.Console.Write("salary:");
                tc.salary = Convert.ToInt16(Console.ReadLine());
                System.Console.WriteLine();
                tch.Add(tc);
            }
            else if (n == 3)
            {
                int y;
                y = Convert.ToInt32(Console.ReadLine());
                tch.Delete(y);
            }
            else if (n == 4)
            {
                var t = new Teacher();
                System.Console.Write("id: ");
                t.id = Convert.ToInt32(Console.ReadLine());
                System.Console.Write("firstname:");
                t.first_name = Console.ReadLine();
                System.Console.Write("lastname:");
                t.last_name = Console.ReadLine();
                System.Console.Write("specialty:");
                t.specialty = Console.ReadLine();
                System.Console.Write("age:");
                t.age = Convert.ToInt16(Console.ReadLine());
                System.Console.Write("salary:");
                t.salary = Convert.ToInt16(Console.ReadLine());
                System.Console.WriteLine();
                tch.Update(t);
            }
            else if (n == 5)
            {
                break;
            }
        }

    }
    if (d == 2)
    {
        while (true)
        {
            int s;
            System.Console.WriteLine();
            System.Console.WriteLine("1 for get student");
            System.Console.WriteLine("2 for add student");
            System.Console.WriteLine("3 for delete student");
            System.Console.WriteLine("4 for update student");
            System.Console.WriteLine("5 for exet program");
            System.Console.WriteLine();
            s = Convert.ToInt32(Console.ReadLine());
            if (s == 1)
            {
                string name;
                name = Console.ReadLine();
                var lis = ct.GetStudent(name);
                System.Console.WriteLine("id----------firstname---------lastname----------phone");
                foreach (var i in lis)
                {
                    System.Console.WriteLine();
                    System.Console.WriteLine($"{i.Id}    |   {i.first_name}     |     {i.last_name}     |     {i.phone}");

                }
            }
            else if (s == 2)
            {
             
                var ct1 = new Students();
                System.Console.Write("firstname:");
                ct1.first_name = Console.ReadLine();
                System.Console.Write("lastname:");
                ct1.last_name = Console.ReadLine();
                System.Console.Write("phone:");
                ct1.phone = Console.ReadLine();
                System.Console.WriteLine();
                ct.AddStudent(ct1);
                System.Console.WriteLine();
            }
            else if (s == 3)
            {
                int t = 0;
                t = Convert.ToInt32(Console.ReadLine());
                System.Console.WriteLine();
                ct.Delete(t);
                System.Console.WriteLine();

            }
            else if (s == 4)
            {
                int l;
                System.Console.Write("id: ");
                l = Convert.ToInt32(Console.ReadLine());

                var st = new Students();
                System.Console.Write("firstname: ");
                st.first_name = Console.ReadLine();
                System.Console.Write("lastname: ");
                st.last_name = Console.ReadLine();
                Console.Write("phone: ");
                st.phone = Console.ReadLine();
                System.Console.WriteLine();
                ct.Update(l, st);
                System.Console.WriteLine();
            }
            else if (s == 5)
            {
                break;
            }

        }
    }
    else if (d == 3)
    {
        while (true)
        {
            int f;
            System.Console.WriteLine();
            System.Console.WriteLine("1 for get employee");
            System.Console.WriteLine("2 for add employee");
            System.Console.WriteLine("3 for delete employee");
            System.Console.WriteLine("4 for update employee");
            System.Console.WriteLine("5 for exet program");
            System.Console.WriteLine();
            f = Convert.ToInt32(Console.ReadLine());
            if (f == 1)
            {
                string t;
                t = Console.ReadLine();
                var emp = Emp.Get(t);
                    System.Console.WriteLine("Id-------------firstname-----------lastname---------age----------salary");
                foreach (var m in emp)
                {
                System.Console.WriteLine($"{m.id}          {m.first_name}          {m.last_name}           {m.age}          {m.salary}");
                }
            }else if(f==2){
                var emp= new Employee();
                System.Console.Write("firstname:");
                emp.first_name = Console.ReadLine();
                System.Console.Write("lastname:");
                emp.last_name = Console.ReadLine();
                System.Console.Write("age:");
                emp.age = Convert.ToInt16(Console.ReadLine());
                System.Console.Write("salary:");
                emp.salary=Convert.ToInt16(Console.ReadLine());
                System.Console.WriteLine();
                Emp.Add(emp);
                System.Console.WriteLine();
             }else if(f==4){
               
                var emp= new Employee();
                System.Console.Write("id:");
                emp.id = Convert.ToInt16(Console.ReadLine());
                System.Console.Write("firstname:");
                emp.first_name = Console.ReadLine();
                System.Console.Write("lastname:");
                emp.last_name = Console.ReadLine();
                System.Console.Write("age:");
                emp.age = Convert.ToInt16(Console.ReadLine());
                System.Console.Write("salary:");
                emp.salary=Convert.ToInt16(Console.ReadLine());
                System.Console.WriteLine();
                Emp.Update(emp);
                }else if(f==3){
                    int y;
                    y=Convert.ToInt16(Console.ReadLine());
                    Emp.Delete(y);
                }

                else if(f==5){
                int t; 
                t=Convert.ToInt16(Console.ReadLine());

                var w=Emp.GetById(t);
                foreach (var m in w )
                {
                System.Console.WriteLine($"{m.id}       {m.first_name}         {m.last_name}       {m.age}         {m.salary}");
                    
                }
             }else if(f==6){
                    break;
                }
        }

    }
}