# 문자열

1. [문자열 입력](#문자열-입력)
2. [문자열 분리](#문자열-분리)
3. 문자열 출력
4. 문자열 비교

## 문자열 입력
C#에서도 문자열을 입력받는 두 가지 방법이 있습니다. Console.ReadLine()과 StreamReader.ReadLine()입니다. 각각에 대한 설명을 드리겠습니다.

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
