using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDesignPatRnD
{
    

    class Decorator
    {
    }
}
/*객체의 결합 을 통해 기능을 동적으로 유연하게 확장 할 수 있게 해주는 패턴
즉, 기본 기능에 추가할 수 있는 기능의 종류가 많은 경우에 각 추가 기능을 Decorator 클래스로 정의 한 후 필요한 Decorator 객체를 조합함으로써 추가 기능의 조합을 설계 하는 방식이다.
Ex) 기본 도로 표시 기능에 차선 표시, 교통량 표시, 교차로 표시, 단속 카메라 표시의 4가지 추가 기능이 있을 때 추가 기능의 모든 조합은 15가지가 된다.
https://gmlwjd9405.github.io/2018/07/09/decorator-pattern.html
*/