using ClassroomSubjectArea;
using ConsoleMenu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassClient.MenuItems
{
    class UpdateClassroomItem : MenuItem
    {
        ClassroomRepository repository;
        public UpdateClassroomItem(string key, ClassroomRepository repository)
            : base(key, "Изменение параметров аудитории")
        {
            this.repository = repository;
            this.Execute = () => UpdateClassroom();
        }

        public void UpdateClassroom()
        {

        }
    }
}
