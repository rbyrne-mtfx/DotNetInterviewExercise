namespace ExposureRebalancing.Tests;

// Scenario 1
//           | Entity | Exposure | Capacity | Priority 
// ----------|--------|----------|----------|---------
// Input     | A      | 40       |    50    |    1
//           | B      | 30       |    60    |    2
//           | C      | 20       |    40    |    3
//           | D      | 10       |    20    |    4
// Expected  | A      | 50       |
//           | B      | 50       |
//           | C      | 0        |
//           | D      | 0        |

// Scenario 2
//           | Entity | Exposure | Capacity | Priority 
// ----------|--------|----------|----------|---------
// Input     | A      | 40       |    100   |    1
//           | B      | 30       |    60    |    2
//           | C      | 20       |    40    |    3
//           | D      | 10       |    20    |    4
// Expected  | A      | 100      | 
//           | B      | 0        | 
//           | C      | 0        | 
//           | D      | 0        | 

// Scenario 3
//           | Entity | Exposure | Capacity | Priority 
// ----------|--------|----------|----------|---------
// Input     | A      | 100      |    100   |    1
//           | B      | 30       |    60    |    2
//           | C      | 20       |    40    |    3
//           | D      | 10       |    20    |    4
// Expected  | A      | 100      |    
//           | B      | 60       |    
//           | C      | 0        |    
//           | D      | 0        |    

// Scenario 4
//           | Entity | Exposure | Capacity | Priority 
// ----------|--------|----------|----------|---------
// Input     | A      | 100      |    100   |    1
//           | B      | 40       |    60    |    2
//           | C      | 20       |    40    |    3
//           | D      | 10       |    20    |    4
// Expected  | A      | 100      |    
//           | B      | 60       |    
//           | C      | 10       |    
//           | D      | 0        |    


[TestFixture]
public class ExposureBalancerTests
{

    [Test]
    public void Rebalance_Scenario_1_Successful()
    {
        var entities = new List<Entity>
        {
            new Entity("A", 40, 50, 1),
            new Entity("B", 30, 60, 2),
            new Entity("C", 20, 40, 3),
            new Entity("D", 10, 20, 4)
        };

        var rebalancer = new ExposureBalancer(entities);

        rebalancer.Rebalance();

        Assert.That(entities[0].Exposure.Equals(50));
        Assert.That(entities[1].Exposure.Equals(50));
        Assert.That(entities[2].Exposure.Equals(0));
        Assert.That(entities[3].Exposure.Equals(0));

    }

    [Test]
    public void Rebalance_Scenario_2_Successful()
    {
    }

    [Test]
    public void Rebalance_Scenario_3_Successful()
    {
    }

    [Test]
    public void Rebalance_Scenario_4_Successful()
    {
    }

}
