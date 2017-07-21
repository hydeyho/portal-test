using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Finning.Web.Models;

namespace Finning.Web.Builders
{
    public class MachineViewModelBuilder
    {
        public MachineViewModel Build(Machine machine)
        {
            var viewModel = new MachineViewModel
            {
                SerialNumber = machine.SerialNumber,
                Description = machine.Description
            };
            return viewModel;
        }

        public List<MachineViewModel> Build(IList<Machine> machines)
        {
            return machines.Select(Build).ToList();
        }
    }
}
