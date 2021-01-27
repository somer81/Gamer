using Game.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Concrete
{
    class PlayerManager : IGameService
    {
        private IEntity _entity;
        public PlayerManager(IEntity entity)
        {
            _entity = entity;
        }

        public void Add()
        {
            Console.WriteLine("Player is Added");
        }

        public void Delete()
        {
            Console.WriteLine("Player is Deleted");
        }

        public void Update()
        {
            Console.WriteLine("Player is Updated");
        }
    }
}
