using DevExtremeAspNetCoreArf.Models;

namespace DevExtremeAspNetCoreArf.Services
{
    public class MockArfRepository : IArfRepository
    {
        private readonly List<Arf> arfList;

        public MockArfRepository()
        {
            arfList = new List<Arf>()
            {
                new Arf() { Id = 1, Name = "First", CompanyName = "First Company" },
                new Arf() { Id = 2, Name = "Second", CompanyName = "Second Company" },
                new Arf() { Id = 3, Name = "Third", CompanyName = "Third Company" },
                new Arf() { Id = 4, Name = "Fourth", CompanyName = "Fourth Company" }
            };
        }

        public IEnumerable<Arf> GetAll()
        {
            return arfList;
        }

        public Arf Get(int id)
        {
            return arfList.FirstOrDefault(a => a.Id == id);
        }

        public Arf Update(Arf arf)
        {
            throw new NotImplementedException();
        }
    }
}
