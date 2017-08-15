namespace UAC.Quality.Repositories
{
    using System.Collections.Generic;
    public interface IAlloyTemperProvider
    {
        void SaveSpecAlloyTemper(int specid, string alloyTempers);

        void AddAlloyTemper(int specid, string alloy, string temper);

        void Delete(int id);
    }
}
