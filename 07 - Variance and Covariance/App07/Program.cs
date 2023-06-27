
Base x = new Base();

// more derivate to less derivate
Base y = new Derived();

x.ExecuteInBase();
y.ExecuteInBase();

Console.WriteLine("@@@@");
// is not recognized by the first declaration
// y.ExecuteInDerived(); // ilegal invoked method

Derived z = new Derived();
z.ExecuteInDerived();
z.ExecuteInBase();

// As COVARIANT, it must returns an object with the same value of the interface implementation
IProducer<Base> prodBase = null!;
Base bs = prodBase.Produce();

// more derived to less derived COVARIANT
IProducer<Derived> prodDerived = null!;
Derived ds = prodDerived.Produce();
Base bs2 = prodDerived.Produce();


// To receive the objects must be from the less derived to the most derived CONTRAVARIANT
IConsumer<Base> consBase = null!;
consBase.Consume(new Base());
consBase.Consume(new Derived());

// To receive the objects must be from the more derived to the less derived CONTRAVARIANT
IConsumer<Derived> consDerived = null!;
//consDerived.Consume(new Base()); // this is illegal
consDerived.Consume(new Derived());

// out in interface indicates a COVARIANT TYPE
interface IProducer<out T> 
{
    T Produce();
}


interface IConsumer<in T> { // this object is entering at interface object this is a CONTRAVARIANT
    void Consume(T obj);
}

class Base
{
    public void ExecuteInBase() => Console.WriteLine($"Executing from {GetType().Name}");
}

class Derived: Base
{
    public void ExecuteInDerived() => Console.WriteLine($"Executing derived from {GetType().Name}");
}

