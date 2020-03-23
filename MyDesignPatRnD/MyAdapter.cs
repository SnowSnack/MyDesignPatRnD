using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyDesignPatRnD
{
    interface OldStandard
    {
        void Attack();
        void DoSomething();
    }

    interface NewStandard
    {
        void Attack();
        void Block();
        void DoSomething();
    }

    class OldSystem : OldStandard
    {
        public void Attack()
        {
            Console.WriteLine("OldA");
        }
        public void DoSomething()
        {
            Console.WriteLine("Old");
        }
    }

    class NewSystem : NewStandard
    {
        public void Attack()
        {
            Console.WriteLine("NewA");
        }
        public void Block()
        {
            Console.WriteLine("B");
        }
        public void DoSomething()
        {
            Console.WriteLine("New");
        }
    }

    class MyAdapter : NewStandard
    {
        OldStandard old;

        public MyAdapter(OldStandard _old)
        {
            old = _old;
        }

        public void Block()
        {
            Console.WriteLine("AdaptB");
        }

        public void Attack()
        {
            old.Attack();
        }

        public void DoSomething()
        {
            old.DoSomething();
        }
    }

    class AdapterTestZone
    {
        public void test()
        {
            OldSystem olds = new OldSystem();
            NewSystem news = new NewSystem();
            MyAdapter myAdapt = new MyAdapter(olds);

            olds.Attack();
            news.Attack();
            myAdapt.Attack();
            Console.ReadKey();
        }
    }
}
