using Vaccine.Core;
using Vaccine.Core.Dtos;
using Vaccine.Core.IRepositories;


namespace Vaccine.DAL
{
    public class VaccineRepository:IVaccineRepository
    {
        private DataContext _dataContext;

        public VaccineRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public List<VaccineDto> GetAll()
        {
            var result = _dataContext.Vaccines.OrderBy(v => v.Name).ToList();
            return result;
        }
    }
}
