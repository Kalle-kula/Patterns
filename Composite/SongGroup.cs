using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Composite
{
    class SongGroup : SongComponent
    {
        // Contains any Songs or SongGroups that are added
        // to this ArrayList

        //songComponents = new List<songComponents>;
        List<SongComponent> songComponents = new List<SongComponent>();

        string groupName;
        string groupDescription;

        public SongGroup(string newGroupName, string newGroupDescription)
        {

            groupName = newGroupName;
            groupDescription = newGroupDescription;
        }

        public string getGroupName() { return groupName; }
        public String getGroupDescription() { return groupDescription; }

        //public void add(SongComponent newSongComponent)
        //{

        //    songComponents.add(newSongComponent);

        //}

        //public void remove(SongComponent newSongComponent)
        //{

        //    songComponents.remove(newSongComponent);

        //}

        //public SongComponent getComponent(int componentIndex)
        //{

        //    return (SongComponent)songComponents.get(componentIndex);

        //}

        //public void displaySongInfo()
        //{

        //    Console.WriteLine(getGroupName() + " " + getGroupDescription() + "\n");

        //    // Cycles through and prints any Songs or SongGroups added
        //    // to this SongGroups ArrayList songComponents

        //    Enumerator songIterator = songComponents.iterator();

        //    while (songIterator.hasNext())
        //    {

        //        SongComponent songInfo = (SongComponent)songIterator.next();

        //        songInfo.displaySongInfo();

        //    }
        //}
    }
}
