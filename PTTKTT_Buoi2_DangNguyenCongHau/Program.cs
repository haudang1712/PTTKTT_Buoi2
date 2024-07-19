using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTKTT_Buoi2_DangNguyenCongHau
{
    class Program
    {

        public static void Main()
        {
            Console.InputEncoding = UnicodeEncoding.Unicode;
            Console.OutputEncoding = UnicodeEncoding.Unicode;

            Console.WriteLine("Chọn bài toán:");
            Console.WriteLine("1. Tìm kiếm nhị phân.");
            Console.WriteLine("2. Sắp xếp MergeSort.");
            Console.WriteLine("3. Sắp xếp QuickSort.");

            Console.WriteLine("Chọn 1 số đi brooo.");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    int[] arr = { 10, 20, 30, 40, 50,60,70,80,90 }; 
                    int n = arr.Length; 
                    int x = 20; 
  
                    int result = binarySearch(arr, 0, n - 1, x); 
  
                    if (result == -1) 
                        Console.WriteLine("Không tìm thấy"); 
                    else
                        Console.WriteLine("Giá trị ở vị trí "+ result);
                    Console.ReadKey();

                    break;
                case 2:
                    do
                    {
                        Console.Write("\nNhap vao so luong phan tu cua mang: ");
                        n = int.Parse(Console.ReadLine());
                    } while (n <= 0);
                    int[] intArray = new int[n];
                    Console.WriteLine("Nhap vao cac phan tu cua mang: ");
                    for (int i = 0; i < intArray.Length; i++)
                    {
                        intArray[i] = int.Parse(Console.ReadLine());
                    }
                    SortMethod(intArray, 0, n - 1);
                    Console.Write("Cac phan tu sau khi sap xep: ");
                    foreach (int item in intArray)
                    {
                        Console.Write(item + " ");
                    }
                    Console.WriteLine();

                    Console.ReadLine();
                    break;
                case 3:
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ.");
                    break;
            }
        }
        static int binarySearch(int[] arr, int left,
                            int right, int x)
        {
            if (right >= left)
            {
                int mid = left + (right - left) / 2;

 
                if (arr[mid] == x)
                    return mid;

                if (arr[mid] > x)
                    return binarySearch(arr, left, mid - 1, x);

                return binarySearch(arr, mid + 1, right, x);
            }

            return -1;
        }

        static public void MergeMethod(int[] numbers, int left, int mid, int right)
        {
            int[] temp = new int[25];
            int i, left_end, num_elements, tmp_pos;
            left_end = (mid - 1);
            tmp_pos = left;
            num_elements = (right - left + 1);
            while ((left <= left_end) && (mid <= right))
            {
                if (numbers[left] <= numbers[mid])
                    temp[tmp_pos++] = numbers[left++];
                else
                    temp[tmp_pos++] = numbers[mid++];
            }
            while (left <= left_end)
                temp[tmp_pos++] = numbers[left++];
            while (mid <= right)
                temp[tmp_pos++] = numbers[mid++];
            for (i = 0; i < num_elements; i++)
            {
                numbers[right] = temp[right];
                right--;
            }
        }
        static public void SortMethod(int[] numbers, int left, int right)
        {
            int mid;
            if (right > left)
            {
                mid = (right + left) / 2;
                SortMethod(numbers, left, mid);
                SortMethod(numbers, (mid + 1), right);
                MergeMethod(numbers, left, (mid + 1), right);
            }
        }
    }
}
