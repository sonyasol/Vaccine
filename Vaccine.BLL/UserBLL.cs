using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mapster;
using Vaccine.Core.IRepositories;
using Vaccine.Core.OutputModel;

namespace Vaccine.BLL
{
    public class UserBLL
    {
        private IUserRepository _userRepository;

        public UserBLL(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public List<UserOutputModel> GetAll()
        {
            var list = _userRepository.GetAll();
            var res = list.Adapt<List<UserOutputModel>>();
            return res;
        }
    }
}
