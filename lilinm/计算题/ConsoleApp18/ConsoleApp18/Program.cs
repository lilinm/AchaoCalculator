using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入题目数量(不要太多哦)：");
            int n = Convert.ToInt32(Console.ReadLine());
            Practices practices1 = new Practices();
            practices1.practices(n);
        }
    }

    public class Practices
    {
             public void practices(int n)
             {
                int i = 0;
                double data1 = 0;
                double data2 = 0;
                double data3 = 0;
                double data4 = 0;
                double data5 = 0;
                double data6 = 0;
                double data7 = 0;
            
                string[] jisuanfu = { "+", "-", "*", "/" };
                    for (i=0 ; i<n; i++)
                    {
                        Random random1 = new Random(int.Parse(DateTime.Now.ToString("HHFFmmss")) + i);
                        int a = random1.Next(3, 5);//后面的取不到
                        switch (a)
                        {
                            case 3:
                                data1 = random1.Next(0, 100);
                                data2 = random1.Next(0, 100);
                                data3 = random1.Next(0, 100);
                                string e1 = jisuanfu[random1.Next(0, 4)];
                                string e2 = jisuanfu[random1.Next(0, 4)];
                                String s = data1 + e1 + data2 + e2 + data3;
                                DataTable dt = new DataTable();
                                double num = Convert.ToDouble(dt.Compute(s, "false"));
                                Result re = new Result();
                                int m = re.result(num);
                                while(m<0)
                                {
                                    data1 = random1.Next(0, 100);
                                    data2 = random1.Next(0, 100);
                                    data3 = random1.Next(0, 100);
                                    s = data1 + e1 + data2 + e2 + data3;
                                    dt = new DataTable();
                                    num = Convert.ToDouble(dt.Compute(s, "false"));
                                    re = new Result();
                                    m = re.result(num);
                                }
                        Console.WriteLine(data1 + e1 + data2 + e2 + data3+"="+num);
                                    break;
                            case 4:
                                data4 = random1.Next(0, 100);
                                data5 = random1.Next(0, 100);
                                data6 = random1.Next(0, 100);
                                data7 = random1.Next(0, 100);
                                string e3 = jisuanfu[random1.Next(0, 4)];
                                string e4 = jisuanfu[random1.Next(0, 4)];
                                string e5 = jisuanfu[random1.Next(0, 4)];
                                String s2 = data4 + e3 + data5 + e4 + data6 + e5 + data7;
                                DataTable dt2 = new DataTable();
                                double num2 = Convert.ToDouble(dt2.Compute(s2, ""));
                                Result re2 = new Result();
                                int m2 = re2.result(num2);
                                while (m2 < 0)
                                {
                                    data4 = random1.Next(0, 100);
                                    data5 = random1.Next(0, 100);
                                    data6 = random1.Next(0, 100);
                                    data7 = random1.Next(0, 100);
                                    s = data4 + e3 + data5 + e4 + data6 + e5 + data7;
                                    dt = new DataTable();
                                    num2 = Convert.ToDouble(dt.Compute(s, "false"));
                                    re2 = new Result();
                                    m2 = re2.result(num2);
                                }
                        Console.WriteLine(data4 + e3 + data5 + e4 + data6 + e5 + data7+'='+num2);
                                    break;
                        }
                    } 
             }
    }
    class Result
    {
        public int result(double n)
        {
            if (n < 0 || n > 1000000)
            {
                return -1;
            }
            if(Convert.ToString(n).Contains("."))
            {
                return -1;
            }
            else return 1;
        }
    }
}