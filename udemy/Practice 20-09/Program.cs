
using System.Runtime.CompilerServices;

public interface IBase
{
    public void Add();
}
public class Base
{

}

public class Child : Base, IBase
{
    //void IBase.Add()
    //{

    //}

    
    public void Add()
    {

    }
}