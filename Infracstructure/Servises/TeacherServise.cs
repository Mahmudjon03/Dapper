namespace Infracstructure.Servises;
using Dapper;
using Npgsql;
using Domain.Models;
public class TeacherServise
{
    string constr = " Server=localhost;Port=5432;Database=DapperDemo;User Id=postgres;Password=mahmud04;";

    public List<Teacher> GetTeacher(string name)
    {
        using (var con = new NpgsqlConnection(constr))
        {
            string sql = $"select * from Teachers ";
            if (name != null)
            {
                sql += $"where lower(first_name) like '%{name.ToLower()}%'";
            }
            var result = con.Query<Teacher>(sql);
            return result.ToList();
        }
    }
    public void Add(Teacher t)
    {
        using (var con = new NpgsqlConnection(constr))
        {
            var result = con.Execute($"insert into Teachers(first_name,last_name,specialty,age,salary) " +
            $"values('{t.first_name}','{t.last_name}','{t.specialty}','{t.age}','{t.salary}');");
            if (result == 1)
            {
                System.Console.WriteLine("Teacher add ");
            }
            else
            {
                System.Console.WriteLine("Error");
            }
        }

    }
    public void Delete(int a)
    {
        using (var conn = new NpgsqlConnection(constr))
        {
            string sql = $"delete from Teachers where id={a}";
            var f = conn.Execute(sql);
            if (f == 1)
            {
                System.Console.WriteLine("Teacher remove sucessfully");
            }
            else
            {
                System.Console.WriteLine("Error");
            }
        }

    }
    public void Update(Teacher t)
    {
        using (var conn = new NpgsqlConnection(constr))
        {
            string sql = $"  update Teachers set first_name ='{t.first_name}',last_name=' {t.last_name}',specialty='{t.specialty}'," +
            $"age={t.age},salary={t.salary} where id={t.id}";
            var f = conn.Execute(sql);
            if (f == 1)
            {
                System.Console.WriteLine("Update  sucessfully");
            }
            else
            {
                System.Console.WriteLine("Error");
            }
        }
    }
}

