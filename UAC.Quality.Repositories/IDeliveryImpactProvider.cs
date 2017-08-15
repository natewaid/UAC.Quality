namespace UAC.Quality.Repositories
{
    public interface IDeliveryImpactProvider
    {
        void SaveDeliveryImpact(int specid, string deliveryImpacts);

        void AddDeliveryImpact(int specid, string impact);

        void Delete(int id);
    }
}
