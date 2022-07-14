using System;

namespace solid_principles.src.dependency_inversion.solution
{
    public interface IRepositoryLayer
    {
        public void Save(object details);
    }
}