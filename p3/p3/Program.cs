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

// var c = ???

var d = DataStore.people.OrderBy(p => p.id).Skip(3).First();

var e = DataStore.people.OrderBy(p => p.id).Skip(49).Take(30);

var f = DataStore.people.FindAll(x => x.age == DataStore.people.Max(p => p.age));

// TODO: g find out if there are duplicate ids in the list

// TODO: h addresses that include tehran

// TODO: i ?? 

// TODO: j 123 is in the id

// TODO: id and address of ppl older than 25















//for (int i = 0; i < count; i++)
//{
//    Random rnd = new();
//    int len = 4;
//    StringBuilder str_build = new StringBuilder();
//    char letter; // char to store random char
//    for (int j = 0; j < len; j++)
//    {
//        double flt = rnd.NextDouble();
//        int shift = Convert.ToInt32(Math.Floor(25 * flt));
//        letter = Convert.ToChar(shift + 65);
//        str_build.Append(letter);        
//    }
//    age = rnd.Next(18, 99);
//    day = rnd.Next(1, 30);
//    //month = rnd.Next(1, 12);
//    year = 2022 - age;
//    nID = rnd.Next(1000, 9999);
//    if (i % 2 == 0)
//        address = "Tehran";
//    else
//        address = "Somewhere else";

//    Person tmp = new Person(str_build.ToString(), age, day, 02, year, address, nID, i);
//    DataStore.people.Add(tmp);
//}


Console.WriteLine("Done");
// rnd.Next(18, 99);
// 2022 - age will be in birth date
// id should be incremented by 1 each iteration
// national id randomized by a certain length




