using System;

namespace solid_principles.src.dependency_inversion.solution
{
    public class BusinessLogicLayer
    {
        public IRepositoryLayer repositoryLayer { get;set; }

        public BusinessLogicLayer(IRepositoryLayer _repositoryLayer)
        {
            repositoryLayer = _repositoryLayer;
        }
        public void Save(object details)
        {
            repositoryLayer.Save(details);
        }
    }
}

//Here the repository can be either DataAccessLayer or TestDataAccessLayer
//we depend on the abastraction (IRepository), not on the implementation
//same as having SqlRepository and MongoRepository 