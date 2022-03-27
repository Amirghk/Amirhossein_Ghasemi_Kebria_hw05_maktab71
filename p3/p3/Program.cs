using System.Text;


int age;
int day;
int month;
int year;
int nID;
string address;
string[] data;
bool first = true;

var lines = File.ReadAllLines(@".\MOCK_DATA.csv");

foreach (var line in lines)
{   
    if (!first)
    {
        data = line.Split(',');
        age = Convert.ToInt32(data[1]);
        day = Convert.ToInt32(data[2].Split('-')[2]);
        month = Convert.ToInt32(data[2].Split('-')[1]);
        year = 2022 - age;
        Person tmp = new Person(data[0], age, day, month, year, data[3], Convert.ToInt32(data[4]), Convert.ToInt32(data[5]));
        DataStore.people.Add(tmp);
    }
    first = false;
}


var a = DataStore.people.FindAll(p => p.age > 20).OrderBy(p => p.name);

var b = DataStore.people.FindAll(p => p.birthdate.Year < 1999);

var c = DataStore.people.Select(x => x).GroupBy(p => p.birthdate).Where(g => g.Count() > 1);
//foreach (var item in c)
//{
//    foreach (var person in item)
//    {
//        Console.WriteLine(person);
//    }
//    Console.WriteLine("*********************************************************");
//}
var d = DataStore.people.OrderBy(p => p.id).Skip(3).First();

var e = DataStore.people.OrderBy(p => p.id).Skip(49).Take(30);

var f = DataStore.people.FindAll(x => x.age == DataStore.people.Max(p => p.age));

var g = DataStore.people.GroupBy(x => x.nationalId).Where(g => g.Count() > 1).ToList();
//foreach (var item in g)
//{
//    foreach (var p in item)
//    {
//        Console.WriteLine(p);
//    }
//    Console.WriteLine("***************************************************************************");
//}
var h = DataStore.people.FindAll(p => p.address.Contains("Tehran"));

var i = DataStore.people.FindAll(p => p.address.Contains("Tehran")).GroupBy(p => p.name).Where(g => g.Count() > 1).ToList();

var j = DataStore.people.FindAll(p => (p.nationalId).ToString().Contains("123"));

var k = DataStore.people.Where(p => p.age > 25).Select(x => new { x.id, x.address });



