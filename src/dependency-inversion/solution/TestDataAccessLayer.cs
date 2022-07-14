using System;

namespace solid_principles.src.dependency_inversion.solution
{
    public class TestDataAccessLayer : IRepositoryLayer
    {
        public void Save(object details)
        {
            //save method with test logic
        }
    }
}