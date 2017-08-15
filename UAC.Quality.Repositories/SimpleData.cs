namespace UAC.Quality.Repositories
{
    using System.Collections.Generic;

    public class SimpleData
    {
        public virtual IEnumerable<string> Alloys() => new List<string>();

        public virtual IEnumerable<string> Tempers() => new List<string>();
    }
}
