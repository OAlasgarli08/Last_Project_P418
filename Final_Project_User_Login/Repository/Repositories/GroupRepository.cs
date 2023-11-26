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
        public void Edit(int id, Group group)
        {
            Group existGroup = DbContext<Group>.Datas.FirstOrDefault(m => m.Id == id);
            if (group.Name != null)
            {
                existGroup.Name = group.Name;
            }
            if (group.Capacity != null)
            {
                existGroup.Capacity = group.Capacity;
            }
            
        }

        public Group GroupNameExist(string name)
        {
            return DbContext<Group>.Datas.FirstOrDefault(m => m.Name == name);
        }

        public Group Search(string name)
        {
            return DbContext<Group>.Datas.FirstOrDefault(m => m.Name == name);
        }

        public List<Group> Sort()
        {
            return DbContext<Group>.Datas.OrderBy(m => m.Capacity).ToList();
        }
    }
}
