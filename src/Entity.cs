
namespace GradeCalculator{
    public abstract class Entity{
        public int Version {get; private set;} = 1;
        public string Guid {get; set;} = "";
        public string Name {get; set;} = "";
        public bool isActive {get; set;} = true;
    }
}