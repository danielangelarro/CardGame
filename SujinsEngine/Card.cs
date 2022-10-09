namespace SujinsEngine;

public abstract class ICard
{
    public string? Name;
    public string? Description;
    public int Rare;
    public abstract void SetCard();
    public abstract void Drop();
}

public abstract class IMonsterCard
{
    
}

public abstract class IInvocationCard
{
    
}