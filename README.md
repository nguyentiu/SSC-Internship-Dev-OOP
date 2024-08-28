# SSC-Internship-Dev-OOP
# Hướng Dẫn Về Lập Trình Hướng Đối Tượng (OOP - Object Oriented Programming) Trong C#

## 1. Giới Thiệu Về OOP
- **Định Nghĩa**:
  - Lập trình hướng đối tượng (Object-Oriented Programming - OOP) là một mô hình lập trình sử dụng các đối tượng và lớp để thiết kế và xây dựng ứng dụng. Cách tiếp cận này tập trung vào việc mô phỏng các thực thể trong thế giới thực thành các đối tượng, bao gồm cả dữ liệu (thuộc tính) và hành vi (phương thức).
  
- **Tại Sao Cần Dùng OOP?**
  - Mô Phỏng Thế Giới Thực: OOP cho phép bạn mô phỏng các tình huống trong thế giới thực một cách hiệu quả bằng cách sử dụng các đối tượng đại diện cho các thực thể.
  - Tái Sử Dụng Mã: Thông qua kế thừa, các lớp có thể tái sử dụng mã hiện có, giúp việc phát triển nhanh hơn và hiệu quả hơn.
  - Dễ Dàng Bảo Trì: Bằng cách đóng gói mã trong các đối tượng, OOP tạo ra một cấu trúc rõ ràng, giúp mã dễ bảo trì và cập nhật hơn.
  - Khả Năng Mở Rộng: OOP hỗ trợ tạo ra các hệ thống có khả năng mở rộng bằng cách cho phép tính mô đun hóa và linh hoạt.

## 2. Lớp và Đối Tượng
- **Lớp (Class)**:
  - Lớp là một bản thiết kế (blueprint) để tạo ra các đối tượng. Nó định nghĩa các thuộc tính (attributes) và phương thức (functions) mà một đối tượng được tạo từ lớp đó sẽ có.
  - **Ví Dụ**:
    ```csharp
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
    
        public void StartEngine()
        {
            Console.WriteLine("Engine started");
        }
    }
    ```
  - **Giải Thích**:
    - `Car` là một lớp có các thuộc tính `Brand`, `Model`, và `Year`, cùng với một phương thức `StartEngine` đại diện cho hành vi của một chiếc xe.

- **Đối Tượng (Object)**:
  - Đối tượng là một thể hiện của lớp. Nó đại diện cho một thực thể cụ thể với các thuộc tính và hành vi đã được định nghĩa bởi lớp.
  - **Ví Dụ**:
    ```csharp
    Car myCar = new Car();
    myCar.Brand = "Toyota";
    myCar.Model = "Corolla";
    myCar.Year = 2020;
    myCar.StartEngine();
    ```
  - **Giải Thích**:
    - `myCar` là một đối tượng của lớp `Car`. Nó có các giá trị cụ thể cho `Brand`, `Model`, và `Year`, và nó có thể thực hiện hành vi `StartEngine`.
## 3. Tính đóng gói (Encapsulation)

### Lý thuyết:
Tính đóng gói là khái niệm đóng gói dữ liệu (thuộc tính) và phương thức (hàm) mà thao tác trên dữ liệu đó vào một đơn vị duy nhất, gọi là lớp. Điều này giúp hạn chế truy cập vào các thành phần nhất định và bảo vệ dữ liệu khỏi việc truy cập và sửa đổi không được phép.

### Các phạm vi truy cập:
- **public:** Thành phần có thể được truy cập từ bất kỳ đâu.
- **private:** Thành phần chỉ có thể được truy cập trong cùng một lớp.
- **protected:** Thành phần có thể được truy cập trong cùng một lớp và bởi các lớp dẫn xuất.
- **internal:** Thành phần có thể được truy cập trong cùng một assembly.

### Ví dụ:
```csharp
public class BankAccount
{
    private decimal balance;

    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            balance += amount;
        }
    }

    public decimal GetBalance()
    {
        return balance;
    }
}
```
- **Giải Thích**:
  - Trường `balance` là `private`, có nghĩa là nó chỉ có thể được truy cập trong lớp `BankAccount`. Phương thức `Deposit` cho phép điều chỉnh `balance` một cách có kiểm soát, và `GetBalance` cung cấp truy cập có kiểm soát đến giá trị của nó.
## 4. Kế thừa (Inheritance)

### Lý thuyết:
Kế thừa cho phép một lớp mới (lớp dẫn xuất) kế thừa các thuộc tính và phương thức từ một lớp hiện có (lớp cơ bản). Điều này giúp tái sử dụng mã và tạo ra một cấu trúc phân cấp lớp.

### Ví dụ:
```csharp
public class Animal
{
    public string Name { get; set; }
    public void Eat()
    {
        Console.WriteLine("Eating...");
    }
}

public class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Barking...");
    }
}
```
- **Giải Thích**:
  - `Animal` là một lớp cơ bản với thuộc tính `Name` và phương thức `Eat`.
  - `Dog` là một lớp dẫn xuất kế thừa thuộc tính `Name` và phương thức `Eat` từ lớp `Animal`. Lớp `Dog` cũng thêm phương thức `Bark` riêng của nó.
## 5. Tính đa hình (Polymorphism)

### Lý thuyết:
Tính đa hình cho phép các phương thức thực hiện các công việc khác nhau dựa trên đối tượng mà nó tác động. Nó có thể đạt được thông qua nạp chồng phương thức (tính đa hình thời gian biên dịch) và ghi đè phương thức (tính đa hình thời gian chạy).

### Nạp chồng phương thức:
Nạp chồng phương thức cho phép nhiều phương thức cùng tên nhưng khác kiểu tham số trong cùng một lớp.

```csharp
public class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public double Add(double a, double b)
    {
        return a + b;
    }
}
```
- **Giải Thích**: Phương thức Add được nạp chồng với hai phiên bản
  - Một phiên bản nhận hai số nguyên (`int`).
  - Một phiên bản nhận hai số thực (`double`).

### Ghi đè phương thức:
Ghi đè phương thức cho phép một lớp dẫn xuất cung cấp một triển khai cụ thể của phương thức đã được định nghĩa trong lớp cơ bản.

```csharp
public class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("Animal sound");
    }
}

public class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Bark");
    }
}
```
- **Giải Thích**:
  - Phương thức `Speak` trong lớp `Animal` được đánh dấu là `virtual`, cho phép các lớp dẫn xuất ghi đè phương thức này.
  - Lớp `Dog` ghi đè phương thức `Speak` của lớp `Animal`, cung cấp một triển khai cụ thể cho lớp `Dog`.

## 6. Tính trừu tượng (Abstraction)

### Lý thuyết:
Tính trừu tượng là khái niệm về việc ẩn đi các chi tiết thực hiện bên trong của một phương thức và chỉ hiển thị chức năng cho người dùng. Nó được triển khai bằng cách sử dụng lớp trừu tượng và giao diện.

### Ví dụ:
```csharp
public abstract class Shape
{
    public abstract double GetArea();
}

public class Circle : Shape
{
    public double Radius { get; set; }
    
    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
}
```
- **Giải Thích**:
  - Lớp `Shape` là một lớp trừu tượng với phương thức trừu tượng `GetArea`. Lớp `Circle` kế thừa từ `Shape` và cung cấp triển khai của riêng nó cho phương thức `GetArea`.
### Ví dụ về Giao diện:
```csharp
public interface IMovable
{
    void Move();
}

public class Car : IMovable
{
    public void Move()
    {
        Console.WriteLine("Car is moving");
    }
}
```
- **Giải Thích**:
  - Giao diện `IMovable` định nghĩa phương thức `Move`. Lớp `Car` triển khai giao diện này và cung cấp triển khai cụ thể của phương thức `Move`.
 
## 7. Bài tập tự luyện
- **Bài Tập 1**: Tạo lớp Person với các trường private cho tên, tuổi và email. Triển khai các phương thức công khai để thiết lập và lấy giá trị của các trường này. Tạo một lớp kế thừa Student, thêm trường studentID và phương thức để hiển thị thông tin sinh viên.
- **Bài Tập 2**: Triển khai lớp trừu tượng Shape với một phương thức trừu tượng GetArea. Tạo hai lớp kế thừa, Rectangle và Triangle, triển khai GetArea theo các công thức cụ thể của chúng.
- **Bài Tập 3**: Viết một chương trình chứng minh việc nạp chồng phương thức (method overloading) bằng cách tạo lớp Calculator với nhiều phương thức Add cho các kiểu dữ liệu khác nhau. Đồng thời, chứng minh việc ghi đè phương thức (method overriding) bằng cách tạo lớp cơ sở Employee và lớp kế thừa Manager với phương thức GetRole đã bị ghi đè.

## 8. Nguồn tham khảo
- **https://www.w3schools.com/cs/cs_oop.php**
- **https://viblo.asia/p/lap-trinh-huong-doi-tuong-oop-L4x5xJxrZBM**
