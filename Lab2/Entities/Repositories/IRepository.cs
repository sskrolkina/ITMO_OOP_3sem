namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.Repositories;

public interface IRepository<T>
{
    T? FindByName(string? name);
    void Add(T obj);
}