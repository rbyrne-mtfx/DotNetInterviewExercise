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
