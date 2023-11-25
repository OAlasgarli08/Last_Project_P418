using Domain.Models;
using Repository.Datas;
using Repository.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class GroupRepository : BaseRepository<Group>, IGroupRepository
    {
        public Group Search(string name)
        {
            return (Group)DbContext<Group>.Datas.Where(m => m.Name == name);
        }

        public List<Group> Sort(int capacity)
        {
            return DbContext<Group>.Datas.OrderBy(m => m.Capacity).ToList();
        }
    }
}
