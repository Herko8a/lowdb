
# LowDB


- Define a path for the JSON file.
- Create a SyncFile adapter using the defined path.
- Instantiate a lowDB object, passing the adapter, and assign the object model.
- Use LINQ for CRUD operations.

### Versions

* 2.0.0 For Net 8
* 1.1.0 For Net 6
* 1.0.2 For Net Core 3.1


---


### C# Example for Write

```csharp
using lowdb;

lowdb<User> db;
string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
string path = appDataPath + @"\miapp\config.json";

FileSync fs = new FileSync(path);
db = new lowdb<User>(fs);

db.data.id = Guid.NewGuid();
db.data.name = "user";
db.data.email = "user@mail.com";
db.data.profiles = new List<Profile>() { 
    new Profile { id = 1, name = "admin" },  
    new Profile { id = 2, name = "user" }
};

db.write();

Console.ReadLine();
```

User model

```csharp
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
```

### Json DB file example
    
```json
{
  "id": "5650bcfe-9eed-45f3-8d29-f3cef5bf012d",
  "name": "user",
  "email": "user@mail.com",
  "profiles": [
    { "id": 1, "name": "admin" },
    { "id": 2, "name": "user" }
  ]
}
```

---

### C# Example for Read

```csharp
using lowdb;

lowdb<User> db;
string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
string path = appDataPath + @"\miapp\config.json";

FileSync fs = new FileSync(path);
db = new lowdb<User>(fs);

string emailUser = db.data.email;

Console.WriteLine(db.data.ToJson(prettyPrint: true));
Console.ReadLine();

```


---


### Source code

https://github.com/Herko8a/lowdb

