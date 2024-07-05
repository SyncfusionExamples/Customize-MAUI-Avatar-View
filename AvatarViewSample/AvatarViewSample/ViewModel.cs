using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvatarViewSample
{
    public class ViewModel
    {
        public ObservableCollection<Model> ProfileCollection
        {
            get;
            set;
        }

        public ViewModel()
        {
            ProfileCollection = new ObservableCollection<Model>();
            ProfileCollection.Add(new Model { Name = "Mike", ImageSource = "mike.png", Colors = Colors.LightCoral });
            ProfileCollection.Add(new Model { Name = "Clara", ImageSource = "clara.png", Colors = Colors.Bisque });
            ProfileCollection.Add(new Model { Name = "Emma", ImageSource = "emma.png", Colors = Colors.Gray });
            ProfileCollection.Add(new Model { Name = "Mia", ImageSource = "mia.png", Colors = Colors.Gray });
            ProfileCollection.Add(new Model { Name = "Alex", ImageSource = "alex.png", Colors = Colors.Gray });
        }
    }
}
