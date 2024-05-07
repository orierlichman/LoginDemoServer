using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace LoginDemoServer.Models;

public partial class LoginDemoDbContext : DbContext
{
    public Models.User GetUSerFromDB(string email)
    {
        Models.User user = this.Users.Where(u => u.Email == email).FirstOrDefault();
        return user;
    }

    public List<Grade> GetUserGrades(string email)
    {
        List<Grade> userGrades = new List<Grade>();
        foreach (Grade g in this.Grades)
        {
            if (g.Email == email)
            {
                userGrades.Add(g);
            }
        }
        return userGrades;
    }

}

