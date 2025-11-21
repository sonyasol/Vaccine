using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mapster;
using Vaccine.Core.Dtos;
using Vaccine.Core.OutputModel;

namespace Vaccine.Core
{
    public class MapsterConfig:IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<VaccineDto, VaccineOutputModel>()
                .Map(v => v.Title, dto => dto.Name.ToString());

            config.NewConfig<UserDto, UserOutputModel>()
                .Map(u => u.Name, dto => dto.Name.ToString());
        }
    }
}
