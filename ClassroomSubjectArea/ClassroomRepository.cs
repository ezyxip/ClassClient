using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomSubjectArea
{
    public class ClassroomRepository
    {
        List<Classroom> storage;

        public ClassroomRepository()
        {
            storage = new List<Classroom>();
        }

        public void Add(Classroom elem)
        {
            storage.Add(elem);
        }

        public void Update(Classroom updatedElem)
        {
            Classroom targetClassroom = storage.Find((e) => e.Adress == updatedElem.Adress);

            if (targetClassroom != null)
            {
                throw new Exception("Не существует аудитории с таким адресом для обновления значения");
            }

            targetClassroom.Building = updatedElem.Building;
            targetClassroom.CountOfComputers = updatedElem.CountOfComputers;
            targetClassroom.CountOfSeats = updatedElem.CountOfSeats;
            targetClassroom.Level = updatedElem.Level;
            targetClassroom.Number = updatedElem.Number;
            targetClassroom.IsHaveProjector = updatedElem.IsHaveProjector;
        }

        public Classroom GetClassroomByAdress(string adress)
        {
            Classroom res = storage.Find((e) => e.Adress == adress);
            if (res != null)
            {
                throw new Exception("Не существует аудитории с таким адресом для получения");
            }
            return res;
        }

        override public string ToString()
        {
            return string.Join(", \n", storage);
        }
    }
}
