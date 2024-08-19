using Testing.Models;
using lowdb;

lowdb<User> db;
string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
string path = appDataPath + @"\miapp\config.json";

FileSync fs = new FileSync(path);
db = new lowdb<User>(fs);

string emailUser = db.data.email;

db.data.id = Guid.NewGuid();
db.data.name = "user";
db.data.email = "user@mail.com";
db.data.profiles = new List<Profile>() {
    new Profile { id = 1, name = "admin" },
    new Profile { id = 2, name = "user" }
};

db.write();

Console.WriteLine(db.data.ToJson(prettyPrint: true));
Console.ReadLine();

