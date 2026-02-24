
//Nhap mang so thuc co n phan tu, n nhap tu ban phim. Tinh tong gia tri cua cac phan tu trong mang.
Console.Write("Nhap n: ");
int t = int.Parse(Console.ReadLine());
double[] arr = new double[t];
double tong = 0;

for (int i = 0; i < t; i++)
{
  Console.Write("arr[" + i + "] =");
  arr[i] = double.Parse(Console.ReadLine());
  tong += arr[i];
}

Console.WriteLine("Tong = " + tong);

//Nhap mang so thuc co n phan tu. Dem so phan tu co gia tri duong trong mang

Console.Write("Nhap n: ");
int N = int.Parse(Console.ReadLine());
double[] ar = new double[N];
int dem = 0;

for (int i = 0; i < N; i++)
{
  Console.Write("arr[" + i + "] =");
  ar[i] = double.Parse(Console.ReadLine());
  if (ar[i] > 0){dem++;}
}

Console.WriteLine("So phan tu duong = " + dem);

//Nhap mang so nguyen co n phan tu. Nhap so nguyen x tu ban phim. Dem so lan x xuat hien trong mang

Console.Write("Nhap n: ");
int A = int.Parse(Console.ReadLine());
int[] mangr = new int[A];

for (int i = 0; i < A; i++)
{
  Console.Write("arr[" + i + "] =");
  mangr[i] = int.Parse(Console.ReadLine());
}

Console.Write("Nhap x: ");
int X = int.Parse(Console.ReadLine());

int count = 0;
for (int i = 0; i < mangr.Length; i++) 
{
  if (mangr[i] == X) count++;
}

Console.WriteLine("So lan " + X + "xuat hien:" + count);

//Nhap mang so thuc co n phan tu. Tim max, min
  Console.Write("Nhap n: ");
  int m = int.Parse(Console.ReadLine());
  double[] array = new double[m];

  for (int i = 0; i < m; i++)
  {
    Console.Write("arr[" + i + "] =");
    array[i] = double.Parse(Console.ReadLine());
  }

  double max = array[0], min = array[0];
  for (int i = 1; i < m; i++)
  {
    if (array[i] > max)
      max = array[i];

    if (array[i] < min)
      min = array[i];
  }

  Console.WriteLine("Gia tri lon nhat: " + max);
  Console.WriteLine("Gia tri nho nhat: " + min);


//Nhap mang so nguyen co n phan tu. Tim phan tu co gia tri lon thu 2 trong mang

  Console.Write("Nhap n: ");
  int G = int.Parse(Console.ReadLine());
  int[] ay = new int[G];

  for (int i = 0; i < G; i++)
  {
    Console.Write($"Nhap a[{i}]: ");
    ay[i] = int.Parse(Console.ReadLine());
  }

  int max1 = int.MinValue;
  int max2 = int.MinValue;

  for (int i = 0; i < G; i++)
  {
    if (ay[i] > max1)
    {
      max2 = max1;
      max1 = ay[i];
    }
    else if (ay[i] > max2 && ay[i] < max1)
    {
      max2 = ay[i];
    }
  }

  Console.WriteLine("Gia tri lon thu 2 = " + max2);


//Nhap mang so thuc co n phan tu. Sap xep mang theo chieu tang dan.
  Console.Write("Nhap n: ");
  int P = int.Parse(Console.ReadLine());
  double[] mangrn = new double[P];

  for (int i = 0; i < P; i++)
  {
    Console.Write($"Nhap a[{i}]: ");
    mangrn[i] = double.Parse(Console.ReadLine());
  }

  Array.Sort(mangrn);

  Console.WriteLine("Mang sau khi sap xep:");
  for (int i = 0; i < mangrn.Length; i++)
  {
    Console.Write(mangrn[i] + " ");
  }



//Nhap mang so nguyen co n phan tu. Nhap 2 so nguyen m, k. Chen gia tri m vao vi tri co index = k trong mang

  Console.Write("Nhap n: ");
  int J = int.Parse(Console.ReadLine());
  int[] aray = new int[J];

  for (int i = 0; i < J; i++)
  {
    Console.Write($"Nhap a[{i}]: ");
    aray[i] = int.Parse(Console.ReadLine());
  }

  Console.Write("Nhap m: ");
  int M = int.Parse(Console.ReadLine());
  Console.Write("Nhap k: ");
  int K = int.Parse(Console.ReadLine());

  List<int> list = new List<int>(aray);
  list.Insert(K, M);

  Console.WriteLine("Mang sau khi chen:");
  for (int i = 0; i < list.Count; i++)
  {
    Console.WriteLine(list[i]);
  }


//Nhap mang so nguyen co n phan tu. Hien thi tat ca cac phan tu la so nguyen to trong mang
  Console.Write("Nhap n: ");
  int V = int.Parse(Console.ReadLine());
  int[] aryt = new int[V];

  for (int i = 0; i < V; i++)
  {
    Console.Write($"Nhap a[{i}]: ");
    aryt[i] = int.Parse(Console.ReadLine());
  }
  Console.Write("Nhap k: ");
  int H = int.Parse(Console.ReadLine());

  List<int> list = new List<int>(aray);
  list.RemoveAt(H);

  Console.WriteLine("Mang sau khi chen:");
  for (int i = 0; i < list.Count; i++)
  {
    Console.WriteLine(list[i]);
  }
//Nhap mang so thuc co n phan tu. Nhap so nguyen k. Xoa phan tu co index = k khoi mang.

Console.Write("Nhap e! = ");
int e = int.Parse(Console.ReadLine());

long gt = 1;

for (int i = 1; i <= e; i++)
{
  gt *= i;
}

Console.WriteLine("gthua: " + gt);


int c;
Console.WriteLine("nhap c: ");
c = int.Parse(Console.ReadLine());
for (int j = 1; j <= c; j++)
{
  if (j % 2 == 0)
  {
    Console.WriteLine("Cac so chan tu 1 den n : " + j);
  }
}

 int n ;
 Console.WriteLine("nhap n:");
 n = int.Parse(Console.ReadLine());
 int sum = 0;
 for(int i = 1; i <= n; i++)
   if(i % 3 == 0 || i % 7 == 0)
     sum += i;
 Console.WriteLine("Tong cac so: " + sum);
//Nhap so nguyen n tu ban phim. Kiem tra n co phai so nguyen to hay khong
 int numberN;
  Console.WriteLine("nhap n:");
  numberN = int.Parse(Console.ReadLine());
  int sumN = 0;
  while(n > 0) {
    sum += n % 10;
    n /= 10;
  }
  Console.WriteLine("Tong cac so: " + sum);
 //Nhap so nguyen n tu ban phim. Kiem tra n co phai so nguyen to hay khong
 Console.Write("Nhap r: ");
 int r = int.Parse(Console.ReadLine());

 bool isPrime = r > 1;

 for (int i = 2; i <= Math.Sqrt(r); i++)
 {
   if (r % i == 0)
   {
     isPrime = false;
     break;
   }
 }

 if (isPrime)
   Console.WriteLine(r + " la so nguyen to");
 else
   Console.WriteLine(r + " khong phai la so nguyen to");
//Nhap so nguyen n tu ban phim. Hien thi cac so nguyen to trong khoang tu 1 den n 
 

/*
Hinh 3
*
* *
* * *
* * * *
* * * * *
 */
 int o = 5;
 for (int i = 0; i < o; i++)
 {
   for (int j = 0; j <= i; j++)
     Console.Write("* ");
   Console.WriteLine();
 }

/*
 Hinh 4
* * * * *
* * * *
* * *
* *
*
 */
 int h = 5;
 for (int i = h; i >= 1; i--)
 {
   for (int j = 1; j <= i; j++)
     Console.Write("* ");
   Console.WriteLine();
 }

/*Hinh 2

* * * * *
*       *
*       *
*       *
* * * * *
*/
 int k = 5;
 for (int i = 0; i < k; i++)
 {
   for (int j = 0; j < k; j++)
   {
     if (i == 0 || i == k - 1 || j == 0 || j == k - 1)
       Console.Write("* ");
     else
       Console.Write("  ");
   }
   Console.WriteLine();
 }

/*
Hinh 1
* * * * *
* * * * *
* * * * *
* * * * *
* * * * *
 */
 int w = 5;
 for (int i = 1; i <= w; i++)
 {
   for (int j = 1; j <= w; j++)
     Console.Write("* ");
   Console.WriteLine();
 }
/*
Hinh 5

        1

      121

    12321

  1234321

123454321
 */
 int g = 5;
 for (int i = 1; i <= g; i++)
 {
   for (int space = 1; space <= g - i; space++)
     Console.Write("  ");

   for (int j = 1; j <= i; j++)
     Console.Write(j);

   for (int j = i - 1; j >= 1; j--)
     Console.Write(j);

   Console.WriteLine();
 }

//Nhap so nguyen n. Tinh S = 1/1 + 1/2 + 1/3 + ... + 1/n
 Console.Write("Nhap a: ");
 int a = int.Parse(Console.ReadLine());
 double s = 0;

 for (int i = 1; i <= a; i++)
   s += 1.0 / i;

 Console.WriteLine("Tong S = " + s);

//Nhap mang co 10 so nguyen. Hien thi cac phan tu co gia tri chan
 int[] mang = new int[10];

 for (int i = 0; i < 10; i++)
 {
   Console.Write("arr[" + i + "] = ");
   mang[i] = int.Parse(Console.ReadLine());
 }

 Console.WriteLine("Cac phan tu chan:");
 for (int i = 0; i < mang.Length; i++)
 {
   if (mang[i] % 2 == 0)
     Console.Write(mang[i] + " ");
 }











