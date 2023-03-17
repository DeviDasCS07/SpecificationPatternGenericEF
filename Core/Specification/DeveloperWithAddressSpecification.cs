using Core.Entities;

public class DeveloperWithAddressSpecification : BaseSpecifcation<Developer>
{
    public DeveloperWithAddressSpecification(int years) : base(x => x.YearsOfExperience > years)
    {
        AddInclude(x => x.Address);
    }
}