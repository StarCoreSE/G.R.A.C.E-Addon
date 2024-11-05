using System.Collections.Generic;
using static Scripts.Structure;

namespace Scripts
{
    public partial class Parts
    {
        public Parts()
        {
            AddClassDefinitions(ShipClass1, ShipClass2);
        }

        public ClassDefinition ShipClass1 => new ClassDefinition
        {
            ClassName = "TestClass01",
            ClassKey = 11, // Must be Unique per class, cannot be 0 or more than 2 digits
            PerFactionAmount = 6, // Maximum per Faction
            PerPlayerAmount = 1, // Maximum per Player
            MaxBlockCount = 6000,
            MinBlockCount = 500, 
            MaxClassWeight = 1000000,
            MinClassWeight = 250000,
            BlacklistedBlocks = new List<string> // Blocks that the Grid cannot have. Placement Attempts will be intercepted, and pastes/prints with these blocks will be in Violation
            {
                "Battery",
                "Collector"
            }
        };

        public ClassDefinition ShipClass2 => new ClassDefinition
        {
            ClassName = "TestClass02",
            ClassKey = 12,
            PerFactionAmount = 6,
            PerPlayerAmount = 1,
            MaxBlockCount = 6000,
            MinBlockCount = 500,
            MaxClassWeight = 1000000,
            MinClassWeight = 250000,
            BlacklistedBlocks = new List<string>
            {
                "Battery",
                "Collector"
            }
        };
    }
}