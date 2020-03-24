using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDesignPatRnD
{
    class ImplementationA : MyComposite
    {

        public void ClientDoSome()
        {
            Console.WriteLine("A 1");
        }
        public void ClientDoSome2()
        {
            Console.WriteLine("A 2");
        }
    }

    class ImplementationB : MyComposite
    {

        public void ClientDoSome()
        {
            Console.WriteLine("B 1");
        }
        public void ClientDoSome2()
        {
            Console.WriteLine("B 2");
        }
    }

    public interface MyComposite
    {
        void ClientDoSome();
        void ClientDoSome2();
    }

    class TestClient
    {
        MyComposite component;


    }
}


//어떤 형태건 클라이언트는 한개의 형태로 받아들여질수있어야한다 EX) Component By_Unity

//너무 좋은 예시가 있어 예시 구현하기 귀찮