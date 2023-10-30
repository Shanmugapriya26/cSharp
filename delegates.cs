using System;
delegate int Calci(int n);
public class HelloWorld {
  static int number=100;
  public static void Main(string[] args) {
    Calci c1 = new Calci(add);
    Console.WriteLine(c1(10));
  }
    public static int add(int n){
        number+=n;
        return number;
    }
}
