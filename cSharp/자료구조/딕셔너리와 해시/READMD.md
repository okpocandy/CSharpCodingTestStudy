# 문자열

1. [딕셔너리(Dictionary)](#딕셔너리(Dictionary))
2. [해시(Hash) 구조](#해시(Hash)_구조)
3. [해시셋(HashSet)](#해시셋(HashSet))

# 딕셔너리(Dictionary)

**딕셔너리(Dictionary)**는 **키-값(key-value)** 쌍으로 데이터를 저장하는 자료구조입니다. C#에서 `Dictionary<TKey, TValue>` 클래스는 `System.Collections.Generic` 네임스페이스에 정의되어 있으며, **빠른 검색, 삽입, 삭제**를 제공하는 대표적인 컬렉션입니다. 키는 중복될 수 없고, 각 키는 고유한 값을 가집니다.

## 1. 기본 사용법

### 딕셔너리 초기화

딕셔너리는 키와 값의 타입을 지정하여 생성할 수 있습니다.

```csharp
using System.Collections.Generic;

Dictionary<int, string> myDictionary = new Dictionary<int, string>();
```

### 요소 추가 (Add)

`Add` 메서드를 사용하여 키와 값을 추가합니다.

```csharp
myDictionary.Add(1, "One");
myDictionary.Add(2, "Two");
```

### 요소 접근

키를 사용하여 값에 접근할 수 있습니다. 존재하지 않는 키를 참조하면 `KeyNotFoundException`이 발생합니다.

```csharp
string value = myDictionary[1]; // value는 "One"이 됩니다.
```

### 요소 제거 (Remove)

`Remove` 메서드를 사용하여 특정 키에 해당하는 요소를 제거할 수 있습니다.

```csharp
myDictionary.Remove(1);
```

### 키 또는 값 존재 여부 확인

- `ContainsKey`: 특정 키가 딕셔너리에 있는지 확인합니다.
- `ContainsValue`: 특정 값이 딕셔너리에 있는지 확인합니다.

```csharp
bool hasKey = myDictionary.ContainsKey(2); // true
bool hasValue = myDictionary.ContainsValue("Two"); // true
```

## 2. 주요 속성과 메서드

- **Count**: 딕셔너리의 요소 개수를 반환합니다.
- **Keys**: 딕셔너리의 모든 키를 반환합니다.
- **Values**: 딕셔너리의 모든 값을 반환합니다.

```csharp
int count = myDictionary.Count;
ICollection<int> keys = myDictionary.Keys;
ICollection<string> values = myDictionary.Values;
```

## 3. 예제 코드

```csharp
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // 딕셔너리 초기화
        Dictionary<int, string> myDictionary = new Dictionary<int, string>();

        // 요소 추가
        myDictionary.Add(1, "One");
        myDictionary.Add(2, "Two");

        // 요소 접근
        Console.WriteLine("Key 1 has value: " + myDictionary[1]);

        // 키와 값 출력
        foreach (var kvp in myDictionary)
        {
            Console.WriteLine("Key: " + kvp.Key + ", Value: " + kvp.Value);
        }

        // 요소 제거
        myDictionary.Remove(1);
        Console.WriteLine("Dictionary count after removal: " + myDictionary.Count);
    }
}
```

---

# 해시(Hash) 구조

**해시(Hash)**는 데이터를 고유한 값(키)을 통해 빠르게 검색할 수 있도록 하는 알고리즘입니다. 데이터를 해시 함수(Hash Function)를 통해 해시 값으로 변환하여 특정 위치에 저장하고, 이후에 이 값을 이용해 데이터를 빠르게 조회하거나 삭제할 수 있습니다. 해시 구조의 핵심은 **해시 함수**와 **해시 테이블**입니다.

## 1. 해시 함수 (Hash Function)

해시 함수는 데이터를 입력받아 고정된 크기의 해시 값을 반환하는 함수입니다. 이 해시 값은 데이터가 저장될 위치를 결정하는 데 사용됩니다. 좋은 해시 함수는 다음의 특성을 가집니다:
- **빠른 계산**: 입력에 대해 빠르게 해시 값을 계산할 수 있어야 합니다.
- **균등 분포**: 입력 값들이 해시 테이블에 고르게 분포되도록 해줍니다.
- **충돌 최소화**: 서로 다른 입력이 동일한 해시 값을 가질 확률(충돌)이 최소화되어야 합니다.

## 2. 해시 테이블 (Hash Table)

해시 테이블은 해시 값을 이용하여 데이터를 저장하는 자료구조입니다. 해시 함수에 의해 계산된 인덱스에 데이터를 저장하며, **상수 시간 복잡도**(O(1))로 데이터의 삽입, 삭제, 검색이 가능합니다.

### 해시 테이블의 구조
- **버킷**: 해시 테이블에서 데이터를 저장하는 공간을 버킷이라고 부릅니다. 하나의 버킷에는 여러 개의 데이터를 저장할 수 있습니다.
- **충돌 해결**: 해시 함수가 서로 다른 두 개의 데이터에 대해 동일한 해시 값을 반환하면 **충돌**이 발생합니다. 이를 해결하기 위해 **체이닝(Chaining)**, **개방 주소법(Open Addressing)** 등의 충돌 해결 기법을 사용합니다.

### 충돌 해결 기법
- **체이닝(Chaining)**: 같은 해시 값을 가지는 데이터를 링크드 리스트로 연결하여 저장하는 방법입니다.
- **개방 주소법(Open Addressing)**: 충돌이 발생하면 다른 버킷을 찾아 데이터를 저장하는 방식입니다.

## 3. 해시 테이블의 장단점

### 장점
- **빠른 접근 속도**: 해시 테이블은 상수 시간(O(1)) 내에 데이터 검색이 가능합니다.
- **효율적 메모리 사용**: 메모리 사용량을 조절하여 효율적으로 데이터를 저장할 수 있습니다.

### 단점
- **충돌 문제**: 해시 함수에 따라 충돌이 발생할 수 있으며, 이를 해결하는 방법에 따라 성능이 저하될 수 있습니다.
- **해시 함수의 품질**: 해시 함수가 비효율적이거나 충돌이 많을 경우 성능이 저하될 수 있습니다.

## 4. 해시 테이블 예제

아래는 C#에서 `Dictionary<TKey, TValue>`를 이용한 해시 테이블의 간단한 예제입니다.

```csharp
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, int> hashTable = new Dictionary<string, int>();

        // 데이터 추가
        hashTable.Add("apple", 1);
        hashTable.Add("banana", 2);
        hashTable.Add("cherry", 3);

        // 데이터 검색
        Console.WriteLine("Value for 'banana': " + hashTable["banana"]);

        // 데이터 제거
        hashTable.Remove("apple");

        // 모든 키-값 쌍 출력
        foreach (var kvp in hashTable)
        {
            Console.WriteLine("Key: " + kvp.Key + ", Value: " + kvp.Value);
        }
    }
}
```

해시 테이블은 데이터의 양이 많고 빠른 검색이 필요한 상황에서 매우 유용한 자료구조입니다.

# 해시셋(HashSet)

**해시셋(HashSet)**은 중복을 허용하지 않는 데이터 집합을 관리하는 자료구조입니다. 해시셋은 데이터의 고유성을 보장하며, 빠른 검색, 삽입, 삭제를 제공합니다. C#에서 `HashSet<T>` 클래스는 `System.Collections.Generic` 네임스페이스에 정의되어 있으며, 내부적으로 해시 테이블을 사용하여 데이터를 관리합니다.

## 1. 기본 사용법

### 해시셋 초기화

`HashSet<T>`는 특정 타입의 데이터를 저장하는 해시셋을 선언할 수 있습니다.

```csharp
using System.Collections.Generic;

HashSet<int> myHashSet = new HashSet<int>();
```

### 요소 추가 (Add)

`Add` 메서드를 사용하여 해시셋에 요소를 추가할 수 있습니다. 동일한 값이 이미 존재하면 추가되지 않으며, `false`를 반환합니다.

```csharp
bool isAdded = myHashSet.Add(1); // true (성공적으로 추가됨)
bool isAddedAgain = myHashSet.Add(1); // false (이미 존재)
```

### 요소 제거 (Remove)

`Remove` 메서드를 사용하여 특정 요소를 제거할 수 있습니다. 존재하지 않는 요소를 제거하려고 할 경우 `false`를 반환합니다.

```csharp
bool isRemoved = myHashSet.Remove(1); // true (성공적으로 제거됨)
```

### 요소 존재 여부 확인 (Contains)

`Contains` 메서드를 사용하여 특정 요소가 해시셋에 있는지 확인할 수 있습니다.

```csharp
bool containsElement = myHashSet.Contains(1); // false (이미 제거됨)
```

### 해시셋 비우기 (Clear)

`Clear` 메서드를 사용하여 해시셋의 모든 요소를 제거할 수 있습니다.

```csharp
myHashSet.Clear(); // 해시셋이 비워짐
```

## 2. 주요 속성과 메서드

- **Count**: 해시셋에 저장된 요소의 개수를 반환합니다.
- **IsSubsetOf**: 현재 해시셋이 다른 컬렉션의 부분집합인지 확인합니다.
- **IsSupersetOf**: 현재 해시셋이 다른 컬렉션의 상위집합인지 확인합니다.
- **UnionWith**: 두 해시셋의 합집합을 계산합니다.
- **IntersectWith**: 두 해시셋의 교집합을 계산합니다.
- **ExceptWith**: 다른 컬렉션에 포함된 요소를 현재 해시셋에서 제거합니다.

```csharp
HashSet<int> set1 = new HashSet<int>() { 1, 2, 3 };
HashSet<int> set2 = new HashSet<int>() { 2, 3, 4 };

set1.UnionWith(set2); // set1은 { 1, 2, 3, 4 }이 됩니다.
set1.IntersectWith(set2); // set1은 { 2, 3 }이 됩니다.
```

## 3. 예제 코드

```csharp
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // 해시셋 초기화
        HashSet<int> myHashSet = new HashSet<int>();

        // 요소 추가
        myHashSet.Add(1);
        myHashSet.Add(2);
        myHashSet.Add(3);

        // 중복 요소 추가 시도
        bool isAdded = myHashSet.Add(2); // false (이미 존재)

        // 요소 존재 확인
        Console.WriteLine("Contains 2: " + myHashSet.Contains(2)); // true

        // 요소 제거
        myHashSet.Remove(1);

        // 해시셋 상태 출력
        Console.WriteLine("HashSet elements:");
        foreach (var item in myHashSet)
        {
            Console.WriteLine(item);
        }

        // 해시셋 비우기
        myHashSet.Clear();
        Console.WriteLine("Count after clear: " + myHashSet.Count); // 0
    }
}
```

## 4. 해시셋의 장단점

### 장점
- **중복 방지**: 동일한 값이 여러 번 저장되지 않기 때문에 중복 데이터를 쉽게 방지할 수 있습니다.
- **빠른 검색, 삽입, 삭제**: 해시셋은 상수 시간 복잡도(O(1))로 요소를 검색, 추가, 삭제할 수 있습니다.

### 단점
- **순서 없음**: 해시셋은 데이터의 삽입 순서를 유지하지 않으며, 무작위로 데이터를 저장합니다.
- **추가 메모리 사용**: 해시 테이블을 기반으로 하기 때문에, 내부적으로 추가적인 메모리가 필요할 수 있습니다.

## 5. HashSet<T>와 List<T> 비교

- **HashSet<T>**: 중복을 허용하지 않으며, 삽입 순서를 유지하지 않습니다. 빠른 검색, 삽입, 삭제가 장점입니다.
- **List<T>**: 중복을 허용하며, 삽입 순서를 유지합니다. 요소에 접근하는 데에는 선형 시간(O(n))이 걸릴 수 있습니다.

HashSet은 중복을 허용하지 않는 고유한 값들의 집합을 관리할 때 유용하며, 특히 데이터의 고유성을 보장하고 빠른 검색이 필요한 상황에서 효과적입니다.

