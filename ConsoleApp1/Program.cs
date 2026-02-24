// See https://aka.ms/new-console-template for more information
/*
/* Biến : trong c# giống c++
    - Biến dùng để lưu trữ dữ liệu từ bàn phím hoặc trả về từ trong phần mềm
    - Đặc điểm:
        + Biến là duy nhâất
        + Mỗi bien co 1 kieu du lieu
        + Gia tri cua moi bien co the thay doi
    - Khai bao bien:
        + Khai bao bien khong co gia tri
            Data_type variable_name;
        + Khai bao bien co gia tri cua bien
            Data_type variabke_name = value;
    - Quy tac dat ten bien:
        + Ten bien chua ky tu chu cai(hoa, thuong), so, _
        + Ten bien khong chua ky tu dac biet
        + Ten bien phan biet hoa thuong
        + Ten bien khong duoc trung tu khoa
        + Ten bien khong trung nhau
*/

/*Kieu du lieu(data type): giong c++
    - La kieu cua gia tri ma bien co luu
    - 1 so kieu du lieu co ban:
        + so nguyen: int
        + so thuc: float || double
        + chuoi: string
*/

/* Toan tu(operator): Giong c++
    - La ky hieu the hien cho cac phep toan
    - 1 so loai toan tu
        + Toan tu so hoc: +, -, *, /, %
        + toan tu quan he: >, <, >=, <=, =, !=
        + toan tu logic: &&, ||, !
        + toan tu bit
        + toan tu gan: =, +=, -=, *=, /=, %=
*/

/* Condition (cau truc dieu khien re nhanh):
    - Thuc hien 1 khoi lenh khi 1 dieu kien nao do duoc thoa man
    Cau truc:
    
    if(condition){
        code block;
    }
    
    i(condition){
        code block1;
    } eles {
        code block2;
    }
    
    if(condition_1){
        code block1;
    } elesif(condition_2){
        code block2;
    } elesif(condition_3){
        code block3;
    }
    .... eles {
        code block n;
    }
    
    if(condition_1){
        if(condition_2){
            code block 1;
        }
    }
    
    Cua truc lua chon switch - case
    Dac diem: 
        + Chi ap dung khi tat ca cac dieu kien deu la so sanh =
        + Khi tim thay case thoa ma: thuc hien case do va ta ca case
            duoc viet ben duoi case thoa man
        Switch(Bien_dang_can_duoc_so_sanh){
            case gia_tri:
                code block;
                break;
            ...
            default:
                code block;
                break;
        }        
*/

/*
    Nhap xuat co ban:
    - Nhap tu ban phim
    Console.Read(): Nhap 1 ky tu tu ban phim, luu tru duoi dang so nguyen
    Console.ReadLine(): mhap 1 chuoi ky tu, nhap sao luu vay
    - Hien thi du lieu ra man hinh
    Console.Write(): in tren 1 dong
    Console.WriteLine(): in xuong dong
*/

/*
    Ep kieu:
    Ep sang int: int.Pare(gia_tri_can_ep)
 */

int so1 = int.Parse(Console.ReadLine());
int so2 =  int.Parse(Console.ReadLine());
Console.WriteLine(so1 + so2);

/*
    1. Nhap 2 so thuc a, b tu ban phim.
    Tinh tong, hieu, tich, thuong
*/
//Khai bao a,b
double a;
double b;
//Nhap a, b
Console.Write("a = ");
a = double.Parse(Console.ReadLine());
Console.Write("b = ");
b = double.Parse(Console.ReadLine());
//Tinh
double tong = a + b; 
double hieu = a - b;
double tich = a * b;
double thuong = a % b;
//Hien thi ket qua
Console.WriteLine("a + b = " + tong);
Console.WriteLine("a + b = " + hieu);
Console.WriteLine("a + b = " + tich);
Console.WriteLine("a + b = " + thuong);

/*
 * 
 */
 
 // khai bao n
 int n;
 // nhap n
 Console.Write("n = ");
 n = int.Parse(Console.ReadLine());
 // kiem tra
 if (n < 0)
 {
     Console.WriteLine(n + " la so am");
 }
 else if (n > 0)
 {
     Console.WriteLine(n + " la so duong");
 }
 else
 {
     Console.WriteLine(n + "khong xac dinh");
 }

 /*
  * Nhap 1 so nguyen. Kiem tra so nguyen do la so chan hay le
  */
 double number;
Console.Write("number = ");
number = double.Parse(Console.ReadLine());
if (number % 2 == 0)
{
    Console.WriteLine(number + " La so chan");
}
else
{
    Console.WriteLine(number + " la so le");
}
  /*
   * Nhap so tuoi cua 1 nguoi tu ban phim (tuoi la so nguyen) 
    Kiem tra: 
    Neu tuoi > 0 && tuoi < 6: hoc mau giao 
    Neu tuoi >= 6 && tuoi < 11: hoc cap 1 
    Neu tuoi >= 11 && tuoi < 16: hoc cap 2 
    Neu tuoi >= 16 && tuoi < 18: hoc cap 3 
    Neu tuoi >= 18 && tuoi < 23: Hoc dai hoc 
    Neu tuoi >= 23 && tuoi <= 65: Di lam 
    Con lai: Nghi huu 
   */
double age;
Console.Write("Vui long nhap tuoi: ");
age = double.Parse(Console.ReadLine());
if (age > 0 && age < 6)
{
    Console.WriteLine(age + " Hoc mau giao ");
} else if (age >= 6 && age < 11)
{
    Console.WriteLine(age + " Hoc cap 1");
}
else if (age >= 11 && age < 16)
{
    Console.WriteLine(age + " Hoc cap 2");
}
else if (age >= 16 && age < 18)
{    Console.WriteLine(age + " hoc cap 3");}
else if(age >= 18 && age < 23)
{ Console.WriteLine(age + " Hoc dai hoc");}
else if (age >= 23 && age <= 65)
{
    Console.WriteLine(age + " di lam");
}
else
{
    Console.WriteLine("Nghi huu");
}
   /*
    * Nhap diem trung binh cua 1 hoc sinh. 
    Neu diem > 0 && diem < 5 => Yeu 
    Neu diem >= 5 && diem < 6.5 => trung binh 
    Neu diem >= 6.5 && diem < 8 => Kha 
    Con lai => gioi 
    */
double ponit;
Console.Write("Vui long nhap diem: ");
ponit = double.Parse(Console.ReadLine());
if (ponit > 0 && ponit < 5)
{
    Console.WriteLine("Yeu");
} else if (ponit >= 5 && ponit < 6.5)
{
    Console.WriteLine(" Trung binh");
} else if (ponit >= 6.5 && ponit < 8)
{
    Console.WriteLine("kha");
}
else if (ponit >= 8 && ponit < 10)
{
    Console.WriteLine(" Gioi");
}
else
{
    Console.WriteLine("So diem khong hop le");
}
    /*
     * Nhap thang la 1 so nguyen. Hien thi so ngay trong thang do
     */
    int month;
    Console.Write("Nhap thang: ");
    month = int.Parse(Console.ReadLine());
    if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 11)
    {
        Console.WriteLine("Thang co 31");
    } else if (month == 4 || month == 6 || month == 9 || month == 12)
    {
        Console.WriteLine("Thang co 30");
    } else if (month == 2)
    {
        Console.WriteLine("Thang co 29");
    }
    else
    {
        Console.WriteLine("Thang khong ton tai");
    }
     /*
      * Nhap 3 so nguyen a, b, c. 
    Hien thi so lon nhat va so nho nhat trong 3 so 
      */
    Console.WriteLine("Vui long nhap 3 so:");
    int number1;
    int number2;
    int number3;
    Console.Write("Nhap number1: ");
    number1 = int.Parse(Console.ReadLine());
    Console.Write("Nhap number2: ");
    number2 = int.Parse(Console.ReadLine());
    Console.Write("Nhap number3: ");
    number3 = int.Parse(Console.ReadLine());
    int max = number1;
    if (number2 > max) max = number2;
    if (number3 > max) max = number3;
    int min = number1;
    if (number2 < min) min = number2;
    if (number3 < min) min = number3;
    Console.WriteLine("SLN" + max);
    Console.WriteLine("SNN" + min);
      /*
       * Nhap 3 so thuc a, b, c. 
    Kiem tra 3 so do co tao thanh tam giac khong.
       */
      Console.WriteLine("Vui long nhap 3 so thuc:");
      double x;
      double y;
      double z;
      Console.Write("Nhap z: ");
      x = int.Parse(Console.ReadLine());
      Console.Write("Nhap y: ");
      y = int.Parse(Console.ReadLine());
      Console.Write("Nhap z: ");
      z = int.Parse(Console.ReadLine());
      if(x > 0 &&  y > 0 && z > 0 && x + y > z && x + z > y  && y + z > a){
              Console.WriteLine("3 So tao len 1 tam giac");
      }
      else
      {
          Console.WriteLine("3 So khong tao len 1 tam giac");
      }
      
//==== Buoi3

/*
    Vong lap(loop):
        - Thuc hien 1 khoi lenh duoc lap lai nhieu lan
        - 3 loai vong lap: for, while, do - while
        - for:
            + cau truc
                for(tham so 1; tham so 2; tham so 3){
                    code block;
                }
            + tham so1: khoi diem bat dau vong lap: xac dinh xem vong lap bat dau tu dau.
                Neu thieu tham so1: Loi cu phap.
            + Tham so2: dieu kien duy tri vong lap: xac dinh xem khi nao vong lap dung.
                Neu thieu tham so2: vong lap vo han.
            + tham so3: buoc nhay vong lap: thay doi dieu kien bat dau cua vong lap tiep theo.
                Neu thieu tham so3: vong lap vo han.
            + vong lap for: kiem tra truoc, thuc hien sau: kiem tra tham so 2 truoc, roi moi thuc hien vong lap
                -> vong lap for co the duoc thuc hien 0 den n lan.
                -> vong lap for duoc dung khi biet duoc so lan lap
        - while
            + cau truc
                tham so 1;
                while(tham so2){
                    code block;
                    tham so3;
                }
            + vong lap while: kiem tra truoc, thuc hien sau: kiem tra tham so 2 truoc, roi moi thuc hien vong lap
                -> Vong lap while co the duoc thuc hien 0 hoac n lan
                -> vong lap while duoc  dung khi biet truoc so lan lap hoac khong biet so lan lap.
        - do - while
            + cau truc:
                tham so 1;
                do {
                    code block;
                    tham so3;
                } while (tham so2);
                
                do {
                    tham so1:
                    code block;
                } while (tham so2);
            + Vong lap do - while : thực hiên trước, kiểm tra sau: thực hien code block truoc kiem tra tham so sau
                -> vong lap do - while: luon thuc hien it nhat 1 lan
                -> vong lap do - while: duoc dung khi biet truoc so lan lap hoac khong biet so lan lap
 */


    /*
     * in cac so tu 1 den 10
     */
     
     /*
        mang (array)
           - la 1 tap hop cac phan tu co cung kieu du lieu
           - cac phan tu duoc phan biet bang 1 so nguyen duoc goi la chi so index
           - index bat dau tu 0
           - khai bao mang:
                data_type[] array_name = new data_type(number_element)
            - Truy xuất 1 phần tử trong mảng:
            array_name[index];
        - Truy xuất lần lượt từng phần tử trong mảng: dùng vòng lặp chạy theo index
            => vòng lặp chạy từ 0 đến number_element - 1
      */



       
      