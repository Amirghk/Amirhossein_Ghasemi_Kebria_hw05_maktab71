public class Person
{
    public string? name;
    public int age;
    public DateTime birthdate;
    public string? address;
    public int nationalId;
    public int id;

    public Person(string name, int age, int day, int month, int year, string address, int nId, int id)
    {
        this.name = name;
        this.age = age;
        birthdate = new DateTime(year, month, day);
        this.address = address;
        nationalId = nId;
        this.id = id;
    }

    // how to override Equals method of object?? https://www.c-sharpcorner.com/article/operator-overloading-in-C-Sharp2/
    public override bool Equals(object o)
    {
        Person p = (Person)o;
        if (p.name == this.name && p.age == this.age && p.birthdate == this.birthdate && p.address == this.address && p.nationalId == this.nationalId && p.id == this.id)
            return true;
        else
            return false;
    }
    public override int GetHashCode()
    {
        return id;
    }
    public static bool operator ==(Person a, Person b)
    {
        return a.Equals(b);
    }
    public static bool operator !=(Person a, Person b)
    {
        return !a.Equals(b);
    }


    public override string ToString()
    {
        return $"{id} -- Name: {name} -- Age: {age} -- Birthdate: {birthdate} -- Address: {address} -- National ID: {nationalId}";
    }
}