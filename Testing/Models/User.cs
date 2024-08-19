using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing.Models;

public class User
{
    public Guid id { get; set; }
    public string name { get; set; }
    public string email { get; set; }
    public List<Profile> profiles { get; set; }

    public User()
    {
        profiles = new List<Profile>();
    }

}

public class Profile
{
    public int id { get; set; }
    public string name { get; set; }
}

