## 복습하기

### 1. for, if 학습
* 구구단 출력

```
input (2~9) : 9 
2 * 1 = 2
2 * 2 = 4
2 * 3 = 6
2 * 4 = 8
2 * 5 = 10
2 * 6 = 12
2 * 7 = 14
2 * 8 = 16
2 * 9 = 18
```

### 2. 메소드, const 학습, 고도화
* 구구단 게임

```
구구단 게임을 시작합니다.
4 * 7 = 28
3 * 2 = 6
7 * 1 = 6
게임 종료 총 20점 획득하였습니다.

구구단 세팅 변경
MAX_NUM = 9
최대 단수를 9단으로 설정하였습니다.
```
### c#의 역사
https://wikidocs.net/227157

### 3. class 학습
```


```
### 예시
사물 배치하기

```
전체 공간 사이즈 : 5 (5*5)
  1. 고양이 (기본 위치 : 위의 공간사이즈의 중앙)
  2. 방해막
사물 선택 : 2
위치 선택 (5*5): 1*1
공간
[2][ ][ ][ ][ ]
[ ][ ][ ][ ][ ]
[ ][ ][1][ ][ ]
[ ][ ][ ][ ][ ]
[ ][ ][ ][ ][ ]
사물 선택 : 2
위치 선택 (5*5): 3*4
[2][ ][ ][ ][ ]
[ ][ ][ ][ ][ ]
[ ][ ][1][ ][ ]
[ ][ ][2][ ][ ]
[ ][ ][ ][ ][ ]

```

```
Random rand = new Random(); 
int a = rand.Next(1, 5);

List<List<string>> myList = new List<List<string>>();
myList.Add(new List<string> { "a", "b" });
myList.Add(new List<string> { "c", "d", "e" });
myList.Add(new List<string> { "qwerty", "asdf", "zxcv" });
myList.Add(new List<string> { "a", "b" });

// To iterate over it.
foreach (List<string> subList in myList)
{
    foreach (string item in subList)
    {
        Console.WriteLine(item);
    }
}


public class Person
{
    public required string LastName { get; set; }
    public required string FirstName { get; set; }
}
```


## 코드 작성 ai 도입
ref: https://learn.microsoft.com/ko-kr/visualstudio/ide/visual-studio-github-copilot-extension?view=vs-2022

  
