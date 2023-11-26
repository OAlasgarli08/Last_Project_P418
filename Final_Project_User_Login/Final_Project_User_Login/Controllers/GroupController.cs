using Service.Services.Interfaces;
using Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_User_Login.Controllers
{
    public class GroupController
    {
        private readonly IGroupService _groupService;
        public GroupController()
        {
            _groupService = new GroupService();
        }

        public void GroupCreate()
        {
            Console.WriteLine("Add group name");
        Name: string name = Console.ReadLine();

            Console.WriteLine("Add group capacity");
            int capacity = int.Parse(Console.ReadLine());

            if (_groupService.GroupNameExist(name) != null)
            {
                Console.WriteLine("This name already exists!");
                goto Name;
            }

            _groupService.Create(new Domain.Models.Group { Name = name, Capacity = capacity });
        }
        public void GroupDelete()
        {
            Console.WriteLine("Write the id of the group you want to delete");
        Id: string idStr = Console.ReadLine();
            int id;
            bool isCorrectId = int.TryParse(idStr, out id);

            if (isCorrectId)
            {
                var group = _groupService.GetById(id);
                _groupService.Delete(group);
            }
            else
            {
                Console.WriteLine("That group doesn't exist!");
                goto Id;
            }
        }

        public void GroupGetAll()
        {
            var groups = _groupService.GetAll();
            foreach (var group in groups)
            {
                Console.WriteLine($"{group.Id} + {group.Name} + {group.Capacity}");
            }
        }

        public void GroupGetById()
        {
            Console.WriteLine("Write the id of the group you want to find");
            int id = int.Parse(Console.ReadLine());

            var group = _groupService.GetById(id);

            Console.WriteLine($"{group.Id} + {group.Name} + {group.Capacity}");
        }

        public void GroupSearch()
        {
            Console.WriteLine("Write the name of the group");
        Name: string name = Console.ReadLine();

            if (name == null)
            {
                Console.WriteLine("Don't leave this empty!");
                goto Name;
            }

            var group = _groupService.Search(name);
            Console.WriteLine($"{group.Id} + {group.Name} + {group.Capacity}");
        }

        public void GroupSort()
        {
            var groups = _groupService.Sort();
            foreach (var group in groups)
            {
                Console.WriteLine($"{group.Id}  +  {group.Name}  +  {groups.Capacity}");
            }
        }

        public void GroupEdit()
        {
            Console.WriteLine("Write the id of the group you want to edit");
        Id: string idStr = Console.ReadLine();
            int id;
            bool isCorrectId = int.TryParse(idStr, out id);

            if (isCorrectId)
            {
                var student = _groupService.GetById(id);
            }
            else
            {
                Console.WriteLine("That group doesn't exist!");
                goto Id;
            }

            Console.WriteLine("Choose group name:");
            string name = Console.ReadLine();

            Console.WriteLine("Choose group capacity:");
            int capacity = int.Parse(Console.ReadLine());



            _groupService.Edit(id, new Domain.Models.Group { Name = name, Capacity = capacity });
        }
    }
}
