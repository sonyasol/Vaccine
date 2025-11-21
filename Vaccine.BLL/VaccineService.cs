using Mapster;
using Vaccine.Core.IRepositories;
using Vaccine.Core.OutputModel;

namespace Vaccine.BLL
{
    public class VaccineService
    {
        private IVaccineRepository _vaccineRepository;

        public VaccineService(IVaccineRepository vaccineRepository)
        {
            _vaccineRepository = vaccineRepository;
        }

        public List<VaccineOutputModel> GetAll()
        {
            var tmp = _vaccineRepository.GetAll();
            var result = tmp.Adapt<List<VaccineOutputModel>>();
            return result;
        }
    }
}
