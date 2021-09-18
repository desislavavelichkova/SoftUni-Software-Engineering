

namespace FoodShortage
{
    public interface IBuyer: IPerson
    {        
        void BuyFood();
        int Food { get; }

    }
}
