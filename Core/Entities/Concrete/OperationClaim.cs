namespace Core.Entities.Concrete
{
    public class OperationClaim: BaseEntity, IEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
