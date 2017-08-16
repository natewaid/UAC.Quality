namespace UAC.Quality.Repositories
{
    using System.Collections.Generic;

    public interface ISimpleData
    {
        IEnumerable<string> Alloys();

        IEnumerable<string> Tempers();
    }
}
