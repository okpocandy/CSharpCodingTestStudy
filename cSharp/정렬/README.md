# 정렬 알고리즘

정렬 알고리즘은 데이터 요소들을 특정 기준에 따라 순서대로 나열하는 알고리즘입니다. 다양한 정렬 알고리즘이 있으며, 각 알고리즘은 시간 복잡도, 공간 복잡도, 안정성 등의 특성에 따라 다릅니다. 아래에서는 몇 가지 주요 정렬 알고리즘과 C# 구현 예제를 설명합니다.

## 버블 정렬 (Bubble Sort)

버블 정렬은 인접한 두 요소를 비교하여 잘못된 순서이면 서로 교환하는 과정을 반복하여 정렬하는 알고리즘입니다.

### 알고리즘 설명

1. 배열의 첫 번째 요소부터 마지막 요소까지 순회합니다.
2. 인접한 두 요소를 비교하여 잘못된 순서이면 서로 교환합니다.
3. 이 과정을 배열이 완전히 정렬될 때까지 반복합니다.

### C# 구현

```csharp
using System;

namespace SortingAlgorithms
{
    class BubbleSortExample
    {
        static void Main(string[] args)
        {
            int[] array = { 5, 2, 9, 1, 5, 6 };
            BubbleSort(array);
            Console.WriteLine("Sorted array: " + string.Join(", ", array));
        }

        static void BubbleSort(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        // Swap array[j] and array[j+1]
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }
    }
}
```
### 버블 정렬(Bubble Sort) 알고리즘의 특징
* 시간 복잡도:
  * 최선의 경우: **O(n)** (이미 정렬된 배열의 경우)
  * 평균 및 최악의 경우: **O(n^2)** (정렬되지 않은 배열의 경우)

* 공간 복잡도: **O(1)** (추가적인 메모리 공간이 거의 필요하지 않음)

* 특징:
  * 안정적인 정렬 알고리즘: 동일한 값의 요소들의 순서가 유지됩니다.
  * 제자리 정렬(in-place sort): 추가적인 메모리 공간을 거의 사용하지 않습니다.
  * 간단하고 구현이 쉬운 정렬 알고리즘
  * **작은 데이터셋에서 효율적**이지만, **큰 데이터셋에서는 비효율적**임

### 참조 링크
* [버블 정렬 위키피디아](https://ko.wikipedia.org/wiki/%EB%B2%84%EB%B8%94_%EC%A0%95%EB%A0%AC)


## 선택 정렬 (Selection Sort)
선택 정렬은 배열에서 가장 작은 요소를 찾아 맨 앞의 요소와 교환하는 과정을 반복하여 정렬하는 알고리즘입니다.

### 알고리즘 설명
1. 배열의 첫 번째 요소부터 순회하며 가장 작은 요소를 찾습니다.
2. 찾은 가장 작은 요소를 현재 위치의 요소와 교환합니다.
3. 이 과정을 배열이 완전히 정렬될 때까지 반복합니다.

### C# 구현
```C#
using System;

namespace SortingAlgorithms
{
    class SelectionSortExample
    {
        static void Main(string[] args)
        {
            int[] array = { 64, 25, 12, 22, 11 };
            SelectionSort(array);
            Console.WriteLine("Sorted array: " + string.Join(", ", array));
        }

        static void SelectionSort(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIdx = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (array[j] < array[minIdx])
                    {
                        minIdx = j;
                    }
                }
                // Swap array[i] and array[minIdx]
                int temp = array[minIdx];
                array[minIdx] = array[i];
                array[i] = temp;
            }
        }
    }
}
```
### 선택 정렬(Selection Sort) 알고리즘의 특징
* 시간 복잡도: 최선, 평균, 최악의 경우 모두 **O(n^2)**
* 공간 복잡도: **O(1)** (추가적인 메모리 공간이 거의 필요하지 않음)
* 특징:
  * 불안정한 정렬 알고리즘: 동일한 값의 요소들의 순서가 바뀔 수 있음
  * 제자리 정렬(in-place sort): 추가적인 메모리 공간을 거의 사용하지 않습니다.
  * 구현이 간단하지만, 다른 효율적인 정렬 알고리즘에 비해 성능이 떨어짐
  * **데이터의 크기에 상관없이 항상 O(n^2)의 시간 복잡도**를 가짐

### 참조 링크
* [선택 정렬 위키피디아 ](https://ko.wikipedia.org/wiki/%EC%84%A0%ED%83%9D_%EC%A0%95%EB%A0%AC)

## 삽입 정렬 (Insertion Sort)
삽입 정렬은 배열의 요소를 하나씩 선택하여 정렬된 부분 배열에 삽입하여 정렬하는 알고리즘입니다.

### 알고리즘 설명
1. 배열의 두 번째 요소부터 순회합니다.
2. 현재 요소를 정렬된 부분 배열의 적절한 위치에 삽입합니다.
3. 이 과정을 배열이 완전히 정렬될 때까지 반복합니다.

### C# 구현
```c#
using System;

namespace SortingAlgorithms
{
    class InsertionSortExample
    {
        static void Main(string[] args)
        {
            int[] array = { 12, 11, 13, 5, 6 };
            InsertionSort(array);
            Console.WriteLine("Sorted array: " + string.Join(", ", array));
        }

        static void InsertionSort(int[] array)
        {
            int n = array.Length;
            for (int i = 1; i < n; i++)
            {
                int key = array[i];
                int j = i - 1;

                // Move elements of array[0..i-1], that are greater than key,
                // to one position ahead of their current position
                while (j >= 0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j = j - 1;
                }
                array[j + 1] = key;
            }
        }
    }
}
```
### 삽입 정렬(Insertion Sort) 알고리즘의 특징
* 시간 복잡도:
  * 최선의 경우: **O(n)** (이미 정렬된 배열의 경우)
  * 평균 및 최악의 경우: **O(n^2)** (정렬되지 않은 배열의 경우)
* 공간 복잡도: **O(1)** (추가적인 메모리 공간이 거의 필요하지 않음)
* 특징:
  * 안정적인 정렬 알고리즘: 동일한 값의 요소들의 순서가 유지됩니다.
  * 제자리 정렬(in-place sort): 추가적인 메모리 공간을 거의 사용하지 않습니다.
  * 점진적으로 배열을 확장하며 정렬
  * **작은 데이터셋이나 거의 정렬된 데이터셋에서 효율적**임

### 참조 링크
* [삽입 정렬 위키피디아](https://ko.wikipedia.org/wiki/%EC%82%BD%EC%9E%85_%EC%A0%95%EB%A0%AC)

## 퀵 정렬 (Quick Sort)
퀵 정렬은 분할 정복 알고리즘의 일종으로, 배열을 피벗을 기준으로 두 부분으로 나눈 후 각각의 부분을 정렬하는 방식입니다.

### 알고리즘 설명
1. 배열에서 피벗 요소를 선택합니다.
2. 피벗보다 작은 요소들은 피벗의 왼쪽으로, 큰 요소들은 피벗의 오른쪽으로 이동시킵니다.
3. 피벗을 기준으로 배열을 분할합니다.
4. 분할된 두 부분 배열에 대해 재귀적으로 퀵 정렬을 수행합니다.

### C# 구현
```c#
using System;

namespace SortingAlgorithms
{
    class QuickSortExample
    {
        static void Main(string[] args)
        {
            int[] array = { 10, 7, 8, 9, 1, 5 };
            QuickSort(array, 0, array.Length - 1);
            Console.WriteLine("Sorted array: " + string.Join(", ", array));
        }

        static void QuickSort(int[] array, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(array, low, high);

                QuickSort(array, low, pi - 1);
                QuickSort(array, pi + 1, high);
            }
        }

        static int Partition(int[] array, int low, int high)
        {
            int pivot = array[high];
            int i = (low - 1);

            for (int j = low; j < high; j++)
            {
                if (array[j] < pivot)
                {
                    i++;
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }

            int temp1 = array[i + 1];
            array[i + 1] = array[high];
            array[high] = temp1;

            return i + 1;
        }
    }
}
```

### 퀵 정렬(Quick Sort) 알고리즘의 특징
* 시간 복잡도:
  * 평균의 경우: O(n log n)
  * 최선의 경우: O(n log n)
  * 최악의 경우: O(n^2) (이미 정렬된 배열에서 피벗이 항상 최솟값이나 최댓값일 때)
* 공간 복잡도: O(log n) (재귀 호출 스택 공간)
* 특징:
  * 불안정한 정렬 알고리즘: 동일한 값의 요소들의 순서가 바뀔 수 있음
  * 제자리 정렬(in-place sort): 추가적인 메모리 공간을 거의 사용하지 않음
  * 분할 정복(divide and conquer) 알고리즘: 문제를 작은 하위 문제로 나누어 해결
  * 평균적으로 매우 빠른 정렬 알고리즘

### 참조 링크
[* 퀵 정렬 위키피디아](https://ko.wikipedia.org/wiki/%ED%80%B5_%EC%A0%95%EB%A0%AC)


## 병합 정렬 (Merge Sort)
병합 정렬은 분할 정복 알고리즘의 일종으로, 배열을 반으로 나눈 후 각각을 정렬하고 다시 합치는 방식입니다.

### 알고리즘 설명
1. 배열을 반으로 나눕니다.
2. 각 부분 배열을 재귀적으로 병합 정렬합니다.
3. 정렬된 부분 배열을 병합하여 하나의 정렬된 배열로 만듭니다.

### C# 구현
```c#
using System;

namespace SortingAlgorithms
{
    class MergeSortExample
    {
        static void Main(string[] args)
        {
            int[] array = { 12, 11, 13, 5, 6, 7 };
            MergeSort(array, 0, array.Length - 1);
            Console.WriteLine("Sorted array: " + string.Join(", ", array));
        }

        static void MergeSort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int mid = left + (right - left) / 2;

                MergeSort(array, left, mid);
                MergeSort(array, mid + 1, right);

                Merge(array, left, mid, right);
            }
        }

        static void Merge(int[] array, int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;

            int[] leftArray = new int[n1];
            int[] rightArray = new int[n2];

            Array.Copy(array, left, leftArray, 0, n1);
            Array.Copy(array, mid + 1, rightArray, 0, n2);

            int i = 0, j = 0;
            int k = left;
            while (i < n1 && j < n2)
            {
                if (leftArray[i] <= rightArray[j])
                {
                    array[k] = leftArray[i];
                    i++;
                }
                else
                {
                    array[k] = rightArray[j];
                    j++;
                }
                k++;
            }

            while (i < n1)
            {
                array[k] = leftArray[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                array[k] = rightArray[j];
                j++;
                k++;
            }
        }
    }
}
```

### 병합 정렬(Merge Sort) 알고리즘의 특징
* 시간 복잡도:
  * 모든 경우: O(n log n)
* 공간 복잡도: O(n) (추가적인 메모리 공간이 필요함)
* 특징:
  * 안정적인 정렬 알고리즘: 동일한 값의 요소들의 순서가 유지됨
  * 분할 정복(divide and conquer) 알고리즘: 문제를 작은 하위 문제로 나누어 해결
  * 외부 정렬(external sorting)에도 적합: 대용량 데이터를 디스크에서 정렬할 때 사용

### 참조 링크
* [병합 정렬 위키피디아](https://ko.wikipedia.org/wiki/%ED%95%A9%EB%B3%91_%EC%A0%95%EB%A0%AC)
