namespace UAC.Quality.Repositories
{
    using System.Collections.Generic;
    using System.Data;
    using Flash;
    using Gimme;

    public class SimpleDataProvider : ISimpleData
    {
        public IEnumerable<string> Alloys()
        {
            var result = new List<string>();

            Flash.List(
                Collection.Locate<IDbConnection>("quality"),
                "quality.alloys",                
                (d) => result.Add(d.GetValue(0).ToString()));

            return result;
        }

        public IEnumerable<string> Tempers()
        {
            var result = new List<string>();

            Flash.List(
                Collection.Locate<IDbConnection>("quality"),
                "quality.tempers",
                (d) => result.Add(d.GetValue(0).ToString()));

            return result;
        }
    }
}