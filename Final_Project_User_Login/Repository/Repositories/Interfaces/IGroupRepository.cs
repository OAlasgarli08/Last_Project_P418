using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories.Interfaces
{
    public interface IGroupRepository : IBaseRepositroy<Group>
    {
        List<Group> Sort();
        Group Search(string name);
        void Edit(int id, Group group);
        Group GroupNameExist(string name);
    }
}
