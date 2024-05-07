# 문자열

1. 문자열 입력
2. 문자열 출력
3. 문자열 분리
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

* **StreamReader.ReadLine():**
    
  파일 등의 스트림에서 한 줄의 문자열을 읽어옵니다.
  
  StreamReader 클래스를 사용하여 파일을 읽는 경우 주로 사용됩니다.
  
  개행 문자가 입력될 때까지의 문자열을 읽어옵니다.
  
  ```C#
  using System.IO;
  
  StreamReader reader = new StreamReader("input.txt"); // 파일에서 문자열 입력 받기
  string line = reader.ReadLine();
  ```
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
