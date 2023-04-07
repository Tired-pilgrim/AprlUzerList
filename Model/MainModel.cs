using MdelLib;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace Model
{
  
    public class MainModel
    {
        public ObservableCollection<User> Users { get; } = new()
        {
            new User { Name = "Вася", Family = "Васильев", Job="Студент" },
            new User { Name = "Николай", Family = "Алексеев", Job="Аспирант"},
            new User { Name = "Сидор", Family = "Сидоров", Job="Ректор" }
        };

        public void AddUzer(User user) => Users.Add(user);
    }
    
}
