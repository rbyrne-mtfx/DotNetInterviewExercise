namespace ExposureRebalancing;

public class ExposureBalancer : IExposureBalancer
{
    private List<Entity> Entities;
    
    public void Rebalance()
    {
        throw new NotImplementedException("Rebalance method to be implemented.");
    }

    public ExposureBalancer(List<Entity> entities)
    {
        Entities = entities;
    }

    public decimal GetTotalExposure()
    {
        return Entities.Sum(e => e.Exposure);
    }

    public bool IsValid()
    {
        return Entities.All(e => e.Exposure <= e.Capacity);
    }
}
