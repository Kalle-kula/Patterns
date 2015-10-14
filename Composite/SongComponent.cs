using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public abstract class SongComponent
    {
        // We throw UnsupportedOperationException so that if
        // it doesn't make sense for a song, or song group
        // to inherit a method they can just inherit the
        // default implementation

        // This allows me to add components
        public void add(SongComponent newSongComponent)
        {
            throw new NotSupportedException();
        }

        // This allows me to remove components
        public void remove(SongComponent newSongComponent)
        {
            throw new NotSupportedException();
        }

        // This allows me to get components
        public SongComponent getComponent(int componentIndex)
        {
            throw new NotSupportedException();
        }

        // This allows me to retrieve song names
        public string getSongName()
        {
            throw new NotSupportedException();
        }

        // This allows me to retrieve band names
        public string getBandName()
        {
            throw new NotSupportedException();
        }

        // This allows me to retrieve release year
        public int getReleaseYear()
        {
            throw new NotSupportedException();
        }

        // When this is called by a class object that extends
        // SongComponent it will print out information
        // specific to the Song or SongGroup
        public void displaySongInfo()
        {
            throw new NotSupportedException();
        }
    }
}
