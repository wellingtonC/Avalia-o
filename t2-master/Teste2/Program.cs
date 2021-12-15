using System;
using System.Collections.Generic;
using System.Linq;

namespace Teste2
{
    /*
      * TODO
      * Implementar CanBeConnect para identificar se o Friend A pode se Conectar com o Friend C. Para isso, é necessário ter um friend em comum.
         - Caso sim, o método deverá retornar True
         - Caso não, o método deverá retornar False
      */
    class Friend
    {
        public string Email { get; private set; }

        public ICollection<Friend> Friends { get; private set; }

        public Friend(string email)
        {
            this.Email = email;
            this.Friends = new List<Friend>();
        }

        public void AddFriendship(Friend friend)
        {
            this.Friends.Add(friend);
        }

        public bool CanBeConnect(Friend teste)
        {
            if (this.Friends.ElementAt(0) == teste.Friends.ElementAtOrDefault(0))
            {
                return true;
            } 
            return false;
        }

        static void Main(string[] args)
        {
            Friend a = new Friend("A");
            Friend b = new Friend("B");
            Friend c = new Friend("C");
           
            a.AddFriendship(b);
            b.AddFriendship(c);
            c.AddFriendship(b);

            c.CanBeConnect(a);
        }

    }
}
