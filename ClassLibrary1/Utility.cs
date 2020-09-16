using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Utility    //default : internal이므로 다른 프로젝트에서 참조할 때 public설정
    {
        public static int ConvertInt(string str)   //문자열을 int로 형변환
        {
            int num;
            int.TryParse(str, out num);
            bool bFlag = int.TryParse(str, out num);
            if (!bFlag)
                num = 0;

            return num;
            /*
            int num = 0;
            bool bFlag = false;

            while(!bFlag)
            {
                bFlag = int.TryParse(Console.ReadLine(), out num);
            }
            return num;
            */
        }

        public static double ConvertDouble(string str)
        {
            double num;
            double.TryParse(str, out num);
            bool bFlag = double.TryParse(str, out num);
            if (!bFlag)
                num = 0.0;

            return num;
        }

        
    }
}
