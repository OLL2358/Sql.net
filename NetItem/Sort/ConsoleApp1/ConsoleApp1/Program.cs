using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    //排序
    {
        public static int[] arr = new int[] { 63, 4, 24, 1, 3, 15 };
        static void Main(string[] args)
        {

            //MaoPao();
            //ChaRu();
            XuanZe();

            for (int i = 0; i < arr.Length; i++)
            {

                Console.WriteLine("{0}", arr[i] + " ");
            }
            Console.ReadKey();

        }
        /// <summary>
        /// 冒泡排序
        /// </summary>
        public static void MaoPao()
        {
            int j, temp;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                j = i + 1;
                id:
                if (arr[i] > arr[j])//就是拿arr[i]和余下的比较,比它小就交换值
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    goto id;
                }
                else
                {
                    if (j < arr.Length - 1)
                    {
                        j++;
                        goto id;
                    }
                }
            }

        }
        /// <summary>
        /// 插入排序 
        /// </summary>
        public static void ChaRu()
        {
            for (int j = 0; j < arr.Length; j++)
            {
                int temp = arr[j];
                int i = j;
                while (i > 0 && (arr[i - 1] > temp))
                {
                    arr[i] = arr[i - 1];
                    --i;
                }
                arr[i] = temp;
            }
        }
        /// <summary>
        /// 选择排序
        /// </summary>
        public static void XuanZe()
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[i])
                    {
                        int t = arr[j];
                        arr[j] = arr[i];
                        arr[i] = t;
                    }
                }
            }
           
        }

    }
}
