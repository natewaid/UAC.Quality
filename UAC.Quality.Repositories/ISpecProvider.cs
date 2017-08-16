namespace UAC.Quality.Repositories
{
    using System.Collections.Generic;
    using Core;

    public interface ISpecProvider
    {
        IEnumerable<Spec> Specs();

        SpecDetailsResult SpecDetails(int specid);

        int SaveSpec(Spec spec);
    }
}
