public interface ICRUD<T>
{
    public int Create(T entity);
    public T Read(int id);
    public int Update(T entity, int id);
    public int Delete(T entity);
    
}