using System;

namespace solid_principles.src.dependency_inversion.violation
{
    public class BusinessLogicLayer
    {
        public DataAccessLayer dataAccessLayer {get;set;} = new DataAccessLayer();
        public void Save(object details)
        {
            dataAccessLayer.Save(details);
        }
    }
}