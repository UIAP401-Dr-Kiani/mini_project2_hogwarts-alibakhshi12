using System;
using System.Collections.Generic;
namespace Hagwartz
{
    public class group
    {
        private Type type;

        public Type Type
        {
            get => type;
            set => type = value;
        }

        private long score;

        public long Score
        {
            get => score;
            set => score = value;
        }

        private List<authorizedPersons> groupPersons = new List<authorizedPersons>();

        public List<authorizedPersons> GroupPersons
        {
            get => groupPersons;
            set => groupPersons = value;
        }

        private List<authorizedPersons> quidditchPlayers = new List<authorizedPersons>();

        public List<authorizedPersons> QuidditchPlayers
        {
            get => quidditchPlayers;
            set => quidditchPlayers = value;
        }
        
    }
}