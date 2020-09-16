using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0916_1
{
    class Button
    {
        static int Button_count = 0;
        static Button btn;  //생성된 버튼 메서드를 확인하기 위한 스태틱, 인스턴스 변수선언
        int click = 0;

        public void Click()
        {
            click++;
            Console.WriteLine(click);
        }
        
        private Button()    //새로운 클래스 호출을 막기위한 private
        {
            Button_count++;
            Console.WriteLine("버튼카운트 -->> {0}", Button_count);
        }

        public static Button CreateInstance()   //싱글톤(클래스 호출을 1번으로 제한)
        {
            if (btn == null)
            {
                btn = new Button();
            }
            return btn;
        }
    }

    class Click_Count
    {
        static void Main(string[] args)
        {
            if (args.Length == 2)
                Console.WriteLine(args[0] + "||" + args[1]);
                //return;

            Button btn1 = Button.CreateInstance();
            btn1.Click();
            btn1.Click();
            btn1.Click();

            Button btn2 = Button.CreateInstance();
            btn2.Click();
            /*
            Button btn1 = new Button();
            btn1.Click();
            btn1.Click();
            btn1.Click();
            btn1.Button();
            
            Button btn2 = new Button();
            btn2.Click();
            btn2.Click();
            btn2.Click();
            btn2.Button();
            */
        }
    }
}
