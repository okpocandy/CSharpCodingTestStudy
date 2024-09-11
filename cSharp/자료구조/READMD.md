# 스택(Stack) 클래스
C#의 Stack 클래스는 LIFO(Last In, First Out) 방식으로 요소를 저장하고 관리하는 컬렉션입니다. 즉, 마지막에 추가된 요소가 가장 먼저 제거됩니다. Stack 클래스는 System.Collections 네임스페이스에 정의되어 있습니다. 아래는 Stack 클래스에 대한 자세한 설명과 예제입니다.

* **1. 기본 사용법**
  
  **스택 초기화**
  
  Stack 클래스를 사용하려면 먼저 인스턴스를 생성해야 합니다.
    
  ```C#
  using System.Collections;
  
  Stack myStack = new Stack();
  ```
    
  **요소 추가 (Push)**
  
  Push 메서드를 사용하여 스택에 요소를 추가합니다.
  
  ```C#
  myStack.Push(1);
  myStack.Push(2);
  myStack.Push(3);
  ```
  
  **요소 제거 (Pop)**
  
  Pop 메서드를 사용하여 스택의 맨 위 요소를 제거하고 반환합니다. 스택이 비어 있을 때 Pop을 호출하면 InvalidOperationException이 발생합니다.
  
  ```C#
  int topElement = (int)myStack.Pop(); // topElement는 3이 됩니다.
  ```
  
  **맨 위 요소 확인 (Peek)**
  
  Peek 메서드를 사용하여 스택의 맨 위 요소를 제거하지 않고 반환합니다. 스택이 비어 있을 때 Peek을 호출하면 InvalidOperationException이 발생합니다.
  
  ```C#
  int topElement = (int)myStack.Peek(); // topElement는 2가 됩니다.
  ```
  
  **스택 비우기 (Clear)**
  
  Clear 메서드를 사용하여 스택의 모든 요소를 제거합니다.
  
  ```C#
  myStack.Clear();
  ```
  
* **2. 주요 속성과 메서드**
  
  **Count: 스택에 있는 요소의 수를 반환합니다.**
  
  ```C#
  int count = myStack.Count;
  ```
  
  **Contains: 특정 요소가 스택에 있는지 확인합니다.**
  
  ```C#
  bool containsTwo = myStack.Contains(2);
  ```
  
  **ToArray: 스택의 요소를 배열로 복사합니다.**
  
  ```C#
  object[] array = myStack.ToArray();
  ```
  
  **Enumerator: 스택을 열거하는 열거자를 반환합니다.**
  
  ```C#
  foreach (var item in myStack)
  {
      Console.WriteLine(item);
  }
  ```
  
* **3. 예제 코드**
  
  아래는 Stack 클래스를 사용하는 예제 코드입니다.
  
  ```C#
  using System;
  using System.Collections;
  
  class Program
  {
      static void Main()
      {
          // 스택 초기화
          Stack myStack = new Stack();
          
          // 요소 추가
          myStack.Push(1);
          myStack.Push(2);
          myStack.Push(3);
  
          // 스택 상태 출력
          Console.WriteLine("Current stack:");
          foreach (var item in myStack)
          {
              Console.WriteLine(item);
          }
  
          // 맨 위 요소 확인
          Console.WriteLine("Top element is: " + myStack.Peek());
  
          // 요소 제거
          Console.WriteLine("Popped element is: " + myStack.Pop());
  
          // 스택 상태 출력
          Console.WriteLine("Current stack after pop:");
          foreach (var item in myStack)
          {
              Console.WriteLine(item);
          }
  
          // 스택 비우기
          myStack.Clear();
          Console.WriteLine("Stack cleared. Current count: " + myStack.Count);
      }
  }
  ```
  
* **4. Stack<T> 제네릭 클래스**
  
  C#에서는 제네릭 스택 클래스인 Stack<T>도 제공합니다. Stack<T>는 System.Collections.Generic 네임스페이스에 정의되어 있으며, 타입 안정성을 제공합니다.
  
  **제네릭 스택 초기화**
  
  ```C#
  using System.Collections.Generic;
  
  Stack<int> myStack = new Stack<int>();
  ```
  
  **제네릭 스택 예제 코드**
  
  아래는 Stack<T> 클래스를 사용하는 예제 코드입니다.
  
  ```C#
  using System;
  using System.Collections.Generic;
  
  class Program
  {
      static void Main()
      {
          // 제네릭 스택 초기화
          Stack<int> myStack = new Stack<int>();
          
          // 요소 추가
          myStack.Push(1);
          myStack.Push(2);
          myStack.Push(3);
  
          // 스택 상태 출력
          Console.WriteLine("Current stack:");
          foreach (var item in myStack)
          {
              Console.WriteLine(item);
          }
  
          // 맨 위 요소 확인
          Console.WriteLine("Top element is: " + myStack.Peek());
  
          // 요소 제거
          Console.WriteLine("Popped element is: " + myStack.Pop());
  
          // 스택 상태 출력
          Console.WriteLine("Current stack after pop:");
          foreach (var item in myStack)
          {
              Console.WriteLine(item);
          }
  
          // 스택 비우기
          myStack.Clear();
          Console.WriteLine("Stack cleared. Current count: " + myStack.Count);
      }
  }
  ```
  
이와 같이, C#의 Stack 클래스와 Stack<T> 제네릭 클래스를 사용하여 LIFO 방식의 컬렉션을 쉽게 관리할 수 있습니다.
