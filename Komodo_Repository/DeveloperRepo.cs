using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Komodo_Data;

    public class DeveloperRepo
    {
        // Add member  to/from a team by their unique identifier. 
        // Create
        public List<Developer> _DevDirectory = new List<Developer>();

        public bool AddDev(Developer developer)
        {
            int startingCount = _DevDirectory.Count;
            _DevDirectory.Add(developer);
            bool wasAdded = (_DevDirectory.Count > startingCount)? true : false;

            return wasAdded;
        }

        //They should be able to see a list of existing developers to choose from and add to existing teams.
        // Read

        public List<Developer> GetAllDev()
        {
            return _DevDirectory;
        }

        public Developer GetDeveloperbyID(int DevID)
        {
            foreach(Developer developer in _DevDirectory)
            {
                if(developer.DevID == DevID)
                {
                    return developer;
                }
            }
            return null;
        }

        //Update

        public bool UpdateDev(int originalId, Developer newdeveloper)
        {

        Developer oldDev = GetDeveloperbyID(originalId);
        if(oldDev != null)
        {
            oldDev.DevNames = newdeveloper.DevNames;
            oldDev.DevID = newdeveloper.DevID;

            return true;
        }
        else
        {
            return false;
        }

        }

        //Our managers need to be able to remove members to/from a team by their unique identifier
        //Delete

        public void DeleteDevById(int input)
        {
            _DevDirectory.RemoveAt(input);
        }
        
    }
