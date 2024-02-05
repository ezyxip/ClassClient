using ClassroomSubjectArea;
using ConsoleMenu;

class FindByComputersAndPlaceItem : MenuItem{
    ClassroomRepository repository;
    public FindByComputersAndPlaceItem(string key, ClassroomRepository repository)
    :base(key, "Поиск аудитории по количеству компьютеров на этаже"){
        this.repository = repository;
        this.Execute = () => Find();
    }

    void Find(){
        Console.Write("Введите номер корпуса: ");
        int building = Convert.ToInt32( Console.ReadLine() );
        Console.Write("Введите номер этажа: ");
        int level = Convert.ToInt32( Console.ReadLine() );
        List<Classroom> result = repository.GetClassroomsByFilter((e) => e.Building == building && e.Level == level && e.IsHaveComputer);
        Console.WriteLine("{0}", string.Join("\n", result));
    }
}