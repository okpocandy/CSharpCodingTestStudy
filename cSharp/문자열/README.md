# 문자열

1. [문자열 입력](#문자열-입력)
2. [문자열 분리](#문자열-분리)
3. [문자열 출력](#문자열-출력)
4. [문자열 비교](#문자열-비교)

## 문자열 입력
C#에서도 문자열을 입력받는 두 가지 방법이 있습니다. Console.ReadLine()과 StreamReader.ReadLine()입니다.
* **Console.ReadLine():**
   
  콘솔에서 사용자로부터 한 줄의 문자열을 입력 받습니다.
  
  Console 클래스의 정적 메서드이며, 콘솔 응용 프로그램에서 주로 사용됩니다.
  
  개행 문자(\n)가 입력될 때까지의 문자열을 읽어옵니다.
  ```C#
  string input = Console.ReadLine(); // 콘솔에서 문자열 입력 받기
  StreamReader.ReadLine():
  ```
  [참조](https://learn.microsoft.com/ko-kr/dotnet/api/system.console.readline?view=net-8.0#system-console-readline)

* **StreamReader.ReadLine():**
    
  파일 등의 스트림에서 한 줄의 문자열을 읽어옵니다.
  
  StreamReader 클래스를 사용하여 파일을 읽는 경우 주로 사용됩니다.
  
  개행 문자가 입력될 때까지의 문자열을 읽어옵니다.
  
  ```C#
  using System.IO;
  
  StreamReader reader = new StreamReader("input.txt"); // 파일에서 문자열 입력 받기
  string line = reader.ReadLine();
  ```
  [참조](https://learn.microsoft.com/ko-kr/dotnet/api/system.io.streamreader.readline?view=net-8.0#system-io-streamreader-readline)
  
이 두 가지 방법을 사용하여 C# 프로그램에서 문자열을 입력받을 수 있습니다.

----------------------------

### 문자열 앞뒤 공백 문자 제거 

* **String.Trim()**

  Trim() 메서드는 문자열의 시작과 끝에 있는 공백을 제거합니다.

  문자열 내의 공백은 유지되며, 문자열의 시작과 끝에만 있는 공백이 제거됩니다.

  주로 사용자 입력을 처리할 때 공백으로 인한 오류를 방지하거나, 문자열을 비교할 때 공백으로 인한 차이를 없앨 때 사용됩니다.

  ```C#
  string input = "  Hello, world!  ";
  string trimmed = input.Trim(); // 시작과 끝의 공백을 제거한 문자열을 반환
  
  Console.WriteLine(trimmed); // "Hello, world!" 출력
  ```
  [참조](https://learn.microsoft.com/ko-kr/dotnet/api/system.string.trim?view=net-8.0)


## 문자열 분리

   문자열 분리는 하나의 문자열을 특정 기준에 따라 여러 부분으로 나누는 작업을 말합니다. 이 작업은 데이터 처리나 분석에서 매우 일반적이며, 예를 들어 CSV 파일에서 데이터를 추출하거나 특정 형식의 로그를 파싱할 때 사용될 수 있습니다.

* **String.Split()**
  
   `String.Split()` 메서드를 사용하여 문자열을 지정된 구분자를 기준으로 분리할 수 있습니다. 반환된 값은 문자열 배열이며, 각 배열 요소는 구분자를 기준으로 분리된 부분 문자열입니다.

  ```C#
   string data = "apple,banana,grape";
   string[] fruits = data.Split(','); // 쉼표를 기준으로 문자열 분리
  ```
   [참조](https://learn.microsoft.com/ko-kr/dotnet/api/system.string.split?view=net-8.0)

* **정규 표현식(Regular Expression)**

   정규 표현식을 사용하여 문자열을 분리할 수도 있습니다. `Regex.Split()` 메서드를 사용하여 구현할 수 있습니다. 이를 통해 더 복잡한 분리 규칙을 정의할 수 있습니다.

   ```C#
   using System.Text.RegularExpressions;
   
   string data = "apple,banana,grape";
   string[] fruits = Regex.Split(data, @"\s*,\s*"); // 쉼표와 공백을 기준으로 문자열 분리
   ```
   [참조](https://learn.microsoft.com/ko-kr/dotnet/api/system.text.regularexpressions.regex.split?view=net-8.0)



* **Substring() 메서드 사용**
   
   `Substring()` 메서드를 사용하여 문자열을 특정 위치에서 잘라내어 분리할 수도 있습니다.

   ```C#
   string data = "applebananaorange";
   string fruit1 = data.Substring(0, 5); // "apple"을 추출
   string fruit2 = data.Substring(5, 6); // "banana"를 추출
   string fruit3 = data.Substring(11); // "orange"를 추출
   ```
   [참조](https://learn.microsoft.com/ko-kr/dotnet/api/system.string.substring?view=net-8.0)


이러한 방법들을 사용하여 문자열을 쉽게 분리할 수 있으며, 각 상황에 맞게 가장 적합한 방법을 선택할 수 있습니다.


## 문자열 출력

문자열 출력은 C# 프로그램에서 매우 중요한 부분 중 하나입니다. 아래에는 다양한 방법으로 문자열을 출력하는 방법에 대해 정리해보겠습니다:

* **Console.WriteLine() 메서드 사용**

   `Console.WriteLine()` 메서드는 표준 출력에 문자열을 출력합니다. 출력 후 자동으로 개행 문자('\n')가 추가됩니다.

   ```C#
   string message = "Hello, world!";
   Console.WriteLine(message);
   ```
   [참조](https://learn.microsoft.com/ko-kr/dotnet/api/system.console.writeline?view=net-8.0)
* **Console.Write() 메서드 사용**

   `Console.Write()` 메서드는 Console.WriteLine()과 비슷하지만, 개행 문자가 추가되지 않습니다. 따라서 출력된 내용이 한 줄에 연속하여 출력됩니다.
   
   ```C#
   string message = "Hello, ";
   Console.Write(message);
   Console.WriteLine("world!");
   ```
  [참조](https://learn.microsoft.com/ko-kr/dotnet/api/system.console.write?view=net-8.0)

* **String.Format() 메서드 사용**

   `String.Format()` 메서드를 사용하여 서식화된 문자열을 생성하고 출력할 수 있습니다. 이를 사용하면 다양한 형식의 문자열을 생성할 수 있습니다.

   ```C#
   string name = "John";
   int age = 30;
   string message = String.Format("My name is {0} and I am {1} years old.", name, age);
   Console.WriteLine(message);
   ```
   [참조](https://learn.microsoft.com/ko-kr/dotnet/api/system.string.format?view=net-8.0)
   
* **보간 문자열(Interpolated String) 사용**

   C# 6.0부터 도입된 보간 문자열을 사용하면 문자열 내에서 변수를 직접 사용할 수 있습니다. 이는 코드를 읽고 작성하기 쉽게 만듭니다.
   
   ```C#
   string name = "John";
   int age = 30;
   string message = $"My name is {name} and I am {age} years old.";
   Console.WriteLine(message);
   ```
   [참조](https://learn.microsoft.com/ko-kr/dotnet/csharp/language-reference/tokens/interpolated)
  
* **StringBuilder 클래스 사용**
   
   여러 개의 문자열을 합쳐야 하는 경우 StringBuilder 클래스를 사용하여 성능을 향상시킬 수 있습니다. `console.WriteLine()`을 많이 사용하면 시간이 오래걸릴 수 있습니다. 그럴때는 StringBuilder 클래스를 사용하여 속도를 향상시킬 수 있습니다.
   
   ```C#
   StringBuilder sb = new StringBuilder();
   sb.Append("Hello, ");
   sb.Append("world!");
   Console.WriteLine(sb.ToString());
   ```
   [참조](https://learn.microsoft.com/ko-kr/dotnet/api/system.text.stringbuilder?view=net-8.0)

## 문자열 비교

문자열 비교는 두 문자열이 동일한지 또는 어떤 순서로 정렬되는지 확인하는 작업입니다. 다양한 프로그래밍 언어에서 문자열 비교 방법은 다르지만, 기본적으로 문자열의 **사전순** 또는 **유니코드 순**으로 비교합니다.

- `==` 연산자
`==` 연산자는 두 문자열이 동일한지 여부를 확인하는데 사용됩니다. 대소문자를 구분하여 비교합니다.

```csharp
string str1 = "hello";
string str2 = "hello";
string str3 = "Hello";

bool isEqual = (str1 == str2);  // true
bool isNotEqual = (str1 == str3);  // false (대소문자 차이)
```

- `Equals` 메서드
`Equals` 메서드도 두 문자열이 같은지 비교합니다. `==`와 유사하지만, 문자열 비교에 대해 더 많은 제어가 가능합니다.

```csharp
string str1 = "hello";
string str2 = "Hello";

bool isEqual = str1.Equals(str2);  // false
bool isEqualIgnoreCase = str1.Equals(str2, StringComparison.OrdinalIgnoreCase);  // true (대소문자 무시)
```

- `CompareTo` 메서드
`CompareTo` 메서드는 두 문자열을 사전순으로 비교합니다. 반환 값은 다음과 같습니다:
- **0**: 두 문자열이 동일
- **음수**: 첫 번째 문자열이 사전적으로 두 번째 문자열보다 앞에 있음
- **양수**: 첫 번째 문자열이 두 번째 문자열보다 뒤에 있음

```csharp
string str1 = "apple";
string str2 = "banana";

int result = str1.CompareTo(str2);  // 음수 값 (-1)
```

- `String.Compare`
`String.Compare`는 두 문자열을 비교하여 정수 값을 반환합니다. 이 메서드는 추가적인 옵션을 제공하며 대소문자 구분 여부 등을 설정할 수 있습니다.

```csharp
string str1 = "apple";
string str2 = "Apple";

int result = String.Compare(str1, str2, StringComparison.OrdinalIgnoreCase);  // 0 (대소문자 무시)
```

### 문자열 비교의 주의점
- **문화권**: 문자열 비교는 시스템의 문화권 설정에 따라 영향을 받을 수 있습니다. 특정 문화권에서는 문자의 대소문자 변환이나 정렬이 다르게 동작할 수 있습니다.
- **대소문자 구분**: 문자열 비교에서 대소문자를 구분할 것인지 설정하는 것이 중요합니다. 기본적으로 대소문자는 구분됩니다.

## 문자열 슬라이싱

**슬라이싱(Slicing)**은 문자열의 일부분을 추출하는 방법입니다. 슬라이싱은 문자열을 배열처럼 인덱스를 사용하여 접근할 수 있습니다. 

### 기본적인 슬라이싱

- `Substring` 메서드
`Substring` 메서드는 문자열의 일부를 추출할 때 사용됩니다. 시작 인덱스와 길이를 지정할 수 있습니다.

```csharp
string str = "Hello, World!";
string subStr = str.Substring(7, 5);  // "World"
```

- **시작 인덱스**: 문자열에서 어디서부터 슬라이싱할지 지정합니다. 인덱스는 0부터 시작합니다.
- **길이**: 추출할 문자열의 길이를 지정합니다.

- 슬라이싱에서 끝까지 가져오기
길이를 생략하면 시작 인덱스에서 문자열 끝까지 가져옵니다.

```csharp
string str = "Hello, World!";
string subStr = str.Substring(7);  // "World!"
```

### C#의 문자열 인덱서와 범위 연산자

C# 8.0 이후에는 **인덱서**와 **범위 연산자**를 사용하여 문자열을 슬라이싱할 수 있습니다.

- 인덱서 (Index)
`^` 연산자를 사용하여 뒤에서부터 인덱싱할 수 있습니다.

```csharp
string str = "Hello, World!";
char lastChar = str[^1];  // '!'
char secondLastChar = str[^2];  // 'd'
```

- 범위 연산자 (Range)
범위 연산자인 `..`을 사용하여 특정 범위를 쉽게 추출할 수 있습니다.

```csharp
string str = "Hello, World!";
string subStr = str[7..12];  // "World"
```

- **시작 인덱스**와 **종료 인덱스**를 지정하여 그 사이의 문자열을 추출합니다.
- 끝 인덱스는 해당 인덱스의 문자를 포함하지 않습니다.

### 예제 코드

```csharp
using System;

class Program
{
    static void Main()
    {
        string str = "Hello, World!";

        // Substring 사용
        string subStr1 = str.Substring(7, 5);  // "World"
        Console.WriteLine(subStr1);

        // 인덱서 사용
        char lastChar = str[^1];  // '!'
        Console.WriteLine(lastChar);

        // 범위 연산자 사용
        string subStr2 = str[0..5];  // "Hello"
        Console.WriteLine(subStr2);
    }
}
```

### 문자열 슬라이싱의 특징
- **불변성**: C#의 문자열은 **불변 객체**입니다. 즉, 문자열 자체는 수정되지 않으며, 슬라이싱한 결과는 새로운 문자열을 생성합니다.
- **인덱스 유효성 검사**: 인덱스가 유효하지 않으면 예외가 발생할 수 있으므로 항상 인덱스 범위를 확인해야 합니다.
