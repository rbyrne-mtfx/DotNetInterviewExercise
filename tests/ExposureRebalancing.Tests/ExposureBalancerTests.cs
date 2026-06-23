namespace ExposureRebalancing.Tests;

[TestFixture]
public class ExposureBalancerTests
{
    private List<Entity> _entities = null!;
    private ExposureBalancer _balancer = null!;

    [SetUp]
    public void SetUp()
    {
        _entities =
        [
            new Entity("A", exposure: 40m, capacity: 50m, priority: 1),
            new Entity("B", exposure: 30m, capacity: 60m, priority: 2),
            new Entity("C", exposure: 20m, capacity: 40m, priority: 3),
            new Entity("D", exposure: 10m, capacity: 20m, priority: 4),
        ];

        _balancer = new ExposureBalancer(_entities);
    }

}
