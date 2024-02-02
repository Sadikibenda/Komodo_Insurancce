using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Komodo_Data;

namespace Komodo_Repository
{
    public class DevTeamRepo
    {
        public List<DevTeam> _DevTeamDirectory = new List<DevTeam>();

        //Create
        public bool AddDevTeam(DevTeam team)
        {
            int startingCount = _DevTeamDirectory.Count;
            _DevTeamDirectory.Add(team);
            bool wasAdded = (_DevTeamDirectory.Count > startingCount)? true : false;

            return wasAdded;
        }

        //Read

        public List<DevTeam> GetDevTeam()
        {
            return _DevTeamDirectory;
        }

        public DevTeam GetDevTeamById(int TeamID)
        {
            foreach(DevTeam team in _DevTeamDirectory)
            {
                if(team.TeamID == TeamID)
                {
                    return team;
                }
            }
            return null;
        }

        //Update

        public bool updateDevTeam(int originalId, DevTeam newTeam)
        {
            DevTeam oldTeam = GetDevTeamById(originalId);
            if(oldTeam != null)
            {
                oldTeam.TeamNames = newTeam.TeamNames;
                oldTeam.TeamID = newTeam.TeamID;

                return true;
            }
            else
            {
                return false;
            }
        }

        //Delete
        public void DeleteDevTeamByID(int input)
        {
            _DevTeamDirectory.RemoveAt(input);
        }
    }
}