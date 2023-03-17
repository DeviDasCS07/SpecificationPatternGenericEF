using Core.Entities;

public class DeveloperByIncomeSpecification : BaseSpecifcation<Developer>
{
    public DeveloperByIncomeSpecification()
    {
        AddOrderByDescending(x => x.EstimatedIncome);
    }
}
