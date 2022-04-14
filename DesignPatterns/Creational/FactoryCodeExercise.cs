

namespace DesignPatterns.Creational;

public interface IPerson
{
    int Id { get; set; }
    string Name { get; set; }
}

public class Person : IPerson
{
    private int _id;
    private string _name;
    public int Id
    {
        get { return _id; }
        set
        {
            _id = value;
        }
    }
    public string Name
    {
        get
        {
            return _name;
        }

        set
        {
            _name = value;
        }
    }
}

public abstract class Factory
{
    public abstract IPerson CreatePerson(string Name);

}

public class PersonFactory : Factory
{
    private int _personCounter = 0;
    public override IPerson CreatePerson(string _name)
    {
        var person = new Person() { Id = _personCounter, Name = _name };
        _personCounter++;
        return person;
    }
}
