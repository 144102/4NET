using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class InputList
    {
        public class MemberAddedEventArgs : EventArgs
        {
            public int MemberAdd { get; set; }
        }

        private List<int> list;

        public InputList(List<int> list)
        {
            this.list = list;
        }

        public void Add(int x)
        {
            list.Add(x);
            var args = new MemberAddedEventArgs { MemberAdd = x };
            OnMemberAdded(args);
        }

        protected virtual void OnMemberAdded(MemberAddedEventArgs e)
        {
            EventHandler<MemberAddedEventArgs> handler = MemberAdded;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        public event EventHandler<MemberAddedEventArgs> MemberAdded;

    }

  

}
