using Constructor.Storage.Containers;
using Constructor.Storage.Managers.Assemblies;
using Constructor.Storage.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Constructor.Controllers
{
    [Route("api/[controller]/[action]")]
    public class AssemblyController : Controller
    {
        public IAssembliesManager Manager;
        public IAssemblyContainerManager assemblyManager;
        public AssemblyController(IAssembliesManager _Manager, IAssemblyContainerManager _assemblyManager)
        {
            Manager = _Manager;
            assemblyManager = _assemblyManager;
        }
        [HttpGet]
        public List<Assembly> GetAll()
        {
            return Manager.GetAll();
        }
        [HttpDelete("{Id}")]
        async public Task<string> DeleteById(string Id)
        {
           await Manager.Delete(Guid.Parse(Id));
            return $"Сборка с id {Id} удалена";
        }

        [HttpPut]
        async public Task<Assembly> MakeEmpty()
        {
            Assembly tmp = new Assembly();
            await Manager.Add(tmp);
            return tmp;
        }

        [HttpGet("{Id}")]
        public Assembly GetById(string Id)
        {
            return Manager.Find(Guid.Parse(Id));
        }


        [HttpGet("{id}")]
        public AssemblyContainer GetFullAssembly(string id)
        {
            assemblyManager.FillContainer(Guid.Parse(id));

            return assemblyManager.Assembly;
        }
    }
}
