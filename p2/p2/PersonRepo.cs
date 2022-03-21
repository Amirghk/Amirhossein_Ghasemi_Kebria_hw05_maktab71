public class PersonRepo : ICRUD<Person>
{
    public int Create(Person entity)
    {
        DataStore.people.Add(entity);
        return 1;
    }

    public int Delete(Person entity)
    {
        try
        {
            DataStore.people.Remove(entity);
        }
        catch (Exception)
        {
            return 0;
        }
        return 1;     
    }

    public Person Read(int id)
    {
        return DataStore.people.First(p => p.id == id);
    }

    public int Update(Person entity, int id)
    {

        DataStore.people.Remove(DataStore.people.First(p => p.id == id));
        DataStore.people.Add(entity);
        return 1;
    }
}