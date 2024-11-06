using System.Collections.Generic;
using static Scripts.Structure;

namespace Scripts
{
    public partial class Parts
    {
        public Parts()
        {
            AddClassDefinitions(Flagship, Carrier, Cruiser, Destroyer, Corvette, Scout);
        }

        public ClassDefinition Flagship => new ClassDefinition
        {
            ClassName = "Flagship",
            ClassKey = 11, // Must be Unique per class, cannot be 0 or more than 2 digits
            PerFactionAmount = 1, // Maximum per Faction
            PerPlayerAmount = 1, // Maximum per Player
            MaxBlockCount = 15000,
            MinBlockCount = 0,
            MaxClassWeight = 40000000,
            MinClassWeight = 30000000,
            BlacklistedBlocks = new List<string> // Blocks that the Grid cannot have. Placement Attempts will be intercepted, and pastes/prints with these blocks will be in Violation
            {
                "Battery",
                "Collector"
            }
        };

        public ClassDefinition Carrier => new ClassDefinition
        {
            ClassName = "Carrier",
            ClassKey = 12, // Must be Unique per class, cannot be 0 or more than 2 digits
            PerFactionAmount = 1, // Maximum per Faction
            PerPlayerAmount = 1, // Maximum per Player
            MaxBlockCount = 10000,
            MinBlockCount = 0,
            MaxClassWeight = 35000000,
            MinClassWeight = 25000000,
            BlacklistedBlocks = new List<string> // Blocks that the Grid cannot have. Placement Attempts will be intercepted, and pastes/prints with these blocks will be in Violation
            {
                "Battery",
                "Collector"
            }
        };

        public ClassDefinition Cruiser => new ClassDefinition
        {
            ClassName = "Cruiser",
            ClassKey = 13, // Must be Unique per class, cannot be 0 or more than 2 digits
            PerFactionAmount = 2, // Maximum per Faction
            PerPlayerAmount = 2, // Maximum per Player
            MaxBlockCount = 8000,
            MinBlockCount = 0,
            MaxClassWeight = 25000000,
            MinClassWeight = 15000000,
            BlacklistedBlocks = new List<string> // Blocks that the Grid cannot have. Placement Attempts will be intercepted, and pastes/prints with these blocks will be in Violation
            {
                "Battery",
                "Collector"
            }
        };

        public ClassDefinition Destroyer => new ClassDefinition
        {
            ClassName = "Destroyer",
            ClassKey = 14, // Must be Unique per class, cannot be 0 or more than 2 digits
            PerFactionAmount = 4, // Maximum per Faction
            PerPlayerAmount = 4, // Maximum per Player
            MaxBlockCount = 5000,
            MinBlockCount = 0,
            MaxClassWeight = 20000000,
            MinClassWeight = 10000000,
            BlacklistedBlocks = new List<string> // Blocks that the Grid cannot have. Placement Attempts will be intercepted, and pastes/prints with these blocks will be in Violation
            {
                "Battery",
                "Collector"
            }
        };

        public ClassDefinition Corvette => new ClassDefinition
        {
            ClassName = "Corvette",
            ClassKey = 15, // Must be Unique per class, cannot be 0 or more than 2 digits
            PerFactionAmount = 6, // Maximum per Faction
            PerPlayerAmount = 6, // Maximum per Player
            MaxBlockCount = 2500,
            MinBlockCount = 0,
            MaxClassWeight = 10000000,
            MinClassWeight = 5000000,
            BlacklistedBlocks = new List<string> // Blocks that the Grid cannot have. Placement Attempts will be intercepted, and pastes/prints with these blocks will be in Violation
            {
                "Battery",
                "Collector"
            }
        };

        public ClassDefinition Scout => new ClassDefinition
        {
            ClassName = "Scout",
            ClassKey = 16, // Must be Unique per class, cannot be 0 or more than 2 digits
            PerFactionAmount = 8, // Maximum per Faction
            PerPlayerAmount = 8, // Maximum per Player
            MaxBlockCount = 1500,
            MinBlockCount = 0,
            MaxClassWeight = 5000000,
            MinClassWeight = 150000,
            BlacklistedBlocks = new List<string> // Blocks that the Grid cannot have. Placement Attempts will be intercepted, and pastes/prints with these blocks will be in Violation
            {
                "Battery",
                "Collector"
            }
        };
    }
}