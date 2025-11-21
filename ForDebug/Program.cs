using Mapster;
using Microsoft.EntityFrameworkCore;
using Vaccine.Core;
using Vaccine.Core.OutputModel;
using Vaccine.DAL;

namespace ForDebug
{
    public class Program
    {
        static void Main(string[] args)
        {
            DataContext data = new DataContext();

            data.Database.EnsureCreated();

            //VaccineRepository vrepository = new VaccineRepository(data);

            //var vrep = vrepository.GetAll();

            //var vaccine = vrep.Adapt<List<VaccineOutputModel>>();

            //Console.WriteLine();
        }
    }
}
