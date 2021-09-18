

namespace MilitaryElite
{
    public class Repair: IRepair
    {
        public Repair(string partName, int workedHours)
        {
            PartName = partName;
            WorkedHours = workedHours;
        }

        public string PartName { get; }
        public int WorkedHours { get; }

        public override string ToString()
        {
            return $"  Part Name: {PartName} Hours Worked: {WorkedHours}";
        }

    }
}
