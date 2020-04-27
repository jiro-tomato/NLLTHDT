using System;
using System.Collections;

namespace stack
{
  class Program //1812832_NguyenNgocQuang
  {
    static void Main(string[] args)
    {
      // Tạo 1 Stack rỗng
      Stack MyStack = new Stack();

      // Thực hiện thêm phần tử vào Stack thông qua hàm Push.
      MyStack.Push("Dog");
      MyStack.Push("Cat");
      MyStack.Push("Fish");

      Console.WriteLine(" So phan tu hien tai cua Stack la: {0}", MyStack.Count);


      Console.WriteLine(" Phan tu dau cua Stack la: {0}", MyStack.Peek());

      Console.WriteLine(" So phan tu cua Stack sau khi goi ham Peek: {0}", MyStack.Count);

      // Thực hiện xoá các phần tử ra khỏi Stack.
      Console.WriteLine(" Popping...");
      int Length = MyStack.Count;
      for (int i = 0; i < Length; i++)
      {
        Console.Write(" " + MyStack.Pop());
      }
      Console.WriteLine();

      // Kiểm tra lại số phần tử của Stack sau khi Pop
      Console.WriteLine(" So phan tu cua Stack sau khi Pop la: {0}", MyStack.Count);
    }
  }
}
